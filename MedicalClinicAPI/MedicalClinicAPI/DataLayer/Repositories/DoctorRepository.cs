using MedicalClinicAPI.Entities;

namespace MedicalClinicAPI.Repositories
{
    public class DoctorRepository
    {
        public List<Doctor> GetAlL()
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

        public Doctor CreateDoctor(Doctor doctor)
        {
            Random rand = new Random();
            if (doctor.Id == null)
                doctor.Id = rand.Next(DbContext.Doctors.Count, 100);
       
                
            var result = new Doctor()
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Specialisation = doctor.Specialisation,
                Pacients = doctor.Pacients
            };

            DbContext.Doctors.Add(result);
            return result;
        }

        public bool DeleteDoctor(Doctor doctor)
        {
           var deleted =  DbContext.Doctors.Remove(doctor);
            if (deleted)
                return true;
            return false;
        }
    }
}
