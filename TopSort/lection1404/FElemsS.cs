using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lection1404
{
    public class FElemsSort
    {
        private int[] srcarr;
        /// <summary>
        /// Конструктор класса, создающий целочисленный массив на основе массива символов
        /// </summary>
        /// <param name="src"></param>
        public FElemsSort(char[] src)
        {
            this.srcarr = new int[src.Length];
            for (int i = 0; i < src.Length; i++)
            {
                this.srcarr[i] = (int)src[i];
            }
        }
        /// <summary>
        /// Функция, осуществляющая сортировку 4 элементов
        /// </summary>
        /// <param name="srcarr"></param>
        /// <returns></returns>
        private int[] Sort(int[] srcarr)
        {
            return QuickSortRangeUp(srcarr, 0, srcarr.Length - 1);
        }
        /// <summary>
        /// Вспомогательная функция для быстрой сортировки
        /// массива по возрастанию
        /// </summary>
        /// <param name="a">Сортируемый массив</param>
        /// <param name="l">Индекс начала сортируемого отрезка</param>
        /// <param name="r">Индекс конца сортируемого отрезка</param>
        /// <returns></returns>
        private int[] QuickSortRangeUp(int[] a, int l, int r)
        {
            int i = l;
            int j = r;
            int pivot = a[(l + r) / 2];
            while (i <= j)
            {
                while (a[i] < pivot)
                {
                    i++;
                }

                while (a[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    SwapByIndex(a, i, j);
                    i++;
                    j--;
                }
            }

            if (l < j)
            {
                QuickSortRangeUp(a, l, j);
            }
            if (i < r)
            {
                QuickSortRangeUp(a, i, r);
            }
            return a;
        }
        /// <summary>
        /// Выполняет обмен элементов данного массива по индексу
        /// </summary>
        /// <param name="arr">Данный массив</param>
        /// <param name="a">Первый индекс</param>
        /// <param name="b">Второй индекс</param>
        private static void SwapByIndex(int[] arr, int a, int b)
        {
            int v = arr[a];
            arr[a] = arr[b];
            arr[b] = v;
        }
        /// <summary>
        /// Функция переводящая массив символов в целочисленный массив
        /// </summary>
        /// <param name="sortedarr"></param>
        /// <returns></returns>
        private char[] ConvertToChar(int[] sortedarr)
        {
            char[] res = new char[sortedarr.Length];
            for (int i = 0; i < sortedarr.Length; i++)
                res[i] = (char)sortedarr[i];
            return res;
        }
        /// <summary>
        /// Функция, возвращающая отсоритрованный массив символов
        /// </summary>
        /// <returns></returns>

        public char[] GetSorted()
        {
            return ConvertToChar(Sort(srcarr));
        }

    }
}
