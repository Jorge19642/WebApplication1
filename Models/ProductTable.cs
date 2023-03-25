using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ProductTable
{
    public int IdProduct { get; set; }

    public string Nombre { get; set; } = null!;

    public double? Precio { get; set; }

    public int? Cantidad { get; set; }

    public int? CodigoDeBarras { get; set; }

    public int? Fkbrand { get; set; }

    public int? Kfkind { get; set; }

    public virtual BrandTable? FkbrandNavigation { get; set; }

    public virtual KindTable? KfkindNavigation { get; set; }
}
