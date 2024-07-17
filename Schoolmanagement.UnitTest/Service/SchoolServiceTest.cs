using Moq;
using SchoolManagement.Domain;
using SchoolManagement.Service.StudentService;
using SchoolManagement.Repository.DataRepositories;

namespace SchoolManagement.UnitTest.Service
{
    [TestFixture]
    public class SchoolServiceTest
    {
        //Steps- Mock, Act, Assert
        [Test]
        public void InsertStudent_ShouldSuccss()
        {
            // Mock
            var mockSchoolRepository = new Mock<ISchoolRepo<Student>>();

            var objStudent = new Student();
            int expectedId = 100; // Expected Unique ID from repository
            mockSchoolRepository.Setup(repo => repo.AddStudent(objStudent)).Returns(expectedId);
            var studentService = new StudentService(mockSchoolRepository.Object);

            // Act
            var actualId = studentService.AddStudent(objStudent);

            // Assert
            //Assert.Multiple(() =>
            //{
            Assert.That(expectedId, Is.EqualTo(actualId));
            //});
        }

        [Test]
        public void InsertStudent_ShouldFailForNullObject()
        {
            // Mock
            var mockSchoolRepository = new Mock<ISchoolRepo<Student>>();
            var studentService = new StudentService(mockSchoolRepository.Object);

            // Act
            var actualId = studentService.AddStudent(null);

            // Assert
            Assert.Zero(actualId);

        }

        [Test]
        public void GetAllStudent_ShouldReturnSuccessWithStudentList()
        {
            // Mock
            var mockSchoolRepository = new Mock<ISchoolRepo<Student>>();
            var expectedStudentList = new List<Student>();

            mockSchoolRepository.Setup(repo => repo.GetAllStudent())
                .Returns(expectedStudentList.AsEnumerable());
            var studentService = new StudentService(mockSchoolRepository.Object);

            // Act
            var actualStudentList = studentService.GetAllStudents();

            // Assert
            Assert.That(expectedStudentList.Count, Is.EqualTo(actualStudentList.Count()));

        }

        [Test]
        public void GetAllStudentReport_ShouldReturnSuccessWithEmptyList()
        {
            // Mock
            var mockSchoolRepository = new Mock<ISchoolRepo<Student>>();
            mockSchoolRepository.Setup(repo => repo.GetAllStudent())
               .Returns(Enumerable.Empty<Student>());
            var studentService = new StudentService(mockSchoolRepository.Object);

            // Act
            var actualForecasts = studentService.GetAllStudents();

            // Assert
            Assert.IsEmpty(actualForecasts);

        }


    }
}