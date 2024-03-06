using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductType { get; set; }

    public int? Price { get; set; }
}
