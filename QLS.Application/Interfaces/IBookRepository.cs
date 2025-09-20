using QLS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLS.Application.Interfaces
{
  public interface IBookRepository
  {
    // AddAsync theo quy tắt đặt tên là phải có Async
    // nếu nó có sử dụng cơ chế bất đồng bộ
    Task AddAsync(Book book);
    Task<List<Book>> GetAllAsync();
    Task<Book?> GetByIdAsync(int id);
    Task UpdateAsync(Book book);
  }
}
