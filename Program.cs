using Microsoft.AspNetCore.Mvc;
using Project1.DbContextes;
using Project1.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDbContext<LibraryDB>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("api/v1/Employees/create", ([FromBody] Employee employee, [FromServices] LibraryDB db) =>
{
    db.Employees.Add(employee);
    db.SaveChanges();
    return new { Message = "Employee Created" };
});
app.MapGet("api/v1/Employees/list", ([FromServices] LibraryDB db) =>
{
    return db.Employees.ToList();
});
app.MapPut("api/v1/Employees/update/{id}", ([FromRoute] int id, [FromBody] Employee employee, [FromServices] LibraryDB db) =>
{
    var e = db.Employees.Find(id);
    if (e == null)
    {
        return new { Message = "Not found!" };
    }
    e.PhoneNumber = employee.PhoneNumber;
    db.SaveChanges();
    return new { Message = "Employee updated!" };
});
app.MapDelete("api/v1/Employees/remove/{id}", ([FromRoute] int id, [FromServices] LibraryDB db) =>
{
    var employee = db.Employees.Find(id);
    if (employee == null)
    {
        return new { Message = "Not found!" };
    }
    db.Employees.Remove(employee);
    db.SaveChanges();
    return new { Message = "Employee Removed!" };
});
app.MapPost("api/v1/Drivers/create", ([FromBody] Driver driver, [FromServices] LibraryDB db) =>
{
    db.Drivers.Add(driver);
    db.SaveChanges();
    return new { Message = "Driver Created" };
});
app.MapGet("api/v1/Drivers/list", ([FromServices] LibraryDB db) =>
{
    return db.Drivers.ToList();
});
app.MapPut("api/v1/Drivers/update/{id}", ([FromRoute] int id, [FromBody] Driver driver, [FromServices] LibraryDB db) =>
{
    var d = db.Drivers.Find(id);
    if (d == null)
    {
        return new { Message = "Not found!" };
    }
    d.PhoneNumber = driver.PhoneNumber;
    db.SaveChanges();
    return new { Message = "Driver updated!" };
});
app.MapDelete("api/v1/Drivers/remove/{id}", ([FromRoute] int id, [FromServices] LibraryDB db) =>
{
    var driver = db.Drivers.Find(id);
    if (driver == null)
    {
        return new { Message = "Not found!" };
    }
    db.Drivers.Remove(driver);
    db.SaveChanges();
    return new { Message = "Driver Removed!" };
});
app.MapPost("api/v1/Cooperatives/create", ([FromBody] Cooperative cooperative, [FromServices] LibraryDB db) =>
{
    db.Cooperatives.Add(cooperative);
    db.SaveChanges();
    return new { Message = "Cooperative Created" };
});
app.MapGet("api/v1/Cooperatives/list", ([FromServices] LibraryDB db) =>
{
    return db.Cooperatives.ToList();
});
app.MapPut("api/v1/Cooperatives/update/{id}", ([FromRoute] int id, [FromBody] Cooperative cooperative, [FromServices] LibraryDB db) =>
{
    var c = db.Cooperatives.Find(id);
    if (c == null)
    {
        return new { Message = "Not found!" };
    }
    c.PhoneNumber = cooperative.PhoneNumber;
    db.SaveChanges();
    return new { Message = "Cooperative updated!" };
});
app.MapDelete("api/v1/Cooperatives/remove/{id}", ([FromRoute] int id, [FromServices] LibraryDB db) =>
{
    var cooperative = db.Cooperatives.Find(id);
    if (cooperative == null)
    {
        return new { Message = "Not found!" };
    }
    db.Cooperatives.Remove(cooperative);
    db.SaveChanges();
    return new { Message = "Cooperative Removed!" };
});
app.MapPost("api/v1/Passengers/create", ([FromBody] Passenger passenger, [FromServices] LibraryDB db) =>
{
    db.Passengers.Add(passenger);
    db.SaveChanges();
    return new { Message = "Passenger Created" };
});
app.MapGet("api/v1/Passengers/list", ([FromServices] LibraryDB db) =>
{
    return db.Passengers.ToList();
});
app.MapPut("api/v1/Passenges/update/{id}", ([FromRoute] int id, [FromBody] Passenger passenger, [FromServices] LibraryDB db) =>
{
    var p = db.Passengers.Find(id);
    if (p == null)
    {
        return new { Message = "Not found!" };
    }
    p.Firstname = passenger.Firstname;
    p.Lastname = passenger.Lastname;
    p.Gender = passenger.Gender;
    p.Email = passenger.Email;
    p.PhoneNumber = passenger.PhoneNumber;
    db.SaveChanges();
    return new { Message = "Passenger updated!" };
});
app.MapDelete("api/v1/Passengers/remove/{id}", ([FromRoute] int id, [FromServices] LibraryDB db) =>
{
    var passenger = db.Passengers.Find(id);
    if (passenger == null)
    {
        return new { Message = "Not found!" };
    }
    db.Passengers.Remove(passenger);
    db.SaveChanges();
    return new { Message = "Passenger Removed!" };
});

app.Run();