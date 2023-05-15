using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity;

namespace OnlineHospitalAppointment.WinForm.Panel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Online Hospital Appointment application
            // see https://github.com/SaneiyanReza
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmIdentity());
        }
    }
}