using CountryApi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace CountryApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {

        PaisRepository Pais = new PaisRepository();

        [HttpGet]
        public List<Models.PaisModel> FindAll()
        {  
            return Pais.FindAll();
        }
    }
}
