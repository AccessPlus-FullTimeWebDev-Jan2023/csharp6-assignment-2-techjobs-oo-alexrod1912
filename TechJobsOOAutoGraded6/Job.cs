using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        

            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employername, Location employerLocation , PositionType jobtype , CoreCompetency jobCoreCompetency ) : this()
        {
            Name = name;
            EmployerName = employername; 
            EmployerLocation = employerLocation;
            JobType = jobtype;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            if (Name == "" || Name == null)
            {
                Name = "Data not available";
            }
            if(EmployerName.Value == null || EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";
            }
            if (EmployerLocation.Value == null || EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobType.Value == null || JobType.Value == "")
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == null || JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";
            }

            return $"\n {Id} \n Name : {Name} \n Employer: {EmployerName} \n Location: {EmployerLocation} \n Position Type: {JobType} \n Core Competency: {JobCoreCompetency} \n";
        }

    }
}

