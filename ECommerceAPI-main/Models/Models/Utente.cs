﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models
{
    [Table("Utente")]
    public partial class Utente
    {
        public Utente()
        {
            Ordines = new HashSet<Ordine>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [StringLength(50)]
        public string Cognome { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(16)]
        public string Password { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public int IDRuolo { get; set; }
        //aggiunto
        [System.Text.Json.Serialization.JsonIgnore]
        //bisognava cancellare le 3 sotto prima di reare model "Registrazione"
        [ForeignKey("IDRuolo")]
        [InverseProperty("Utentes")]
        public virtual Ruolo IDRuoloNavigation { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        [InverseProperty("IDUtenteNavigation")]
        public virtual ICollection<Ordine> Ordines { get; set; }
    }
}