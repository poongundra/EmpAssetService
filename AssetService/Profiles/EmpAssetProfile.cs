using AutoMapper;
using EmpAssetService.Dtos;
using EmpAssetService.Models;

namespace EmpAssetService.Profiles
{
    public class EmpAssetProfile : Profile
    {
        public EmpAssetProfile()
        {
            CreateMap<EmpAsset, EmpAssetReadDto>();
            CreateMap<EmpAssetReadDto, EmpAsset>();
            CreateMap<EmpAssetCreateDto, EmpAsset>();

        }
    }

}
