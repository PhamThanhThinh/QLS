using QLS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLS.Domain.Entities
{
  public class Book
  {
    [Key]
    public int Id { get; set; }
    // tiêu đề cuốn sách: Title/BookName
    [Required]    
    [MaxLength(100)]
    public string? Title { get; set; }
    // tác giả
    [Required]
    [MaxLength(100)]
    public string? Author { get; set; }
    // ngày xuất bản
    public DateTime? PublishDate { get; set; }
    public Category Category { get; set; }
  }
}
