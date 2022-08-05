using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using selfieAWookie.Core.Selfies.Domain;

namespace WebAPIASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        #region public metohds
        [HttpGet(Name = "Selfies")]
        //public IEnumerable<Selfies> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(item => new Selfies() { Id = item });
        //}
        public IActionResult get()
        {
            var modele = Enumerable.Range(0, 5).Select(i => new Selfie()
            {
               Id = i
            });

            return this.Ok(modele);

        }
        #endregion

    }
}
