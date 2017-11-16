using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_13
{
    class ArraySousa
    {
        public static void consoleOutput(string title, int[] array)
        {
            Console.Write(title);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.Write("\n");
        }
        public static int[] sort(int[] array)
        {
            int[] temp = array;

            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[i] < temp[j])
                    {
                        int tempI = temp[i];
                        int tempJ = temp[j];
                        temp[i] = tempJ;
                        temp[j] = tempI;
                    }
                }
            }

            return temp;
        }
        public static int[] kyoutsu(int[] array1, int[] array2)
        {
            int[] temp = new int[10];

            int countArray1 = 0;
            int countArray2 = 0;
            int countTemp = 0;

            while (true)
            {
                if (array1[countArray1] < array2[countArray2])
                {
                    countArray1++;
                }
                else
                {
                    if (array1[countArray1] > array2[countArray2])
                    {
                        countArray2++;
                    }
                    else
                    {
                        if (countTemp == 0)
                        {
                            temp[countTemp] = array1[countArray1];
                            countTemp++;
                        }
                        else
                        {
                            if (temp[countTemp - 1] != array1[countArray1])
                            {
                                temp[countTemp] = array1[countArray1];
                                countTemp++;
                            }
                        }
                        countArray1++;
                        countArray2++;
                    }
                }
                if (countArray1 >= array1.Length &&
                    countArray2 >= array2.Length)
                {
                    break;
                }
            }

            int[] array = new int[countTemp];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }

            return array;
        }
        public static int[] wa(int[] array1, int[] array2)
        {
            int[] temp = new int[10];

            int countArray1 = 0;
            int countArray2 = 0;
            int countTemp = 0;

            while (true)
            {
                if (array1[countArray1] < array2[countArray2])
                {
                    if (countTemp == 0)
                    {
                        temp[countTemp] = array1[countArray1];
                        countTemp++;
                    }
                    else
                    {
                        if (temp[countTemp - 1] != array1[countArray1])
                        {
                            temp[countTemp] = array1[countArray1];
                            countTemp++;
                        }
                    }
                    countArray1++;
                }
                else
                {
                    if (array1[countArray1] > array2[countArray2])
                    {
                        if (countTemp == 0)
                        {
                            temp[countTemp] = array2[countArray2];
                            countTemp++;
                        }
                        else
                        {
                            if (temp[countTemp - 1] != array2[countArray2])
                            {
                                temp[countTemp] = array2[countArray2];
                                countTemp++;
                            }
                        }
                        countArray2++;
                    }
                    else
                    {
                        if (countTemp == 0)
                        {
                            temp[countTemp] = array1[countArray1];
                            countTemp++;
                        }
                        else
                        {
                            if (temp[countTemp - 1] != array1[countArray1])
                            {
                                temp[countTemp] = array1[countArray1];
                                countTemp++;
                            }
                        }
                        countArray1++;
                        countArray2++;
                    }
                }
                if (countArray1 >= array1.Length &&
                    countArray2 >= array2.Length)
                {
                    break;
                }
            }

            int[] array = new int[countTemp];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }

            return array;
        }
    }
}
