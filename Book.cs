using System.Text.Json.Serialization;

public class Book
{
    [JsonIgnore]
    public int PublishingHouseId { get; set; }

    [JsonPropertyName("Title")]
    public string Title { get; set; }

    public PublishingHouse PublishingHouse { get; set; }
}
