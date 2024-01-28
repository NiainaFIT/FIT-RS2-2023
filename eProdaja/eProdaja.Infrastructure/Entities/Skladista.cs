﻿using System;
using System.Collections.Generic;

namespace eProdaja.Infrastructure.Entities;

public partial class Skladista
{
    public int SkladisteId { get; set; }

    public string Naziv { get; set; } = null!;

    public string? Adresa { get; set; }

    public string? Opis { get; set; }

    public virtual ICollection<Izlazi> Izlazi { get; set; } = new List<Izlazi>();

    public virtual ICollection<Ulazi> Ulazi { get; set; } = new List<Ulazi>();
}
