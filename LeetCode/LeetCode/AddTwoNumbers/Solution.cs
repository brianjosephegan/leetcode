namespace LeetCode.AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return ConvertNumberToLinkedList(
                ReverseNumber(GetNumberFromLinkedList(l1) + GetNumberFromLinkedList(l2)
                ));
        }

        internal int GetNumberFromLinkedList(ListNode listNode)
        {
            var number = listNode == null ? 0 : listNode.val;
            var power = 1;

            while (listNode.next != null)
            {
                listNode = listNode.next;
                number = (number * (int)Math.Pow(10, power)) + listNode.val;
            }

            return number;
        }

        internal ListNode ConvertNumberToLinkedList(int number)
        {
            ListNode listNode = null;

            do
            {
                var digit = number % 10;
                listNode = new ListNode(digit, listNode);
                number /= 10;
            } while (number > 0);

            return listNode;
        }

        internal int ReverseNumber(int number)
        {
            var result = 0;
            var power = 1;

            do
            {
                var digit = number % 10;
                result = (result * (int)Math.Pow(10, power)) + digit;
                number /= 10;
            } while (number > 0);

            return result;
        }
    }
}
