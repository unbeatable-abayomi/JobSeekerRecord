using JobSeekerRecord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSeekerRecord.Repository
{
   public interface IJobSeeker
    {
        IEnumerable<JobSeekerModel> AllJobSeekers { get; }

        public void AddJobSeekers(JobSeekerModel jobSeekerModel);

        public JobSeekerModel GetJobSeeker(long Id);
        public JobSeekerModel DeleteJobSeeker(long Id);
        public void EditJobSeeker(JobSeekerModel jobSeekerModel);
        IQueryable<JobSeekerModel> Search(string Surname);
    }
}
