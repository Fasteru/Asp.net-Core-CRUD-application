using SRPS.Entities.DomainModels;
using SRPS.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPS.Repository
{
    public interface IGetDataInterface
    {
        List<StudentsDomainModel> GetAll();

        StudentsDomainModel GetDataBasedOnId(string studentsId);

        void AddStudentsData(StudentsDomainModel studentsDomainModel);

        void UpdateStudentsData(StudentsDomainModel studentsDomainModel);

        void DeleteStudentsData(StudentsDomainModel studentsDomainModel);
    }
}
