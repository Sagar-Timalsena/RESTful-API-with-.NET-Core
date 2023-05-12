using MagicView.Models;
using MagicView.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicView.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult <IEnumerable<VillaDto>> GetVillas()
        {
            return Ok((VillaStore.villaList));
        }
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<VillaDto> GetVillas(int id)
        {
            if( id==0)
            {
                return BadRequest();
            }
            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            if(villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
/*
            return Ok(VillaStore.villaList.FirstOrDefault(u=>u.Id==id));*/
        }
    }
}
