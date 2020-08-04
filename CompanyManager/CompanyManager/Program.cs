using Core.DAL.Repos;
using Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager
{
	class Program
	{
		static void Main(string[] args)
		{
			Company company = Companies.GetCompany(2);
			Console.WriteLine($"Loaded company ID: { company.Id } Name: { company.Name}");
		}
	}
}
