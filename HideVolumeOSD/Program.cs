
using System;
using System.Windows.Forms;
using System.Threading;

namespace HideVolumeOSD
{
    /// <summary>
    /// 
    /// </summary>
    static class Program
    {
        public static bool InitFailed = false;
        public static bool SilentRun = false;

        static Mutex mutex = new Mutex(true, "{00A827A1-C8D4-4FAF-A79B-0193AF81249B}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                if (args.Length == 1)
                {
                    HideVolumeOSDLib lib = new HideVolumeOSDLib(null);

                    lib.Init();

                    if (args[0] == "-silent")
                    {
                        lib.CloseOSD();
                    }
                    else if (args[0] == "-hide")
                    {
                        lib.HideOSD();
                    }
                    else if (args[0] == "-show")
                    {
                        lib.ShowOSD();
                    }
                    Application.Exit();
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    using (ProcessIcon pi = new ProcessIcon())
                    {
                        pi.Display();

                        if (!InitFailed)
                            Application.Run();
                    }
                }

                mutex.ReleaseMutex();
            }
        }
    }
}