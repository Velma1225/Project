using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HabanMVC.Models;

public partial class FakeHaBanContext : DbContext
{
    public FakeHaBanContext()
    {
    }

    public FakeHaBanContext(DbContextOptions<FakeHaBanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<JobList> JobLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Database=FakeHaBan;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JobList>(entity =>
        {
            entity.ToTable("JobList");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.JobDescription).IsRequired();
            entity.Property(e => e.JobName).IsRequired();
            entity.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
