﻿namespace eProdaja.Model.Requests
{
    public class KorisniciUpdateRequest
    {
        public string? Ime { get; set; }

        public string? Prezime { get; set; }

        public string? Email { get; set; }

        public string? Telefon { get; set; }

        public bool Status { get; set; }
    }
}
