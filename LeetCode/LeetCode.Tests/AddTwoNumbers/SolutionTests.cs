using LeetCode.AddTwoNumbers;

namespace LeetCode.Tests.AddTwoNumbers
{
    public class SolutionTests
    {
        [Fact]
        public void Example1()
        {
            var listNode1 = new ListNode(3);
            listNode1 = new ListNode(4, listNode1);
            listNode1 = new ListNode(2, listNode1);

            var listNode2 = new ListNode(4);
            listNode2 = new ListNode(6, listNode2);
            listNode2 = new ListNode(5, listNode2);

            var solution = new Solution();
            var listNode = solution.AddTwoNumbers(listNode1, listNode2);

            listNode.Should().NotBeNull();
        }
    }
}
