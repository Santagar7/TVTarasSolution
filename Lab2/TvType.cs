using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class TvType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TV> Tvs { get; set; }
    }
}
