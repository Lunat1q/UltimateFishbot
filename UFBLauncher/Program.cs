using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace UFBLauncher
{
    class Program
    {
        private const string ExeExt = ".exe";
        private const string DefaultName = "UltimateFishBot.exe";
        private static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            var lastName = Properties.Settings.Default.UFBName;

#if !DEBUG
            if (!RunBotSecretly(lastName)) RunBotSecretly(DefaultName);
#else
            RunBotSecretly(DefaultName);
#endif

        }

        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        static bool RunBotSecretly(string name)
        {
            var currentPath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), name);
            var ufbExeFile = new FileInfo(currentPath);
            if (ufbExeFile.Exists)
            {
                var newName = RandomString(12) + ExeExt;
                var newPath = Path.Combine(Path.GetDirectoryName(currentPath), newName);
                ufbExeFile.MoveTo(newPath);
                Properties.Settings.Default.UFBName = newName;
                Properties.Settings.Default.Save();
                var p = Process.Start(ufbExeFile.FullName);
                while (p.MainWindowHandle == IntPtr.Zero)
                {
                    Thread.Sleep(1500);
                }
                p.WaitForInputIdle();
                SetWindowText(p.MainWindowHandle, newName);
                return true;
            }
            return false;
        }

        private static string RandomString(int length, string chars = "abcdefghijklmnopqrstuvwxyz0123456789")
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
