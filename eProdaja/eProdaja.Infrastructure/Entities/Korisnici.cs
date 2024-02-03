using System;
using System.Collections.Generic;

namespace eProdaja.Infrastructure.Entities;

public partial class Korisnici
{
    public int KorisnikId { get; set; }

    public string Ime { get; set; } = null!;

    public string Prezime { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefon { get; set; }

    public string KorisnickoIme { get; set; } = null!;

    public string LozinkaHash { get; set; } = null!;

    public string LozinkaSalt { get; set; } = null!;

    public bool Status { get; set; }

    public virtual ICollection<Izlazi> Izlazi { get; set; } = new List<Izlazi>();

    public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; } = new List<KorisniciUloge>();

    public virtual ICollection<Ulazi> Ulazi { get; set; } = new List<Ulazi>();
}
