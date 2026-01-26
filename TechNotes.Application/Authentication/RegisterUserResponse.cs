using System;

namespace TechNotes.Application.Authentication;

public class RegisterUserResponse
{
    public bool Succeded { get; set; }
    public List<string> Errors { get; set; } = new();
}
