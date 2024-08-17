using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Views_Example.Models
{
    public class IdentityModels
    {
    }

    public class ApplicationUser : IdentityUser
    {
        // Additional properties for user profile, if any
        // Example: public string FullName { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            return userIdentity;
        }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> //IdentityDBcontext gi kreira site tabeli sto se odgovorni za cuvanje na podatoci, mora da nasleduva
    {

        //nie dodavame - tabeli za modelite sto gi kreairavme nie 

        //ja pretstavuva tabelata na izveduvaci Artist vo bazata
        public DbSet<Artist> Artists { get; set; }

        //ja pretstavuva tabelata na zanrovi vo bazata

        public DbSet<Genre> Genres { get; set; }

        //ja pretstavuva tabelata na albumi vo bazata

        public DbSet<Album> Albums { get; set; }



        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // DbSet properties for additional entities, if any
        // Example: public DbSet<YourEntity> YourEntities { get; set; }
    }
}