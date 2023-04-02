using System;
using System.Linq;

namespace DZ_CS_7
{
    internal class ArrayInt: IICalc
    {
        private int size;
        private int[] arr;

        public ArrayInt(int size)
        {
            this.size = size;
            arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Random obj = new();
                arr[i] = obj.Next(0, 100);
            }
        }

        public int CountDistinct()
        {
            int countUnique = 0;
            bool found;
            Console.Write("Number of unique values in array:\t");

            for (int i = 0; i < size; i++)
            {
                found = false;
                for (int j = 0; j < size; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found) countUnique++;
            }
            return countUnique;
        }

        public int EqualToValue(int valueToCompare)
        {
            int countEqual = 0;
            Console.Write("Number of elements equal to " + valueToCompare + " in array: ");
            foreach (var item in arr)
            {
                if (item == valueToCompare)
                {
                    countEqual++;
                }
            }
            return countEqual;
        }

        public int Greater(int valueToCompare)
        {
            int greaterCount = 0;

            foreach (var item in arr) 
                if (item > valueToCompare) greaterCount++;

            Console.Write("Amount of elements greater than " + valueToCompare + ":\t");
            return greaterCount;
        }

        public int Less(int valueToCompare)
        {
            int lessCount = 0;

            foreach (var item in arr)
                if (item < valueToCompare) lessCount++;

            Console.Write("Amount of elements less than " + valueToCompare + ":\t");
            return lessCount;
        }

        public void Show()
        {
            Console.WriteLine("Array of " + size + " random elements");

            foreach (var item in arr)
                Console.Write(item + " ");

            Console.WriteLine();
        }

        public void ShowEven()
        {
            Console.WriteLine("All even elements of array:");
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
        }

        public void ShowOdd()
        {
            Console.WriteLine("All odd elements of array:");
            foreach (var item in arr)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
