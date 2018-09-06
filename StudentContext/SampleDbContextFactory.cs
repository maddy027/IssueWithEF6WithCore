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
			return new StudentDbContext(@"server=LQAM3133;Initial Catalog=Mar2018;user id=userid;password=pwd;Trusted_Connection=True;MultipleActiveResultSets=true");
		}
	}
}
