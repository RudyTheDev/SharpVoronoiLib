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
            Assert.AreEqual(2, tree.Root.Data);
            Assert.AreEqual(1, tree.Root.Left.Data);
            Assert.AreEqual(3, tree.Root.Right.Data);
            Assert.AreEqual(tree.Root, tree.Root.Left.Next);
            Assert.AreEqual(tree.Root.Left, tree.Root.Previous);
            Assert.AreEqual(tree.Root, tree.Root.Right.Previous);
            Assert.AreEqual(tree.Root.Right, tree.Root.Next);
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
            Assert.AreEqual('o', tree.Root.Data);
            Assert.AreEqual('L', tree.Root.Left.Data);
            Assert.AreEqual('a', tree.Root.Right.Data);
            Assert.AreEqual('g', tree.Root.Right.Left.Data);
            Assert.AreEqual('n', tree.Root.Right.Right.Data);
            Assert.AreEqual('!', tree.Root.Right.Right.Right.Data);
            RBTreeNode<char> traverse = RBTree<char>.GetFirst(tree.Root);
            Assert.AreEqual('L', traverse.Data);
            traverse = traverse.Next;
            Assert.AreEqual('o', traverse.Data);
            traverse = traverse.Next;
            Assert.AreEqual('g', traverse.Data);
            traverse = traverse.Next;
            Assert.AreEqual('a', traverse.Data);
            traverse = traverse.Next;
            Assert.AreEqual('n', traverse.Data);
            traverse = traverse.Next;
            Assert.AreEqual('!', traverse.Data);
            traverse = traverse.Next;
            Assert.AreEqual(null, traverse);
        }

        [Test]
        public void TestInsertAtFront()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.InsertSuccessor(null, 4);
            tree.InsertSuccessor(null, 5);
            tree.InsertSuccessor(null, 3);
            tree.InsertSuccessor(null, 4);
            Assert.AreEqual(5, tree.Root.Data);
            Assert.AreEqual(4, tree.Root.Right.Data);
            Assert.AreEqual(3, tree.Root.Left.Data);
            Assert.AreEqual(4, tree.Root.Left.Left.Data);
            RBTreeNode<int> traverse = RBTree<int>.GetFirst(tree.Root);
            Assert.AreEqual(4, traverse.Data);
            traverse = traverse.Next;
            Assert.AreEqual(3, traverse.Data);
            traverse = traverse.Next;
            Assert.AreEqual(5, traverse.Data);
            traverse = traverse.Next;
            Assert.AreEqual(4, traverse.Data);
            traverse = traverse.Next;
            Assert.AreEqual(null, traverse);
        }

        [Test]
        public void TestInsertInMiddle()
        {
            RBTree<int> tree = new RBTree<int>();
            RBTreeNode<int> first = tree.InsertSuccessor(null, 1);
            tree.InsertSuccessor(first, -1);
            tree.InsertSuccessor(first, 2);
            Assert.AreEqual(2, tree.Root.Data);
            Assert.AreEqual(1, tree.Root.Left.Data);
            Assert.AreEqual(-1, tree.Root.Right.Data);
            first = RBTree<int>.GetFirst(tree.Root);
            Assert.AreEqual(1, first.Data);
            first = first.Next;
            Assert.AreEqual(2, first.Data);
            first = first.Next;
            Assert.AreEqual(-1, first.Data);
            first = first.Next;
            Assert.AreEqual(null, first);
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
            Assert.AreEqual('o', tree.Root.Data);
            Assert.AreEqual('L', tree.Root.Left.Data);
            Assert.AreEqual('g', tree.Root.Right.Data);
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
            Assert.AreEqual('n', tree.Root.Data);
            Assert.AreEqual('a', tree.Root.Left.Data);
            Assert.AreEqual('!', tree.Root.Right.Data);
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
            Assert.AreEqual('o', tree.Root.Data);
            Assert.AreEqual('L', tree.Root.Left.Data);
            Assert.AreEqual('n', tree.Root.Right.Data);
            Assert.AreEqual('a', tree.Root.Right.Left.Data);
            Assert.AreEqual('!', tree.Root.Right.Right.Data);
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
                        Assert.AreEqual(k, check.Data);
                        check = check.Next;
                    }
                    for (int k = j; k < i; k++)
                    {
                        Assert.AreEqual(k + 1, check.Data);
                        check = check.Next;
                    }
                    //readd
                    tree.InsertSuccessor(traverse.Previous, traverse.Data);
                }
            }
        }
    }
}
