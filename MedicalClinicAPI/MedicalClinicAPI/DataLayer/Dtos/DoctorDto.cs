namespace MedicalClinicAPI.DataLayer.Dtos
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialisation { get; set; }
        public List<PacientDto> Pacients { get; set; }
    }
}
