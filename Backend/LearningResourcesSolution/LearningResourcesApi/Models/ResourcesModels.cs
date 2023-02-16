using LearningResourcesApi.Domain;
using System.ComponentModel.DataAnnotations;

namespace LearningResourcesApi.Models;

public record GetResourcesResponse
{
    public List<GetResourceItem> Items { get; init; } = new();

}

public record GetResourceItem
{
    public string Id { get; init; } = "";
    public string Description { get; init; } = "";
    public LearningItemType Type { get; init; }
    public string Link { get; init; } = "";
}

public record CreateResourceItem
{
    [Required]
    public string Description { get; init; } = "";
    [Required]
    public LearningItemType Type { get; init; }
    // Still want to add validation checks here, never trust anything from the client! Check it on the server side
    [Required, MaxLength(100), MinLength(5)]
    public string Link { get; init; } = "";
}
