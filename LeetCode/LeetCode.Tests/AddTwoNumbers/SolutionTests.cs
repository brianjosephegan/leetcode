using LeetCode.AddTwoNumbers;

namespace LeetCode.Tests.AddTwoNumbers
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        /*
         * Input
            l1 =
            [2,4,9]
            l2 =
            [5,6,4,9]

            Use Testcase
            Output
            [8,9,8,5]
            Expected
            [7,0,4,0,1]
        */

        [Theory]
        [InlineData(243, 564, 708)]
        [InlineData(0, 0, 0)]
        [InlineData(9999999, 9999, 89990001)]
        [InlineData(249, 5649, 70401)]
        public void Example1(int number1, int number2, int expected)
        {
            var listNode1 = _solution.ConvertNumberToLinkedList(number1);
            var listNode2 = _solution.ConvertNumberToLinkedList(number2);
            
            var listNode = _solution.AddTwoNumbers(listNode1, listNode2);

            _solution.GetNumberFromLinkedList(listNode).Should().Be(expected);
        }
    }
}
