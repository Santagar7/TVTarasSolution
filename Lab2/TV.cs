using System.Collections.Generic;

namespace Lab2 {
    public class TV {
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public double Diagonal { get; set; }

        public int TypeId { get; set; }

        public double Power { get; set; }

        public virtual TvType Type { get; set; }
    }
}
