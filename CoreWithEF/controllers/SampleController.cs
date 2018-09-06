using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Edmx;
using StudentContext;

namespace CoreWithEF.controllers
{
    public class SampleController : Controller
    {
		private readonly StudentDbContext _dbContext;

		public SampleController(StudentDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
        {
            return View();
        }

		[HttpGet("/api/studentDetails")]
		public IList<char> GetStudentDetails()
		{
			return _dbContext.Students.FirstOrDefault().Name.ToString().ToList();
		}
	}
}