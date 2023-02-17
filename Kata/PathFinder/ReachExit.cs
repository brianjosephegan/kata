using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.PathFinder
{
    public static class ReachExit
    {
        public static bool Find(string maze)
        {
            var mazeSideLength = (int)Math.Sqrt(maze.Length);

            return TraverseMatrixBfs(
                maze,
                mazeSideLength,
                new Tuple<int, int>(0, 0),
                new Tuple<int, int>(mazeSideLength - 1, mazeSideLength - 1));
        }

        private static bool TraverseMatrixBfs(
            string maze,
            int mazeSideLength,
            Tuple<int, int> start,
            Tuple<int, int> exit)
        {
            var seen = new HashSet<Tuple<int, int>>();
            var queue = new Stack<Tuple<int, int>>();

            queue.Push(start);

            while (queue.Any())
            {
                var current = queue.Pop();
                seen.Add(current);

                System.Diagnostics.Debug.WriteLine($"Current: X = {current.Item1}, Y = {current.Item2}");

                if (current.Equals(exit))
                {
                    return true;
                }

                var north = new Tuple<int, int>(current.Item1 - 1, current.Item2);
                if (!seen.Contains(north) && north.Item1 >= 0 && maze[(north.Item1 * mazeSideLength) + north.Item2] != 'W')
                {
                    queue.Push(north);
                }
                var south = new Tuple<int, int>(current.Item1 + 1, current.Item2);
                if (!seen.Contains(south) && south.Item1 < mazeSideLength && maze[(south.Item1 * mazeSideLength) +  south.Item2] != 'W')
                {
                    queue.Push(south);
                }
                var east = new Tuple<int, int>(current.Item1, current.Item2 + 1);
                if (!seen.Contains(east) && east.Item2 < mazeSideLength && maze[(east.Item1 * mazeSideLength) + east.Item2] != 'W')
                {
                    queue.Push(east);
                }
                var west = new Tuple<int, int>(current.Item1, current.Item2 - 1);
                if (!seen.Contains(west) && west.Item2 >= 0 && maze[(west.Item1 * mazeSideLength) + west.Item2] != 'W')
                {
                    queue.Push(west);
                }
            }

            return false;
        }
    }
}
