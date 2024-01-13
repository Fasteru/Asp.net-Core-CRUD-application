using SRPS.Entities;
using SRPS.Entities.DomainModels;
using SRPS.MODELS;
using System.Security.Cryptography;

namespace SRPS.Repository
{
    public class GetDataRepository: IGetDataInterface
    {
        private readonly SRPSDbContext _db;

        public GetDataRepository(SRPSDbContext sRPSDbContext)
        {
            _db = sRPSDbContext;
        }

        public List<StudentsDomainModel> GetAll()
        {
            

            return (from StudentsDomainModel in _db.SRPS_TBL_Students.AsEnumerable() select StudentsDomainModel).ToList();
        }

        public StudentsDomainModel GetDataBasedOnId(string studentsId)
        {

            StudentsDomainModel studentdomainModel = null;
            List<StudentsDomainModel> ListOfstudentsDomainModels =  (from StudentsDomainModel in _db.SRPS_TBL_Students.AsEnumerable() select StudentsDomainModel).ToList();
            foreach (var student in ListOfstudentsDomainModels)
            {
                if (Convert.ToString(student.Id).Contains(studentsId))
                {
                    studentdomainModel = student;
                    return studentdomainModel;
                }
                else
                {
                    continue;
                }
            }

            return studentdomainModel;
        }

        public void AddStudentsData(StudentsDomainModel studentsDomainModel)
        {
            _db.SRPS_TBL_Students.Add(studentsDomainModel);
            _db.SaveChanges();
        }

        public void UpdateStudentsData(StudentsDomainModel studentsDomainModel)
        {
            _db.SRPS_TBL_Students.Update(studentsDomainModel);
            _db.SaveChanges();
        }

        public void DeleteStudentsData(StudentsDomainModel DomainModel)
        {
            _db.SRPS_TBL_Students.Remove(DomainModel);
            _db.SaveChanges();
        }
    }
}