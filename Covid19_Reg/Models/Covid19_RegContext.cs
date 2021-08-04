using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Covid19_Reg.Models
{
    public partial class Covid19_RegContext : DbContext
    {
        public Covid19_RegContext()
        {
        }

        public Covid19_RegContext(DbContextOptions<Covid19_RegContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DailyCheckin> DailyCheckins { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-0EP1O0UN\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Covid19_Reg;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<DailyCheckin>(entity =>
            {
                entity.ToTable("DailyCheckin");

                //Id为自增主键，要注意在设计表的时候：标识规范：是
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("Id");

                entity.Property(e => e.ChangedContent)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("User");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .HasColumnName("User_Name")
                    .IsFixedLength(true);

                entity.Property(e => e.UserDept)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("User_Dept")
                    .IsFixedLength(true);

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("User_Email")
                    .IsFixedLength(true);

                entity.Property(e => e.UserPasswd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("User_Passwd")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
