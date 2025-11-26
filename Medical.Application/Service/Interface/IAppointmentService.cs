using Medical.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Service.Interface
{
    public interface IAppointmentService
    {
        Task createAppointment(AppointmentDTO dto);
    }
}
