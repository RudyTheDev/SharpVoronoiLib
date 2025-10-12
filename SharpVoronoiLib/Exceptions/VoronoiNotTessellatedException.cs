namespace SharpVoronoiLib.Exceptions;

public class VoronoiNotTessellatedException() 
    : Exception("This data is not ready yet, you must tessellate the plane first.");