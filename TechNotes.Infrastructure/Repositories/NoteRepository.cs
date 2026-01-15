using System;
using Microsoft.EntityFrameworkCore;
using TechNotes.Domain.Notes;

namespace TechNotes.Infrastructure.Repositories;

public class NoteRepository : INoteRepository
{
    private readonly ApplicationDbContext _context;
    public NoteRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<Note>> GetAllAsync()
    {
        return await _context.Notes.ToListAsync();
    }
}
