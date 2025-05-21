using NUnit.Framework;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class RBTreeTest
    {
        [Test]
        public void TestSuccessorOrder()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.InsertSuccessor(null, 1);
            tree.InsertSuccessor(tree.Root, 2);
            tree.InsertSuccessor(tree.Root.Right, 3);
            Assert.That(tree.Root.Data, Is.EqualTo(2));
            Assert.That(tree.Root.Left.Data, Is.EqualTo(1));
            Assert.That(tree.Root.Right.Data, Is.EqualTo(3));
            Assert.That(tree.Root.Left.Next, Is.EqualTo(tree.Root));
            Assert.That(tree.Root.Previous, Is.EqualTo(tree.Root.Left));
            Assert.That(tree.Root.Right.Previous, Is.EqualTo(tree.Root));
            Assert.That(tree.Root.Next, Is.EqualTo(tree.Root.Right));
        }

        [Test]
        public void TestInsertAtBack()
        {
            RBTree<char> tree = new RBTree<char>();
            RBTreeNode<char> last = tree.InsertSuccessor(null, 'L');
            last = tree.InsertSuccessor(last, 'o');
            last = tree.InsertSuccessor(last, 'g');
            last = tree.InsertSuccessor(last, 'a');
            last = tree.InsertSuccessor(last, 'n');
            last = tree.InsertSuccessor(last, '!');
            Assert.That(tree.Root.Data, Is.EqualTo('o'));
            Assert.That(tree.Root.Left.Data, Is.EqualTo('L'));
            Assert.That(tree.Root.Right.Data, Is.EqualTo('a'));
            Assert.That(tree.Root.Right.Left.Data, Is.EqualTo('g'));
            Assert.That(tree.Root.Right.Right.Data, Is.EqualTo('n'));
            Assert.That(tree.Root.Right.Right.Right.Data, Is.EqualTo('!'));
            RBTreeNode<char> traverse = RBTree<char>.GetFirst(tree.Root);
            Assert.That(traverse.Data, Is.EqualTo('L'));
            traverse = traverse.Next;
            Assert.That(traverse.Data, Is.EqualTo('o'));
            traverse = traverse.Next;
            Assert.That(traverse.Data, Is.EqualTo('g'));
            traverse = traverse.Next;
            Assert.That(traverse.Data, Is.EqualTo('a'));
            traverse = traverse.Next;
            Assert.That(traverse.Data, Is.EqualTo('n'));
            traverse = traverse.Next;
            Assert.That(traverse.Data, Is.EqualTo('!'));
            traverse = traverse.Next;
            Assert.That(traverse, Is.Null);
        }

        [Test]
        public void TestInsertAtFront()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.InsertSuccessor(null, 4);
            tree.InsertSuccessor(null, 5);
            tree.InsertSuccessor(null, 3);
            tree.InsertSuccessor(null, 4);
            Assert.That(tree.Root.Data, Is.EqualTo(5));
            Assert.That(tree.Root.Right.Data, Is.EqualTo(4));
            Assert.That(tree.Root.Left.Data, Is.EqualTo(3));
            Assert.That(tree.Root.Left.Left.Data, Is.EqualTo(4));
            RBTreeNode<int> traverse = RBTree<int>.GetFirst(tree.Root);
            Assert.That(traverse.Data, Is.EqualTo(4));
            traverse = traverse.Next;
            Assert.That(traverse.Data, Is.EqualTo(3));
            traverse = traverse.Next;
            Assert.That(traverse.Data, Is.EqualTo(5));
            traverse = traverse.Next;
            Assert.That(traverse.Data, Is.EqualTo(4));
            traverse = traverse.Next;
            Assert.That(traverse, Is.EqualTo(null));
        }

        [Test]
        public void TestInsertInMiddle()
        {
            RBTree<int> tree = new RBTree<int>();
            RBTreeNode<int> first = tree.InsertSuccessor(null, 1);
            tree.InsertSuccessor(first, -1);
            tree.InsertSuccessor(first, 2);
            Assert.That(tree.Root.Data, Is.EqualTo(2));
            Assert.That(tree.Root.Left.Data, Is.EqualTo(1));
            Assert.That(tree.Root.Right.Data, Is.EqualTo(-1));
            first = RBTree<int>.GetFirst(tree.Root);
            Assert.That(first.Data, Is.EqualTo(1));
            first = first.Next;
            Assert.That(first.Data, Is.EqualTo(2));
            first = first.Next;
            Assert.That(first.Data, Is.EqualTo(-1));
            first = first.Next;
            Assert.That(first, Is.Null);
        }

        [Test]
        public void TestRemoveAtBack()
        {
            RBTree<char> tree = new RBTree<char>();
            RBTreeNode<char> last = tree.InsertSuccessor(null, 'L');
            last = tree.InsertSuccessor(last, 'o');
            last = tree.InsertSuccessor(last, 'g');
            last = tree.InsertSuccessor(last, 'a');
            last = tree.InsertSuccessor(last, 'n');
            last = tree.InsertSuccessor(last, '!');
            RBTreeNode<char> prev = last.Previous;
            tree.RemoveNode(last);
            last = prev.Previous;
            tree.RemoveNode(prev);
            tree.RemoveNode(last);
            Assert.That(tree.Root.Data, Is.EqualTo('o'));
            Assert.That(tree.Root.Left.Data, Is.EqualTo('L'));
            Assert.That(tree.Root.Right.Data, Is.EqualTo('g'));
        }

        [Test]
        public void TestRemoveAtFront()
        {
            RBTree<char> tree = new RBTree<char>();
            RBTreeNode<char> last = tree.InsertSuccessor(null, 'L');
            RBTreeNode<char> first = last;
            last = tree.InsertSuccessor(last, 'o');
            last = tree.InsertSuccessor(last, 'g');
            last = tree.InsertSuccessor(last, 'a');
            last = tree.InsertSuccessor(last, 'n');
            last = tree.InsertSuccessor(last, '!');
            last = first.Next;
            tree.RemoveNode(first);
            first = last;
            last = last.Next;
            tree.RemoveNode(first);
            first = last;
            tree.RemoveNode(first);
            Assert.That(tree.Root.Data, Is.EqualTo('n'));
            Assert.That(tree.Root.Left.Data, Is.EqualTo('a'));
            Assert.That(tree.Root.Right.Data, Is.EqualTo('!'));
        }

        [Test]
        public void TestRemoveInMiddle()
        {
            RBTree<char> tree = new RBTree<char>();
            RBTreeNode<char> last = tree.InsertSuccessor(null, 'L');
            last = tree.InsertSuccessor(last, 'o');
            RBTreeNode<char> mid = last = tree.InsertSuccessor(last, 'g');
            last = tree.InsertSuccessor(last, 'a');
            last = tree.InsertSuccessor(last, 'n');
            last = tree.InsertSuccessor(last, '!');

            tree.RemoveNode(mid);
            Assert.That(tree.Root.Data, Is.EqualTo('o'));
            Assert.That(tree.Root.Left.Data, Is.EqualTo('L'));
            Assert.That(tree.Root.Right.Data, Is.EqualTo('n'));
            Assert.That(tree.Root.Right.Left.Data, Is.EqualTo('a'));
            Assert.That(tree.Root.Right.Right.Data, Is.EqualTo('!'));
        }

        [Test]
        public void TestRemove()
        {
            RBTree<int> tree = new RBTree<int>();
            for (int i = 0; i < 50; i++)
            {
                tree.InsertSuccessor(RBTree<int>.GetLast(tree.Root), i);
                for (int j = 0; j <= i; j++)
                {
                    RBTreeNode<int> traverse = RBTree<int>.GetFirst(tree.Root);
                    for (int k = 0; k < j; k++)
                    {
                        traverse = traverse.Next;
                    }
                    //remove jth element
                    tree.RemoveNode(traverse);
                    RBTreeNode<int> check = RBTree<int>.GetFirst(tree.Root);
                    for (int k = 0; k < j; k++)
                    {
                        Assert.That(check.Data, Is.EqualTo(k));
                        check = check.Next;
                    }
                    for (int k = j; k < i; k++)
                    {
                        Assert.That(check.Data, Is.EqualTo(k + 1));
                        check = check.Next;
                    }
                    //readd
                    tree.InsertSuccessor(traverse.Previous, traverse.Data);
                }
            }
        }
    }
}
