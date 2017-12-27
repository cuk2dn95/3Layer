using Client.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.DAL
{
    class StudentDAL
    {

        HttpConnector httpConnector;

       public StudentDAL()
        {
            httpConnector = new HttpConnector();
        }


        public  bool addStudent(Student student)
        {

            HttpResponseMessage response = httpConnector.PostAsJsonAsync(
                "api/Students", student).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else return false;
        }


        public bool  deleteStudent(int id)
        {
            HttpResponseMessage response = httpConnector.DeleteAsync(
                "api/Students/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else return false;


        }


        public Student getStudent(int id)
        {
            Student student = null;
            String uri = "api/Students/" + id;
            HttpResponseMessage response = httpConnector.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                student = JsonConvert.DeserializeObject<Student>(json);
            }
            return student;
        }

        public bool updateStudent(Student student)
        {
            String uri = "api/Students/" + student.Id;
            HttpResponseMessage response = httpConnector.PutAsJsonAsync(uri, student).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;

        }


        public List<Lop> getAllClass()
        {
            String uri = "api/Lops";
            HttpResponseMessage response = httpConnector.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                var json =  response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Lop>>(json);
            }
            return null;
        }


        public List<Student> getAllStudent()
        {
            String uri = "api/Students";
            HttpResponseMessage response = httpConnector.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Student>>(json);
            }
            return null;
        }


    }
}
