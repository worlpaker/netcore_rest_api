using Rest_api.Models;
//Interface

namespace Rest_api.Data
{
    public interface IVehiclesrepository
    {
        List<Vehicles> Getallvehicles();


        List<Cars> Get_Car_Bycolour(Colours? colour);
        List<Boats> Get_Boats_Bycolour(Colours? colour);
        List<Buses> Get_Buses_Bycolour(Colours? colour);

        List<Cars> Post_Car_Byid(int id, bool headlights);

        List<Cars> Delete_Car_Byid(int id);




    }
}