namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public string NationalCode { get; set; }

    public string Name { get; set; }

    public string LastName { get; set; }

    public byte IsMale { get; set; }

    public string PhoneNumber { get; set; }

    public string BirthDay { get; set; }

    public int CreateDateTime { get; set; }

    public int RoleId { get; set; }

    public byte? IsDeleted { get; set; }

    public byte? IsSuspended { get; set; }

    public virtual ICollection<AdminActivityLog> AdminActivityLogs { get; } = new List<AdminActivityLog>();

    public virtual ICollection<Expert> Experts { get; } = new List<Expert>();

    public virtual Role Role { get; set; }
}