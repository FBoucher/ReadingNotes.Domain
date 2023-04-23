
using System.Runtime.Serialization;
using Azure.Data.Tables;
using ReadingNotes.Domain;

public class Summary : ITableEntity
{
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public Azure.ETag ETag { get; set; }
    public DateTimeOffset? Timestamp { get; set; }

    [DataMember(Name = "id")]
    public string Id { get; set; }
    
    [DataMember(Name = "title")]
    public string? Title { get; set; }

  [DataMember(Name = "filename")]
  public string? FileName { get; set; }

    [DataMember(Name = "isgenerated")]
  public string? IsGenerated { get; set; }

[IgnoreDataMember]
  public RNotes? RNotes { get; set; }
}