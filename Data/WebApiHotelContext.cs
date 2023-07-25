using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApiHotel.Models;

namespace WebApiHotel.Data;

public partial class WebApiHotelContext : DbContext
{
    public WebApiHotelContext(DbContextOptions<WebApiHotelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Apartament> Apartaments { get; set; }

    public virtual DbSet<Categoriapartament> Categoriapartaments { get; set; }

    public virtual DbSet<CheckInapartament> CheckInapartaments { get; set; }

    public virtual DbSet<Employeesofthespasalon> Employeesofthespasalons { get; set; }

    public virtual DbSet<Newsletter> Newsletters { get; set; }

    public virtual DbSet<Offerhotel> Offerhotels { get; set; }

    public virtual DbSet<Orderhotel> Orderhotels { get; set; }

    public virtual DbSet<OrderhotelHasSpahotel> OrderhotelHasSpahotels { get; set; }

    public virtual DbSet<OrderhotelHasUserhotel> OrderhotelHasUserhotels { get; set; }

    public virtual DbSet<Reservationapartament> Reservationapartaments { get; set; }

    public virtual DbSet<Reservationspa> Reservationspas { get; set; }

    public virtual DbSet<Rolehotel> Rolehotels { get; set; }

    public virtual DbSet<Spahotel> Spahotels { get; set; }

    public virtual DbSet<Userhotel> Userhotels { get; set; }

    public virtual DbSet<ViewApartament> ViewApartaments { get; set; }

    public virtual DbSet<ViewSpa> ViewSpas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Apartament>(entity =>
        {
            entity.HasKey(e => e.IdApartment).HasName("PRIMARY");

            entity.ToTable("apartament");

            entity.HasIndex(e => new { e.Description, e.IdApartment, e.CountRoom, e.NumberApartament, e.IdCategoriApartament }, "Composite_Description_Image").HasAnnotation("MySql:IndexPrefixLength", new[] { 3, 0, 0, 0, 0 });

            entity.HasIndex(e => e.NumberApartament, "Number_UNIQUE").IsUnique();

            entity.Property(e => e.IdApartment)
                .ValueGeneratedNever()
                .HasColumnName("idApartment");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.IdCategoriApartament).HasColumnName("_idCategoriApartament");
        });

        modelBuilder.Entity<Categoriapartament>(entity =>
        {
            entity.HasKey(e => e.IdCategoriApartament).HasName("PRIMARY");

            entity.ToTable("categoriapartament");

            entity.HasIndex(e => e.NameCategori, "INDEX_nameC").HasAnnotation("MySql:IndexPrefixLength", new[] { 3 });

            entity.Property(e => e.IdCategoriApartament)
                .ValueGeneratedNever()
                .HasColumnName("idCategoriApartament");
            entity.Property(e => e.ImageApartament).HasColumnType("text");
            entity.Property(e => e.LinkApartament).HasColumnType("text");
            entity.Property(e => e.NameCategori).HasMaxLength(45);
        });

        modelBuilder.Entity<CheckInapartament>(entity =>
        {
            entity.HasKey(e => e.IdCheckInApartament).HasName("PRIMARY");

            entity.ToTable("check_inapartament");

            entity.HasIndex(e => e.EndCheck, "End_check_UNIQUE").IsUnique();

            entity.Property(e => e.IdCheckInApartament)
                .ValueGeneratedNever()
                .HasColumnName("idCheck_inApartament");
            entity.Property(e => e.EndCheck).HasColumnName("End_check");
            entity.Property(e => e.IdOrderHotel).HasColumnName("_idOrderHotel");
            entity.Property(e => e.StartCheck).HasColumnName("Start_check");
        });

        modelBuilder.Entity<Employeesofthespasalon>(entity =>
        {
            entity.HasKey(e => e.IdEmployeesofthespasalon).HasName("PRIMARY");

            entity.ToTable("employeesofthespasalon");

            entity.Property(e => e.IdEmployeesofthespasalon)
                .ValueGeneratedNever()
                .HasColumnName("idEmployeesofthespasalon");
            entity.Property(e => e.Openinghours).HasMaxLength(45);
            entity.Property(e => e.SpaHotelIdSpaHotel).HasColumnName("SpaHotel_idSpaHotel");
            entity.Property(e => e.UserHotelIdUserHotel).HasColumnName("UserHotel_idUserHotel");
            entity.Property(e => e.Workingdays).HasMaxLength(45);
        });

        modelBuilder.Entity<Newsletter>(entity =>
        {
            entity.HasKey(e => e.IdNewsletter).HasName("PRIMARY");

            entity.ToTable("newsletter");

            entity.Property(e => e.IdNewsletter)
                .ValueGeneratedNever()
                .HasColumnName("idNewsletter");
            entity.Property(e => e.Sale).HasColumnName("sale");
            entity.Property(e => e.TextNewsletter).HasColumnType("text");
        });

