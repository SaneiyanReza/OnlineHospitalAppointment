using AutoMapper;
using OnlineHospitalAppointment.Dll.Tools;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Views;

namespace OnlineHospitalAppointment.WinForm.Panel
{
    public static class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            //Provide all the Mapping Configuration
            var config = new MapperConfiguration(cfg =>
            {
                //Configuring ExpertDto and ExpertView
                cfg.CreateMap<ExpertDto, ExpertView>()
                .ForMember(view => view.Address, src => src.MapFrom(x => string.Concat(x.ProvienceName, " ", x.CityName)))
                .ForMember(view => view.FreeDateTime, src => src.MapFrom(x => DateTimeHelper.UnixTimeToDateTime(x.FreeDateTime)));

                //Configuring UserAppointmentDto and UserAppointmentView
                cfg.CreateMap<UserAppointmentDto, UserAppointmentView>()
                .ForMember(view => view.ReservedDateTime, src => src.MapFrom(x => DateTimeHelper
                .UnixTimeToDateTime(x.ReservedAt)));
            });

            //Create an Instance of Mapper and return that Instance
            Mapper mapper = new(config);

            return mapper;
        }
    }
}