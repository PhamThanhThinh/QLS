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
  }
}
