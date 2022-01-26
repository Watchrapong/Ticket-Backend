using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ticket_Backend.models;

namespace Ticket_Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ticket>()
                .HasKey(ticket => ticket.Id);
            modelBuilder.Entity<Ticket>()
                .Property(ts => ts.TicketStatus)
                .HasConversion(new EnumToStringConverter<TicketStatus>());
            modelBuilder.Entity<Ticket>()
                .HasOne(ticket => ticket.Customer)
                .WithMany(customer => customer.Tickets)
                .HasForeignKey(ticket => ticket.CustomerId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Ticket>()
                .HasOne(ticket => ticket.User)
                .WithMany(user => user.Tickets)
                .HasForeignKey(ticket => ticket.UserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Ticket>()
                .HasOne(ticket => ticket.Equipment)
                .WithMany(equipment => equipment.Tickets)
                .HasForeignKey(ticket => ticket.EquipmentId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Associate>()
                .HasKey(associate => associate.Id);
            modelBuilder.Entity<Associate>()
                .HasOne(associate => associate.User)
                .WithMany(user => user.Associates)
                .HasForeignKey(associate => associate.UserId);
            modelBuilder.Entity<Associate>()
                .HasOne(associate => associate.Ticket)
                .WithMany(ticket => ticket.Associates)
                .HasForeignKey(associate => associate.TicketId);

            modelBuilder.Entity<Customer>()
                .HasKey(customer => customer.Id);

            modelBuilder.Entity<Equipment>()
                .HasKey(equipment => equipment.Id);
            modelBuilder.Entity<Equipment>()
                .HasOne(equipment => equipment.Customer)
                .WithMany(customer => customer.Equipments)
                .HasForeignKey(equipment => equipment.CustomerId);

            modelBuilder.Entity<Tasks>()
                .HasKey(task => task.Id);
            modelBuilder.Entity<Tasks>()
                .HasOne(task => task.Ticket)
                .WithMany(ticket => ticket.Tasks)
                .HasForeignKey(task => task.TicketId);

            modelBuilder.Entity<TicketComment>()
                .HasKey(ticketcomment => ticketcomment.Id);
            modelBuilder.Entity<TicketComment>()
                .HasOne(ticketcomment => ticketcomment.Ticket)
                .WithMany(ticket => ticket.TicketComments)
                .HasForeignKey(ticketcomment => ticketcomment.TicketId);

            modelBuilder.Entity<TicketStatusLog>()
                .HasKey(ticketstatuslog => ticketstatuslog.Id);
            modelBuilder.Entity<TicketStatusLog>()
                .Property(ts => ts.TicketStatus)
                .HasConversion(new EnumToStringConverter<TicketStatus>());
            modelBuilder.Entity<TicketStatusLog>()
                .HasOne(ticketstatuslog => ticketstatuslog.Ticket)
                .WithMany(ticket => ticket.TicketStatusLogs)
                .HasForeignKey(ticketstatuslog => ticketstatuslog.TicketId);

            modelBuilder.Entity<TicketStatusLog>()
                .HasOne(ticketstatuslog => ticketstatuslog.User)
                .WithMany()
                .HasForeignKey(ticketstatuslog => ticketstatuslog.UserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasKey(user => user.Id);

        }
        #endregion


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Tasks> Tasklist { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Associate> Associates { get; set; }
        public DbSet<TicketComment> TicketComments { get; set; }
        public DbSet<TicketStatusLog> TicketStatusLogs { get; set; }

    }
}

