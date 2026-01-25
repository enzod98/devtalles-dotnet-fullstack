namespace TechNotes.Application.Notes.UpdateNote;

public class UpdateNoteCommandHandler : ICommandHandler<UpdateNoteCommand, NoteResponse?>
{
    private readonly INoteRepository _noteRepository;
    public UpdateNoteCommandHandler(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }
    public async Task<Result<NoteResponse?>> Handle(UpdateNoteCommand request, CancellationToken cancellationToken)
    {
        var noteToUpdate = request.Adapt<Note>();
        var updatedNote = await _noteRepository.UpdateNoteAsync(noteToUpdate);
        return updatedNote is null 
                    ? Result.Fail<NoteResponse?>("No se pudo actualizar") 
                    : updatedNote.Adapt<NoteResponse>();

    }
}
