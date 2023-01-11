using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace fix_ef_donet.DataContext
{
    [Table("tab_ninja")]
    public class NinjaEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("ninja_name")]
        public String NinjaName { get; set; }

        [Column("ninja_gender")]
        public String NinjaGender { get; set; }

        [Column("ninja_color")]
        public String NinjaColor { get; set; }

        [Column("ninja_power")]
        public int NinjaPower { get; set; }

    }
}

