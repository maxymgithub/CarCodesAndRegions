using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string RegionName { get; set; }
        public IEnumerable<CarNumberCode> RegionCodes { get; set; }
    }
}
