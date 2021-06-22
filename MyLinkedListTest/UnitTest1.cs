using NUnit.Framework;
using LinkedListProblem;

namespace MyLinkedListTest
{
    public class Tests
    {        
        [Test]
        public void SearchTheNode()
        {
            LinkedList list = new LinkedList();
            list.AddToEnd(56);
            list.AddToEnd(30);
            list.AddToEnd(70);
            Node node = list.Search(30);
            Assert.AreEqual(30, node.data);
        }
    }
}