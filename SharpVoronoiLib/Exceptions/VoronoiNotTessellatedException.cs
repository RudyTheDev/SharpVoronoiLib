using System;

namespace SharpVoronoiLib.Exceptions;

public class VoronoiNotTessellatedException : Exception
{
    public VoronoiNotTessellatedException()
        : base("This data is not ready yet, you must tessellate the plane first.")
    {
            
    }
}