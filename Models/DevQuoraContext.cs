using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace quora.Models;

public partial class DevQuoraContext : DbContext
{
    private readonly string connectionstring;
    public DevQuoraContext(string connection) => connectionstring = connection;

    public DevQuoraContext(DbContextOptions<DevQuoraContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Answer> Answers { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectionstring);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Answer__3214EC07368F23B1");

            entity.ToTable("Answer");

            entity.Property(e => e.CreatedBy).HasMaxLength(1000);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ModifiedBy).HasMaxLength(1000);
            entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Question).WithMany(p => p.Answers)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__Answer__Question__66603565");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Question__3214EC0734EFE06B");

            entity.ToTable("Question");

            entity.Property(e => e.CreatedBy).HasMaxLength(1000);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ModifiedBy).HasMaxLength(1000);
            entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Topic).WithMany(p => p.Questions)
                .HasForeignKey(d => d.TopicId)
                .HasConstraintName("FK__Question__TopicI__6383C8BA");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => e.TopicId).HasName("PK__Topic__022E0F5D1FFB8B95");

            entity.ToTable("Topic");

            entity.Property(e => e.TopicCreatedBy).HasMaxLength(1000);
            entity.Property(e => e.TopicCreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.TopicDescription).HasMaxLength(1000);
            entity.Property(e => e.TopicModifiedBy).HasMaxLength(1000);
            entity.Property(e => e.TopicModifiedDateTime).HasColumnType("datetime");
            entity.Property(e => e.TopicName).HasMaxLength(1000);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
