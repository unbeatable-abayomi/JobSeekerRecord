using JobSeekerRecord.Data;
using JobSeekerRecord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSeekerRecord.Repository
{
    public class JobSeekerRepository : IJobSeeker
    {
        private readonly DataContext _dataContext;
        public JobSeekerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public IEnumerable<JobSeekerModel> AllJobSeekers => _dataContext.JobSeekerTable;

        public void AddJobSeekers (JobSeekerModel jobSeekerModel)
        {
            _dataContext.JobSeekerTable.Add(jobSeekerModel);
            _dataContext.SaveChanges();
        }
        public JobSeekerModel GetJobSeeker(long Id)
        {
            JobSeekerModel jobSeekerModel = _dataContext.JobSeekerTable.Find(Id);
            return jobSeekerModel;
        }

        public JobSeekerModel DeleteJobSeeker(long Id)
        {
            JobSeekerModel jobSeekerModel = _dataContext.JobSeekerTable.Find(Id);
           if(jobSeekerModel != null)
            {
                _dataContext.JobSeekerTable.Remove(jobSeekerModel);
                _dataContext.SaveChanges();
            }
            
            

            return jobSeekerModel;

        }
        public void EditJobSeeker(JobSeekerModel jobSeekerModel)
        {
            _dataContext.Entry(jobSeekerModel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dataContext.SaveChanges();
        }
        public IQueryable<JobSeekerModel> Search(string Surname)
        {
            var jobSeekerModels = _dataContext.JobSeekerTable.Where(n => n.FirstName.Contains(Surname) || n.LastName.Contains(Surname));
            return jobSeekerModels;
        }
    }
}
