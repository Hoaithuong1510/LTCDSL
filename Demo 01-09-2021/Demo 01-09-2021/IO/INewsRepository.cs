using Demo_01_09_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01_09_2021.IO
{
	public interface INewsRepository
	{
		List<Publisher> GetNews();

		void Save(List<Publisher> publisher);
	}
}
