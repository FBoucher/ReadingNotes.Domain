using System.Collections.Generic;

namespace ReadingNotes.Domain;

/// <summary>
/// Notes Categories
/// </summary>
public static class NoteCategories
{
    /// <summary>
    /// Get a dictionary to change the short version by the long version of category name.
    /// </summary>
    public static readonly Dictionary<string, string> GetCategories = new Dictionary<string, string>
        {
            {"cloud", "Cloud"},
            {"data", "Data"},
            {"database", "Databases"},
            {"dev", "Programming"},
            {"devops", "DevOps"},
            {"misc", "Miscellaneous"},
             {"top", "Suggestion of the week"},
              {"oss", "Open Source"}
        };
}