using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_PH34491.Models
{
    public class Ca
    {
        [Key]
        public string Id { get; set; }
        public string Ten { get; set; }


        public int Tuoi { get; set; }

        [ForeignKey("IdDV")]
        public string IdDV { get; set; }
        public string NoiSong { get; set; }


        public virtual DongVat DongVat { get; set; }

    }
}
