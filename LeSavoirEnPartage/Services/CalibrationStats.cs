using LeSavoirEnPartage.Models;

namespace LeSavoirEnPartage.Services;

public enum CalibrationVerdict { NotEnoughData, Overconfident, Underconfident, WellCalibrated }

/// <summary>Compare la confiance exprimée (moyenne) et le taux de réussite réel.</summary>
public sealed record CalibrationStats(int Count, int Hits, double AverageConfidence, double HitRate, CalibrationVerdict Verdict)
{
    public const int MinimumBets = 3;
    public const double Tolerance = 0.10;

    public static CalibrationStats From(IReadOnlyCollection<Bet> bets)
    {
        if (bets.Count == 0) return new CalibrationStats(0, 0, 0, 0, CalibrationVerdict.NotEnoughData);
        var hits = bets.Count(b => b.Correct);
        var confidence = bets.Average(b => b.Confidence) / 100.0;
        var hitRate = (double)hits / bets.Count;
        var gap = confidence - hitRate;
        var verdict = bets.Count < MinimumBets ? CalibrationVerdict.NotEnoughData
            : gap > Tolerance ? CalibrationVerdict.Overconfident
            : gap < -Tolerance ? CalibrationVerdict.Underconfident
            : CalibrationVerdict.WellCalibrated;
        return new CalibrationStats(bets.Count, hits, confidence, hitRate, verdict);
    }
}
