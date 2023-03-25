namespace MedicalClinicAPI.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Specialisation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Pacient> Pacients { get; set; }

    }
}
