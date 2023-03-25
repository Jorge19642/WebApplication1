using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BrandTable
{
    public int IdBrand { get; set; }

    public string Brand { get; set; } = null!;

    public virtual ICollection<ProductTable> ProductTables { get; } = new List<ProductTable>();
}
