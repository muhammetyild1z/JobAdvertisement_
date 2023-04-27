using AutoMapper;
using FluentValidation;
using jobAdvertisementApp.Business.Interfaces;
using jobAdvertisementApp.DataAccess.UnitOfWork;
using jobAdvertisementApp.Dtos;
using jobAdvertisementApp.Entities;

namespace jobAdvertisementApp.Business.Services
{
    public class ProvidedServiceService : Service<ProvidedServiceCreateDto,ProvidedServiceUpdateDto,ProvidedServiceListDto,ProvidedService>,IProvidedServiceService
    {
        public ProvidedServiceService(IMapper mapper, IValidator<ProvidedServiceCreateDto> createDtoValidator,IValidator<ProvidedServiceUpdateDto> updateDtoValidator,IUow uow) : base(mapper,createDtoValidator,updateDtoValidator,uow)
        {
        }

    }
}
