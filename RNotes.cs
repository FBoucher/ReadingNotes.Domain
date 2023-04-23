using System.Collections;

namespace ReadingNotes.Domain;

public class RNotes
{
    public RNotes(string number)
    {
        this.Number = number;
        this.Title = $"Reading Notes #{number}";
        this.Notes = new Dictionary<string, List<Note>>();
    }
    public string Number { get; set; }
    public string  Title { get; set; } = string.Empty;
    public string Tags { get; set; } = string.Empty;
    public string Intro { get; set; } = string.Empty;
    public Dictionary<string, List<Note>> Notes { get; set; }
}