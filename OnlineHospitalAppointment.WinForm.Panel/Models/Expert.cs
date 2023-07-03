using OnlineHospitalAppointment.Dll.Tools.Helpers;

namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class Expert
{
    public Expert(string fullName, int specialistTypeId, int cityId, int userId)
    {
        FullName = fullName;
        SpecialistTypeId = specialistTypeId;
        CityId = cityId;
        CreateDateTime = DateTime.Now.ToUnixTime();
        UserId = userId;
    }

    public int Id { get; set; }

    public string FullName { get; set; }

    public int SpecialistTypeId { get; set; }

    public int CityId { get; set; }

    public int CreateDateTime { get; set; }

    public int UserId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsSuspended { get; set; }

    public virtual ICollection<AppointmentChart> AppointmentCharts { get; } = new List<AppointmentChart>();

    public virtual ICollection<ReservationLog> ReservationLogs { get; } = new List<ReservationLog>();

    public virtual User User { get; set; }

    public void ModifyExpertByAdmin(string fullName, int specialistTypeId, int cityId)
    {
        FullName = fullName;
        SpecialistTypeId = specialistTypeId;
        CityId = cityId;
    }

    public void Delete()
    {
        IsDeleted = true;
    }

    public void Suspend()
    {
        IsSuspended = true;
    }
}