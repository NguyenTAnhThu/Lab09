using  51900564_lab9;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentService;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddOneStudent()
        {

            StudentService.StudentService service = new StudentService.StudentService();
            Student s1 = new Student() { Id = 1, Name = "Thư", Age = 50 };
            bool status1 = service.addStudent(s1);
            //status 
            Assert.IsTrue(status1);
        }

        [TestMethod]
        //Mssv đã tồn tại trong danh sách
        public void TestAddMultiStudent()
        {

            StudentService.StudentService service = new StudentService.StudentService();
            Student s1 = new Student() { Id = 1, Name = "Thư", Age = 50 };
            Student s2 = new Student() { Id = 1, Name = "Thư", Age = 50 };


            bool status1 = service.addStudent(s1);
            bool status2 = service.addStudent(s2);
            //status 
            Assert.IsFalse(status2);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullStudent()
        {
            StudentService.StudentService service = new StudentService.StudentService();
            service.addStudent(null);
        }

        [TestMethod]

        public void addFailStudent()
        {
            StudentService.StudentService service = new StudentService.StudentService();
            Student s = new Student() { Name = "Thư", Age = 50 };
            bool status = service.addStudent(s);
            Assert.IsFalse(status);
        }

        //TEST POSITION
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void OutArr()
        {
            StudentService.StudentService service = new StudentService.StudentService();
            service.getStudentAt(-1);
        }

    }
}