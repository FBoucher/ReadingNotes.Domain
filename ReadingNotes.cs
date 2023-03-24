namespace ReadingNotes.Domain;

public class ReadingNotes
{
    public ReadingNotes(int number)
    {
        this.Number = number;
        this.Title = $"Reading Notes #{number}";
        this.NoteGroups = new List<ReadingNoteGroup>();
    }
    public int Number { get; set; }
    public string  Title { get; set; } = string.Empty;
    public string  Filename { get; set; } = string.Empty;
    public string Tags { get; set; } = string.Empty;
    public string Intro { get; set; } = string.Empty;
    public List<ReadingNoteGroup> NoteGroups { get; set; }
}