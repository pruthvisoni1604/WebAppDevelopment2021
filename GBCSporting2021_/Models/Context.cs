using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Incident> Incidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, Name = "Canada" },
                new Country { CountryId = 2, Name = "India" },
                new Country { CountryId = 3, Name = "America" },
                new Country { CountryId = 4, Name = "Maxico" },
                new Country { CountryId = 5, Name = "Pakistan" },
                new Country { CountryId = 6, Name = "Russia" },
                new Country { CountryId = 7, Name = "China" }
                );
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Firstname = "Sahay",
                    Lastname = "Patel",
                    Address = "45, King Road Street",
                    City = "Toronto",
                    State = "Ontario",
                    Postalcode = "M1T5Y8",
                    Email = "Sahay.Patel123@domain.com",
                    CountryId = 1,
                    Phone = "123-456-7890"
                },
                new Customer
                {
                    CustomerId = 2,
                    Firstname = "Rutik",
                    Lastname = "Patel",
                    Address = "20, bobcat terr",
                    City = "Ahmedabad",
                    State = "Gujrat",
                    Postalcode = "M1B5C9",
                    Email = "Rutik.Patel123@domain.com",
                    CountryId = 2,
                    Phone = "145-895-7945"
                },
                new Customer
                {
                    CustomerId = 3,
                    Firstname = "Namya",
                    Lastname = "Patel",
                    Address = "20, bobcat terr",
                    City = "Toronto",
                    State = "Ontario",
                    Postalcode = "M1B5C9",
                    Email = "Namya.Patel123@domain.com",
                    CountryId = 1,
                    Phone = "458-985-9658"
                },
                new Customer
                {
                    CustomerId = 4,
                    Firstname = "Pruthvi",
                    Lastname = "Soni",
                    Address = "9, Buckhurt street",
                    City = "Utica",
                    State = "Newyork",
                    Postalcode = "M8H8Y9",
                    Email = "Pruthvi.Soni897@domain.com",
                    CountryId = 3,
                    Phone = "458-987-9696"
                },
                new Customer
                {
                    CustomerId = 5,
                    Firstname = "Vishwa",
                    Lastname = "Mavani",
                    Address = "78, Queen Rode",
                    City = "Brampton",
                    State = "Ontario",
                    Postalcode = "M1U7O5",
                    Email = "Sahay.Patel123@domain.com",
                    CountryId = 1,
                    Phone = "123-456-7777"
                },
                new Customer
                {
                    CustomerId = 6,
                    Firstname = "Harsh",
                    Lastname = "Raval",
                    Address = "85, york residency",
                    City = "Mumbai",
                    State = "Maharastra",
                    Postalcode = "F5Y7U6",
                    Email = "Harsh.Raval999@domain.com",
                    CountryId = 2,
                    Phone = "898-456-8890"
                },
                new Customer
                {
                    CustomerId = 7,
                    Firstname = "Vatsal",
                    Lastname = "Bhavani",
                    Address = "65, strong trr",
                    City = "Toronto",
                    State = "Ontario",
                    Postalcode = "M1T5P5",
                    Email = "Vatsal3@domain.com",
                    CountryId = 1,
                    Phone = "123-999-7890"
                }
                );
            modelBuilder.Entity<Technician>().HasData(
                new Technician
                {
                    TechnicianId = 1,
                    Technicianname = "Mickle Robert",
                    Technicianemail = "MickleRobert@domain.com",
                    Technicianphone = "897-897-8979"
                },
                new Technician
                {
                    TechnicianId = 2,
                    Technicianname = "Palak Vyas",
                    Technicianemail = "PalakVyas@domain.com",
                    Technicianphone = "123-123-1231"
                },
                new Technician
                {
                    TechnicianId = 3,
                    Technicianname = "",
                    Technicianemail = "MickleRobert@domain.com",
                    Technicianphone = "897-897-8979"
                },
                new Technician
                {
                    TechnicianId = 4,
                    Technicianname = "Mickle Robert",
                    Technicianemail = "MickleRobert@domain.com",
                    Technicianphone = "897-897-8979"
                },
                new Technician
                {
                    TechnicianId = 5,
                    Technicianname = "Deepakar Mukhraji",
                    Technicianemail = "DeepakarMukhraji@domain.com",
                    Technicianphone = "147-147-1474"
                },
                new Technician
                {
                    TechnicianId = 6,
                    Technicianname = "Malhar Dave",
                    Technicianemail = "MalharDave@domain.com",
                    Technicianphone = "456-456-4564"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Code = "TRM789",
                    Productname = "Tournament Master",
                    Productprice = 8.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 2,
                    Code = "AT564",
                    Productname = "Accont Tracker",
                    Productprice = 7.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 3,
                    Code = "CR50",
                    Productname = "Class Reminder 5.0",
                    Productprice = 2.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 4,
                    Code = "PS9",
                    Productname = "Project Scheduler",
                    Productprice = 8.00,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 5,
                    Code = "ST30",
                    Productname = "schedule tracker 3.0",
                    Productprice = 4.89,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 6,
                    Code = "TRYT789",
                    Productname = "Draft Manager 2.0",
                    Productprice = 7.69,
                    ReleaseDate = DateTime.Now
                }
                );
            modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    IncidentId = 1,
                    CustomerId = 5,
                    ProductId = 2,
                    title = "Error in launching program",
                    Description = "Program fail with error code 510, unable to open database",
                    TechnicianId = 2,
                    Dateopened = DateTime.Now,
                    Dateclosed = ""
                },
                new Incident
                {
                    IncidentId = 2,
                    CustomerId = 3,
                    ProductId = 2,
                    title = "Error in launching program",
                    Description = "Program fail with error code 510, unable to open database",
                    TechnicianId = 2,
                    Dateopened = DateTime.Now,
                    Dateclosed = ""
                },
                new Incident
                {
                    IncidentId = 3,
                    CustomerId = 4,
                    ProductId = 5,
                    title = "Error while choose exit option",
                    Description = "404 error when chooose exit option and can not exit",
                    TechnicianId = 4,
                    Dateopened = DateTime.Now,
                    Dateclosed = ""
                },
                new Incident
                {
                    IncidentId = 4,
                    CustomerId = 3,
                    ProductId = 4,
                    title = "Error in all project showing ",
                    Description = "database can not load when choose show all project",
                    TechnicianId = 6,
                    Dateopened = DateTime.Now,
                    Dateclosed = ""
                },
                new Incident
                {
                    IncidentId = 5,
                    CustomerId = 6,
                    ProductId = 6,
                    title = "Error in draft track 2.0",
                    Description = "Some time draft can not be tracked",
                    TechnicianId = 6,
                    Dateopened = DateTime.Now,
                    Dateclosed = ""
                },
                new Incident
                {
                    IncidentId = 6,
                    CustomerId = 3,
                    ProductId = 3,
                    title = "Error in setting Class",
                    Description = "Get Error in setting class for reminder",
                    TechnicianId = 4,
                    Dateopened = DateTime.Now,
                    Dateclosed = ""
                }
                );


        }
    }
}
