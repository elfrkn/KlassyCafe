using AutoMapper;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.Rezervation;
using KlassyCafe.Dtos.Table;

namespace KlassyCafeSignalR.Mapping
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Rezervation, ResultRezervationDto>().ReverseMap();
            CreateMap<Rezervation, CreateRezervationDto>().ReverseMap();
            CreateMap<Rezervation, UpdateRezervationDto>().ReverseMap();
            CreateMap<Rezervation, GetByIdRezervationDto>().ReverseMap();

            CreateMap<Table, ResultTableDto>().ReverseMap();
        }
       
    }
}
