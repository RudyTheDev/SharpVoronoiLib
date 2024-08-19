using System.Collections.Generic;

namespace SharpVoronoiLib
{
    internal class FortuneEventComparer : IComparer<FortuneEvent>
    {
        internal static FortuneEventComparer Instance { get; } = new FortuneEventComparer(); 
        private FortuneEventComparer() { }


        public int Compare(FortuneEvent? a, FortuneEvent? b)
        {
            int c = a!.Y.ApproxCompareTo(b!.Y);
            return c == 0 ? a.X.ApproxCompareTo(b.X) : c;
        }
    }
}