using Microsoft.EntityFrameworkCore;
using QLS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLS.Infrastructure.Data
{
  public class QLSDbContext : DbContext
  {
    public QLSDbContext(DbContextOptions<QLSDbContext> options)
      : base(options) { }

    public DbSet<Book> Books { get; set; }

    // có thể không cần cũng được
    // code được generate bởi AI ChatGPT
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //  // Cấu hình entity Book
    //  modelBuilder.Entity<Book>(entity =>
    //  {
    //    // Đặt tên bảng
    //    entity.ToTable("Books");

    //    // Khóa chính
    //    entity.HasKey(e => e.Id);

    //    // Thuộc tính Title
    //    entity.Property(e => e.Title)
    //          .IsRequired()            // bắt buộc nhập
    //          .HasMaxLength(100);      // tối đa 100 ký tự

    //    // Thuộc tính Author
    //    entity.Property(e => e.Author)
    //          .IsRequired()
    //          .HasMaxLength(100);
    //  });
    //}

  }
}
