using System;
using System.Text;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name
        {
            get
            {
                if (Name == string.Empty)
                    return "Data not available";
                else
                    return Name;

            }
            set { Name = value; }
        }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
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
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append("ID: ").Append(Id).Append(Environment.NewLine);
            sb.Append("Name: ").Append(Name).Append(Environment.NewLine);
            sb.Append("Employer: ").Append(EmployerName.ToString()).Append(Environment.NewLine);
            sb.Append("Location: ").Append(EmployerLocation.ToString());
            sb.Append("Position Type: ").Append(JobType.ToString()).Append(Environment.NewLine);
            sb.Append("Core Competency: ").Append(JobCoreCompetency.ToString()).Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
