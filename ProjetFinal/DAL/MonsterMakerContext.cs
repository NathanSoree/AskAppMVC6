using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class MonsterMakerContext : DbContext
    {
        public MonsterMakerContext()
        {
        }
        public MonsterMakerContext(DbContextOptions<MonsterMakerContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder is null)
                throw new ArgumentNullException(nameof(optionsBuilder));

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MonsterMaker;Trusted_Connection=True;MultipleActiveResultSets=true");
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<MonsterSpeedEF>().HasKey(s => new
            {
                s.MonsterId,
                s.IdEnum
            });

            modelBuilder.Entity<MonsterSpeedEF>()
                .HasOne<MonsterEF>(mEF => mEF.Monster)
                .WithMany(mEF => mEF.Speeds)
                .HasForeignKey(meEF => meEF.MonsterId);

            modelBuilder.Entity<MonsterStatsEF>().HasKey(s => new
            {
                s.MonsterId,
                s.IdEnum
            });

            modelBuilder.Entity<MonsterStatsEF>()
                .HasOne<MonsterEF>(mEF => mEF.Monster)
                .WithMany(mEF => mEF.Stats)
                .HasForeignKey(meEF => meEF.MonsterId);

            modelBuilder.Entity<MonsterSkillEF>().HasKey(s => new
            {
                s.MonsterId,
                s.IdEnumSkill
            });

            modelBuilder.Entity<MonsterSkillEF>()
                .HasOne<MonsterEF>(mEF => mEF.Monster)
                .WithMany(mEF => mEF.Skills)
                .HasForeignKey(meEF => meEF.MonsterId);

            modelBuilder.Entity<MonsterVulnerabilitiesEF>().HasKey(s => new
            {
                s.MonsterId,
                s.IdEnum
            });

            modelBuilder.Entity<MonsterVulnerabilitiesEF>()
                .HasOne<MonsterEF>(mEF => mEF.Monster)
                .WithMany(mEF => mEF.Vulnerabilities)
                .HasForeignKey(meEF => meEF.MonsterId);

            modelBuilder.Entity<MonsterResistanceEF>().HasKey(s => new
            {
                s.MonsterId,
                s.IdEnum
            });

            modelBuilder.Entity<MonsterResistanceEF>()
                .HasOne<MonsterEF>(mEF => mEF.Monster)
                .WithMany(mEF => mEF.Resistances)
                .HasForeignKey(meEF => meEF.MonsterId);

            modelBuilder.Entity<MonsterImmunitiesEF>().HasKey(s => new
            {
                s.MonsterId,
                s.IdEnum
            });

            modelBuilder.Entity<MonsterImmunitiesEF>()
                .HasOne<MonsterEF>(mEF => mEF.Monster)
                .WithMany(mEF => mEF.Immunities)
                .HasForeignKey(meEF => meEF.MonsterId);

            modelBuilder.Entity<MonsterCondImmuEF>().HasKey(s => new
            {
                s.MonsterId,
                s.IdEnum
            });

            modelBuilder.Entity<MonsterCondImmuEF>()
                .HasOne<MonsterEF>(mEF => mEF.Monster)
                .WithMany(mEF => mEF.ConditionImmunities)
                .HasForeignKey(meEF => meEF.MonsterId);

            modelBuilder.Entity<MonsterSenseEF>().HasKey(s => new
            {
                s.MonsterId,
                s.IdEnum
            });

            modelBuilder.Entity<MonsterSenseEF>()
                .HasOne<MonsterEF>(mEF => mEF.Monster)
                .WithMany(mEF => mEF.Senses)
                .HasForeignKey(meEF => meEF.MonsterId);

            modelBuilder.Entity<MonsterLanguageEF>().HasKey(s => new
            {
                s.MonsterId,
                s.Language
            });

            modelBuilder.Entity<MonsterLanguageEF>()
                .HasOne<MonsterEF>(mEF => mEF.Monster)
                .WithMany(mEF => mEF.Languages)
                .HasForeignKey(meEF => meEF.MonsterId);

        }

        public DbSet<MonsterEF> Monsters { get; set; }
    }
}
