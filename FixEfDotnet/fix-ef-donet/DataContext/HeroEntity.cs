using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace fix_ef_donet.DataContext
{
    [Table("tbl_hero")]
    public class HeroEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("hero_name")]
        public String HeroName { get; set; }

        [Column("hero_role")]
        public String HeroRole { get; set; }

        [Column("hero_power")]
        public int HeroPower { get; set; }

    }
}

