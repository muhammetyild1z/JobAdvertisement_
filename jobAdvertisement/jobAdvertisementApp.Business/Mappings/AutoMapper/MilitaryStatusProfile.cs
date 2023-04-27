using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jobAdvertisementApp.Dtos;
using jobAdvertisementApp.Entities;

namespace jobAdvertisementApp.Business.Mappings.AutoMapper
{
    public class MilitaryStatusProfile : Profile
    {
        public MilitaryStatusProfile()
        {
            CreateMap<MilitaryStatus, MilitaryStatusListDto>().ReverseMap();
        }
    }
}
