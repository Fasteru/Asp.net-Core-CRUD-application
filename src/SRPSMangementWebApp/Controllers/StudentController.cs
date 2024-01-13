using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SRPS.Entities.DomainModels;
using SRPS.MODELS;
using SRPS.Processor;

namespace SRPSMangementWebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentsInterface _StudentsInterface;

        public StudentController(IStudentsInterface StudentsInterface)
        {
            _StudentsInterface = StudentsInterface;
        }

        [Route("/")]
        public  IActionResult GetStudents()
        {
           List<StudentsModels> studentlist =  _StudentsInterface.GetStudentsData();

            return View("GetStudents",studentlist);
        }

        [HttpGet]
        [Route("/[action]")]
        public IActionResult CreateStudent()
        {
            return View("CreateStudents");
        }

        [HttpPost]
        [Route("/[action]")]
        public IActionResult CreateStudent(StudentsModels studentsModels)
        {
            _StudentsInterface.CreateStudentsData(studentsModels);
            return RedirectToAction("GetStudents");
        }

        [HttpGet]
        [Route("/[action]/{studentid}")]
        public IActionResult EditStudent(string studentid)
        {

            StudentsModels studentlistBasedOnId = _StudentsInterface.EditStudentsData(studentid);
            return View("EditStudents", studentlistBasedOnId);
        }

        [HttpPost]
        [Route("/[action]/{studentid}")]
        public IActionResult EditStudent(StudentsModels studentsModels)
        {
            _StudentsInterface.UpdateStudentsData(studentsModels);
            return RedirectToAction("GetStudents");

        }

        [HttpGet]
        [Route("/[action]/{studentid}")]
        public IActionResult DeleteStudent(string studentid)
        {
            _StudentsInterface.DeleteStudentsData(studentid);
            return RedirectToAction("GetStudents");
        }

    }
}
