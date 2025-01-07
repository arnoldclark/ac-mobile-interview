using AcGarageAPI.Adapters;
using AcGarageAPI.Data;
using AcGarageAPI.DtoModels;
using MediatR;

namespace AcGarageAPI.CQS.Commands;

public class CreateCar(CarDto carDto) : IRequest
{
    public CarDto CarDto { get; set; } = carDto;
}

public class CreateCarHandler(GarageDbContext context) : IRequestHandler<CreateCar>
{
    public async Task Handle(CreateCar request, CancellationToken cancellationToken)
    {
        var car = request.CarDto.ToCar();

        await context.Cars.AddAsync(car, cancellationToken);

        await context.SaveChangesAsync(cancellationToken);
    }
}