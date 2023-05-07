using System.Collections.Generic;

namespace ReadingNotes.Domain;

/// <summary>
/// Notes Categories
/// </summary>
public static class NoteCategories
{
    public static Dictionary<string, string> Category = new Dictionary<string, string>{
                                                        {"cloud", "Cloud"},
                                                        {"data", "Data"},
                                                        {"database", "Databases"},
                                                        {"dev", "Programming"},
                                                        {"devops", "DevOps"},
                                                        {"misc", "Miscellaneous"},
                                                        {"oss", "Open Source"},
                                                        {"pp", "Power Platform"},
                                                        {"top", "Suggestion of the week"},
                                                        {"del", "del"}
                                                    };
    /// <summary>
    /// Get a dictionary to change the short version by the long version of category name.
    /// </summary>
    public static string GetCategories(string? category)
    {
        if (!String.IsNullOrEmpty(category) && Category.ContainsKey(category))
        {
            return Category[category];
        }
        else
        {
            return Category["misc"];
        }
    }
}

