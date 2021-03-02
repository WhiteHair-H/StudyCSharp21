using System;

namespace CallbackTestApp
{

    delegate int Compare(int a, int b); // a,b 비교 대리자
    class Program
    {
        //오름차순 a가 b보다 크면 1리턴, 같으면 0으로 리턴, a < b이면 -1로 리턴
        static int AscendCompare(int a , int b)
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        //내림차순 a가 b보다 작으면 1리턴, 같으면 0으로 리턴, a > b이면 -1리턴
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] Dataset, Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < Dataset.Length; i++)
            {
                for (int j = 0; j < Dataset.Length - (i + 1); j++)
                {
                    // 비교하여 값 위치 변경 
                    if (comparer(Dataset[j], Dataset[j+1]) > 0 )
                    {
                        temp = Dataset[j + 1];
                        Dataset[j + 1] = Dataset[j];
                        Dataset[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };
            Console.WriteLine("sorting....");
            BubbleSort(array, new Compare(DescendCompare)); //내림차순 정렬
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
