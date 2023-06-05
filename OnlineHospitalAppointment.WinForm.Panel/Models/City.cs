namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int ProvinceId { get; set; }

    public virtual Province Province { get; set; }
}