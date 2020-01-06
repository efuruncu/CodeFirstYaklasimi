namespace CodeFirstYaklasimi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satis
    {
        public int SatisID { get; set; }

        public int? MusteriID { get; set; }

        public decimal? Tutar { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
