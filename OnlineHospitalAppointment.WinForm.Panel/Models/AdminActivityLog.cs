namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class AdminActivityLog
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Description { get; set; }

    public int CreateDateTime { get; set; }

    public virtual User User { get; set; }
}