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
    public static string GetCategories(string? category)
    {
        var categories = new Dictionary<string, string>
                                                    {
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
        if (!String.IsNullOrEmpty(category) && categories.ContainsKey(category))
        {
            return categories[category];
        }
        else
        {
            return categories["misc"];
        }
    }
}