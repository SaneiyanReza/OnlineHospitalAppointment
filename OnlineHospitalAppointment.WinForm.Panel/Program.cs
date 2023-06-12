using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);

            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<OnlineHospitalAppointmentDbContext>(options =>
                    {
                        options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
                    });
                });

            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var onlineHospitalAppointmentContext = services.GetRequiredService<OnlineHospitalAppointmentDbContext>();
                // Online Hospital Appointment application
                // see https://github.com/SaneiyanReza
                ApplicationConfiguration.Initialize();
                Application.Run(new FrmIdentity(onlineHospitalAppointmentContext));
            }
        }

        private static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            MessageBox.Show("Exception thrown : " + e.Message, "Exception",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}