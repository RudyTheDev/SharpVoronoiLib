using System;

namespace SharpVoronoiLib.Exceptions;

public class VoronoiDoesntHaveSitesException : Exception
{
    public VoronoiDoesntHaveSitesException()
        : base("This data is not ready yet, you must add sites to the plane first.")
    {
            
    }
}