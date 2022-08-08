using AutoMapper;
using MobilityRentApp_Backend.Controllers.Base;
using MobilityRentApp_Backend.Data.Base;
using MobilityRentApp_Backend.Data.Repositories;
using MobilityRentApp_Backend.Model.Entities;
using MobilityRentApp_Backend.Model.Dtos.Mobility;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MobilityRentApp_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobilityController : CustomControllerBase<Mobility>
    {
        private const string getMobilityRouteName = "getMobility";
        public MobilityController(IMobilityRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<MobilityDto>>> Get()
        {
            return await Get<MobilityDto>();
        }

        [HttpGet("{id:int}", Name = getMobilityRouteName)]
        public async Task<ActionResult<MobilityDto>> Get(int id)
        {
            return await Get<MobilityDto>(id);
        }

        [HttpPost]
        public async Task<ActionResult<MobilityDto>> Post([FromBody] CreateMobilityDto createMobilityDto)
        {
            return await Post<CreateMobilityDto, MobilityDto>(createMobilityDto, getMobilityRouteName);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateMobilityDto updateMobilityDto)
        {
            return await Put<UpdateMobilityDto>(updateMobilityDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}
