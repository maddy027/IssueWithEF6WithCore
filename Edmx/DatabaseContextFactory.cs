using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edmx
{
	public class DatabaseContextFactory : IDbContextFactory<EpackMar2018Entities>
	{
		public EpackMar2018Entities Create()
		{
			return new Edmx.EpackMar2018Entities("Data Source=LQAM3133;Initial Catalog=EpackMar2018;user id=EpackUser;password=EpackPwd;");
		}
	}
}
