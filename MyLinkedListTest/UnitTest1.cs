using NUnit.Framework;
using LinkedListProblem;

namespace MyLinkedListTest
{
    public class Tests
    {
        LinkedList list = new LinkedList();
        [Test]
        public void SearchTheNode()
        {            
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Node node = list.Search(30);
            Assert.AreEqual(30, node.data);
        }

        [Test]
        public void GivenThreeNumbersWhenInsertingThirdInBetween()
        {
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertAtParticularPosition(3, 40);
            Node node = list.Search(40);
            Assert.AreEqual(40, node.data);
        }
    }
}