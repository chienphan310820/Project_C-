using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OnlineEduDB
{
    public partial class MyDB : DbContext
    {
        public MyDB()
            : base("name=MyDB")
        {
        }

        public virtual DbSet<Active> Active { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Chapter> Chapter { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Description> Description { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<MyCourse> MyCourse { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Video> Video { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Active>()
                .Property(e => e.ActiveID)
                .IsUnicode(false);

            modelBuilder.Entity<Active>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Active>()
                .HasMany(e => e.Course)
                .WithRequired(e => e.Active)
                .HasForeignKey(e => e.Active_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Chapter>()
                .Property(e => e.ChapterID)
                .IsUnicode(false);

            modelBuilder.Entity<Chapter>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Chapter>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Chapter>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Chapter>()
                .HasMany(e => e.Video)
                .WithRequired(e => e.Chapter)
                .HasForeignKey(e => e.Chapter_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.CourseID)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.CourseName)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Active_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Category)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Chapter)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Description)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Images)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.MyCourse)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Description>()
                .Property(e => e.DescriptonTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Description>()
                .Property(e => e.Description1)
                .IsUnicode(false);

            modelBuilder.Entity<Description>()
                .Property(e => e.ShortTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Description>()
                .Property(e => e.ShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Description>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Images>()
                .Property(e => e.Image_url)
                .IsUnicode(false);

            modelBuilder.Entity<Images>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MyCourse>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.Role_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Age)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Url_Image)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Course)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.Teacher_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Course_ID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MyCourse)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.Video_url)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.Chapter_ID)
                .IsUnicode(false);
        }
    }
}
