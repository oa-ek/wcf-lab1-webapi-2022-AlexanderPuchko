namespace AutoOA.API
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string? Region { get; set; }

        public string? BodyType { get; set; }

        public string? VehicleModel { get; set; }

        public short ProductionYear { get; set; } // Рік випуску

        public string? GearBox { get; set; }

        public string? DriveType { get; set; }

        public string? StateNumber { get; set; } = "Не задано"; // Гос номер
        public int NumberOfSeats { get; set; } // Кількість сидінь
        public int NumberOfDoors { get; set; } // Кількість дверей
        public decimal Price_USD { get; set; } = 0; // Ціна в доларах
        public decimal Price_UAH { get; set; } = 0; // Ціна в гривнях
        public decimal Price_EUR { get; set; } = 0; // Ціна в євро
        public bool isNew { get; set; } // Новий?
        public string MileageIconPath { get; set; } = @"\Images\MileageIcon.png";
        public int Mileage { get; set; } // Пробіг

        public string? VehicleIconPath { get; set; } // Шлях до іконки

        public string? FuelType { get; set; }

        public string? Color { get; set; } // Колір
        public string? Description { get; set; } // Опис

        public string? User { get; set; }
    }
}
