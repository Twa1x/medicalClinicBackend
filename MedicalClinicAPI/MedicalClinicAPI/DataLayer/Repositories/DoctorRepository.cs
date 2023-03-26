using MedicalClinicAPI.Entities;

namespace MedicalClinicAPI.Repositories
{
    public class DoctorRepository
    {
        public List<Doctor>GetAlL()
        {
            var result = DbContext.Doctors;

            return result;
        }

        public Doctor GetById(int doctorId)
        {
            var result = DbContext.Doctors
                .Where(e => e.Id == doctorId)
                .FirstOrDefault();

            return result;
        }
    }
}
