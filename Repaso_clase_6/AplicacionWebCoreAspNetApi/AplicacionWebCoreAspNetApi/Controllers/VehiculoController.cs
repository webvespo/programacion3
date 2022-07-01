using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWebCoreAspNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        public VehiculoController()
        {
        }
        [HttpPost]
        [Route("GetBrand")]
        public string GetBrandById(long idBrand)
        {
            return idBrand == 1 ? "Chevrolet" : "Otras";
        }

    }
}