        modelBuilder.Entity<Offerhotel>(entity =>
        {
            entity.HasKey(e => new { e.IdUserHotel, e.IdNewsletter })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("offerhotel");

            entity.Property(e => e.IdUserHotel).HasColumnName("_idUserHotel");
            entity.Property(e => e.IdNewsletter).HasColumnName("_idNewsletter");
        });

        modelBuilder.Entity<Orderhotel>(entity =>
        {
            entity.HasKey(e => e.IdOrderHotel).HasName("PRIMARY");

            entity.ToTable("orderhotel");

            entity.Property(e => e.IdOrderHotel)
                .ValueGeneratedNever()
                .HasColumnName("idOrderHotel");
            entity.Property(e => e.IdApartment).HasColumnName("_idApartment");
        });

        modelBuilder.Entity<OrderhotelHasSpahotel>(entity =>
        {
            entity.HasKey(e => new { e.IdOrderHotel, e.IdUserHotel })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("orderhotel_has_spahotel");

            entity.HasIndex(e => e.SessionSpa, "Session_UNIQUE").IsUnique();

            entity.Property(e => e.IdOrderHotel).HasColumnName("_idOrderHotel");
            entity.Property(e => e.IdUserHotel).HasColumnName("_idUserHotel");
            entity.Property(e => e.IdSpaHotel).HasColumnName("_idSpaHotel");
        });

        modelBuilder.Entity<OrderhotelHasUserhotel>(entity =>
        {
            entity.HasKey(e => new { e.IdOrderHotel, e.IdUserHotel })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("orderhotel_has_userhotel");

            entity.Property(e => e.IdOrderHotel).HasColumnName("_idOrderHotel");
            entity.Property(e => e.IdUserHotel).HasColumnName("_idUserHotel");
            entity.Property(e => e.PaymentSing).HasColumnName("Payment_sing");
        });

        modelBuilder.Entity<Reservationapartament>(entity =>
        {
            entity.HasKey(e => e.IdReservationApartament).HasName("PRIMARY");

            entity.ToTable("reservationapartament");

            entity.Property(e => e.IdReservationApartament)
                .ValueGeneratedNever()
                .HasColumnName("idReservationApartament");
            entity.Property(e => e.EndReserv).HasColumnName("End_reserv");
            entity.Property(e => e.IdOrderHotel).HasColumnName("_idOrderHotel");
            entity.Property(e => e.StartReserv).HasColumnName("Start_reserv");
        });

        modelBuilder.Entity<Reservationspa>(entity =>
        {
            entity.HasKey(e => e.IdReservationSpa).HasName("PRIMARY");

            entity.ToTable("reservationspa");

            entity.Property(e => e.IdReservationSpa)
                .ValueGeneratedNever()
                .HasColumnName("idReservationSpa");
            entity.Property(e => e.DateReserv).HasColumnName("Date_reserv");
            entity.Property(e => e.OrderHotelIdOrderHotel).HasColumnName("OrderHotel_idOrderHotel");
            entity.Property(e => e.SpaHotelIdSpaHotel).HasColumnName("SpaHotel_idSpaHotel");
            entity.Property(e => e.TimeReserv)
                .HasColumnType("time")
                .HasColumnName("Time_reserv");
            entity.Property(e => e.UserHotelIdUserHotel).HasColumnName("UserHotel_idUserHotel");
        });

        modelBuilder.Entity<Rolehotel>(entity =>
        {
            entity.HasKey(e => e.IdRoleHotel).HasName("PRIMARY");

            entity.ToTable("rolehotel");

            entity.HasIndex(e => e.NameRole, "INDEX_namer").HasAnnotation("MySql:IndexPrefixLength", new[] { 3 });

            entity.Property(e => e.IdRoleHotel)
                .ValueGeneratedNever()
                .HasColumnName("idRoleHotel");
            entity.Property(e => e.NameRole).HasMaxLength(45);
        });

        modelBuilder.Entity<Spahotel>(entity =>
        {
            entity.HasKey(e => e.IdSpaHotel).HasName("PRIMARY");

            entity.ToTable("spahotel");

            entity.HasIndex(e => new { e.NameSpa, e.Regulations }, "Composite_spaname_Regulations").HasAnnotation("MySql:IndexPrefixLength", new[] { 3, 3 });

            entity.Property(e => e.IdSpaHotel)
                .ValueGeneratedNever()
                .HasColumnName("idSpaHotel");
            entity.Property(e => e.LinkSpa).HasColumnType("text");
            entity.Property(e => e.NameSpa).HasMaxLength(45);
            entity.Property(e => e.Regulations).HasColumnType("text");
        });

