﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models;

public partial class Checkout
{
    [Key]
    [Column("CheckOutID")]
    public int CheckOutId { get; set; }

    [Column("MemberID")]
    public int? MemberId { get; set; }

    [Column("BookID")]
    public int? BookId { get; set; }

    [Column("CheckOut_Date")]
    public DateOnly CheckOutDate { get; set; }

    [Column("Due_Date")]
    public DateOnly DueDate { get; set; }

    public bool Returned { get; set; }

    [ForeignKey("BookId")]
    [InverseProperty("Checkouts")]
    public virtual Book Book { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("Checkouts")]
    public virtual Member Member { get; set; }

    [InverseProperty("CheckOut")]
    public virtual ICollection<Penalty> Penalties { get; set; } = new List<Penalty>();

    [InverseProperty("CheckOut")]
    public virtual ICollection<Return> Returns { get; set; } = new List<Return>();
}