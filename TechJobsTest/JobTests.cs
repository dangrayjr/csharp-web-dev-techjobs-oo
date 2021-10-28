using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        Job job;
        
        [TestInitialize]
        public void CreateJobObject()
        {
            job = new Job("Product tester",
                new Employer("Acme"),
                new Location("Desert"),
                new PositionType("Quality Control"),
                new CoreCompetency("Persistence")
            );

        }


        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(job.EmployerName.Value == "Acme");
            Assert.IsTrue(job.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job.JobType.Value == "Quality Control");
            Assert.IsTrue(job.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester",
                new Employer("Acme"),
                new Location("Desert"),
                new PositionType("Quality Control"),
                new CoreCompetency("Persistence")
            );

            Assert.IsFalse(job.Equals(job1));
        }

        [TestMethod]
        public void TestToString()
        {
            Job job1 = new Job("Product tester",
                  new Employer("Acme"),
                  new Location("Desert"),
                  new PositionType("Quality Control"),
                  new CoreCompetency("Persistence"));

            string jobstring = job1.ToString();

            Assert.AreEqual(jobstring[0], jobstring[jobstring.Length - 1]);
        }

        [TestMethod]
        public void TestExpectedString()
        {
            Job job1 = new Job("Product tester",
                  new Employer("Acme"),
                  new Location("Desert"),
                  new PositionType("Quality Control"),
                  new CoreCompetency("Persistence"));

            string jobString = job1.ToString();

            string expectedString = "\n ID: " + job1.Id + "\n" +
                "\n Name: Product tester\n" +
                "\n Employer: Acme\n" +
                "\n Location: Desert\n" +
                "\n Position Type: Quality Control\n" +
                "\n Core Compentency: Persistence\n";

            Assert.AreEqual(jobString , expectedString);
        }

        [TestMethod]
        public void TestNoData()
        {
            Job job1 = new Job("Product tester",
                  new Employer("Acme"),
                  new Location(""),
                  new PositionType("Quality Control"),
                  new CoreCompetency("Persistence"));

            string jobString = job1.ToString();

            string expectedString = "\n ID: " + job1.Id + "\n" +
                "\n Name: Product tester\n" +
                "\n Employer: Acme\n" +
                "\n Location: Data not available.\n" +
                "\n Position Type: Quality Control\n" +
                "\n Core Compentency: Persistence\n";

            Assert.AreEqual(jobString, expectedString);
        }

    }
}
