using MedicalClinicAPI.Core.Dtos;
using MedicalClinicAPI.DataLayer.Dtos;
using MedicalClinicAPI.Entities;
using MedicalClinicAPI.Mapping;
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

        public DoctorDto GetById(int doctorId)
        {
            var doctor = doctorRepository.GetById(doctorId);

            var result = doctor.ToDoctorDto();

            return result;
        }

        public bool DeleteDoctor(int doctorId)
        {
            var doctor = doctorRepository.GetById(doctorId);

            if (doctor == null)
                return false;
            var deleted = doctorRepository.DeleteDoctor(doctor);
            if (deleted)
                return true;
            return false;
        }

        public bool CreateDoctor(Doctor doctor)
        {
            if (doctor != null)
            {
                var newDoctor = doctorRepository.CreateDoctor(doctor);
                if (newDoctor == null)
                    return false;
                return true;
            }
            return false;

        }

        public bool EditNameAndSpecialisation(DoctorUpdateDto payload)
        {
            if (payload == null || payload.Specialisation == null
                || payload.FirstName == null || payload.LastName == null)
            {
                return false;
            }

            var result = doctorRepository.GetById(payload.Id);
            if (result == null) return false;

            result.FirstName = payload.FirstName;
            result.LastName = payload.LastName;

            return true;
        }
    }
}
