﻿using OnlineHospitalAppointment.Dll.Tools.Helpers;

namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class User
{
    public User(string userName, string nationalCode, string name, string lastName, bool isMale,
        string phoneNumber, string birthDay, int roleId)
    {
        UserName = userName;
        NationalCode = nationalCode;
        Name = name;
        LastName = lastName;
        IsMale = isMale;
        PhoneNumber = phoneNumber;
        BirthDay = birthDay;
        CreateDateTime = DateTimeHelper.ToUnixTime(DateTime.Now);
        RoleId = roleId;
        IsDeleted = 0;
        IsSuspended = 0;
    }

    public int Id { get; set; }

    public string UserName { get; set; }

    public string NationalCode { get; set; }

    public string Name { get; set; }

    public string LastName { get; set; }

    public bool IsMale { get; set; }

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