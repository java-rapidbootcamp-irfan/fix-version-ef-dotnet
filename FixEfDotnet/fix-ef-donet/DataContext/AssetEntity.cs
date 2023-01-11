using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace fix_ef_donet.DataContext
{
    [Table("tbl_asset")]
    public class AssetEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("asset_code")]
        public String AssetCode { get; set; }

        [Column("asset_name")]
        public String AssetName { get; set; }

        [Column("purchase_year")]
        public int PurchaseYear { get; set; }

        [Column("jumlah_asset")]
        public int JumlahAsset { get; set; }

        [Column("description")]
        public String Description { get; set; }

    }
}