        modelBuilder.Entity<Userhotel>(entity =>
        {
            entity.HasKey(e => e.IdUserHotel).HasName("PRIMARY");

            entity.ToTable("userhotel");

            entity.HasIndex(e => new { e.NameUser, e.SurnameUser }, "Composite_name_surname").HasAnnotation("MySql:IndexPrefixLength", new[] { 10, 10 });

            entity.HasIndex(e => e.EmailUser, "Email_UNIQUE").IsUnique();

            entity.HasIndex(e => e.PhoneUser, "PhoneUser_UNIQUE").IsUnique();

            entity.HasIndex(e => e.LoginUser, "login_UNIQUE").IsUnique();

            entity.Property(e => e.IdUserHotel)
                .ValueGeneratedNever()
                .HasColumnName("idUserHotel");
            entity.Property(e => e.BithdayUser).HasColumnName("bithdayUser");
            entity.Property(e => e.Document)
                .HasColumnType("text")
                .HasColumnName("document");
            entity.Property(e => e.EmailUser)
                .HasMaxLength(45)
                .HasDefaultValueSql("'менше 18 років'");
            entity.Property(e => e.IdRoleHotel).HasColumnName("_idRoleHotel");
            entity.Property(e => e.LoginUser)
                .HasMaxLength(45)
                .HasDefaultValueSql("'менше 18 років'")
                .HasColumnName("loginUser");
            entity.Property(e => e.MiddleUser).HasMaxLength(45);
            entity.Property(e => e.NameUser).HasMaxLength(45);
            entity.Property(e => e.PassworldUser)
                .HasMaxLength(45)
                .HasDefaultValueSql("'менше 18 років'")
                .HasColumnName("passworldUser");
            entity.Property(e => e.PhoneUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("'менше 18 років'");
            entity.Property(e => e.Sex)
                .HasMaxLength(45)
                .HasColumnName("sex");
            entity.Property(e => e.SurnameUser).HasMaxLength(45);
        });

        modelBuilder.Entity<ViewApartament>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_apartament");
            entity.HasKey(e => e.Id).HasName("PRIMARY");
            entity.Property(e => e.Імя).HasMaxLength(45);
            entity.Property(e => e.ДатаБронювання).HasColumnName("Дата бронювання");
            entity.Property(e => e.ДатаНародження).HasColumnName("Дата народження");
            entity.Property(e => e.Документ).HasColumnType("text");
            entity.Property(e => e.КатегоріяАпартаментів)
                .HasMaxLength(45)
                .HasColumnName("Категорія апартаментів");
            entity.Property(e => e.КількістьРазівВідпочинку).HasColumnName("Кількість разів відпочинку");
            entity.Property(e => e.НомерБронювання).HasColumnName("Номер бронювання");
            entity.Property(e => e.НомерТелефону)
                .HasMaxLength(20)
                .HasDefaultValueSql("'менше 18 років'")
                .HasColumnName("Номер телефону");
            entity.Property(e => e.ПоБатькові)
                .HasMaxLength(45)
                .HasColumnName("По батькові");
            entity.Property(e => e.Пошта)
                .HasMaxLength(45)
                .HasDefaultValueSql("'менше 18 років'")
                .HasColumnName("пошта");
            entity.Property(e => e.Прізвище).HasMaxLength(45);
            entity.Property(e => e.Стать).HasMaxLength(45);
        });

        modelBuilder.Entity<ViewSpa>(entity =>
        {
         
            entity
                .HasNoKey()
                .ToView("view_spa");
   entity.HasKey(e => e.Id).HasName("PRIMARY");
            entity.Property(e => e.Імя).HasMaxLength(45);
            entity.Property(e => e.ДатаБронювання).HasColumnName("Дата бронювання");
            entity.Property(e => e.ДатаНародження).HasColumnName("Дата народження");
            entity.Property(e => e.Документ).HasColumnType("text");
            entity.Property(e => e.КількістьВідвідуванняСпа).HasColumnName("Кількість відвідування спа");
            entity.Property(e => e.НазваСпа)
                .HasMaxLength(45)
                .HasColumnName("Назва спа");
            entity.Property(e => e.НомерБронювання).HasColumnName("Номер бронювання");
            entity.Property(e => e.НомерТелефону)
                .HasMaxLength(20)
                .HasDefaultValueSql("'менше 18 років'")
                .HasColumnName("Номер телефону");
            entity.Property(e => e.ПоБатькові)
                .HasMaxLength(45)
                .HasColumnName("По батькові");
            entity.Property(e => e.Пошта)
                .HasMaxLength(45)
                .HasDefaultValueSql("'менше 18 років'")
                .HasColumnName("пошта");
            entity.Property(e => e.Прізвище).HasMaxLength(45);
            entity.Property(e => e.Стать).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
