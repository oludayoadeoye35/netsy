﻿using Microsoft.AspNetCore.Mvc; // To use IActionResult.
using Microsoft.AspNetCore.OData.Query; // To use [EnableQuery].
using Microsoft.AspNetCore.OData.Routing.Controllers; // To use ODataController.
using Northwind.EntityModels; // To use NorthwindContext.

namespace Northwind.OData.Services.Controllers;

public class EmployeesController : ODataController
{
  protected readonly NorthwindContext _db;

  public EmployeesController(NorthwindContext db)
  {
    _db = db;
  }

  [EnableQuery]
  public IActionResult Get()
  {
    return Ok(_db.Employees);
  }

  [EnableQuery]
  public IActionResult Get(int key)
  {
    return Ok(_db.Employees.Where(
      employee => employee.EmployeeId == key));
  }
}
