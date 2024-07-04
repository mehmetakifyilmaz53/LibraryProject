﻿using LibraryProject.Data;
using LibraryProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryProject.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LbContext _context;

        public BookRepository(LbContext context)
        {
            _context = context;
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task AddBookAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }
    }
}
