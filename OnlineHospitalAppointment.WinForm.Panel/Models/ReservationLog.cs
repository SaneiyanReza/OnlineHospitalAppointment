namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class ReservationLog
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ExpertId { get; set; }

    public int ReservedAt { get; set; }

    public string TrackingCode { get; set; }

    public byte IsCanceled { get; set; }

    public byte TypeCanceled { get; set; }

    public string Description { get; set; }

    public virtual Expert Expert { get; set; }
}