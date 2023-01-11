using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace fix_ef_donet.DataContext
{
    [Table("tbl_category")]
    public class CategoryEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("category_code")]
        public String CategoryCode { get; set; }

        [Column("category_name")]
        public String CategoryName { get; set; }

        [Column("description")]
        public String Description { get; set; }

    }
}

