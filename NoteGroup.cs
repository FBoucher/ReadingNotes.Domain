namespace ReadingNotes.Domain;

public class ReadingNoteGroup
{
    ReadingNoteGroup(string category)
    {
        this.Category = category;
        Notes = new List<Note>();
    }
    public string Category { get; set; }
    public List<Note> Notes { get; set; }
}