using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoLauncher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string fullargs="-windowtitle \"Marine Sharpshooter 2\" -rez Engine.rez -rez game.rez +DisableMusic 0 +DisableSound 0 +DisableMovies 0 +DisableJoystick 1 +EnableTripBuf 0 +DisableHardwareCursor 0";   //required to get the game running
            int length;
            length = args.GetLength(0);

            for (int i = 0; i!=length; i++)     //a lazy way of handling additional parameters
            {
                fullargs = fullargs + " "+ args[i];
            }
            try
            {
                Process firstProc = new Process();
                firstProc.StartInfo.FileName = "Lithtech.exe";
                firstProc.StartInfo.Arguments = fullargs;
                firstProc.EnableRaisingEvents = true;

                firstProc.Start();
                firstProc.WaitForExit();   
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred!!!: " + ex.Message);
                return;
            }
        }
    }
}
