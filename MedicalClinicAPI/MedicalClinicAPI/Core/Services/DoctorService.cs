using MedicalClinicAPI.Entities;
using MedicalClinicAPI.Repositories;

namespace MedicalClinicAPI.Services
{
    public class DoctorService
    {
        private DoctorRepository doctorRepository { get; set; }

        public DoctorService(DoctorRepository doctorRepository)
        {
            this.doctorRepository = doctorRepository;
        }

        public List<Doctor> GetAll()
        {
            var result = doctorRepository.GetAlL();

            return result;
        }

        public Doctor GetById(int doctorId)
        {
           var result = doctorRepository.GetById(doctorId);
            return result;
        }
    }
}
