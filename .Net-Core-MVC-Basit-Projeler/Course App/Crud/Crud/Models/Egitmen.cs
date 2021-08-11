using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Egitmen
    {
        [Required(ErrorMessage ="Lütfen id yi giriniz")]
        public int id { get; set; }
        [Required(ErrorMessage = "Lütfen İsminizi  giriniz")]
        public string isim { get; set; }
        [Required(ErrorMessage = "Lütfen Soy isminizi  giriniz")]
        public string soyisim { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon numaranızı  giriniz")]
        public decimal Telefon{ get; set; }
        [Required(ErrorMessage = "Lütfen mail adresini giriniz ")]
        [EmailAddress(ErrorMessage ="Lüten mail formatında bir giriş yapınız")]
        public string email { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklama  giriniz")]
        public string açiklama { get; set; }
        [Required(ErrorMessage = "Lütfen Fotograf ekleyiniz")]
        public string Fotograf { get; set; }
    }
}
