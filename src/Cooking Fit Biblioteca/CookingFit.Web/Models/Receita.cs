﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CookingFit.Web.Models;

public partial class Receita
{
    public string Nome { get; set; }

    public int IdReceita { get; set; }

    public string Descriçao { get; set; }

    public bool Ativo { get; set; }

    public virtual ICollection<Cardapio> Cardapios { get; set; } = new List<Cardapio>();
}