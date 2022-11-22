using AutoMapper;
using EmpAssetService.Data;
using EmpAssetService.Dtos;
using EmpAssetService.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpAssetService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpAssetController : Controller
    {

        private readonly IEmpAssetRepository _empAssetRepository;
        private readonly IMapper _mapper;

        public EmpAssetController(IEmpAssetRepository empAssetRepository, IMapper mapper)
        {
            _empAssetRepository = empAssetRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<EmpAssetReadDto>> GetEmpAssetDetails()
        {

            var empAsset = _empAssetRepository.GetEmpAssetDetails();

            return Ok(_mapper.Map<IEnumerable<EmpAssetReadDto>>(empAsset));
        }



        [HttpGet("{id}", Name = "GetEmpAssetDetailsById")]
        public ActionResult<EmpAssetReadDto> GetEmpAssetDetailsById(int id)
        {
            var empAsset = _empAssetRepository.GetEmpAssetDetailsbyId(id);

            return Ok(_mapper.Map<EmpAssetReadDto>(empAsset));
        }

        [HttpPost]
        public ActionResult<EmpAssetReadDto> CreateEmpAsset(EmpAssetCreateDto empAssetCreateDto)
        {
            var empAssetModel = _mapper.Map<EmpAsset>(empAssetCreateDto);

            _empAssetRepository.CreateEmpAssetDetails(empAssetModel);

            _empAssetRepository.SaveChanges();

            var empAssetReadDto = _mapper.Map<EmpAssetReadDto>(empAssetModel);


            return CreatedAtRoute(nameof(GetEmpAssetDetailsById), new { id = empAssetReadDto.Id }, empAssetReadDto);

        }
    }
}
