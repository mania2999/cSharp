using System;

namespace comparing
{
    class Program
    {   
        static void Main(string[] args) 
        {
            var car1 = new Car(200);
            var car2 = new Car(200);

            bool test1 = car1 == car2;                         // wynik bedzie false bo porownujemy na jakich miejscach w pamieci to zostalo zapisane (zostaly zapiasane na dwoch roznych misejscach w pamieci)
            Console.WriteLine($"are this object equal : {test1}");
            bool test2 = car1.Equals(car2);                     // wynik bedzie true bo porownujemy juz  wartosci Power a nie obiekty
            Console.WriteLine($"are this object equal by test 2: {test2}");
        }
    }
    class Car
    {
        public override bool Equals(object? obj)
        {   
            if (obj == null) return false;
            if( this.GetType() != obj.GetType() ) return false;

            Car ObjasCar = (Car)obj;
            if (this.Power == ObjasCar.Power)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Power { get; set; }
        public Car(int power)
        {
            this.Power = power;
        }
    }
}