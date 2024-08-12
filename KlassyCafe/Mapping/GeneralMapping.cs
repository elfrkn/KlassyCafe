using AutoMapper;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.About;
using KlassyCafe.Dtos.Category;
using KlassyCafe.Dtos.Product;
using KlassyCafe.Dtos.Rezervation;
using KlassyCafe.Dtos.Slider;
using KlassyCafe.Dtos.Table;

namespace KlassyCafe.Mapping
{
    public class GeneralMapping :Profile
    {
        public GeneralMapping()
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, GetByIdSliderDto>().ReverseMap();

            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, GetByIdAboutDto>().ReverseMap();

            CreateMap<Product, ResultProductWithCategoryDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();
            CreateMap<Product, ResultproductDto>().ReverseMap();

            CreateMap<Rezervation, ResultRezervationDto>().ReverseMap();
            CreateMap<Rezervation, CreateRezervationDto>().ReverseMap();
            CreateMap<Rezervation, UpdateRezervationDto>().ReverseMap();
            CreateMap<Rezervation, GetByIdRezervationDto>().ReverseMap();

            CreateMap<Table, ResultTableDto>().ReverseMap();
        }
    }
}
