﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoronoiLib.Structures;

namespace VoronoiLibTests
{
    [TestClass]
    public class RBTreeTest
    {
        [TestMethod]
        public void TestSuccessorOrder()
        {
            var tree = new RBTree<int>();
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

        [TestMethod]
        public void TestSuccessorOrderName()
        {
            var tree = new RBTree<char>();
            var last = tree.InsertSuccessor(null, 'L');
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
            var traverse = tree.GetFirst(tree.Root);
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

        [TestMethod]
        public void TestInsertAtFront()
        {
            var tree = new RBTree<int>();
            tree.InsertSuccessor(null, 4);
            tree.InsertSuccessor(null, 5);
            tree.InsertSuccessor(null, 3);
            tree.InsertSuccessor(null, 4);
            Assert.AreEqual(5, tree.Root.Data);
            Assert.AreEqual(4, tree.Root.Right.Data);
            Assert.AreEqual(3, tree.Root.Left.Data);
            Assert.AreEqual(4, tree.Root.Left.Left.Data);
            var traverse = tree.GetFirst(tree.Root);
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
    }
}
