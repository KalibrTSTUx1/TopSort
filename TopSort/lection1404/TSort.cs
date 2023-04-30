using System.Data;

namespace lection1404
{
    public class QuickTopS
    {
        /// <summary>
        /// Класс, создающий пары в отношении частичного порядка
        /// </summary>
        /// <typeparam name="T">Произвольный тип данных пары</typeparam>
        public class Pair<T>
        {
            public T Item;
            public T next;
            public Pair (T first, T second)
            {
                Item = first;
                next = second;
            }
        }
        /// <summary>
        /// Подкласс, предоставляющий методы, которые осуществляют нелинейную топологическую сортировку.
        /// </summary>
        /// <typeparam name="T">Произвольный тип данных</typeparam>
        public class UsualTopSort<T>
        {
            /// <summary>
            /// Метод, осуществляющий топологическую сортировку, 
            /// принимающий список элементов и список ограничений и
            /// возвращает отсортированный список элементов.
            /// </summary>
            /// <param name="elements">список элементов</param>
            /// <param name="constrains">список ограничений</param>
            /// <returns>отсортированнный список элементов</returns>
            public List<T> TopSort(List<T> elements, List<Pair<T>> constrains)
            {
                List<T> sorted = new();
                T item;
                while (elements.Count != 0)
                {
                    item = FindItem(constrains, elements);
                    sorted.Add(item);
                    RemoveFromElements(elements, item);
                    RemoveFromConstrains(constrains, item);
                }
                return sorted;
            }
            /// <summary>
            /// Процедура, осуществляющая удаление из списка ограничений
            /// таких, которые содержат минимальный элемент
            /// </summary>
            /// <param name="constrains">список ограничений</param>
            /// <param name="item">минимальный элемент</param>
            void RemoveFromConstrains(List<Pair<T>> constrains, T item)
            {
                for (int i = 0; i < constrains.Count; ++i)
                {
                    if (constrains[i].Item.Equals(item) || constrains[i].next.Equals(item))
                    {
                        constrains.Remove(constrains[i]);
                    }

                }
                return;
            }
            /// <summary>
            /// Вспомогательный метод, который осуществляет поиск минимального элемента и
            /// возвращает минимальный элемент из всего списка элементов
            /// </summary>
            /// <param name="constrains">список ограничений</param>
            /// <param name="elems">список элементов</param>
            /// <returns>минимальный элемент</returns>
            static T FindItem(List<Pair<T>> constrains, List<T> elems)
            {
                T foundItem = elems[0];
                for (int i = 0; i < elems.Count; ++i)
                {
                    bool found = false;
                    for (int j = 0; j < constrains.Count; ++j)
                    {
                        if (constrains[j].next.Equals(elems[i]))
                        {
                            found = true;
                            break;
                        }

                    }
                    if (!found)
                        foundItem = elems[i];
                }
                return foundItem;
            }
            /// <summary>
            /// Процедура, удаляющая из списка элементов найденный минимальный элемент
            /// </summary>
            /// <param name="elems">список элементов</param>
            /// <param name="item">найденный минимальный элемент</param>
            void RemoveFromElements(List<T> elems, T item)
            {
                elems.Remove(item);
                return;
            }

        }
        /// <summary>
        /// Подкласс, осуществляющий быструю топологическую сортировку
        /// </summary>
        /// <typeparam name="T">Данный тип данных </typeparam>
        public class ClassQuickTopologicalSorting <T>
        {
            Dictionary<T, int> _Tint = new();
            Dictionary<int, T> intT = new();
            int n;
            /// <summary>
            /// Функция, переводящая произвольный тип данных из списка элементов
            /// ,создавая два словаря словаря
            /// </summary>
            /// <param name="elems">Список элементов произвольного типа данных</param>
            /// <returns>Словари целочисленных элементов</returns>
            public (Dictionary<T, int>, Dictionary<int, T>) CreateDict(List<T> elems)
            {
                _Tint.Clear(); intT.Clear();
                n = elems.Count;
                for (int i = 0; i<n;i++)
                {
                    _Tint.Add(elems[i], i);
                    intT.Add(i, elems[i]);
                }
                return (_Tint, intT);
            }

