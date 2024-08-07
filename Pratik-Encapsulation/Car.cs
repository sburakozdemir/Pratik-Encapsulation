using System;

namespace Pratik_Encapsulation
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private string _color;
        private int _doorCount;

        public Car(string brand, string model, string color, int doorCount)
        {
            _brand = brand;
            _model = model;
            _color = color;
            DoorCount = doorCount; // Burada DoorCount özelliğini kullanıyoruz
        }

        public string Brand { get { return _brand; } }
        public string Model { get { return _model; } }
        public string Color { get { return _color; } }

        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                if (value == 2 || value == 4)
                    _doorCount = value;
                else
                {
                    Console.WriteLine("Hatalı giriş: Kapı sayısı 2 veya 4 olmalıdır.");
                    _doorCount = -1; // Hatalı giriş durumunda -1 atıyoruz
                }
            }
        }

        public void InfoCar()
        {
            Console.WriteLine($"Markası {_brand}, modeli {_model}, rengi {_color}, kapı sayısı {_doorCount.ToString()} olan bir araba oluşturdunuz");
        }
    }
}