using System.Text;
using System.Text.Json;

namespace ReadingNotes.Domain;

public class Note
{
    /// <summary>
    /// Title of the post
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// If available name of the author. If multiple author they will be comma separated.
    /// </summary>
    public string? Author { get; set; }
    public string? DateAdded { get; set; }

    /// <summary>
    /// Keywords separated by a ".". The first one will by used as <see cref="ReadingNote.Category"/>. 
    /// </summary>
    public string? Tags { get; set; }
    public string? Comment { get; set; }
    public string? Url { get; set; }

    private string _category = String.Empty;

    ///<summary>
    /// Set using the first  <see cref="Note.Tags"/> and part of the  <see cref="NoteCategories"/> 
    /// </summary>
    public string Category
    {
        get
        {
            if (String.IsNullOrEmpty(_category))
            {
                _category = this.GetCategory();
            }
            return _category;
        }
        set{_category = value;}
    }




    public string? ToMarkDown()
    {

        var md = new StringBuilder();

        md.AppendFormat("{0}- ", Environment.NewLine);
        if (!string.IsNullOrEmpty(Url))
        {
            md.AppendFormat("**[{0}]({1})** ", Title, Url);
        }
        else
        {
            md.AppendFormat("**[{0}](#)** ", Title);
        }

        if (!string.IsNullOrEmpty(Author))
            md.AppendFormat(" ({0}) ", Author);

        md.AppendFormat("- {0}", Comment);

        return md.ToString();
    }


    public static Note? CreateFromString(string DeserializeObj)
    {
        return JsonSerializer.Deserialize<Note>(DeserializeObj, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    private string GetCategory()
    {
        string category = "misc";
        string noteCategories = string.Empty;

        if (!String.IsNullOrEmpty(this.Tags))
        {
            var newListTgas = this.Tags.Split('.');

            category = NoteCategories.GetCategories(newListTgas[0]);
        }

        return NoteCategories.GetCategories(category);
    }
}