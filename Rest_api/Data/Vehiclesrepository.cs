using Rest_api.Models;
//Fake Data & Handle request
namespace Rest_api.Data
{  //Fake Data
    public class Vehiclesrepository : IVehiclesrepository
    {

        //Sample for Buses & Cars & Boats - Can be vehicle.
        public static readonly List<Vehicles> vehicles = new()

        {
            new Vehicles() { Cars =  new Cars  { Id = 1, Colours = Colours.Red, Wheels = 4,  Headlights = true }  },

            new Vehicles() { Buses = new Buses { Id = 1, Colours = Colours.Black } },

            new Vehicles() { Boats = new Boats { Id = 1, Colours = Colours.Blue } }

        };

        //This is just sample to create only cars.
        public static readonly List<Cars> cars = new ()
        {
            new Cars () { Id = 1, Colours = Colours.Red, Wheels = 4, Headlights = false},
            new Cars () { Id = 2, Colours = Colours.Blue, Wheels = 4, Headlights = true},
            new Cars () { Id = 3, Colours = Colours.Black, Wheels = 4, Headlights = false},
            new Cars () { Id = 4, Colours = Colours.White, Wheels = 4, Headlights = true},

        };
        //This is just sample to create only Boats.
        public static readonly List<Boats> boats = new ()
        {
            new Boats () { Id = 1, Colours = Colours.Red},
            new Boats () { Id = 2, Colours = Colours.Blue},
            new Boats () { Id = 3, Colours = Colours.Black},
            new Boats () { Id = 4, Colours = Colours.White},

        };
        //This is just sample to create only Buses.
        public static readonly List<Buses> buses = new()
        {
            new Buses () { Id = 1, Colours = Colours.Red},
            new Buses () { Id = 2, Colours = Colours.Blue},
            new Buses () { Id = 3, Colours = Colours.Black},
            new Buses () { Id = 4, Colours = Colours.White},
            new Buses () { Id = 5, Colours = Colours.White},


        };

         //Handle requests

         //GET Methods
        public List<Vehicles> Getallvehicles()
        {
            return vehicles;
        }

        public List <Cars> Get_Car_Bycolour(Colours? colour)
        {
            return cars.FindAll(x => x.Colours == colour);
        }

        public List<Boats> Get_Boats_Bycolour(Colours? colour)
        {
            return boats.FindAll(x => x.Colours == colour);
        }
       

        public List<Buses> Get_Buses_Bycolour(Colours? colour)
        {
            return buses.FindAll(x => x.Colours == colour);
        }

        //POST Headlight on/off

        public List<Cars> Post_Car_Byid(int id, bool headlights)
        {
            var car = cars.Find(x => x.Id == id);
            if (car != null)
                car.Headlights = headlights;
            
            return cars.FindAll(x => x.Id == id); //show the change
        }

        //DELETE Cars by Id
        public List<Cars> Delete_Car_Byid(int id)
        {
            var car = cars.RemoveAll(x => x.Id == id);
  
            return cars; //show full list of cars after delete

        }


    }
}
