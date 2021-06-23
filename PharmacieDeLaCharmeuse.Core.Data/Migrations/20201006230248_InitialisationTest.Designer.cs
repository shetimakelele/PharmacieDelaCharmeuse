﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacieDeLaCharmeuse.Core.Data;

namespace PharmacieDeLaCharmeuse.Core.Data.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20201006230248_InitialisationTest")]
    partial class InitialisationTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.Astuce", b =>
                {
                    b.Property<int>("AstuceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AstuceImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategorieAstuceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEdition")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionCourte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AstuceId");

                    b.HasIndex("CategorieAstuceId");

                    b.ToTable("Astuce");

                    b.HasData(
                        new
                        {
                            AstuceId = 1,
                            AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",
                            CategorieAstuceId = 1,
                            DateEdition = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ici une DescriptionLongue longue",
                            DescriptionCourte = "Ici une Description courte",
                            ProduitId = 4,
                            Titre = "ici un titre"
                        },
                        new
                        {
                            AstuceId = 2,
                            AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",
                            CategorieAstuceId = 1,
                            DateEdition = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ici une DescriptionLongue longue",
                            DescriptionCourte = "Ici une Description courte",
                            ProduitId = 4,
                            Titre = "ici un titre"
                        },
                        new
                        {
                            AstuceId = 3,
                            AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",
                            CategorieAstuceId = 1,
                            DateEdition = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ici une DescriptionLongue longue",
                            DescriptionCourte = "Ici une Description courte",
                            ProduitId = 4,
                            Titre = "ici un titre"
                        },
                        new
                        {
                            AstuceId = 4,
                            AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",
                            CategorieAstuceId = 1,
                            DateEdition = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ici une DescriptionLongue longue",
                            DescriptionCourte = "Ici une Description courte",
                            ProduitId = 4,
                            Titre = "ici un titre"
                        },
                        new
                        {
                            AstuceId = 5,
                            AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",
                            CategorieAstuceId = 1,
                            DateEdition = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ici une DescriptionLongue longue",
                            DescriptionCourte = "Ici une Description courte",
                            ProduitId = 4,
                            Titre = "ici un titre"
                        },
                        new
                        {
                            AstuceId = 6,
                            AstuceImageUrl = " https://www.dinafem.org/uploads/sativex_3.jpg",
                            CategorieAstuceId = 1,
                            DateEdition = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ici une DescriptionLongue longue",
                            DescriptionCourte = "Ici une Description courte",
                            ProduitId = 4,
                            Titre = "ici un titre"
                        });
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.CategorieAstuce", b =>
                {
                    b.Property<int>("CategorieAstuceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionCategorieAstuce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomCategorieAstuce")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategorieAstuceID");

                    b.ToTable("CategorieAstuce");

                    b.HasData(
                        new
                        {
                            CategorieAstuceID = 1,
                            DescriptionCategorieAstuce = "Description ici",
                            NomCategorieAstuce = "Beauté"
                        },
                        new
                        {
                            CategorieAstuceID = 2,
                            DescriptionCategorieAstuce = "Description ici et la",
                            NomCategorieAstuce = "Régime"
                        });
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.CategorieProduit", b =>
                {
                    b.Property<int>("CategorieProduitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionCategorieProduit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomCategorieProduit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategorieProduitID");

                    b.ToTable("CategorieProduit");

                    b.HasData(
                        new
                        {
                            CategorieProduitID = 1,
                            DescriptionCategorieProduit = "Médicament de premier niveau a recuper sans ordonance",
                            NomCategorieProduit = "Médicament sans ordonnace"
                        },
                        new
                        {
                            CategorieProduitID = 2,
                            DescriptionCategorieProduit = "Médicament de deuxieme niveau uniquement par ordonnance",
                            NomCategorieProduit = "Médicament avec ordonnace"
                        });
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.Commande", b =>
                {
                    b.Property<int>("CommandeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse1")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Adresse2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodePostal")
                        .HasColumnType("int")
                        .HasMaxLength(10);

                    b.Property<decimal>("CommandeTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateCommande")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Pays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommandeId");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.CommandeDetail", b =>
                {
                    b.Property<int>("CommandeDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.HasKey("CommandeDetailId");

                    b.HasIndex("CommandeId");

                    b.HasIndex("ProduitId");

                    b.ToTable("CommandeDetails");
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.ImageModel", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitreImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.Produit", b =>
                {
                    b.Property<int>("ProduitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorieProduitId")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionCourte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionLongue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnStock")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrixPromo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("ProduitDuMois")
                        .HasColumnType("bit");

                    b.HasKey("ProduitId");

                    b.HasIndex("CategorieProduitId");

                    b.ToTable("Produit");

                    b.HasData(
                        new
                        {
                            ProduitId = 1,
                            CategorieProduitId = 1,
                            DescriptionCourte = "Ici une Description courte",
                            DescriptionLongue = "ici une DescriptionLongue longue",
                            EnStock = 10,
                            ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                            Nom = "Doliprane",
                            Prix = 2m,
                            PrixPromo = 1m,
                            ProduitDuMois = true
                        },
                        new
                        {
                            ProduitId = 2,
                            CategorieProduitId = 1,
                            DescriptionCourte = "Ici une Description courte",
                            DescriptionLongue = "ici une DescriptionLongue longue",
                            EnStock = 100,
                            ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                            Nom = "Paracetamol",
                            Prix = 5m,
                            PrixPromo = 1m,
                            ProduitDuMois = true
                        },
                        new
                        {
                            ProduitId = 4,
                            CategorieProduitId = 2,
                            DescriptionCourte = "Ici une Description courte",
                            DescriptionLongue = "ici une DescriptionLongue longue",
                            EnStock = 10,
                            ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                            Nom = "Doliprane",
                            Prix = 2m,
                            PrixPromo = 1m,
                            ProduitDuMois = true
                        },
                        new
                        {
                            ProduitId = 5,
                            CategorieProduitId = 2,
                            DescriptionCourte = "Ici une Description courte",
                            DescriptionLongue = "ici une DescriptionLongue longue",
                            EnStock = 105,
                            ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                            Nom = "Sirop",
                            Prix = 5m,
                            PrixPromo = 1m,
                            ProduitDuMois = false
                        },
                        new
                        {
                            ProduitId = 6,
                            CategorieProduitId = 2,
                            DescriptionCourte = "Ici une Description courte",
                            DescriptionLongue = "ici une DescriptionLongue longue",
                            EnStock = 105,
                            ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                            Nom = "Baume",
                            Prix = 15m,
                            PrixPromo = 16m,
                            ProduitDuMois = false
                        },
                        new
                        {
                            ProduitId = 3,
                            CategorieProduitId = 2,
                            DescriptionCourte = "Ici une Description courte",
                            DescriptionLongue = "ici une DescriptionLongue longue",
                            EnStock = 105,
                            ImageUrL = "https://cdn.shop-pharmacie.fr/images/245x245/doliprane-paracetamol-1000-mg-comprimes-effervescents-F10000168-p10.jpg",
                            Nom = "contraception",
                            Prix = 15m,
                            PrixPromo = 16m,
                            ProduitDuMois = false
                        },
                        new
                        {
                            ProduitId = 7,
                            CategorieProduitId = 2,
                            DescriptionCourte = "Ici une Description courte",
                            DescriptionLongue = "ici une DescriptionLongue longue",
                            EnStock = 105,
                            ImageUrL = "https://www.dinafem.org/uploads/sativex_3.jpg",
                            Nom = "Lotion",
                            Prix = 15m,
                            PrixPromo = 16m,
                            ProduitDuMois = false
                        },
                        new
                        {
                            ProduitId = 8,
                            CategorieProduitId = 2,
                            DescriptionCourte = "Ici une Description courte",
                            DescriptionLongue = "ici une DescriptionLongue longue",
                            EnStock = 105,
                            ImageUrL = "https://www.dinafem.org/uploads/sativex_3.jpg",
                            Nom = "dentifrice",
                            Prix = 15m,
                            PrixPromo = 16m,
                            ProduitDuMois = true
                        });
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProduitId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartSessionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProduitId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.TestProduit", b =>
                {
                    b.Property<int>("TestProduitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateEdition")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionCourte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoteTest")
                        .HasColumnType("int");

                    b.Property<string>("TestImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestProduitId");

                    b.ToTable("TestProduit");

                    b.HasData(
                        new
                        {
                            TestProduitId = 1,
                            DateEdition = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ici une DescriptionLongue longue",
                            DescriptionCourte = "Ici une Description courte",
                            NoteTest = 8,
                            TestImageUrl = "https://www.dinafem.org/uploads/sativex_3.jpg",
                            Titre = "dentifrice"
                        },
                        new
                        {
                            TestProduitId = 2,
                            DateEdition = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ici une DescriptionLongue longue",
                            DescriptionCourte = "Ici une Description courte",
                            NoteTest = 8,
                            TestImageUrl = "https://www.dinafem.org/uploads/sativex_3.jpg",
                            Titre = "dentifrice"
                        },
                        new
                        {
                            TestProduitId = 3,
                            DateEdition = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ici une DescriptionLongue longue",
                            DescriptionCourte = "Ici une Description courte",
                            NoteTest = 8,
                            TestImageUrl = "https://www.dinafem.org/uploads/sativex_3.jpg",
                            Titre = "dentifrice"
                        });
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.Astuce", b =>
                {
                    b.HasOne("PharmacieDeLaCharmeuse.Core.Data.Models.CategorieAstuce", "categorieAstuce")
                        .WithMany("Astuces")
                        .HasForeignKey("CategorieAstuceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.CommandeDetail", b =>
                {
                    b.HasOne("PharmacieDeLaCharmeuse.Core.Data.Models.Commande", "Commande")
                        .WithMany("CommandeDetails")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmacieDeLaCharmeuse.Core.Data.Models.Produit", "Produit")
                        .WithMany()
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.Produit", b =>
                {
                    b.HasOne("PharmacieDeLaCharmeuse.Core.Data.Models.CategorieProduit", "categorieProduit")
                        .WithMany("Produits")
                        .HasForeignKey("CategorieProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PharmacieDeLaCharmeuse.Core.Data.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("PharmacieDeLaCharmeuse.Core.Data.Models.Produit", "Produit")
                        .WithMany()
                        .HasForeignKey("ProduitId");
                });
#pragma warning restore 612, 618
        }
    }
}
