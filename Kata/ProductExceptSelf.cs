﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class ProductExceptSelf
    {
        public int[] Compute(int[] numbers)
        {
            var result = new int[numbers.Length];
            int lastProduct = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0 || numbers[i] == 0)
                {
                    result[i] = ComputeProductExceptSelfFromIndex(numbers, i);
                }
                else
                {
                    result[i] = ComputeProductExceptSelfFromLastProduct(numbers, i, lastProduct);
                }

                lastProduct = result[i];
            }

            return result;
        }

        private int ComputeProductExceptSelfFromIndex(int[] numbers, int targetIndex)
        {
            int? product = null;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i != targetIndex)
                {
                    if (product.HasValue)
                    {
                        product *= numbers[i];
                    }
                    else
                    {
                        product = numbers[i];
                    }
                }
            }

            return product.Value;
        }

        private int ComputeProductExceptSelfFromLastProduct(int[] numbers, int index, int lastProduct) => lastProduct / numbers[index] * numbers[index - 1];
    }
}
