namespace CodeFirstYaklasimi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteri")]
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            Satis = new HashSet<Satis>();
        }

        public int MusteriID { get; set; }

        [StringLength(50)]
        public string MusteriAdi { get; set; }

        [StringLength(50)]
        public string MusteriSoyadi { get; set; }

        [StringLength(500)]
        public string Adres { get; set; }

        [StringLength(12)]
        public string CepTelNo { get; set; }

        public Boolean MesajGelsinMi { get; set; }





        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
