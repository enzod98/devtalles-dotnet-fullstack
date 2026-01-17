using System;
using MediatR;

namespace TechNotes.Application.Notes.GetNoteById;

public class GetNoteByIdQuery : IRequest<NoteResponse?>
{
    public required int Id { get; set; }
}
