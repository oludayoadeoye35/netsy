﻿using Microsoft.OData.Edm; // To use IEdmModel.
using Microsoft.OData.ModelBuilder; // ODataConventionModelBuilder
using Northwind.EntityModels; // To use Northwind entity models.

partial class Program
{
  static IEdmModel GetEdmModelForCatalog()
  {
    ODataConventionModelBuilder builder = new();
    builder.EntitySet<Category>("Categories");
    builder.EntitySet<Product>("Products");
    builder.EntitySet<Supplier>("Suppliers");
    return builder.GetEdmModel();
  }

  static IEdmModel GetEdmModelForOrderSystem()
  {
    ODataConventionModelBuilder builder = new();
    builder.EntitySet<Customer>("Customers");
    builder.EntitySet<Order>("Orders");
    builder.EntitySet<Employee>("Employees");
    builder.EntitySet<Product>("Products");
    builder.EntitySet<Shipper>("Shippers");
    return builder.GetEdmModel();
  }
}
