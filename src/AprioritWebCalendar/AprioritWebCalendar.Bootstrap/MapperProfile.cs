﻿using AutoMapper;
using AprioritWebCalendar.Business.DomainModels;
using AprioritWebCalendar.Data.Models;
using AprioritWebCalendar.ViewModel.Account;
using AprioritWebCalendar.ViewModel.Calendar;
using AprioritWebCalendar.ViewModel.Event;
using System;
using System.Globalization;

namespace AprioritWebCalendar.Bootstrap
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region User.

            CreateMap<ApplicationUser, User>()
                .ForMember(dest => dest.IsEmailConfirmed, opt => opt.MapFrom(src => src.EmailConfirmed));

            CreateMap<User, UserViewModel>();

            #endregion

            #region Calendar.

            CreateMap<Business.DomainModels.Calendar, Data.Models.Calendar>()
                .ForMember(dest => dest.Owner, opt => opt.Ignore())
                .ForMember(dest => dest.EventCalendars, opt => opt.Ignore())
                .ForMember(dest => dest.SharedUsers, opt => opt.Ignore());

            CreateMap<Data.Models.Calendar, Business.DomainModels.Calendar>();

            CreateMap<CalendarShortModel, Business.DomainModels.Calendar>();
            CreateMap<Business.DomainModels.Calendar, CalendarShortModel>();

            #endregion

            #region Event.

            CreateMap<Business.DomainModels.Event, Data.Models.Event>()
                .ForMember(dest => dest.Calendars, opt => opt.Ignore())
                .ForMember(dest => dest.Invitations, opt => opt.Ignore())
                .ForMember(dest => dest.Owner, opt => opt.Ignore())
                .ForMember(dest => dest.Period, opt => opt.Ignore());

            CreateMap<Data.Models.Event, Business.DomainModels.Event>();
            CreateMap<EventViewModel, Business.DomainModels.Event>()
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => DateTime.ParseExact(src.StartDate, "MM/dd/yyyy", CultureInfo.InvariantCulture)))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => DateTime.ParseExact(src.EndDate, "MM/dd/yyyy", CultureInfo.InvariantCulture)))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => TimeSpan.ParseExact(src.StartTime, "g", CultureInfo.InvariantCulture)))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => TimeSpan.ParseExact(src.EndTime, "g", CultureInfo.InvariantCulture)));

            #endregion

            #region UserCalendar.

            CreateMap<Business.DomainModels.UserCalendar, Data.Models.UserCalendar>()
                .ForMember(dest => dest.Calendar, opt => opt.Ignore())
                .ForMember(dest => dest.User, opt => opt.Ignore());


            CreateMap<Data.Models.UserCalendar, Business.DomainModels.UserCalendar>();

            CreateMap<Business.DomainModels.UserCalendar, UserCalendarViewModel>();

            #endregion

            #region EventCalendar.

            CreateMap<Business.DomainModels.EventCalendar, Data.Models.EventCalendar>()
                .ForMember(dest => dest.Calendar, opt => opt.Ignore())
                .ForMember(dest => dest.Event, opt => opt.Ignore());

            CreateMap<Data.Models.EventCalendar, Business.DomainModels.EventCalendar>();

            #endregion

            #region Invitation.

            CreateMap<Business.DomainModels.Invitation, Data.Models.Invitation>()
                .ForMember(dest => dest.Event, opt => opt.Ignore())
                .ForMember(dest => dest.Invitator, opt => opt.Ignore())
                .ForMember(dest => dest.User, opt => opt.Ignore());

            CreateMap<Data.Models.Invitation, Business.DomainModels.Invitation>();

            #endregion

            #region Period.

            CreateMap<Business.DomainModels.Period, Data.Models.Period>();
            CreateMap<Data.Models.Period, Business.DomainModels.Period>();

            #endregion
        }
    }
}
