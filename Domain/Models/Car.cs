using System.ComponentModel.DataAnnotations;

namespace Cars_New.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Картинка")]
        [Required(ErrorMessage = "Не указана картинка данной машины")]
        public string img { get; set; }

        [Required(ErrorMessage = "Не указано короткое описание машины")]
        [Display(Name = "Краткое описание")]
        public string longDisk { get; set; }

        [Required(ErrorMessage = "Не указано название машины")]
        [Display(Name = "Марка машины")]
        public string name { get; set; }

        [Required(ErrorMessage = "Не указан год издания машины")]
        [Display(Name = "Год машины")]
        public int year { get; set; }

        public int guarantee { get; set; }

        [Required(ErrorMessage = "Не указана стоимость машины")]
        [Display(Name = "Стоимость")]
        public int sum { get; set; }

        //Колеса машины
        [Required(ErrorMessage = "Не указаны Колеса машины")]
        [Display(Name = "Колеса")]
        public string? wheels { get; set; }

        [Required(ErrorMessage = "Не указан цвет машины")]
        [Display(Name = "Цвет")]
        public string? color { get; set; }

        [Required(ErrorMessage = "Не указано длинное описание машины")]
        [StringLength(120)]
        [Display(Name = "Длинное описание")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Не указан город машины")]
        [Display(Name = "город")]
        public string city { get; set; }

        //Кузов
        [Required(ErrorMessage = "Не указан кузов машины")]
        [Display(Name = "кузов")]
        public string Body { get; set; }

        //Коробка передач
        [Required(ErrorMessage = "Не указано Коробка передач машины")]
        [Display(Name = "Коробка передач")]
        public string Transmission { get; set; }

        //Руль
        [Required(ErrorMessage = "Не указан Руль машины")]
        [Display(Name = "Руль")]
        public string Steering { get; set; }

        //Номер
        [Required(ErrorMessage = "Не указан Номер покупателя")]
        [Display(Name = "Номер покупателя")]
        public int phone { get; set; }

    }
}
