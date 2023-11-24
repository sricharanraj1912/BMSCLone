using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BMS_BL;
using BMS_EF;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace BMSWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BmsController : ControllerBase
    {
        [HttpGet("/getmovies")]
        public List<BMS_EF.Movie> GetMovies()
        {
            var movies = BMS_BL.Movie.Get();

            return movies;
        }

        [HttpPost("/addmovies/{mname}/{ml}/{rd}/{cinema}")]
        public IActionResult AddMovie([FromRoute] string mname, [FromRoute] string ml, [FromRoute] DateTime rd, [FromRoute] string cinema)
        {
            BMS_BL.Admin.Add(new BMS_EF.Movie { MovieName = mname, MovieLang = ml, ReleaseDate = rd, Cinema = cinema });
            return Ok("Added");
        }
        [HttpPut("/updatemovies/{mid}")]
        public IActionResult Update([FromRoute] int mid, [FromForm] BMS_EF.Movie a)
        {
            BMS_BL.Admin.Update(mid, a);
            return Ok("updated");

        }
        [HttpDelete("/deletemovies/{mid}")]
        public IActionResult Delete([FromRoute] int mid)
        {
            BMS_BL.Admin.Delete(mid);
            return Ok("deleted");

        }
        [HttpGet("/search/{mname}")]
        public IActionResult GetMovie([FromRoute] string mname)
        {
            var movie=BMS_BL.User.Search(mname);
            return Ok(movie);
        }

        //public IActionResult BookTicket(BMS_EF.BookTicket b) {
        //var}
        [HttpPost("/booktickets")]
        public IActionResult booktickets([FromForm]BMS_EF.BookTicket b)
        {
            BMS_BL.User.bookicket(b);

            return Ok("ticket booked");
        }

        
        [HttpPost("/addusers")]
        public IActionResult AddUsers([FromForm] BMS_EF.RegisterUser ru)
        {
            BMS_BL.User.AddUser(ru);

            return Ok("user added");
        }






    }

}
