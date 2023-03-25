using System.Collections;

namespace ReadingNotes.Domain;

public class Notes
{
    public Notes(int number)
    {
        this.Number = number;
        this.Title = $"Reading Notes #{number}";
        this.NoteGroups = new Dictionary<string, List<Note>>();
    }
    public int Number { get; set; }
    public string  Title { get; set; } = string.Empty;
    public string  Filename { get; set; } = string.Empty;
    public string Tags { get; set; } = string.Empty;
    public string Intro { get; set; } = string.Empty;
    public Dictionary<string, List<Note>> NoteGroups { get; set; }
}