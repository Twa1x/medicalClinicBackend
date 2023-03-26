using MedicalClinicAPI.Core.Dtos;
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

        [HttpPut("/create-doctor")]
        public ActionResult<bool> CreateDoctor([FromBody] Doctor doctor)
        {
            bool created = doctorService.CreateDoctor(doctor);
            if (created)
                return Ok("Created succesfully");

            return BadRequest("Couldn't create a new doctor!");
        }

        [HttpDelete("/delete-doctor/{doctorId}")]
        public ActionResult<bool> Delete(int doctorId)
        {
            bool deleted =  doctorService.DeleteDoctor(doctorId);
            if (deleted)
                return Ok("Deleted succesfully");
            return BadRequest("Couldn't delete the doctor");

        }

        [HttpGet("/get/{doctorId}")]
        public ActionResult<Doctor> GetById(int doctorId)
        {
            var result = doctorService.GetById(doctorId);

            if (result == null)
            {
                return BadRequest("Doctor not fount");
            }

            return Ok(result);
        }

        [HttpPatch("edit-name-and-specialisation")]
        public ActionResult<bool> GetById([FromBody] DoctorUpdateDto doctorUpdateModel)
        {
            var result = doctorService.EditNameAndSpecialisation(doctorUpdateModel);

            if (!result)
            {
                return BadRequest("Doctor could not be updated.");
            }

            return result;
        }
    }

}
