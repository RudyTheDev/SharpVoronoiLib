namespace SharpVoronoiLib.UnitTestGenerator;

/// <summary>
/// How the layout should be transformed and repeated in the generated tests.
/// Basically, if the test is not symmetric, then we can also easily test the other rotations and mirrors of the layout.
/// </summary>
public enum LayoutTransform
{
    None,
    Rotate90,
    Rotate180,
    Rotate270,
    Mirror,
    MirrorAndRotate90,
    MirrorAndRotate180,
    MirrorAndRotate270,
}