using OnlineHospitalAppointment.Dll.Tools.Helpers;

namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class LoginLog
{
    public LoginLog(string userName, string password)
    {
        UserName = userName;
        Password = password;
        CreateDateTime = DateTimeHelper.ToUnixTime(DateTime.UtcNow);
    }

    public int Id { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public int CreateDateTime { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();

    public void UpdateIdentity(string userName, string password)
    {
        UserName = userName;
        Password = PasswordHelper.HashPassword(password);
    }
}