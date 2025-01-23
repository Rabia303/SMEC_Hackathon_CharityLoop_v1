﻿// <auto-generated />
using System;
using CharityLoop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CharityLoop.Migrations
{
    [DbContext(typeof(ngoDbContext))]
    [Migration("20250122190017_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CharityLoop.Models.ActivityLog", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogId"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PerformedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("LogId");

                    b.ToTable("ActivityLogs");
                });

            modelBuilder.Entity("CharityLoop.Models.AddDonation", b =>
                {
                    b.Property<int>("donationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("donationId"));

                    b.Property<string>("cause")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("donationId");

                    b.ToTable("AddDonation");
                });

            modelBuilder.Entity("CharityLoop.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"));

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoucherRules")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("CharityLoop.Models.Disposal", b =>
                {
                    b.Property<int>("DisposalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisposalId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ScheduledDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DisposalId");

                    b.HasIndex("UserId");

                    b.ToTable("Disposals");
                });

            modelBuilder.Entity("CharityLoop.Models.Gallery", b =>
                {
                    b.Property<int>("imgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("imgId"));

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("imgId");

                    b.ToTable("Gallery");
                });

            modelBuilder.Entity("CharityLoop.Models.HelpCentre", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("HelpCentre");
                });

            modelBuilder.Entity("CharityLoop.Models.NGO", b =>
                {
                    b.Property<int>("NGOId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NGOId"));

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NGOId");

                    b.ToTable("NGOs");
                });

            modelBuilder.Entity("CharityLoop.Models.UserReg", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User_Reg");
                });

            modelBuilder.Entity("CharityLoop.Models.about_cwu", b =>
                {
                    b.Property<int>("cvuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cvuID"));

                    b.Property<string>("contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cvuID");

                    b.ToTable("About_Career_with_us");
                });

            modelBuilder.Entity("CharityLoop.Models.about_om", b =>
                {
                    b.Property<int>("omID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("omID"));

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("omID");

                    b.ToTable("ABout_Our_Mission");
                });

            modelBuilder.Entity("CharityLoop.Models.about_os", b =>
                {
                    b.Property<int>("osID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("osID"));

                    b.Property<string>("osimg1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("osimg2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("osimg3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("osimg4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("osID");

                    b.ToTable("About_Our_Supporters");
                });

            modelBuilder.Entity("CharityLoop.Models.about_team", b =>
                {
                    b.Property<int>("atID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("atID"));

                    b.Property<string>("designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("atID");

                    b.ToTable("About_team");
                });

            modelBuilder.Entity("CharityLoop.Models.about_wwd", b =>
                {
                    b.Property<int>("wwdID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("wwdID"));

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("wwdID");

                    b.ToTable("About_what_we_do");
                });

            modelBuilder.Entity("CharityLoop.Models.admin_register", b =>
                {
                    b.Property<int>("Admin_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Admin_Id"));

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Admin_Id");

                    b.ToTable("Admin_Register");
                });

            modelBuilder.Entity("CharityLoop.Models.contact", b =>
                {
                    b.Property<int>("contactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("contactId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactId");

                    b.HasIndex("UserId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("CharityLoop.Models.donation", b =>
                {
                    b.Property<int>("donatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("donatorId"));

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("donationId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("donatorId");

                    b.HasIndex("UserId");

                    b.HasIndex("donationId");

                    b.ToTable("Donation");
                });

            modelBuilder.Entity("CharityLoop.Models.listofNGO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logo_img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameofNGO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ListOfNGO");
                });

            modelBuilder.Entity("CharityLoop.Models.ourPrograms", b =>
                {
                    b.Property<int>("opID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("opID"));

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opHeading")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("opID");

                    b.ToTable("OurPrograms");
                });

            modelBuilder.Entity("CharityLoop.Models.team", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("teams");
                });

            modelBuilder.Entity("DonateClothes", b =>
                {
                    b.Property<int>("DonationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonationId"));

                    b.Property<int?>("AddDonationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("NGOId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduledDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRegId")
                        .HasColumnType("int");

                    b.HasKey("DonationId");

                    b.HasIndex("AddDonationId");

                    b.HasIndex("NGOId");

                    b.HasIndex("UserRegId");

                    b.ToTable("DonateClothes");
                });

            modelBuilder.Entity("Voucher", b =>
                {
                    b.Property<int>("VoucherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoucherId"));

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserRegUserId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("VoucherId");

                    b.HasIndex("UserRegUserId");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("CharityLoop.Models.Disposal", b =>
                {
                    b.HasOne("CharityLoop.Models.UserReg", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CharityLoop.Models.contact", b =>
                {
                    b.HasOne("CharityLoop.Models.UserReg", "UserReg")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserReg");
                });

            modelBuilder.Entity("CharityLoop.Models.donation", b =>
                {
                    b.HasOne("CharityLoop.Models.UserReg", "UserReg")
                        .WithMany("donations")
                        .HasForeignKey("UserId");

                    b.HasOne("CharityLoop.Models.AddDonation", "AddDonation")
                        .WithMany("donations")
                        .HasForeignKey("donationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddDonation");

                    b.Navigation("UserReg");
                });

            modelBuilder.Entity("DonateClothes", b =>
                {
                    b.HasOne("CharityLoop.Models.AddDonation", "AddDonation")
                        .WithMany()
                        .HasForeignKey("AddDonationId");

                    b.HasOne("CharityLoop.Models.NGO", "NGO")
                        .WithMany()
                        .HasForeignKey("NGOId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CharityLoop.Models.UserReg", "UserReg")
                        .WithMany("DonateClothes")
                        .HasForeignKey("UserRegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddDonation");

                    b.Navigation("NGO");

                    b.Navigation("UserReg");
                });

            modelBuilder.Entity("Voucher", b =>
                {
                    b.HasOne("CharityLoop.Models.UserReg", "UserReg")
                        .WithMany()
                        .HasForeignKey("UserRegUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserReg");
                });

            modelBuilder.Entity("CharityLoop.Models.AddDonation", b =>
                {
                    b.Navigation("donations");
                });

            modelBuilder.Entity("CharityLoop.Models.UserReg", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("DonateClothes");

                    b.Navigation("donations");
                });
#pragma warning restore 612, 618
        }
    }
}
