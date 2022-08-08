using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobilityRentApp_Backend.Controllers.Base;
using MobilityRentApp_Backend.Data.Repositories;
using MobilityRentApp_Backend.Model.Dtos.MobilityKind;
using MobilityRentApp_Backend.Model.Entities;

namespace MobilityRentApp_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobilityKindController : CustomControllerBase<MobilityKind>
    {
        private const string getMobilityKindRouteName = "getMobilityKind";
        public MobilityKindController(IMobilityKindRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<MobilityKindDto>>> Get()
        {
            return await Get<MobilityKindDto>();
        }

        [HttpGet("{id:int}", Name = getMobilityKindRouteName)]
        public async Task<ActionResult<MobilityKindDto>> Get(int id)
        {
            return await Get<MobilityKindDto>(id);
        }

        [HttpPost]
        public async Task<ActionResult<MobilityKindDto>> Post([FromBody] CreateMobilityKindDto createMobilityKindDto)
        {
            return await Post<CreateMobilityKindDto, MobilityKindDto>(createMobilityKindDto, getMobilityKindRouteName);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateMobilityKindDto updateMobilityKindDto)
        {
            return await Put<UpdateMobilityKindDto>(updateMobilityKindDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}
