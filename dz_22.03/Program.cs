using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_22._03
{
    class Car
    {
        public string body { get; set; }
        public int power { get; set; }
        public int wheel { get; set; }
        public string trans { get; set; }
        public Car() { }
        public Car(string b, int p, int w, string t)
        {
            body = b;
            power = p;
            wheel = w;
            trans = t;
        }
        public override string ToString()
        {
            return $"Body: {body}\nPower: {power}\nWheel: {wheel}\nTransmission: {trans}";
        }
    }

    interface CarBuilder
    {
        void BodyBuild();
        void PowerBuild();
        void WheelBuild();
        void TransBuild();
        Car GetCar();
    }

    class CarBuilder1 : CarBuilder
    {
        private Car car;
        public void BodyBuild()
        {
            if (car == null)
                car = new Car();
            car.body = "Ламба";
        }
        public void PowerBuild()
        {
            if (car == null)
                car = new Car();
            car.power = 98;
        }
        public void WheelBuild()
        {
            if (car == null)
                car = new Car();
            car.wheel = 13;
        }
        public void TransBuild()
        {
            if (car == null)
                car = new Car();
            car.trans = "5 Manual";
        }
        public Car GetCar()
        {
            if (car == null)
                return null;
            return car;
        }
    }
    class CarBuilder2 : CarBuilder
    {
        private Car car;
        public void BodyBuild()
        {
            if (car == null)
                car = new Car();
            car.body = "Беха";
        }
        public void PowerBuild()
        {
            if (car == null)
                car = new Car();
            car.power = 160;
        }
        public void WheelBuild()
        {
            if (car == null)
                car = new Car();
            car.wheel = 14;
        }
        public void TransBuild()
        {
            if (car == null)
                car = new Car();
            car.trans = "4 Auto";
        }
        public Car GetCar()
        {
            if (car == null)
                return null;
            return car;
        }
    }
    class CarBuilder3 : CarBuilder
    {
        private Car car;
        public void BodyBuild()
        {
            if (car == null)
                car = new Car();
            car.body = "Универсал";
        }
        public void PowerBuild()
        {
            if (car == null)
                car = new Car();
            car.power = 120;
        }
        public void WheelBuild()
        {
            if (car == null)
                car = new Car();
            car.wheel = 16;
        }
        public void TransBuild()
        {
            if (car == null)
                car = new Car();
            car.trans = "4 Manual";
        }
        public Car GetCar()
        {
            if (car == null)
                return null;
            return car;
        }
    }
    class CarBuilder4 : CarBuilder
    {
        private Car car;
        public void BodyBuild()
        {
            if (car == null)
                car = new Car();
            car.body = "Плюха";
        }
        public void PowerBuild()
        {
            if (car == null)
                car = new Car();
            car.power = 66;
        }
        public void WheelBuild()
        {
            if (car == null)
                car = new Car();
            car.wheel = 13;
        }
        public void TransBuild()
        {
            if (car == null)
                car = new Car();
            car.trans = "4 auto";
        }
        public Car GetCar()
        {
            if (car == null)
                return null;
            return car;
        }
    }

    class Shop
    {
        private CarBuilder car;
        public void Car()
        {
            Console.WriteLine("Enter num of CarBuilder\n");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                car = new CarBuilder1();
            }
            if (choose == 2)

            {
                car = new CarBuilder2();
            }
            if (choose == 3)
            {
                car = new CarBuilder3();
            }
            if (choose == 4)
            {
                car = new CarBuilder4();
            }
            else
            {
                car = null;
            }
        }
        public void BuildCar()
        {
            if (car == null)
                car = new CarBuilder1();
            car.BodyBuild();
            car.TransBuild();
            car.PowerBuild();
            car.WheelBuild();
        }
        public CarBuilder GetCar()
        {
            return car;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            shop.Car();
            shop.BuildCar();
            var build = shop.GetCar();
            Car car = build.GetCar();
            Console.WriteLine(car);
        }
    }
}
