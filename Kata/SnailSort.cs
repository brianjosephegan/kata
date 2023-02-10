using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kata
{
    public static class SnailSort
    {
        public static int[] Sort(int[][] array)
        {
            var result = new List<int>();
            var direction = Direction.Right;
            var rowIndex = 0;
            var columnIndex = 0;
            var iterationCount = 0;
            var numbersToAdd = array.Length;

            while (result.Count != (array.Length * array.Length))
            {
                switch (direction)
                {
                    case Direction.Left:
                        TraverseLeft(result, array, ref rowIndex, ref columnIndex, numbersToAdd);
                        break;
                    case Direction.Right:
                        TraverseRight(result, array, ref rowIndex, ref columnIndex, numbersToAdd);
                        break;
                    case Direction.Up:
                        TraverseUp(result, array, ref rowIndex, ref columnIndex, numbersToAdd);
                        break;
                    case Direction.Down:
                        TraverseDown(result, array, ref rowIndex, ref columnIndex, numbersToAdd);
                        break;
                }

                direction = ChangeDirection(direction, ref rowIndex, ref columnIndex);
                iterationCount++;
                if (iterationCount == 1 || iterationCount % 3 == 0)
                {
                    numbersToAdd--;
                }
            }

            return result.ToArray();
        }

        private static Direction ChangeDirection(Direction direction, ref int rowIndex, ref int columnIndex)
        {
            switch (direction)
            {
                case Direction.Left:
                    rowIndex--;
                    return Direction.Up;
                case Direction.Right:
                    rowIndex++;
                    return Direction.Down;
                case Direction.Up:
                    columnIndex++;
                    return Direction.Right;
                case Direction.Down:
                    columnIndex--;
                    return Direction.Left;
                default:
                    throw new ArgumentException();
            }
        }

        private enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        private static void TraverseLeft(List<int> result, int[][] array, ref int rowIndex, ref int columnIndex, int numbersToAdd)
        {
            for (var i = 0; i < numbersToAdd; i++)
            {
                result.Add(array[rowIndex][columnIndex--]);
            }

            columnIndex++;
        }

        private static void TraverseRight(List<int> result, int[][] array, ref int rowIndex, ref int columnIndex, int numbersToAdd)
        {
            for (var i = 0; i < numbersToAdd; i++)
            {
                result.Add(array[rowIndex][columnIndex++]);
            }

            columnIndex--;
        }

        private static void TraverseUp(List<int> result, int[][] array, ref int rowIndex, ref int columnIndex, int numbersToAdd)
        {
            for (var i = 0; i < numbersToAdd; i++)
            {
                result.Add(array[rowIndex--][columnIndex]);
            }

            rowIndex++;
        }

        private static void TraverseDown(List<int> result, int[][] array, ref int rowIndex, ref int columnIndex, int numbersToAdd)
        {
            for (var i = 0; i < numbersToAdd; i++)
            {
                result.Add(array[rowIndex++][columnIndex]);
            }

            rowIndex--;
        }
    }
}
