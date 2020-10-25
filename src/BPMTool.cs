using System;
using System.Windows.Forms;

namespace BPMTool
{
    internal static class BPMTool
    {
        // Calculates the new BPM of a sample if you were to change its pitch.
        public static double GetBPMFromPitchChange(double OldBPM, double PitchChange)
        {
            double Magic = 1.059463094359295;
            double MagicPow = Math.Pow(Magic, PitchChange);

            return Math.Round(MagicPow * OldBPM, 2);
        }

        // Calculates the new Pitch of a sample if you were to change it's BPM.
        public static double GetPitchFromBPMChange(double OldBPM, double NewBPM)
        {
            double EqualTemperamentStep = 0.05776227;
            double Log = Math.Log(NewBPM / OldBPM);

            return Math.Round(Log / EqualTemperamentStep, 2);
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
        }
    }
}