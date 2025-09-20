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

    private string? _title;
    // tiêu đề cuốn sách: Title/BookName
    [Required(ErrorMessage = "Vui lòng điền thông tin tiêu đề cuốn sách")]    
    [MaxLength(100)]
    public string? Title
    { 
      get => _title;
      set => _title = value?.Trim(); 
    }

    private string? _author;
    // tác giả
    [MaxLength(100)]
    [Required(ErrorMessage = "Vui lòng điền thông tin tác giả")]
    public string? Author
    { 
      get => _author;
      set => _author = value?.Trim();
    }
    // ngày xuất bản
    [Required(ErrorMessage = "Vui lòng điền thông tin ngày xuất bản")]
    public DateTime? PublishDate { get; set; }
    // danh mục sách
    [EnumDataType(typeof(Category), ErrorMessage = "Vui lòng chọn danh mục")]
    public Category Category { get; set; }
  }
}
