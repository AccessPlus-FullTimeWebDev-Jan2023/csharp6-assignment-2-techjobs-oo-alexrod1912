
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //Testing Objects
        //initalize your testing objects here

        [TestMethod] //2
        public void TestSettingJobId()
        {
            Assert.AreNotEqual(job1, job2, "Objects with different ID Equal?");
            double difference = job2.Id -job1.Id;
            Assert.IsTrue(difference == 1);

        }

        [TestMethod] //3
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name, "Is Name set at time of declaration?");
            Assert.AreEqual("ACME", job3.EmployerName.Value, "Is EmployerName set at time of declaration?");
            Assert.AreEqual("Desert", job3.EmployerLocation.Value, "Is EmployerLocation set at time of declaration?");
            Assert.AreEqual("Quality control", job3.JobType.Value, "Is JobType set at time of declaration?");
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value, "Is Name set at time of declaration?");

        }

        [TestMethod] //4
        public void TestJobsForEquality()
        {

            Assert.AreEqual(job2.Equals(job3), false);

        }

    }

    
}

