﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YOGBIS.Data.DataContext;

namespace YOGBIS.Data.Migrations
{
    [DbContext(typeof(YOGBISContext))]
    [Migration("20210515212648_AddYeniTblolar")]
    partial class AddYeniTblolar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(127)")
                        .HasMaxLength(127);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(127)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(127)")
                        .HasMaxLength(127);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(127)")
                        .HasMaxLength(127);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(127)")
                        .HasMaxLength(127);

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(127)")
                        .HasMaxLength(127);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(127)")
                        .HasMaxLength(127);

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(127)")
                        .HasMaxLength(127);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(127)")
                        .HasMaxLength(127);

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Eyaletler", b =>
                {
                    b.Property<int>("EyaletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EyaletAciklama")
                        .HasColumnType("text");

                    b.Property<string>("EyaletAdi")
                        .HasColumnType("text");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.Property<int?>("UlkelerUlkeId")
                        .HasColumnType("int");

                    b.HasKey("EyaletId");

                    b.HasIndex("UlkelerUlkeId");

                    b.ToTable("Eyaletlers");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Kategoriler", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("text");

                    b.Property<string>("KategoriDerece")
                        .HasColumnType("text");

                    b.Property<string>("KategoriKullanimi")
                        .HasColumnType("text");

                    b.Property<int>("KategoriPuan")
                        .HasColumnType("int");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Kitalar", b =>
                {
                    b.Property<int>("KitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KitaAciklama")
                        .HasColumnType("text");

                    b.Property<string>("KitaAdi")
                        .HasColumnType("text");

                    b.Property<int>("UlkeGrupId")
                        .HasColumnType("int");

                    b.Property<int?>("UlkeGruplariUlkeGrupId")
                        .HasColumnType("int");

                    b.HasKey("KitaId");

                    b.HasIndex("UlkeGruplariUlkeGrupId");

                    b.ToTable("Kitalars");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.MulakatSorulari", b =>
                {
                    b.Property<int>("MulakatSorulariId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cevap")
                        .HasColumnType("text");

                    b.Property<string>("Derecesi")
                        .HasColumnType("text");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("MulakatId")
                        .HasColumnType("int");

                    b.Property<int?>("MulakatlarMulakatId")
                        .HasColumnType("int");

                    b.Property<string>("Soru")
                        .HasColumnType("text");

                    b.Property<int>("SoruNo")
                        .HasColumnType("int");

                    b.Property<int>("SoruSiraNo")
                        .HasColumnType("int");

                    b.HasKey("MulakatSorulariId");

                    b.HasIndex("MulakatlarMulakatId");

                    b.ToTable("MulakatSorularis");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Mulakatlar", b =>
                {
                    b.Property<int>("MulakatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AdaySayisi")
                        .HasColumnType("int");

                    b.Property<DateTime>("BaslamaTarihi")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime");

                    b.Property<string>("Derecesi")
                        .HasColumnType("text");

                    b.Property<string>("Durumu")
                        .HasColumnType("text");

                    b.Property<string>("MulakatAciklama")
                        .HasColumnType("text");

                    b.Property<string>("MulakatAdi")
                        .HasColumnType("text");

                    b.Property<string>("OnaySayisi")
                        .HasColumnType("text");

                    b.Property<int>("SorulanSoruSayisi")
                        .HasColumnType("int");

                    b.HasKey("MulakatId");

                    b.ToTable("Mulakatlars");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Sehirler", b =>
                {
                    b.Property<int>("SehirId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("Baskent")
                        .HasColumnType("bit");

                    b.Property<int>("EyaletId")
                        .HasColumnType("int");

                    b.Property<int?>("EyaletlerEyaletId")
                        .HasColumnType("int");

                    b.Property<string>("SehirAciklama")
                        .HasColumnType("text");

                    b.Property<string>("SehirAdi")
                        .HasColumnType("text");

                    b.HasKey("SehirId");

                    b.HasIndex("EyaletlerEyaletId");

                    b.ToTable("Sehirlers");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.SoruBankasi", b =>
                {
                    b.Property<int>("SoruBankasiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cevap")
                        .HasColumnType("text");

                    b.Property<string>("Derecesi")
                        .HasColumnType("text");

                    b.Property<string>("Soru")
                        .HasColumnType("text");

                    b.Property<string>("SoruDurumu")
                        .HasColumnType("text");

                    b.Property<int>("SoruKategoriId")
                        .HasColumnType("int");

                    b.Property<int>("SorulmaSayisi")
                        .HasColumnType("int");

                    b.HasKey("SoruBankasiId");

                    b.ToTable("SoruBankasis");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.SoruBankasiLog", b =>
                {
                    b.Property<int>("SoruBankasiLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cevap")
                        .HasColumnType("text");

                    b.Property<string>("Islem")
                        .HasColumnType("text");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("text");

                    b.Property<string>("Soru")
                        .HasColumnType("text");

                    b.Property<int>("SoruBankasiId")
                        .HasColumnType("int");

                    b.HasKey("SoruBankasiLogId");

                    b.HasIndex("SoruBankasiId");

                    b.ToTable("SoruBankasiLogs");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.SoruKategori", b =>
                {
                    b.Property<int>("SoruKategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int?>("KategorilerKategoriId")
                        .HasColumnType("int");

                    b.Property<int?>("SoruBankasiId")
                        .HasColumnType("int");

                    b.Property<int>("SoruId")
                        .HasColumnType("int");

                    b.HasKey("SoruKategoriId");

                    b.HasIndex("KategorilerKategoriId");

                    b.HasIndex("SoruBankasiId");

                    b.ToTable("SoruKategoris");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.UlkeGruplari", b =>
                {
                    b.Property<int>("UlkeGrupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UlkeGrupAciklama")
                        .HasColumnType("text");

                    b.Property<string>("UlkeGrupAdi")
                        .HasColumnType("text");

                    b.HasKey("UlkeGrupId");

                    b.ToTable("UlkeGruplaris");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Ulkeler", b =>
                {
                    b.Property<int>("UlkeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("KitaId")
                        .HasColumnType("int");

                    b.Property<int?>("KitalarKitaId")
                        .HasColumnType("int");

                    b.Property<string>("UlkeAciklama")
                        .HasColumnType("text");

                    b.Property<string>("UlkeAdi")
                        .HasColumnType("text");

                    b.Property<string>("UlkeBayrak")
                        .HasColumnType("text");

                    b.HasKey("UlkeId");

                    b.HasIndex("KitalarKitaId");

                    b.ToTable("Ulkelers");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Kullanici", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<bool?>("Aktif")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime");

                    b.Property<string>("Soyad")
                        .HasColumnType("text");

                    b.Property<string>("TcKimlikNo")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Kullanici");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Eyaletler", b =>
                {
                    b.HasOne("YOGBIS.Data.DbModels.Ulkeler", "Ulkeler")
                        .WithMany()
                        .HasForeignKey("UlkelerUlkeId");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Kitalar", b =>
                {
                    b.HasOne("YOGBIS.Data.DbModels.UlkeGruplari", "UlkeGruplari")
                        .WithMany()
                        .HasForeignKey("UlkeGruplariUlkeGrupId");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.MulakatSorulari", b =>
                {
                    b.HasOne("YOGBIS.Data.DbModels.Mulakatlar", "Mulakatlar")
                        .WithMany()
                        .HasForeignKey("MulakatlarMulakatId");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Sehirler", b =>
                {
                    b.HasOne("YOGBIS.Data.DbModels.Eyaletler", "Eyaletler")
                        .WithMany()
                        .HasForeignKey("EyaletlerEyaletId");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.SoruBankasiLog", b =>
                {
                    b.HasOne("YOGBIS.Data.DbModels.SoruBankasi", "SoruBankasi")
                        .WithMany()
                        .HasForeignKey("SoruBankasiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.SoruKategori", b =>
                {
                    b.HasOne("YOGBIS.Data.DbModels.Kategoriler", "Kategoriler")
                        .WithMany("SoruKategoris")
                        .HasForeignKey("KategorilerKategoriId");

                    b.HasOne("YOGBIS.Data.DbModels.SoruBankasi", "SoruBankasi")
                        .WithMany("SoruKategoris")
                        .HasForeignKey("SoruBankasiId");
                });

            modelBuilder.Entity("YOGBIS.Data.DbModels.Ulkeler", b =>
                {
                    b.HasOne("YOGBIS.Data.DbModels.Kitalar", "Kitalar")
                        .WithMany()
                        .HasForeignKey("KitalarKitaId");
                });
#pragma warning restore 612, 618
        }
    }
}
