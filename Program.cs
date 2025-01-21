using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{

    class Car
    {
        // Свойства класса Car
        public string Brand { get; set; }
        public string Number { get; set; }
        public int Mileage { get; set; }
        // Метод для расчета среднегодового пробега
        public double CalculateAverageAnnualMileage(int age)
        {
            if (age <= 0)
{
                throw new ArgumentException("Возраст автомобиля >0.");
            }
            return (double)Mileage / age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Car
            Car myCar = new Car();
            // Задание свойств объекта
            myCar.Brand = "Jeep";
            myCar.Number = "C123TC" ;
            myCar.Mileage = 12300;
            // Вывод значений свойств объекта на экран
            Console.WriteLine("Марка: { myCar.Brand}");
            Console.WriteLine("Номер: { myCar.Number}");
            Console.WriteLine("Пробег: { myCar.Mileage} км ");
            // Расчет среднегодового пробега
            int age = 2; // Возраст автомобиля
            double averageAnnualMileage = myCar.CalculateAverageAnnualMileage(age);
            Console.WriteLine("Среднегодовой пробег: { averageAnnualMileage} км / год ");
        }
    }
}
