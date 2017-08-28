using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
    class Program
    {
        public static void merge(int [] numbers, int left, int mid, int right) {

            int [] temp = new int[numbers.Length];
            int left_end;
            int num_elem;
            int temp_pos;

            left_end = (mid -1);
            temp_pos = left;
            num_elem = (right - left + 1);

            while ((left <= left_end) && (mid <= right)) {

                if (numbers[left] <= numbers[mid]) {
                    temp[temp_pos++] = numbers[left++];
                } else {
                    temp[temp_pos++] = numbers[mid++];
                }
            }
            while (left <= left_end) {
                temp[temp_pos++] = numbers[left++];
            }
            while (mid <= right) {
                temp[temp_pos++] = numbers[mid++];
            }

            for (int j = 0; j < num_elem; j++) {
                numbers[right] = temp[right];
                right--;
            }

        }

        public static void sort(int [] numbers, int left, int right) {

            int mid;
            if (right > left) {
                mid = (right + left) / 2;
                
                sort(numbers, left, mid);
                sort(numbers, (mid + 1), right);
                merge(numbers, left, (mid + 1), right);

            }

        }
        static void Main(string[] args)
        {
         
            int [] numbers = {3, 7, 4, 5, 2, 8, 9, 6, 1};
            int len = numbers.Length;

            Console.WriteLine("MergeSort: ");
            sort(numbers, 0, len - 1);
            for (int i = 0; i < len; i++) {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