            List<Pair<int>> int_cons = new();
            /// <summary>
            /// Функция, создающая список целочисленных пар на основе списка
            /// содержащего элементы пар произвольного типа,
            /// таким образом переводящая произвольный тип данных
            /// в целочисленный
            /// </summary>
            /// <param name="cons">Список пар произвольного типа</param>
            /// <returns>Целочисленный список пар</returns>
            public List<Pair<int>> ReformCons(List<Pair<T>> cons)
            {
                Pair<T> pair;
                Pair<int> intPair;
                int m = cons.Count;
                int item, next;
                for (int i =0; i<m;i++ )
                {
                    pair = cons[i];
                    item = _Tint[pair.Item];
                    next = _Tint[pair.next];
                    intPair = new Pair<int>(item, next);
                    int_cons.Add(intPair);
                }
                return int_cons;
            }

            int[] pred;
            List<int>[] succ;
            /// <summary>
            /// Функция, создающая массив предшественников элемента и список его последователей
            /// на основе целочисленного списка пар ограничений
            /// </summary>
            /// <param name="intCons">Список целочисленных пар ограничений</param>
            /// <returns>Массив предшественников элемента и список его последователей</returns>
            public (int[], List<int>[])CreatePred_Succ (List<Pair<int>> intCons)
            {
                pred = new int[n];
                succ = new List<int>[n];
                for (int k = 0; k<n; k++)
                {
                    succ[k] = new List<int>();
                }
                foreach(Pair<int> pair in intCons)
                {
                    pred[pair.next]++;
                    succ[pair.Item].Add(pair.next);
                }
                return (pred, succ);
            }

            List<int> cand = new();
            /// <summary>
            /// Функция, создающая список кандидатов, то есть элементов, 
            /// которые не имеют предшественников в упорядоченном множестве
            /// </summary>
            /// <param name="pred">Массив предшественников</param>
            /// <returns>Целочисленный список кандидатов</returns>
            public List<int> CreateCand(int[] pred)
            {
                for (int i =0; i<n; i++)
                {
                    if (pred[i] == 0) cand.Add(i);
                }
                return cand;
            }
            /// <summary>
            /// Функция, инициализирующая структуры, то есть
            /// заполняющая списки и массивы ограничений, последователей,
            /// предшественников и словари элементов
            /// </summary>
            /// <param name="elems">Список элементов произвольного типа</param>
            /// <param name="cons">Список пар ограничений произвольного типа</param>
            public void InitStruct(List<T> elems, List<Pair<T>> cons)
            {
                (_Tint, intT) = CreateDict(elems);
                int_cons = ReformCons(cons);
                (pred, succ) = CreatePred_Succ(int_cons);
                cand = CreateCand(pred);
            }
            List<int> sorted = new List<int>();
            /// <summary>
            /// Итоговая функция, осуществляющая топологическую сортировку
            /// на заданном множестве элементов и множестве ограничений
            /// в целочисленном типе данных
            /// </summary>
            void Sorting ()
            {
                int k = 0;
                List<int> list;
                int item;
                while(k<cand.Count)
                {
                    item = cand[k];
                    sorted.Add(item);
                    list = succ[item];
                    foreach(int i in list)
                    {
                        pred[i]--;
                        if (pred[i] == 0) cand.Add(i);

                    }
                    succ[item].Clear();
                    k++;
                }
            }
            public List<T> sortedT = new();
            /// <summary>
            /// Функция, переводящая элементы в исходный тип данных
            /// </summary>
            void BackToT()
            {
                T itemT;
                foreach (int it in sorted)
                {
                    itemT = intT[it];
                    sortedT.Add(itemT);
                }
            }
            /// <summary>
            /// Итоговая функция, осуществляющая топологическую сортировку элементов
            /// на основе списка пар ограничений
            /// </summary>
            /// <param name="elems">Список элементов произвольного типа</param>
            /// <param name="cons">Список пар элементов - ограничений</param>
            /// <returns>Булево значение удачности тренировки и отсортированный
            /// список элементов</returns>
            public (List<T>, bool) QTopSort(List<T> elems, List<Pair<T>> cons)
            {
                InitStruct(elems, cons);
                Sorting();
                BackToT();
                if (sortedT.Count == n) return (sortedT, true);
                else return (sortedT, false);
            }
        }

    }
}