namespace TechNotes.Application.Notes;

public record struct NoteResponse(
    int Id,
    string Title,
    String? Content,
    DateTime PublishedAt,
    bool IsPublished,
    DateTime CreatedAt
);
