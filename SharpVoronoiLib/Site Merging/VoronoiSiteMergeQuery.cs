namespace SharpVoronoiLib;

/// <summary>
/// Defines the signature for <see cref="ISiteMergingAlgorithm"/> query callback to user code.
/// This basically asks the question - should these two sites be merged into one (and which one)?
/// </summary>
public delegate VoronoiSiteMergeDecision VoronoiSiteMergeQuery(VoronoiSite site1, VoronoiSite site2);


public enum VoronoiSiteMergeDecision
{
    DontMerge,
    MergeIntoSite1,
    MergeIntoSite2
}