namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class SpecialistType
{
    public SpecialistType(string specialist)
    {
        Specialist = specialist;
    }

    public int Id { get; set; }

    public string Specialist { get; set; }
}