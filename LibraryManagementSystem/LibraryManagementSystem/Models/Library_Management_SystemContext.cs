﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models;

public partial class Library_Management_SystemContext : DbContext
{
    public Library_Management_SystemContext()
    {
    }

    public Library_Management_SystemContext(DbContextOptions<Library_Management_SystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Checkout> Checkouts { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Penalty> Penalties { get; set; }

    public virtual DbSet<Return> Returns { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Books__3DE0C227C78325F6");
        });

        modelBuilder.Entity<Checkout>(entity =>
        {
            entity.HasKey(e => e.CheckOutId).HasName("PK__Checkout__50A4641BA0200D1A");

            entity.HasOne(d => d.Book).WithMany(p => p.Checkouts).HasConstraintName("FK__Checkouts__BookI__3C69FB99");

            entity.HasOne(d => d.Member).WithMany(p => p.Checkouts).HasConstraintName("FK__Checkouts__Membe__3B75D760");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__Members__0CF04B383BE37A79");
        });

        modelBuilder.Entity<Penalty>(entity =>
        {
            entity.HasKey(e => e.PenaltyId).HasName("PK__Penaltie__567E06E7E0E15E89");

            entity.HasOne(d => d.CheckOut).WithMany(p => p.Penalties).HasConstraintName("FK__Penalties__Check__534D60F1");
        });

        modelBuilder.Entity<Return>(entity =>
        {
            entity.HasKey(e => e.ReturnId).HasName("PK__Returns__F445E988AC1FACE9");

            entity.HasOne(d => d.CheckOut).WithMany(p => p.Returns).HasConstraintName("FK__Returns__CheckOu__3F466844");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}