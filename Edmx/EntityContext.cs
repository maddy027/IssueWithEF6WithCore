using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Edmx
{
    public class EntityContext
    {

		public IList<string> GetStudentDetails()
		{
			IList<string> lstStudent = new List<string>();
			try
			{

				using (EpackMar2018Entities db = new EpackMar2018Entities("Data Source=LQAM3133;Initial Catalog=EpackMar2018;user id=EpackUser;password=EpackPwd;"))
				{
					var result = db.GetStudentDetails();
					foreach (var v in result)
					{
						lstStudent.Add(v.ToString());
					}

				}
			}
			catch (Exception ex)
			{

			}
			//lstStudent.Add(new Entities_.Student() { Name = "Mahadev", Id = 1 });
			return lstStudent;
		}

	}
}
