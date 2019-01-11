using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentContext
{
	public class SampleDbContextFactory : IDbContextFactory<StudentDbContext>
	{
		StudentDbContext IDbContextFactory<StudentDbContext>.Create()
		{
            return new StudentDbContext(@"Server=(localdb)\mssqllocaldb;Database=Mar2018;Trusted_Connection=True;MultipleActiveResultSets=true");
		}
    }
}
