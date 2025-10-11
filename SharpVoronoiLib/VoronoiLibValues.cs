namespace SharpVoronoiLib;

/// <summary>
/// Various values as used by the library in case external uses need to know about these.
/// </summary>
public static class VoronoiLibValues
{
    /// <summary>
    /// The epsilon value used by the library for floating point comparisons.
    /// Note that a lot of internal logic also applies complex mathematical operations first,
    /// so the effective precision may be less than this value.
    /// It is recommended to use computed the library's instances (cells, edges, etc.)
    /// rather than relying on checking coordinates directly.
    /// </summary>
    public const double epsilon = EpsilonUtils.epsilon;
}