namespace _3_Task2
{
    public class Vehicle
    {

        protected int XLocation { get; private set; }
        protected int YLocation { get; private set; }
        protected int Price { get; private set; }
        protected int Speed { get; private set; }
        protected int Year { get; private set; }
        //public virtual int NumberOfPessengers { get; private set; }
        //public virtual int Port { get; private set; }
        //public virtual int Height { get; private set; }


        public Vehicle(int Xlocation, int Ylocation, int price, int speed, int year)
        {
            XLocation = Xlocation;
            YLocation = Ylocation;
            Price = price;
            Speed = speed;
            Year = year;
        }

        public Vehicle(int price, int speed, int year)
            : this(0, 0, price, speed, year)
        {

        }

  

    }

    public class Plane : Vehicle
    {
        public int Height { get; set; }
        public int NumberOfPessengers { get; set; }

        public Plane(int Xlocation, int Ylocation, int price, int speed, int year)
            : base(Xlocation, Ylocation, price, speed, year)
        {

        }

        public Plane(int price, int speed, int year)
            : base(price, speed, year)
        {

        }

    }

    public class Car : Vehicle
    {
        public Car(int Xlocation, int Ylocation, int price, int speed, int year)
            : base(Xlocation, Ylocation, price, speed, year)
        {

        }

        public Car(int price, int speed, int year)
            : base(price, speed, year)
        {

        }
    }

    public class Ship : Vehicle
    {
        public int Port { get; set; }
        public int NumberOfPessengers { get; set; }

        public Ship(int Xlocation, int Ylocation, int price, int speed, int year)
            : base(Xlocation, Ylocation, price, speed, year)
        {

        }

        public Ship(int price, int speed, int year)
            : base(price, speed, year)
        {

        }
    }
}
