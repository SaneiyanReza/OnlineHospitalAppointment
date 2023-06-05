namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class Province
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<City> Cities { get; } = new List<City>();
}