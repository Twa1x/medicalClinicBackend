﻿using MedicalClinicAPI.DataLayer.Dtos;
using MedicalClinicAPI.DataLayer.Mapping;
using MedicalClinicAPI.Entities;

namespace MedicalClinicAPI.Mapping
{
    public static class DoctorsMappingExtensions
    {
        public static DoctorDto ToDoctorDto(this Doctor doctor)
        {
            if (doctor == null) return null;

            var result = new DoctorDto();
            result.Id = doctor.Id;
            result.FullName = doctor.FirstName + " " + doctor.LastName;
            result.Specialisation = doctor.Specialisation;
            result.Pacients = doctor.Pacients.ToPacientDtos();
            return result;
        }

        public static Doctor FromDoctorDto(this DoctorDto doctor)
        {
            var result = new Doctor();
            string[] fullName = doctor.FullName.Split(' ');
            result.FirstName = fullName.ElementAt(0);
            result.LastName = fullName.ElementAt(1);
            result.Specialisation = doctor.Specialisation;
            return result;
        }

    }
}
