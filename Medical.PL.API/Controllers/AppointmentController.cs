using Medical.Application.DTO;
using Medical.Application.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical.PL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        public IAppointmentService _servive;
        public AppointmentController(IAppointmentService servive)
        {
            _servive = servive;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AppointmentDTO dto)
        {
            await _servive.createAppointment(dto);
            return Ok("Appoinment created successfully");
        }
    }
}
