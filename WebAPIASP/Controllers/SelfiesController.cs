using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using selfieAWookie.Core.Selfies.Domain;
using selfieAWookie.Core.Selfies.Infrastructures;

namespace WebAPIASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        #region Fields
        private readonly SelfiesContext _context;
        #endregion
        #region constructors
        public SelfiesController(SelfiesContext context) {
            this._context = context;
        }
            #endregion  
        #region public metohds
        [HttpGet(Name = "Selfies")]
        //public IEnumerable<Selfies> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(item => new Selfies() { Id = item });
        //}
        public IActionResult get()
        {
           
            var modele = this._context.selfies
                .Include(item => item.Wookie)
                .Select(item => new { Title=item.Title,  WookieID = item.Wookie.id,nbrSelfiesDeWookie = item.Wookie.Selfies.Count})
                .ToList();
            return this.Ok(modele);

        }
        #endregion

    }
}
