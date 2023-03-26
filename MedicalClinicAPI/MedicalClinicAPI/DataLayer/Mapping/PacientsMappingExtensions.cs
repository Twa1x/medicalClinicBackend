using MedicalClinicAPI.DataLayer.Dtos;
using MedicalClinicAPI.Entities;
using System.Diagnostics;

namespace MedicalClinicAPI.DataLayer.Mapping
{
    public static class PacientsMappingExtensions
    {
        public static List<PacientDto> ToPacientDtos(this List<Pacient> pacients)
        {
            var results = pacients.Select(e => e.ToPacientDto()).ToList();

            return results;
        }

        public static PacientDto ToPacientDto(this Pacient pacient)
        {
            if (pacient == null) return null;

            var result = new PacientDto();
            result.FirstName = pacient.FirstName;
            result.LastName = pacient.LastName;
           

            return result;
        }
    }
}
