using Microsoft.AspNetCore.Mvc;
using WEBAPI.Model;
using WEBAPI.Model.Data;

namespace WEBAPI.Controllers
{
    [ApiController]
    // simplified code
    [Route("api/shirts")]
    public class ShirtController: ControllerBase
    {

        [HttpGet]
        //[Route("/shirts")]
        public IActionResult getAllShirts()
        {
            return Ok(ShirtData.getAllShirts());
        }

        [HttpGet("{id}")]

        //[Route("/shirts")]

        //[HttpGet("{id}/{color}")]
        //public string getAPArticularShirt(int id, [FromRoute] string color)

        //public string getAPArticularShirt(int id, [FromHeader(Name = "Color")] string color)
        public IActionResult getAPArticularShirt(int id)

        //public string getAPArticularShirt(int id, [FromQuery] string color)
        {
            if (id <= 0) return BadRequest();
            var shirtwithId = ShirtData.returnShirt(id);
            if(shirtwithId == null)
            {
                return NotFound();
            }

            return Ok(shirtwithId);
        }

        [HttpPost]
        //[Route("/shirts")]
        public IActionResult createAShirt([FromForm] Shirt shirt)
        {
            if (shirt == null)
            {
                return BadRequest();
            }

            var isShirtExists = ShirtData.getShirtById(shirt.Brand, shirt.Color, shirt.Gender, shirt.Size);
            if (isShirtExists != null) return BadRequest();

            ShirtData.AddShirt(shirt);
            return Ok("Created");
        }

        [HttpPut("{id}")]
        //[Route("/shirts/{id}")]
        public IActionResult updateAShirt(int id)
        {
            return Ok($"updating Shirt with {id}");
        }

        [HttpDelete("{id}")]
        //[Route("/shirts/{id}")]
        public IActionResult deleteAShirt(int id)
        {
            return Ok($"deleting Shirt with {id}");
        }
    }
}
