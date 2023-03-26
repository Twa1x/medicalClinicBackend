using MedicalClinicAPI.Entities;

namespace MedicalClinicAPI
{
    public class DbContext
    {

        public static List<Doctor> Doctors = new List<Doctor>
        {

       

            new Doctor
            {
                Id=1,
                FirstName="Mihai",
                LastName="Pop",
                Specialisation="ORL",
                Pacients = new List<Pacient>
                {
                   new Pacient
                   {
                       Id=1,
                       FirstName="Alex",
                       LastName="Ion",
                       Age= 17,
                       SSN=1232131321,
                       DoctorId=1
                   }
                   ,
                   new Pacient
                   {
                       Id=2,
                       FirstName="Vasile",
                       LastName="Mihai",
                       Age= 35,
                       SSN=5532131321,
                       DoctorId=1
                   }
                   ,
                   new Pacient
                   {
                       Id=3,
                       FirstName="Catalin",
                       LastName="Popa",
                       Age= 19,
                       SSN=6782131321,
                       DoctorId=1
                   }
                }

            }
            ,
             new Doctor
            {
                Id=2,
                FirstName="Ionel",
                LastName="Schiopu",
                Specialisation="Ortoped",
                Pacients = new List<Pacient>
                {
                   new Pacient
                   {
                       Id=4,
                       FirstName="Marian",
                       LastName="Popescu",
                       Age= 53,
                       SSN=9932131321,
                       DoctorId=1
                   }
                   ,
                   new Pacient
                   {
                       Id=5,
                       FirstName="Catalina",
                       LastName="Mirela",
                       Age= 35,
                       SSN=8632131321,
                       DoctorId=1
                   }
                   ,
                   new Pacient
                   {
                       Id=6,
                       FirstName="Lili",
                       LastName="Trandafir",
                       Age= 25,
                       SSN=6422131321,
                       DoctorId=1
                   }
                }

            }
        };
    }
}
