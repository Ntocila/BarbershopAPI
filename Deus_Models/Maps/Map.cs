using AutoMapper;
using Deus_Models.DTOs;
using Deus_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_Models.Maps
{
    public class Map : Profile
    {
        public Map()
        {
            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Appointment, AppointmentDto>().ReverseMap();
        }
    }
}
