using AcGarageAPI.DtoModels;
using AcGarageAPI.Entities;

namespace AcGarageAPI.Adapters;

public static class MapCarDtoToCarAdapter
{
    public static Car ToCar(this CarDto carDto)
    {
        return new Car
        {
            Make = carDto.Make,
            Model = carDto.Model,
            Registration = carDto.Registration,
            Price = carDto.Price!.Value
        };
    }
}