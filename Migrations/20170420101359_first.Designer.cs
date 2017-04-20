using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using hjemmeside2.Models;

namespace hjemmeside2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20170420101359_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("hjemmeside2.Models.Booking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Combobox");

                    b.Property<string>("Comments");

                    b.Property<DateTime>("DateTimeny");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName");

                    b.Property<int>("PhoneNumber");

                    b.Property<DateTime>("Tidspunkt");

                    b.HasKey("ID");

                    b.ToTable("Bookings");
                });
        }
    }
}
