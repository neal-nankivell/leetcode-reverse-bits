using NUnit.Framework;
using Answer;

namespace Tests
{
    public class SolutionTests
    {
        [TestCase((uint)43261596, ExpectedResult = (uint)964176192)]
        [TestCase((uint)964176192, ExpectedResult = (uint)43261596)]
        public uint ReverseBits(uint n)
        {
            var sut = new Solution();
            return sut.reverseBits(n);
        }
    }
}