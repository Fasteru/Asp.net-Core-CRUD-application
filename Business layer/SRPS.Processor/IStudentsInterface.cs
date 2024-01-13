using SRPS.MODELS;

namespace SRPS.Processor
{
    public interface IStudentsInterface
    {
        List<StudentsModels> GetStudentsData();
        void CreateStudentsData(StudentsModels studentsModels);

        StudentsModels EditStudentsData(string studentsId);
        void UpdateStudentsData(StudentsModels studentsModels);
        void DeleteStudentsData(string studentsId);

    }
}
