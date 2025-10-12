namespace SharpVoronoiLib.Exceptions;

public class VoronoiDoesntHaveSitesException() 
    : Exception("This data is not ready yet, you must add sites to the plane first.");