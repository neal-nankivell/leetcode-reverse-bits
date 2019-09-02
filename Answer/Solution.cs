using System.Linq;

namespace Answer
{
    // Reverse bits of a given 32 bits unsigned integer.
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;

            foreach (int i in Enumerable.Range(0, 32))
            {
                var bit = (uint)1 << i;
                if ((n & bit) == bit)
                {
                    result |= ((uint)1 << 31) >> i;
                }
            }

            return result;
        }
    }
}
