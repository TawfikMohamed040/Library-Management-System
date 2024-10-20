﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models;

public partial class Return
{
    [Key]
    [Column("ReturnID")]
    public int ReturnId { get; set; }

    [Column("CheckOutID")]
    public int? CheckOutId { get; set; }

    [Column("Return_Date")]
    public DateOnly ReturnDate { get; set; }

    [ForeignKey("CheckOutId")]
    [InverseProperty("Returns")]
    public virtual Checkout CheckOut { get; set; }
}