using Microsoft.EntityFrameworkCore;
using QLS.Application.Interfaces;
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

    public BookRepository(IDbContextFactory<QLSDbContext> db)
    {
      _db = db.CreateDbContext();
    }

  }
}
