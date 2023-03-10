using Cars_New.Models;
using Domain.Interface;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Cars_New.CQRS.GetAllBasket.GetAllBasketCommandHand
{
    public class GetAllBasketCommand : IRequest<IEnumerable<Basket>>
    {
        [Key]
        public int? id { get; set; }

        [Display(Name = "Картинка")]
        [Required(ErrorMessage = "Не указана картинка данной машины")]
        public string? img { get; set; }

        [Required(ErrorMessage = "Не указано короткое описание машины")]
        [StringLength(20)]
        [MaxLength(20)]
        [MinLength(10)]
        [Display(Name = "Краткое описание")]
        public string? longDisk { get; set; }

        [Required(ErrorMessage = "Не указано название машины")]
        [MaxLength(255)]
        [MinLength(1)]
        [Display(Name = "Марка машины")]
        public string? name { get; set; }

        [Required(ErrorMessage = "Не указан год издания машины")]
        [Display(Name = "Год машины")]
        public int? year { get; set; }

        public int? guarantee { get; set; }

        [Required(ErrorMessage = "Не указана стоимость машины")]
        [Display(Name = "Стоимость")]
        public int? sum { get; set; }

        //Колеса машины
        [Required(ErrorMessage = "Не указаны Колеса машины")]
        [Display(Name = "Колеса")]
        public string? wheels { get; set; }

        [Required(ErrorMessage = "Не указан цвет машины")]
        [Display(Name = "Цвет")]
        public string? color { get; set; }

        [Required(ErrorMessage = "Не указано длинное описание машины")]
        [StringLength(120)]
        [MaxLength(120)]
        [MinLength(10)]
        [Display(Name = "Длинное описание")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Не указан город машины")]
        [Display(Name = "город")]
        public string? city { get; set; }

        //Кузов
        [Required(ErrorMessage = "Не указан кузов машины")]
        [Display(Name = "кузов")]
        public string? Body { get; set; }

        //Коробка передач
        [Required(ErrorMessage = "Не указано Коробка передач машины")]
        [Display(Name = "Коробка передач")]
        public string? Transmission { get; set; }

        //Руль
        [Required(ErrorMessage = "Не указан Руль машины")]
        [Display(Name = "Руль")]
        public string? Steering { get; set; }

        //Номер
        [Required(ErrorMessage = "Не указан Номер покупателя")]
        [Display(Name = "Номер покупателя")]
        public int? phone { get; set; }
    }

    public class GetAllBasketHandler : IRequestHandler<GetAllBasketCommand, IEnumerable<Basket>>
    {
        private readonly IRepository _repository;
        private readonly ILogger<GetAllBasketHandler> _logger;
        private const string ThisName = nameof(GetAllBasketHandler);

        public GetAllBasketHandler(ILogger<GetAllBasketHandler> logger, IRepository _repository)
        {
            _logger = logger;
            this._repository = _repository;
        }
        public async Task<IEnumerable<Basket>> Handle(GetAllBasketCommand request, CancellationToken cancellationToken)
        {
            var loghand = $"{ThisName}/{nameof(Handle)}";
            _logger.LogInformation($"method {loghand} started working");
            return await _repository.GetAllBasketAsync();
        }
    }
}
