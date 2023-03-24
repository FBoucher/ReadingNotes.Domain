namespace ReadingNotes.Domain;

public class ReadingNoteGroup
{
    ReadingNoteGroup(string category)
    {
        this.Category = category;
        Notes = new List<ReadingNote>();
    }
    public string Category { get; set; }
    public List<ReadingNote> Notes { get; set; }
}