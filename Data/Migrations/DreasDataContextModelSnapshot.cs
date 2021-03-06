﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DreasDataContext))]
    partial class DreasDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DREAS.Models.Address", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("HouseNo")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LGA")
                        .IsRequired();

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("StreetName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DREAS.Models.CompanyProfile", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CAC");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactPersonnel");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("ID");

                    b.ToTable("CompanyProfiles");
                });

            modelBuilder.Entity("DREAS.Models.Contact", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AddressID");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DREAS.Models.Enquiry", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("FAQ");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Message");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid>("PropertyID");

                    b.HasKey("ID");

                    b.ToTable("Enquiries");
                });

            modelBuilder.Entity("DREAS.Models.Log", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActionType");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("IPAddress");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Message");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("Status");

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("DREAS.Models.Notification", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("EmailID");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid?>("MessageID");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("PropertyID");

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("EmailID");

                    b.HasIndex("MessageID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("DREAS.Models.Payment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid>("ServiceID");

                    b.Property<int>("Status");

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DREAS.Models.Promotion", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("ImageURL");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<Guid>("PropertyID");

                    b.HasKey("ID");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("DREAS.Models.Property", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CategoryID");

                    b.Property<Guid?>("ContactID");

                    b.Property<string>("Details");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<Guid>("OwnerID");

                    b.Property<decimal>("Price");

                    b.Property<int>("Status");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ContactID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("DREAS.Models.PropertyCategory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Duplex");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("Flat");

                    b.Property<string>("HalfDuplex");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("RoomNo");

                    b.Property<string>("Terrace");

                    b.HasKey("ID");

                    b.ToTable("PropertyCategories");
                });

            modelBuilder.Entity("DREAS.Models.PropertyList", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid?>("PropertyCategoryID");

                    b.Property<Guid>("PropertyID");

                    b.Property<int>("Type");

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("PropertyCategoryID");

                    b.ToTable("PropertyLists");
                });

            modelBuilder.Entity("DREAS.Models.Referal", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ReferalCode");

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Referals");
                });

            modelBuilder.Entity("DREAS.Models.Role", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DREAS.Models.Service", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("DREAS.Models.Settlement", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("Category");

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Settlements");
                });

            modelBuilder.Entity("DREAS.Models.Transaction", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid>("PropertyID");

                    b.Property<string>("ReferenceNo");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("DREAS.Models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BlockedDate");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsBlocked");

                    b.Property<bool>("IsConfirmed");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("UserType");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DREAS.Models.UserProfile", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BVN");

                    b.Property<Guid?>("ContactID");

                    b.Property<Guid>("EntryBy");

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("NIN");

                    b.Property<int>("ReferalCode");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("DREAS.Models.Contact", b =>
                {
                    b.HasOne("DREAS.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DREAS.Models.Log", b =>
                {
                    b.HasOne("DREAS.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DREAS.Models.Notification", b =>
                {
                    b.HasOne("DREAS.Models.Contact", "Email")
                        .WithMany()
                        .HasForeignKey("EmailID");

                    b.HasOne("DREAS.Models.Enquiry", "Message")
                        .WithMany()
                        .HasForeignKey("MessageID");
                });

            modelBuilder.Entity("DREAS.Models.Property", b =>
                {
                    b.HasOne("DREAS.Models.PropertyCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("DREAS.Models.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactID");

                    b.HasOne("DREAS.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DREAS.Models.PropertyList", b =>
                {
                    b.HasOne("DREAS.Models.PropertyCategory", "PropertyCategory")
                        .WithMany()
                        .HasForeignKey("PropertyCategoryID");
                });

            modelBuilder.Entity("DREAS.Models.UserProfile", b =>
                {
                    b.HasOne("DREAS.Models.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactID");
                });
#pragma warning restore 612, 618
        }
    }
}
