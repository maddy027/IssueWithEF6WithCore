using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using StudentContext.Models;

namespace StudentContext
{
	public class StudentDbContext : DbContext
	{
		public StudentDbContext()
		{
		}

		public StudentDbContext(string connectionName) :base(connectionName)
		{

		}

		public DbSet<Student> Students { get; set; }

	}
}
