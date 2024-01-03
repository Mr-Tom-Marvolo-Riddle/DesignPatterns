using System.Diagnostics;

namespace QuickFind
{
    [DebuggerDisplay("{Start} -> {End}")]
    internal class Union
    {
        public int Start { get; set; }
        public int End { get; set; }
    }
}