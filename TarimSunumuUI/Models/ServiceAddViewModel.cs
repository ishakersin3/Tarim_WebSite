using System.ComponentModel.DataAnnotations;

namespace TarimSunumuUI.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Bu Alan Boş Geçilemez")]
        public string Title{ get; set; }

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel Alanı Boş Geçilemez")]
        public string Image { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama Alanı Boş Geçilemez")]
        public string Description { get; set; }
    }
}
