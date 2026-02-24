namespace SharpVoronoiLib.Exceptions;

public class VoronoiRandomPointGenerationEncounteredTooManyInvalidSites() 
    : NullReferenceException("While generating random points for sites, the algorithm encountered too many invalid site points. " +
                             "This is likely an issue with the random point generation algorithm.");