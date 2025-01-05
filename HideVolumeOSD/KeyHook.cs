using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HideVolumeOSD
{  
    class KeyHook
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
          LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]        
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        public static event EventHandler VolumeKeyPressed = delegate {};
        public static event EventHandler VolumeKeyReleased = delegate {};
        public static event EventHandler HotKeyReleased = delegate {};

        public static void StartListening()
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                _hookID = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        public static void StopListening()
        {
            UnhookWindowsHookEx(_hookID);
        }
        
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            int vkCode = Marshal.ReadInt32(lParam);

            if (vkCode == (int)Keys.VolumeDown || vkCode == (int)Keys.VolumeUp)
            { 
                if (nCode >= 0)
                {
                    if (wParam == (IntPtr)WM_KEYDOWN)
                    {
                        if (VolumeKeyPressed != null)
                        {
                            VolumeKeyPressed(null, EventArgs.Empty);
                        }
                    }
                    else if (wParam == (IntPtr)WM_KEYUP)
                    {
                        if (VolumeKeyReleased != null)
                        {
                            VolumeKeyReleased(null, EventArgs.Empty);
                        }
                    }
                }
            }
            // Sets the hotkey if the user settings page is active and the text to enter a hotkey is in focus
            else if (UserSettings.GetFormActive() && UserSettings.GetHotboxKeyFocused())
            {
                Keys key = (Keys)Keys.Parse(typeof(Keys), (vkCode).ToString());
                Settings.Default.VolumeDisplayHotkey = key.ToString();
            }
            // Triggers the hotkey if the toggle hotkey option is enabled
            else if (Settings.Default.VolumeDisplayHotkeyEnabled)
            {
                string formattedKey = Settings.Default.VolumeDisplayHotkey;
                int key = (int)Keys.Parse(typeof(Keys), formattedKey);

                if (vkCode == key)
                {
                    if (wParam == (IntPtr)WM_KEYUP && !UserSettings.GetFormActive())
                    {
                        HotKeyReleased(null, EventArgs.Empty);
                    }
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }      
    }
}
