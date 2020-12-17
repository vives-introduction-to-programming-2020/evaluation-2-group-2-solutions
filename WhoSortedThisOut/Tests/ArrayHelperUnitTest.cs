using System;
using WhoSortedThisOut;
using Xunit;

namespace Tests
{
    public class ArrayHelperUnitTest
    {
        private ArrayHelper helper = new ArrayHelper();

        [Fact]
        public void TestMaximum()
        {
            Assert.Equal(2, helper.Maximum(new int[] { 8, 12, 23, 0, -1 }));
            Assert.Equal(4, helper.Maximum(new int[] { 12, -93, 8, 0, 93, 9, 11 }));
            Assert.Equal(6, helper.Maximum(new int[] { 0, 1, 2, 3, 4, 5, 6 }));
            Assert.Equal(0, helper.Maximum(new int[] { 6, 5, 4, 3, 2, 1, 0 }));
        }

        [Fact]
        public void TestMaximumEmptyArray()
        {
            Assert.Equal(-1, helper.Maximum(new int[] { }));
        }

        [Fact]
        public void TestSortedAscending()
        {
            Assert.True(helper.IsSortedAscending(new int[] { -1, 4, 6, 89, 101, 232 }));
            Assert.False(helper.IsSortedAscending(new int[] { -12, 4, 6, 89, 1, 232 }));
            Assert.False(helper.IsSortedAscending(new int[] { 1, 4, 6, 89, 101, 23 }));
            Assert.False(helper.IsSortedAscending(new int[] { 1, 4, 6, 89, 101, 232, 0 }));
            Assert.False(helper.IsSortedAscending(new int[] { 2, 1, 6, 89, 101, 232 }));
            Assert.True(helper.IsSortedAscending(new int[] { -606, 23, 201, 5556 }));
        }

        [Fact]
        public void TestSortedAscendingEmptyArray()
        {
            Assert.False(helper.IsSortedAscending(new int[] { }));
        }
    }
}
