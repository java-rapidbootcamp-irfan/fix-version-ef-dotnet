using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fix_ef_donet.DataContext
{
    [Table("tab_absen")]
    public class AbsenEntity { 
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("absen_name")]
    public String AbsenName { get; set; }

    [Column("izin")]
    public String Izin { get; set; }

    [Column("sakit")]
    public String Sakit { get; set; }

    [Column("absen")]
    public String Absen { get; set; }

    [Column("jumlah_hadir")]
    public int JumlahHadir { get; set; }
        
    [Column("description")]
    public String Description { get; set; }
    }
}