namespace SharpVoronoiLib.Exceptions;

public class VoronoiSiteNotClosedException() 
    : Exception("The requested operation relies on this site being closed, i.e. having all edges form a loop.");