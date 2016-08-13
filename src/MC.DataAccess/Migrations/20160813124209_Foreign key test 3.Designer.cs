using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MC.DataAccess;

namespace MC.DataAccess.Migrations
{
    [DbContext(typeof(MCContext))]
    [Migration("20160813124209_Foreign key test 3")]
    partial class Foreignkeytest3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MC.Models.Entities.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("MC.Models.Entities.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlockId");

                    b.Property<int>("BlockMetaData");

                    b.Property<string>("Name");

                    b.Property<int>("NetworkId");

                    b.Property<double>("NumberStored");

                    b.HasKey("ItemId");

                    b.HasIndex("NetworkId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("MC.Models.Entities.Network", b =>
                {
                    b.Property<int>("NetworkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("NetworkId");

                    b.ToTable("Networks");
                });

            modelBuilder.Entity("MC.Models.Entities.Item", b =>
                {
                    b.HasOne("MC.Models.Entities.Network", "Network")
                        .WithMany("Items")
                        .HasForeignKey("NetworkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
