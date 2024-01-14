using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	public class AppCategory : AppEntityBase
	{
        public AppCategory()
        {
        }
        public string Name { get; set; }
		public string Description { get; set; }
	}
}
