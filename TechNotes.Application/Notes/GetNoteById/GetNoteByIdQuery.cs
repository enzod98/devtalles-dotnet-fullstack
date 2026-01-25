namespace TechNotes.Application.Notes.GetNoteById;

public class GetNoteByIdQuery : IQuery<NoteResponse?>
{
    public required int Id { get; set; }
}
