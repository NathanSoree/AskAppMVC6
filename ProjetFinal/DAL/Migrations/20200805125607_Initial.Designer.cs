﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(MonsterMakerContext))]
    [Migration("20200805125607_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.EntityFramework.ActionEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AttackId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAttack")
                        .HasColumnType("bit");

                    b.Property<int?>("MonsterEFId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttackId");

                    b.HasIndex("MonsterEFId");

                    b.ToTable("ActionEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.AttackEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttackDie")
                        .HasColumnType("int");

                    b.Property<int>("DamageType")
                        .HasColumnType("int");

                    b.Property<int>("DiceMultiplicator")
                        .HasColumnType("int");

                    b.Property<int>("Modifier")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AttackEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.HealthEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConModifier")
                        .HasColumnType("int");

                    b.Property<int>("HitDie")
                        .HasColumnType("int");

                    b.Property<int>("Multiplicator")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HealthEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.LegendaryActionEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MonsterEFId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MonsterEFId");

                    b.ToTable("LegendaryActionEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterCondImmuEF", b =>
                {
                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("IdEnum")
                        .HasColumnType("int");

                    b.HasKey("MonsterId", "IdEnum");

                    b.ToTable("MonsterCondImmuEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Alignment")
                        .HasColumnType("int");

                    b.Property<int>("ArmorClass")
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DifficultyRating")
                        .HasColumnType("int");

                    b.Property<int?>("HealthId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWide")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbrLegendaryActionPerTurn")
                        .HasColumnType("int");

                    b.Property<string>("OtherImmunities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherResistences")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherVulnerabilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HealthId");

                    b.ToTable("Monsters");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterImmunitiesEF", b =>
                {
                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("IdEnum")
                        .HasColumnType("int");

                    b.HasKey("MonsterId", "IdEnum");

                    b.ToTable("MonsterImmunitiesEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterLanguageEF", b =>
                {
                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MonsterId", "Language");

                    b.ToTable("MonsterLanguageEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterResistanceEF", b =>
                {
                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("IdEnum")
                        .HasColumnType("int");

                    b.HasKey("MonsterId", "IdEnum");

                    b.ToTable("MonsterResistanceEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterSenseEF", b =>
                {
                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("IdEnum")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("MonsterId", "IdEnum");

                    b.ToTable("MonsterSenseEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterSkillEF", b =>
                {
                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("IdEnumSkill")
                        .HasColumnType("int");

                    b.Property<int>("IdEnumProf")
                        .HasColumnType("int");

                    b.HasKey("MonsterId", "IdEnumSkill");

                    b.ToTable("MonsterSkillEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterSpeedEF", b =>
                {
                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("IdEnum")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("MonsterId", "IdEnum");

                    b.ToTable("MonsterSpeedEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterStatsEF", b =>
                {
                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("IdEnum")
                        .HasColumnType("int");

                    b.Property<bool>("Saving")
                        .HasColumnType("bit");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("MonsterId", "IdEnum");

                    b.ToTable("MonsterStatsEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterVulnerabilitiesEF", b =>
                {
                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("IdEnum")
                        .HasColumnType("int");

                    b.HasKey("MonsterId", "IdEnum");

                    b.ToTable("MonsterVulnerabilitiesEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.ReactionEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MonsterEFId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MonsterEFId");

                    b.ToTable("ReactionEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.TraitsEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MonsterEFId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MonsterEFId");

                    b.ToTable("TraitsEF");
                });

            modelBuilder.Entity("DAL.EntityFramework.ActionEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.AttackEF", "Attack")
                        .WithMany()
                        .HasForeignKey("AttackId");

                    b.HasOne("DAL.EntityFramework.MonsterEF", null)
                        .WithMany("Actions")
                        .HasForeignKey("MonsterEFId");
                });

            modelBuilder.Entity("DAL.EntityFramework.LegendaryActionEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", null)
                        .WithMany("LegendaryActions")
                        .HasForeignKey("MonsterEFId");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterCondImmuEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", "Monster")
                        .WithMany("ConditionImmunities")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.HealthEF", "Health")
                        .WithMany()
                        .HasForeignKey("HealthId");
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterImmunitiesEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", "Monster")
                        .WithMany("Immunities")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterLanguageEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", "Monster")
                        .WithMany("Languages")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterResistanceEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", "Monster")
                        .WithMany("Resistances")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterSenseEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", "Monster")
                        .WithMany("Senses")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterSkillEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", "Monster")
                        .WithMany("Skills")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterSpeedEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", "Monster")
                        .WithMany("Speeds")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterStatsEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", "Monster")
                        .WithMany("Stats")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.EntityFramework.MonsterVulnerabilitiesEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", "Monster")
                        .WithMany("Vulnerabilities")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.EntityFramework.ReactionEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", null)
                        .WithMany("Reactions")
                        .HasForeignKey("MonsterEFId");
                });

            modelBuilder.Entity("DAL.EntityFramework.TraitsEF", b =>
                {
                    b.HasOne("DAL.EntityFramework.MonsterEF", null)
                        .WithMany("Traits")
                        .HasForeignKey("MonsterEFId");
                });
#pragma warning restore 612, 618
        }
    }
}
