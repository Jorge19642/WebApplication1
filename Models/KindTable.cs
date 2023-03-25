using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class KindTable
{
    public int Idkind { get; set; }

    public string Kind { get; set; } = null!;

    public virtual ICollection<ProductTable> ProductTables { get; } = new List<ProductTable>();
}
