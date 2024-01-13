using AutoMapper;
using SRPS.Entities.DomainModels;
using SRPS.MODELS;
using SRPS.Repository;
using System.ComponentModel;

namespace SRPS.Processor
{
    public class StudentsProcessor : IStudentsInterface
    {
        private readonly GetDataRepository _getDataRepository;

        public StudentsProcessor(GetDataRepository getDataRepository)
        {
            _getDataRepository = getDataRepository;
            Mapper.CreateMap<StudentsDomainModel, StudentsModels>();
        }

        public void CreateStudentsData(StudentsModels studentsModels)
        {
            StudentsDomainModel studentsDomainModel = new StudentsDomainModel();
            Mapper.CreateMap<StudentsModels, StudentsDomainModel>();
            Mapper.Map(studentsModels, studentsDomainModel);
             _getDataRepository.AddStudentsData(studentsDomainModel);
        }

        public void DeleteStudentsData(string studentsId)
        {
            var studentsListBasedOnId = _getDataRepository.GetDataBasedOnId(studentsId);
            _getDataRepository.DeleteStudentsData(studentsListBasedOnId);
        }

        public StudentsModels EditStudentsData(string studentsId)
        {
            var studentsListBasedOnId = Mapper.Map<StudentsDomainModel, StudentsModels>(_getDataRepository.GetDataBasedOnId(studentsId));
            return studentsListBasedOnId;
        }

        public List<StudentsModels> GetStudentsData()
        {          

            var studentsList = Mapper.Map<List<StudentsDomainModel>, List<StudentsModels>>(_getDataRepository.GetAll());
            return studentsList;
        }

        public void UpdateStudentsData(StudentsModels studentsModels)
        {

            StudentsDomainModel studentsDomainModel = new StudentsDomainModel();
            Mapper.CreateMap<StudentsModels, StudentsDomainModel>();
            Mapper.Map(studentsModels, studentsDomainModel);
             _getDataRepository.UpdateStudentsData(studentsDomainModel);
        }
    }
}
