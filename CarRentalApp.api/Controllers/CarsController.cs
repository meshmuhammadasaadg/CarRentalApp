using CarRentalApp.api.Domain.IServices;
using CarRentalApp.api.Infrastructure.DTOs.Cars;
using CarRentalApp.api.Infrastructure.ViewModels.Cars;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController(ICarService carService) : ControllerBase
{
    private readonly ICarService _carService = carService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var cars = await _carService.GetAllCars();

        return Ok(cars);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<CarViewModel>> GetAll([FromRoute] int id)
    {
        var car = await _carService.GetByIdAsync(id);

        if (car is null)
            return NotFound($"We are not found cars with this ID: {id}");

        var result = new CarViewModel
        {
            Id = id,
            Model = car!.Model,
            PlateNumber = car.PlateNumber
        };

        return Ok(result);
    }
    [HttpPost("")]
    public async Task<bool> Add([FromBody] CarCreateRequest request)
    {
        var car = _carService.AddCarAsync(new CarCreateRequest
        {
            Model = "s",
            PlateNumber = "s",
            Year = 2020
        });

        return true;
    }


}
