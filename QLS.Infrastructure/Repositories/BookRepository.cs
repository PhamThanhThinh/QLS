using Microsoft.EntityFrameworkCore;
using QLS.Application.Interfaces;
using QLS.Domain.Entities;
using QLS.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLS.Infrastructure.Repositories
{
  public class BookRepository : IBookRepository
  {
    // constructor
    private readonly QLSDbContext _db;

    //public BookRepository(QLSDbContext db)
    //{
    //  _db = db;
    //}

    // service có vòng đời lifecycle dài hơn
    public BookRepository(IDbContextFactory<QLSDbContext> db)
    {
      _db = db.CreateDbContext();
    }

    public async Task AddAsync(Book book)
    {
      _db.Books.Add(book);
      await _db.SaveChangesAsync();
    }

    public async Task<List<Book>> GetAllAsync()
    {
      var books = await _db.Books.ToListAsync();
      return books;
    }

    public async Task<Book?> GetByIdAsync(int id)
    {
      var book = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);
      return book;
    }

    //public async Task UpdateAsync(Book book)
    //{
    //  _db.Entry(book).State = EntityState.Modified;
    //  await _db.SaveChangesAsync();
    //}
    public async Task UpdateAsync(Book book)
    {
      if (book == null)
        throw new ArgumentNullException(nameof(book));

      var existingBook = await _db.Books.FindAsync(book.Id);
      if (existingBook == null)
        throw new KeyNotFoundException($"Book with id {book.Id} not found");

      // Cập nhật từng field cần thiết
      _db.Entry(existingBook).CurrentValues.SetValues(book);

      await _db.SaveChangesAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
      var book = await GetByIdAsync(id);

      if (book is not null)
      {
        _db.Books.Remove(book);
        await _db.SaveChangesAsync();
      }

    }

  }
}
