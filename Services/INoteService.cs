﻿using LibraryProject.Models;

namespace LibraryProject.Services
{
    public interface INoteService
    {
        Task<Note> GetNoteByIdAsync(int id);
        Task<IEnumerable<Note>> GetAllNotesAsync();
        Task AddNoteAsync(Note note);
        Task UpdateNoteAsync(Note note);
        Task DeleteNoteAsync(int id);
    }
}
