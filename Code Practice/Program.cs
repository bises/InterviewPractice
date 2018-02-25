using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Custom LinkedList
            //LinkedList myList = new LinkedList();
            //myList.AddToEnd(10);
            //myList.AddToEnd(9);
            //myList.AddToEnd(7);
            //myList.AddToEnd(11);
            //myList.AddToEnd(5);
            //myList.AddToEnd(4);
            //myList.AddToEnd(12);
            //myList.Print();

            //Console.WriteLine();

            //Console.WriteLine(myList.getMax());

            //myList.reverse();

            //myList.Print();

            #endregion

            #region array rotation
            //int[] y = new int[5] { 1, 2, 3, 4, 5 };
            //y = rotate(y, 2);
            //foreach (int x in y)
            //    Console.Write(x);
            #endregion

            #region default LinkedList
            //LinkedList<int> defaultList = new LinkedList<int>();
            //defaultList.AddLast(8);
            //defaultList.AddLast(9);
            //defaultList.AddLast(7);
            //defaultList.AddLast(6);
            //defaultList.AddLast(5);
            //defaultList.AddLast(9);
            //defaultList.AddLast(4);
            //defaultList.AddLast(2);

            //LinkedList<int> newlist = new LinkedList<int>();
            //foreach (int x in defaultList)
            //{
            //    Console.Write("|"+ x +"|-> ");
            //}
            //Console.WriteLine();

            //while(defaultList.Count > 0)
            //{
            //    LinkedListNode<int> temp = defaultList.Last;
            //    defaultList.Remove(temp.Value);
            //    newlist.AddLast(temp.Value);
            //}
            //int max = Int32.MinValue;
            //foreach (int x in newlist)
            //{
            //    if (x > max)
            //    {
            //        max = x;
            //    }
            //}
            //Console.Write(max);
            #endregion

            #region doubly linkedlist
            //DoublyLinkedList myList = new DoublyLinkedList();
            //myList.addToEnd(10);
            //myList.addToEnd(9);
            //myList.addToEnd(7);
            //myList.addToEnd(11);
            //myList.addToEnd(5);
            //myList.addToEnd(4);
            //myList.addToEnd(12);
            //myList.print();

            //Console.WriteLine();

            ////myList.printReverse();

            ////Console.WriteLine(myList.getMax());

            //myList.remove(12);
            //myList.print();
            #endregion

            #region Tree
            //TreeNode n1 = new TreeNode(8);
            //n1.add(2, n1);
            //n1.add(4, n1);
            //n1.add(3, n1);
            //n1.add(5, n1);
            //n1.add(7, n1);
            //n1.add(9, n1);

            //n1.preOrder(n1);
            #endregion

            #region mergesort
            //int[] us = new int[] { 1, 5, 6, 2, 3, 4, 7 };
            //foreach (int x in us)
            //{
            //    Console.Write(x + " ");
            //}
            //Console.WriteLine();
            //int[] s = Sorter.QuickSort(us, 0, us.Length - 1);
            //foreach (int x in s)
            //{
            //    Console.Write(x + " ");
            //}
            #endregion

            #region PermuteString
            //Miscellenous.PermutateString("abc");
            #endregion

            #region stack
            //Stack s = new Stack();
            //s.push(4);
            //s.push(5);
            //s.push(6);
            //s.push(7);
            //s.push(8);
            //s.push(9);

            //s.pop();
            #endregion

            #region Longest Consecutinve Sequence
            //Miscellenous.LongestConsecutiveSeq(new int[] { 2, 1, 0, 4, 5, 6, 7});
            #endregion

            #region Find Intersection in consecutive array
            //Miscellenous.FindIntersection(new int[] { 1, 2, 3, 4, 5, 6 },
            //                              new int[] { 2, 4, 6, 8, 10, 12 },
            //                              new int[] { 2, 3, 6, 9, 11, 13 });
            #endregion

            #region validate parenthesis
            //Miscellenous.ValidataParenthesis("{((){}{[]}");
            #endregion

            #region Kth Most Frequennt Element
            Miscellenous.KthMostFrequentEement(new int[] { 1, 2, 3, 2, 4, 5, 2, 3, 4, 2, 3 },2);
            #endregion

            Console.ReadLine();
        }
    }
}
