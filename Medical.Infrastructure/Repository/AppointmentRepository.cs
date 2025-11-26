using Medical.Domain.Entity;
using Medical.Domain.Interface;
using Medical.Infrastructure.Prsistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private ApplicationDBContext _context;
        public AppointmentRepository(ApplicationDBContext context) 
        {
            _context = context;
        }
        public async Task create(Appointment entity)
        {
            _context.Appointments.Add(entity);
           await _context.SaveChangesAsync();
        }
    }
}
