/**
 * A TrainComposition is built by attaching and detaching wagons from the left and the right sides.
 * For example, if we start by attaching wagon 7 from the left followed by attaching wagon 13, again from the left, we get a composition of two wagons (13 and 7 from left to right). Now the first wagon that can be detached from the right is 7 and the first that can be detached from the left is 13.
 * Implement a TrainComposition that models this problem.
 */

using System.Collections.Generic;

namespace SimpleAlgorithm
{
    public class TrainComposition
    {
        private LinkedList<int> _list = new LinkedList<int>();

        public void AttachWagonFromLeft(int wagonId)
        {
            _list.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            _list.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            var wagon = _list.First;

            _list.RemoveFirst();

            return wagon.Value;
        }

        public int DetachWagonFromRight()
        {
            var wagon = _list.Last;

            _list.RemoveLast();

            return wagon.Value;
        }

        //public static void Main(string[] args)
        //{
        //    TrainComposition tree = new TrainComposition();
        //    tree.AttachWagonFromLeft(7);
        //    tree.AttachWagonFromLeft(13);
        //    Console.WriteLine(tree.DetachWagonFromRight()); // 7 
        //    Console.WriteLine(tree.DetachWagonFromLeft()); // 13
        //}
    }
}
