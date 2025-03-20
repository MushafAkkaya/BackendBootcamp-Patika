using DependencyInjection_ServiceLifeTimes.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection_ServiceLifeTimes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //Constructor injection yöntemiyle DI
        //private readonly ISiramatik _siramatik;
        //public ValuesController(ISiramatik siramatik)
        //{
        //    _siramatik = siramatik;
        //}

        [HttpGet]
        public IActionResult Get(int sayi = 1)
        {
            var siraNumaralari = new List<int>();

            for (int i = 0; i < sayi; i++)
            {
                var _siramatik = HttpContext.RequestServices.GetRequiredService<ISiramatik>();
                // Property injection yöntemiyle DI

                var yeniNumara = _siramatik.SiraNumarasiAl();
                siraNumaralari.Add(yeniNumara);
            }
            return Ok(siraNumaralari);
        }
    }
}
