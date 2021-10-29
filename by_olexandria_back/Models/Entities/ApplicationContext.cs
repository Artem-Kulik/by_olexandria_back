using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Entities
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public virtual DbSet<UserAdditionalInfo> UserAdditionalInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasOne(ui => ui.UserAdditionalInfo)
                .WithOne(u => u.User)
                .HasForeignKey<UserAdditionalInfo>();

            builder.Entity<Worship>()
                .HasOne(wor => wor.SongsCollection)
                .WithOne(w => w.Worship)
                .HasForeignKey<SongsCollection>();

            base.OnModelCreating(builder);
        }
        public virtual DbSet<Worship> Worships { get; set; }
        public virtual DbSet<WorshipType> WorshipTypes { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<SongsCollection> SongsCollections { get; set; }
        public virtual DbSet<Song_SongsCollection> Song_SongsCollections { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}
