using System.Text;
using System.Text.Json;

namespace ReadingNotes.Domain;

    public class ReadingNote
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? DateAdded { get; set; }
        public string? Tags { get; set; }
        public string? Comment { get; set; }
        public string? Url { get; set; }
        public string? Category { get; set; }
        public string? ToMarkDown()
        {

            var md = new StringBuilder();               

            md.AppendFormat("{0}- ", Environment.NewLine);
            if (!string.IsNullOrEmpty(Url))
            {
                md.AppendFormat("**[{0}]({1})** ", Title, Url);
            }
            else {
                md.AppendFormat("**[{0}](#)** ", Title);
            }

            if (!string.IsNullOrEmpty(Author))
                md.AppendFormat(" ({0}) ", Author);

            md.AppendFormat("- {0}", Comment);

            return md.ToString();
        }


        public static ReadingNote CreateFromString(string DeserializeObj)
        {
            return JsonSerializer.Deserialize<ReadingNote>(DeserializeObj, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }