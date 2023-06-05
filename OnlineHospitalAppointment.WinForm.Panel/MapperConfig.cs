﻿using AutoMapper;
using OnlineHospitalAppointment.Dll.Tools.Helpers;
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
                .ForMember(view => view.Address, src => src.MapFrom(x => string.Concat(x.ProvienceName, " ", x.CityName)));

                //Configuring UserAppointmentDto and UserAppointmentView
                cfg.CreateMap<UserAppointmentDto, UserAppointmentView>()
                .ForMember(view => view.ReservedDateTime, src => src.MapFrom(x => DateTimeHelper
                .UnixTimeToDate(x.ReservedAt)));
            });

            //Create an Instance of Mapper and return that Instance
            Mapper mapper = new(config);

            return mapper;
        }
    }
}