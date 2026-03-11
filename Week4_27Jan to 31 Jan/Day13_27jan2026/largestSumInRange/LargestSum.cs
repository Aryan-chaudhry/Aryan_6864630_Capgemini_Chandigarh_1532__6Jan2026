using System;
using System.Collections.Generic;
using System.Text;

namespace largestSumInRange
{
    internal class LargestSum
    {
        // largest sum in range of 1 to 100 like largestSum = max(1-10) + max(11-20) + max(21-30) + .......
        // example [5,13,18,25,27,40] sum = 5 + 18 + 27 + 40
        public  static int Check(int[] arr)
        {
            bool negCondition = false;
            bool zeroAndGreaterCondition = false;

            foreach(var item in arr)
            {
                if(item < -1)
                {
                    negCondition = true;
                }
                else if(item == 0 || item > 100)
                {
                    zeroAndGreaterCondition = true;

				}
            }

            if(negCondition == true && zeroAndGreaterCondition == true)
            {
                return -3;
            }
            else if(negCondition == true && zeroAndGreaterCondition == false)
            {
                return -1;
            }
            else if(negCondition == false && zeroAndGreaterCondition == true)
            {
                return -2;
            }

            Dictionary<int, int> dt = new Dictionary<int, int>();
            dt.Add(0, 10);
            dt.Add(1, 20);
            dt.Add(2, 30);
            dt.Add(3, 40);
            dt.Add(4, 50);
            dt.Add(5, 60);
            dt.Add(6, 70);
            dt.Add(7, 80);
            dt.Add(8, 90);
            dt.Add(9, 100);

            int[] store = new int[10];

            for(int i=0; i<arr.Length; i++)
            {
                int target = arr[i];
                 
                foreach(var item in dt)
                {
                    if(target <= item.Value)
                    {
                        int index = item.Key;
                        store[index] = Math.Max(target, store[index]);
                        break;
                    }
                }
            }

            int sum = 0;
            foreach(var item in store)
            {
                sum += item;
            }

            return sum;
        }
    }
}
