﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend.Contexts;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231004211917_relations-favorite")]
    partial class relationsfavorite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("backend.Models.Consumer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("Id");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletedAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("OriginCity")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Origin_City");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Password");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("bytea")
                        .HasColumnName("Picture");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Telephone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Consumers");
                });

            modelBuilder.Entity("backend.Models.ConsumerFavProducer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConsumerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProducerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ConsumerId");

                    b.HasIndex("ProducerId");

                    b.ToTable("ConsumerFavProducer");
                });

            modelBuilder.Entity("backend.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("Id");

                    b.Property<DateTime?>("AcceptedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("AcceptedAt");

                    b.Property<string>("ConsumerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConsumerObs")
                        .HasColumnType("text")
                        .HasColumnName("ConsumerObs");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletedAt");

                    b.Property<string>("ProducerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProducerObs")
                        .HasColumnType("text")
                        .HasColumnName("ProducerObs");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("Quantity");

                    b.Property<DateTime?>("RejectedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("RejectedAt");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ConsumerId");

                    b.HasIndex("ProducerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("backend.Models.Producer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("Id");

                    b.Property<string>("Attended_Cities")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("AttendedCities");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletedAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("OriginCity")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("OriginCity");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Password");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("bytea")
                        .HasColumnName("Picture");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Telephone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.Property<string>("Where_to_Find")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("WhereToFind");

                    b.HasKey("Id");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("backend.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("Id");

                    b.Property<int>("AvailableQuantity")
                        .HasColumnType("integer")
                        .HasColumnName("AvailableQuantity");

                    b.Property<int>("Category")
                        .HasColumnType("integer")
                        .HasColumnName("Category");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Description");

                    b.Property<DateTime>("HarvestDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("HarvestDate");

                    b.Property<bool>("IsOrganic")
                        .HasColumnType("boolean")
                        .HasColumnName("IsOrganic");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("Picture");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("Price");

                    b.Property<string>("ProducerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Unit")
                        .HasColumnType("integer")
                        .HasColumnName("Unit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ProducerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("backend.Models.ConsumerFavProducer", b =>
                {
                    b.HasOne("backend.Models.Consumer", "Consumer")
                        .WithMany("FavdProducers")
                        .HasForeignKey("ConsumerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Producer", "Producer")
                        .WithMany("FavdByConsumers")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consumer");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("backend.Models.Order", b =>
                {
                    b.HasOne("backend.Models.Consumer", "Consumer")
                        .WithMany("Orders")
                        .HasForeignKey("ConsumerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Producer", "Producer")
                        .WithMany("Orders")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consumer");

                    b.Navigation("Producer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("backend.Models.Product", b =>
                {
                    b.HasOne("backend.Models.Producer", "Producer")
                        .WithMany("Products")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("backend.Models.Consumer", b =>
                {
                    b.Navigation("FavdProducers");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("backend.Models.Producer", b =>
                {
                    b.Navigation("FavdByConsumers");

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
