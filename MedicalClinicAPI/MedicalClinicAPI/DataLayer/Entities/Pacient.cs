﻿namespace MedicalClinicAPI.Entities
{
    public class Pacient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public long SSN { get; set; }

        public int DoctorId { get; set; }
    }
}
