using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobilityRentApp_Backend.Controllers.Base;
using MobilityRentApp_Backend.Data.Repositories;
using MobilityRentApp_Backend.Model.Dtos.RentEnrollment;
using MobilityRentApp_Backend.Model.Entities;

namespace MobilityRentApp_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentEnrollmentController : CustomControllerBase<RentEnrollment>
    {
        private const string getRentEnrollmentRouteName = "getRentEnrollment";

        private IRentEnrollmentRepository _repository;
        public RentEnrollmentController(IRentEnrollmentRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<RentEnrollmentDto>>> Get()
        {
            return await Get<RentEnrollmentDto>();
        }

        [HttpGet("{id:int}", Name = getRentEnrollmentRouteName)]
        public async Task<ActionResult<RentEnrollmentDto>> Get(int id)
        {
            return await Get<RentEnrollmentDto>(id);
        }

        [HttpGet("user/{id:int}")]
        public List<RentEnrollmentDto> GetByUser(int id)
        {
            var result = _repository.GetByUser(id);
            var dto = mapper.Map<List<RentEnrollmentDto>>(result);
            return dto;
        }

        [HttpPost]
        public async Task<ActionResult<RentEnrollmentDto>> Post([FromBody] CreateRentEnrollmentDto createRentEnrollmentDto)
        {
            return await Post<CreateRentEnrollmentDto, RentEnrollmentDto>(createRentEnrollmentDto, getRentEnrollmentRouteName);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateRentEnrollmentDto updateRentEnrollmentDto)
        {
            return await Put<UpdateRentEnrollmentDto>(updateRentEnrollmentDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }

    }
}
