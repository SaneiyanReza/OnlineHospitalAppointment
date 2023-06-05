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
    }
}