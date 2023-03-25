using MedicalClinicAPI.Entities;
using MedicalClinicAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalClinicAPI.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorsController : ControllerBase
    {
        private DoctorService doctorService { get; set; }

        public DoctorsController(DoctorService doctorService)
        {
            this.doctorService = doctorService;
        }


        [HttpGet("/get-all")]
        public ActionResult<List<Doctor>> GetAll()
        {
            var results = doctorService.GetAll();
            return Ok(results);
        }

        [HttpGet("/get/{studentId}")]
        public ActionResult<Doctor> GetById(int doctorId)
        {
            var result = doctorService.GetById(doctorId);

            if (result == null)
            {
                return BadRequest("Doctor not fount");
            }

            return Ok(result);
        }
    }

}
