using Project1.DbContextes;
using Project1.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("api/v1/Employees/create", (Employee employee) =>
{
    using var db = new LibraryDB();
    db.Employees.Add(employee);
    db.SaveChanges();
    return "Employee Created";
});
app.MapGet("api/v1/Employees/list", () =>
{
    using var db = new LibraryDB();
    return db.Employees.ToList();
});
app.MapPut("api/v1/Employees/update/{id}", (int id, Employee employee) =>
{
    using var db = new LibraryDB();
    var e = db.Employees.Find(id);
    if (e == null)
    {
        return "Not found!";
    }
    e.PhoneNumber = employee.PhoneNumber;
    db.SaveChanges();
    return "Employee updated!";
});
app.MapDelete("api/v1/Employees/remove/{id}", (int id) =>
{
    using var db = new LibraryDB();
    var employee = db.Employees.Find(id);
    if (employee == null)
    {
        return "Not found!";
    }
    db.Employees.Remove(employee);
    db.SaveChanges();
    return "Employee Removed!";
});
app.MapPost("api/v1/Drivers/create", (Driver driver) =>
{
    using var db = new LibraryDB();
    db.Drivers.Add(driver);
    db.SaveChanges();
    return "Driver Created";
});
app.MapGet("api/v1/Drivers/list", () =>
{
    using var db = new LibraryDB();
    return db.Drivers.ToList();
});
app.MapPut("api/v1/Drivers/update/{id}", (int id, Driver driver) =>
{
    using var db = new LibraryDB();
    var d = db.Drivers.Find(id);
    if (d == null)
    {
        return "Not found!";
    }
    d.PhoneNumber = driver.PhoneNumber;
    db.SaveChanges();
    return "Driver updated!";
});
app.MapDelete("api/v1/Drivers/remove/{id}", (int id) =>
{
    using var db = new LibraryDB();
    var driver = db.Drivers.Find(id);
    if (driver == null)
    {
        return "Not found!";
    }
    db.Drivers.Remove(driver);
    db.SaveChanges();
    return "Driver Removed!";
});
app.MapPost("api/v1/Cooperatives/create", (Cooperative cooperative) =>
{
    using var db = new LibraryDB();
    db.Cooperatives.Add(cooperative);
    db.SaveChanges();
    return "Cooperative Created";
});
app.MapGet("api/v1/Cooperatives/list", () =>
{
    using var db = new LibraryDB();
    return db.Cooperatives.ToList();
});
app.MapPut("api/v1/Cooperatives/update/{id}", (int id, Cooperative cooperative) =>
{
    using var db = new LibraryDB();
    var c = db.Cooperatives.Find(id);
    if (c == null)
    {
        return "Not found!";
    }
    c.PhoneNumber = cooperative.PhoneNumber;
    db.SaveChanges();
    return "Cooperative updated!";
});
app.MapDelete("api/v1/Cooperatives/remove/{id}", (int id) =>
{
    using var db = new LibraryDB();
    var cooperative = db.Cooperatives.Find(id);
    if (cooperative == null)
    {
        return "Not found!";
    }
    db.Cooperatives.Remove(cooperative);
    db.SaveChanges();
    return "Cooperative Removed!";
});
app.MapPost("api/v1/Passengers/create", (Passenger passenger) =>
{
    using var db = new LibraryDB();
    db.Passengers.Add(passenger);
    db.SaveChanges();
    return "Passenger Created";
});
app.MapGet("api/v1/Passengers/list", () =>
{
    using var db = new LibraryDB();
    return db.Passengers.ToList();
});
app.MapPut("api/v1/Passenges/update/{id}", (int id, Passenger passenger) =>
{
    using var db = new LibraryDB();
    var p = db.Passengers.Find(id);
    if (p == null)
    {
        return "Not found!";
    }
    p.Firstname = passenger.Firstname;
    p.Lastname = passenger.Lastname;
    p.Gender = passenger.Gender;
    p.Email = passenger.Email;
    p.PhoneNumber = passenger.PhoneNumber;
    db.SaveChanges();
    return "Passenger updated!";
});
app.MapDelete("api/v1/Passengers/remove/{id}", (int id) =>
{
    using var db = new LibraryDB();
    var passenger = db.Passengers.Find(id);
    if (passenger == null)
    {
        return "Not found!";
    }
    db.Passengers.Remove(passenger);
    db.SaveChanges();
    return "Passenger Removed!";
});

app.Run();