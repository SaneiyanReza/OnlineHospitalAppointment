namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class AppointmentChart
{
    public AppointmentChart(int expertId, int appointmentDate)
    {
        ExpertId = expertId;
        AppointmentDate = appointmentDate;
        IsReserved = false;
    }

    public int Id { get; set; }

    public int? UserId { get; set; }

    public int ExpertId { get; set; }

    public int AppointmentDate { get; set; }

    public bool IsReserved { get; set; }

    public virtual Expert Expert { get; set; }

    public virtual ICollection<ReservationLog> ReservationLogs { get; } = new List<ReservationLog>();

    public virtual User User { get; set; }
}