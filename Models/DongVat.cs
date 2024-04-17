using System.ComponentModel.DataAnnotations;

namespace MVC_PH34491.Models
{
    public class DongVat
    {
        [Key]
        public string Id { get; set; }
        public string Ho { get; set; }
        public string NoiSong { get; set; }
        public string ThucAn { get; set; }
        public virtual List<Ca> Cas { get; set; }
    }
}
