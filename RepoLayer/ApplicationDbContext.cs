using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Define your entities as DbSet properties here
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<SessionEntity> Sessions { get; set; }
        public DbSet<QuestionDifficultyEntity> Question_Difficulty_Levels { get; set; }
        public DbSet<TestFormatEntity> Test_Format { get; set; }
        public DbSet<TopicEntity> Topics { get; set; }
        public DbSet<QuestionEntity> Questions { get; set; }
        public DbSet<CampaignEntity> Campaigns { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TopicEntity>()
                .HasMany(t => t.Questions)
                .WithOne(q => q.Topic)
                .HasForeignKey(q => q.Id);
        }
    }
}
