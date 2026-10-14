namespace LeSavoirEnPartage.Models;

public sealed class Journey
{
    public required string Id { get; init; }
    public required string Title { get; init; }
    public required string Question { get; init; }
    public required string Description { get; init; }
    public required string Category { get; init; }
    public required string Icon { get; init; }
    public required string WikipediaUrl { get; init; }
    public required string EnglishUrl { get; init; }
    public required string SpanishUrl { get; init; }
    public required string SecondarySourceName { get; init; }
    public required string SecondarySourceUrl { get; init; }
    public required string[] Paths { get; init; }
    public required string[] PathQuestions { get; init; }
    public required string[] PathSourceUrls { get; init; }
    public required string[] PathSourceUrlsEnglish { get; init; }
    public required string[] PathSourceUrlsSpanish { get; init; }
    public required string[] PathFacts { get; init; }
    public required string[] PathFactSourceNames { get; init; }
    public required string[] PathFactSourceUrls { get; init; }
    public required string[] PathClaims { get; init; }
    public required bool[] PathClaimTruths { get; init; }
}
