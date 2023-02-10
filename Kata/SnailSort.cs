using System;
using System.Collections.Generic;

namespace Kata
{
    public static class SnailSort
    {
        public static int[] Sort(int[][] array)
        {
            if (array == null || (array.Length == 1 && array[0].Length == 0))
            {
                return Array.Empty<int>();
            }

            var result = new List<int>();
            var direction = Direction.Right;
            var rowIndex = 0;
            var columnIndex = 0;
            var iterationCount = 0;
            var totalNumbersToAdd = array.Length * array.Length;
            var numbersToAdd = array.Length;

            while (result.Count != totalNumbersToAdd)
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
                if (numbersToAdd == array.Length || iterationCount % 2 == 0)
                {
                    numbersToAdd--;
                }
                iterationCount++;
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
