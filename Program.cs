namespace Builder
{
    public interface Builder
    {
        public void reset();
        public void setSeats(int number);
        public void setEngine(string engine);
        public void setTripComputer();
        public void setGPS();
    }
    public class Car
    {

    }
    public class Manuel
    {

    }

    public class CarBuilder : Builder
    {
        private Car? car;
        public void reset()
        {
            this.car=new Car();
        }

        public void setEngine(string engine)
        {
           //do work
        }

        public void setGPS()
        {
            //do work
        }

        public void setSeats(int number)
        {
            //do work
        }

        public void setTripComputer()
        {
            //do work
        }
        public Car getResult() => this.car;
    }

    public class CarManuelBuilder : Builder
    {
        private Manuel? manuel;
        public void reset()
        {
            this.manuel=new Manuel();
        }

        public void setEngine(string engine)
        {
            throw new NotImplementedException();
        }

        public void setGPS()
        {
            throw new NotImplementedException();
        }

        public void setSeats(int number)
        {
            throw new NotImplementedException();
        }

        public void setTripComputer()
        {
            throw new NotImplementedException();
        }
        public Manuel getResult() => this.manuel;
    }

    public class Director
    {
        public Builder? builder;

        public void makeSUV(Builder builder)
        {
            this.builder = builder;
        }
        public void makeSportsCar(Builder builder)
        {
            builder.reset();
            builder.setSeats(2);
            builder.setEngine("SportEngine");
            builder.setTripComputer();
            builder.setGPS();
        }

    }

    public class Client
    {
        Director director;
        public Client()
        {
            director = new Director();
            CarBuilder carBuilder = new CarBuilder();
            director.makeSportsCar(carBuilder);
            Car car=carBuilder.getResult();
        }
    }
}