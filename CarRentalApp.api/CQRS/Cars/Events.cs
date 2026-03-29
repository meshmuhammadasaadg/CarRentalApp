using MediatR;

namespace CarRentalApp.api.CQRS.Cars;

public record CreateCarEvent(string PlateNumber) : INotification;
public record DeletedCarEvent(int Id) : INotification;  
