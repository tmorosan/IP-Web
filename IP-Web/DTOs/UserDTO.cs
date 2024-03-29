﻿using System.ComponentModel.DataAnnotations;

namespace IP_Web.DTOs;

public class UserDTO
{
    public string Nume { get; set; } = string.Empty;
    public string Prenume { get; set; } = string.Empty;
    public string Cnp { get; set; } = string.Empty;
    public int Varsta { get; set; }
    public string Telefon { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Profesie { get; set; } = string.Empty;
    public string LocDeMunca { get; set; } = string.Empty;
    public string Oras { get; set; } = string.Empty;
    public string Strada { get; set; } = string.Empty;
    public int NrStrada { get; set; }
    public int CodPostal { get; set; }
    public List<string> Alergii { get; set; } = new List<string>();
    public List<string> IstoricMedical { get; set; } = new List<string>();
    public List<string> ConsulatiiCardio { get; set; } = new List<string>();

    public string? IdAdmin { get; set; }


}
