using System;
using Moq;
using NUnit.Framework;

namespace TddMockPractice
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void LoadsData()
        {
            var mockRepository = new Mock<FileRepository>();
            mockRepository.Setup(r => r.Load(It.IsAny<string>())).Returns("01/01/2000");
            var employee = new Employee("Garvan", mockRepository.Object);
            employee.LoadData();
            Assert.That(employee.DateOfBirth, Is.EqualTo(new DateTime(2000,1,1)));
        }

        [Test]
        public void EmployeeLoadsFromFileRepository()
        {
            var mockRepository = new Mock<FileRepository>();

            var employee = new Employee("Garv", mockRepository.Object);

            employee.LoadData();

            mockRepository.Verify(r => r.Load("Garvan"));
           
            


        }
    }

    public class Employee
    {
        private readonly string name;
        private readonly FileRepository fileRepository;

        public Employee(string name) : this(name, new FileRepository())
        {
        }

        public Employee(string name, FileRepository fileRepository)
        {
            this.name = name;
            this.fileRepository = fileRepository;
        }

        public DateTime DateOfBirth { get; private set; }

        public void LoadData()
        {
            //var data = fileRepository.Load(name);
            //DateOfBirth = Convert.ToDateTime(data);
            DateOfBirth = DateTime.Now;
        }
    }
}