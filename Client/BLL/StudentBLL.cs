using Client.DAL;
using Client.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.BLL
{
    class StudentBLL
    {
        StudentDAL studentDal;

        public StudentBLL()
        {
            studentDal = new StudentDAL();

        }



        public List<Student> getAllStudent()
        {
            return studentDal.getAllStudent();
        }

        public List<Lop> getAllLop()
        {
            return studentDal.getAllClass();
        }

        public bool addStudent(Student student)
        {

            return studentDal.addStudent(student);

        }

        public bool updateStudent(Student student)
        {
            return studentDal.updateStudent(student);
        }

        public bool deleteStudent(int id)
        {
            return studentDal.deleteStudent(id);
        }

    }
}
