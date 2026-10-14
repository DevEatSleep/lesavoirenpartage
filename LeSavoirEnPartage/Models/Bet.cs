namespace LeSavoirEnPartage.Models;

/// <summary>Un pari sur une affirmation : la réponse donnée, la confiance (50-100) et si elle était juste.</summary>
public sealed class Bet
{
    public bool Answer { get; set; }
    public int Confidence { get; set; } = 50;
    public bool Correct { get; set; }
}
