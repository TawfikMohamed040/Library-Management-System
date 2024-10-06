﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models;

public partial class Library_Management_SystemContext : IdentityDbContext<AppUser> 
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

    public virtual DbSet<Penalty> Penalties { get; set; }

    public virtual DbSet<Return> Returns { get; set; }

    public virtual DbSet<AppUser> AppUsers { get; set; }
    //public virtual DbSet<AspNetUs>

    //public virtual DbSet<Asp>

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-0GO3MVT;Initial Catalog=Library_Management_System;Integrated Security=True;Encrypt=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure IdentityUserLogin primary key
        modelBuilder.Entity<IdentityUserLogin<string>>()
               .HasKey(login => new { login.LoginProvider, login.ProviderKey });

        // Configure IdentityUserRole primary key
        modelBuilder.Entity<IdentityUserRole<string>>()
               .HasKey(role => new { role.UserId, role.RoleId });

        // Configure IdentityUserToken primary key
        modelBuilder.Entity<IdentityUserToken<string>>()
               .HasKey(token => new { token.UserId, token.LoginProvider, token.Name });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Books__3DE0C227D485C8B8");
        });

        modelBuilder.Entity<Checkout>(entity =>
        {
            entity.HasKey(e => e.CheckOutId).HasName("PK__Checkout__50A4641B9EF96F05");

            entity.HasOne(d => d.Book).WithMany(p => p.Checkouts).HasConstraintName("FK__Checkouts__BookI__3E52440B");
        });

        modelBuilder.Entity<Penalty>(entity =>
        {
            entity.HasKey(e => e.PenaltyId).HasName("PK__Penaltie__567E06E7A02D34C4");

            entity.HasOne(d => d.CheckOut).WithMany(p => p.Penalties).HasConstraintName("FK__Penalties__Check__440B1D61");
        });

        modelBuilder.Entity<Return>(entity =>
        {
            entity.HasKey(e => e.ReturnId).HasName("PK__Returns__F445E9887FF9A84B");

            entity.HasOne(d => d.CheckOut).WithMany(p => p.Returns).HasConstraintName("FK__Returns__CheckOu__412EB0B6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}