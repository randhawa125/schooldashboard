using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Helper
{
	public class RoleHelper
	{
		public static string GetHomePage(string role)
		{
			switch (role)
			{
				case "Admin":
					return "Admin/Dashboard";
				case "Student":
					return "Student/Dashboard";
				case "Counsellor":
					return "Counsellor/Dashboard";
				case "School":
					return "School/Dashboard";
				default:
					return "";
			}
		}
	}
}
