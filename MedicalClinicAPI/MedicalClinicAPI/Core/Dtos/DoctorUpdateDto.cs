using System.ComponentModel.DataAnnotations;

namespace MedicalClinicAPI.Core.Dtos
{
    public class DoctorUpdateDto
    {

        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required, MaxLength(50)]
        public string Specialisation { get; set; }
    }
}
