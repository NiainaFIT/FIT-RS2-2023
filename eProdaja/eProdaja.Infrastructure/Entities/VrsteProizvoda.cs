using System;
using System.Collections.Generic;

namespace eProdaja.Infrastructure.Entities;

public partial class VrsteProizvoda
{
    public int VrstaId { get; set; }

    public string Naziv { get; set; } = null!;

    public virtual ICollection<Proizvodi> Proizvodi { get; set; } = new List<Proizvodi>();
}
