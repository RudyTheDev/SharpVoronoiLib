using System.Collections.Generic;

namespace SharpVoronoiLib
{
    internal class FortuneEventComparer : IComparer<FortuneEvent>
    {
        internal static FortuneEventComparer Instance { get; } = new FortuneEventComparer(); 
        private FortuneEventComparer() { }


        public int Compare(FortuneEvent? a, FortuneEvent? b)
        {
            if (ReferenceEquals(a, b))
                return 0;
            
            int c = a!.Y.ApproxCompareTo(b!.Y);
            
            if (c == 0)
                c = a.X.ApproxCompareTo(b.X);

            if (c == 0)
                c = a.DuplicateCounter.CompareTo(b.DuplicateCounter);
            
            return c;
        }
    }
}