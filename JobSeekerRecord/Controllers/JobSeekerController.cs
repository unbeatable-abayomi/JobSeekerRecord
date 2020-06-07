using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSeekerRecord.Models;
using JobSeekerRecord.Repository;
using Microsoft.AspNetCore.Mvc;

namespace JobSeekerRecord.Controllers
{
    public class JobSeekerController : Controller
    {
        private readonly IJobSeeker _jobSeeker;
        public JobSeekerController(IJobSeeker jobSeeker)
        {
            _jobSeeker = jobSeeker;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lists()
        {
            return View(_jobSeeker.AllJobSeekers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(JobSeekerModel jobSeekerModel)
        {
            if (ModelState.IsValid)
            {
                _jobSeeker.AddJobSeekers(jobSeekerModel);   
            }
            return View("SuccessAdd", jobSeekerModel);
        }
        public IActionResult Details(long Id)
        {
            JobSeekerModel jobSeekerModel = _jobSeeker.GetJobSeeker(Id);
            return View(jobSeekerModel);

        }
       


        [HttpGet]
        public IActionResult DeleteConfirm(long Id)
        {
            JobSeekerModel jobSeekerModel = _jobSeeker.GetJobSeeker(Id);
            if(jobSeekerModel == null)
            {
                //error message
            }
            return View(jobSeekerModel);
        }
        [HttpPost]
        public IActionResult Deleted(long Id)
        {
            JobSeekerModel jobSeekerModel = _jobSeeker.DeleteJobSeeker(Id);

            return View("DeletedMessage",jobSeekerModel);
        }

        [HttpGet]
        public IActionResult Edit(long Id)
        {
            JobSeekerModel jobSeekerModel = _jobSeeker.GetJobSeeker(Id);
            return View(jobSeekerModel);
        }
        [HttpPost]
        public IActionResult Edit(JobSeekerModel jobSeekerModel)
        {
            _jobSeeker.EditJobSeeker(jobSeekerModel);
            return View("EditSuccess", jobSeekerModel);
        }
        [HttpPost]
        public IActionResult SearchResult(string surname)
        {
            IQueryable<JobSeekerModel> jobSeekerModels = _jobSeeker.Search(surname);
            return View("SearchResultView",jobSeekerModels);
        }

        [HttpGet]
        public IActionResult SearchResult()
        {
            return View();
        }
    }
}