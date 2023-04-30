using lection1404;
using System.Globalization;
using System.Runtime.InteropServices;
using static lection1404.QuickTopS;

namespace p
{
    class RandomGraph
    {
        int n;
        int[,] mtx;
        public RandomGraph(int n)
        {
            this.n = n;
        }
        public void FillTree ()
        {
            this.mtx = CreateTreeGraph(n);
        }
        public void FillOriented()
        {
            this.mtx = CreateOrientedGraph(n);
        }
        public int[,] GetMatrixAdj()
        {
            return this.mtx;
        }
        private int[,] CreateOrientedGraph(int n)
        {
            Random r = new Random();
            int[,] res = new int[n, n];
            for (int i = 0; i<n;i++)
            {
                for( int j = i+1; j<n;j++)
                    res[i,j] = r.Next(0,2);
            }
            return res;
        }
        private int[,] CreateTreeGraph(int n)
        {
            List<int>[] ListAdj;
            List<int> Vertexes;
            Random r = new Random();

            ListAdj = new List<int>[n];
            //
            for (int i =0; i<n;i++)
            {
                int numOfV = r.Next(1, 4);
                ListAdj[i] = new List<int>();
                
                for (int j = 1; j<numOfV+1; j++)
                {
                    if (i+j < n)
                        ListAdj[i].Add(i+j);
                }
                i += (numOfV -1) ;
            }
            //convert to matrix adj'
            int[,] mtx = ConvertToMtxAdj(ListAdj, n);
            return mtx;
        }
       
        private int[,] ConvertToMtxAdj(List<int>[] L, int n)
        {
            int[,] mtx = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                if (L[i] == null)
                    continue;
                foreach (int k in L[i])
                    mtx[i, k] = 1;
            }
            return mtx;
        }

    }
    static class Convertion
    {
        static public List<int> GetListElems(int[,] mtx )
        {
            List<int> list = new List<int>();
            for (int i =0; i< Math.Max(mtx.GetLength(0), mtx.GetLength(1)) ; i++)
                list.Add(i);

            return list;

        }

        static public List<QuickTopS.Pair<int>> GetListConstrains(int[,] mtx)
        {
            List<QuickTopS.Pair<int>> constrains = new List<QuickTopS.Pair<int>>();

            for (int i = 0; i<mtx.GetLength(0); i++)
                for (int j = i+1; j<mtx.GetLength(1); j++)
                    if (mtx[i,j] != 0)
                        constrains.Add(
                            new Pair<int>(i,j)
                            );

            return constrains;
        }
    }
    class p
    {
        public static void testSort()
        {
            List<string> elems = new List<string> { "кофта", "футболка", "куртка", "шапка" };
            List<QuickTopS.Pair<string>> constrains = new List<QuickTopS.Pair<string>>();
            constrains.Add(new QuickTopS.Pair<string>("футболка", "кофта"));
            constrains.Add(new QuickTopS.Pair<string>("кофта", "куртка"));
            constrains.Add(new QuickTopS.Pair<string>("футболка", "шапка"));
            QuickTopS.UsualTopSort<string> test = new QuickTopS.UsualTopSort<string>();
            ClassQuickTopologicalSorting<string> tq = new ClassQuickTopologicalSorting<string>();

            List<string> rs = tq.QTopSort(elems, constrains).Item1;
            List<string> res = test.TopSort(elems, constrains);
            Console.WriteLine("FastSort");
            foreach (string s in rs)
                Console.Write("{0} ", s);
            Console.WriteLine();
            Console.WriteLine("UsualSort");
            foreach (string s in res)
              Console.Write("{0} ", s);
        }
        public static void testSort1()
        {
            List<string> elems = new List<string> { "Встать", "Приготовить завтрак", "Почистить зубы", "Позавтракать", "Открыть глаза" };
            List<QuickTopS.Pair<string>> constrains = new List<QuickTopS.Pair<string>>();
            constrains.Add(new QuickTopS.Pair<string>("Открыть глаза", "Встать"));
            constrains.Add(new QuickTopS.Pair<string>("Встать", "Приготовить завтрак"));
            constrains.Add(new QuickTopS.Pair<string>("Приготовить завтрак", "Позавтракать"));
            constrains.Add(new QuickTopS.Pair<string>("футболка", "шапка"));
            QuickTopS.UsualTopSort<string> test = new QuickTopS.UsualTopSort<string>();
            ClassQuickTopologicalSorting<string> tq = new ClassQuickTopologicalSorting<string>();

            List<string> rs = tq.QTopSort(elems, constrains).Item1;
            List<string> res = test.TopSort(elems, constrains);
            Console.WriteLine("FastSort");
            foreach (string s in rs)
                Console.Write("{0} ", s);
            Console.WriteLine();
            Console.WriteLine("UsualSort");
            foreach (string s in res)
              Console.Write("{0} ", s);
        }
        public static void testSort2()
        {
            List<string> elems = new List<string> { "1", "2", "3", "4", "5", "6", "7"};
            List<QuickTopS.Pair<string>> constrains = new List<QuickTopS.Pair<string>>();
            constrains.Add(new QuickTopS.Pair<string>("1", "2"));
            constrains.Add(new QuickTopS.Pair<string>("1", "3"));
            constrains.Add(new QuickTopS.Pair<string>("2", "4"));
            constrains.Add(new QuickTopS.Pair<string>("3", "5"));
            constrains.Add(new QuickTopS.Pair<string>("2", "6"));
            constrains.Add(new QuickTopS.Pair<string>("5", "7"));
            QuickTopS.UsualTopSort<string> test = new QuickTopS.UsualTopSort<string>();
            ClassQuickTopologicalSorting<string> tq = new ClassQuickTopologicalSorting<string>();

            List<string> rs = tq.QTopSort(elems, constrains).Item1;
            List<string> res = test.TopSort(elems, constrains);
            Console.WriteLine("FastSort");
            foreach (string s in rs)
                Console.Write("{0} ", s);
            Console.WriteLine();
            Console.WriteLine("UsualSort");
            foreach (string s in res)
                Console.Write("{0} ", s);
        }
        public static void testSort3()
        {
            List<string> elems = new List<string> { "1", "2", "3" };
            List<QuickTopS.Pair<string>> constrains = new List<QuickTopS.Pair<string>>();
            constrains.Add(new QuickTopS.Pair<string>("1", "2"));
            constrains.Add(new QuickTopS.Pair<string>("2", "3"));
            constrains.Add(new QuickTopS.Pair<string>("3", "1"));
            QuickTopS.UsualTopSort<string> test = new QuickTopS.UsualTopSort<string>();
            ClassQuickTopologicalSorting<string> tq = new ClassQuickTopologicalSorting<string>();

            List<string> rs = tq.QTopSort(elems, constrains).Item1;
            List<string> res = test.TopSort(elems, constrains);
            Console.WriteLine("FastSort");
            foreach (string s in rs)
                Console.Write("{0} ", s);
            Console.WriteLine();
            Console.WriteLine("UsualSort");
            foreach (string s in res)
                Console.Write("{0} ", s);
        }
        public static void testSort4()
        {
            List<string> elems = new List<string> { "кофта", "футболка", "куртка", "шапка" };
            List<QuickTopS.Pair<string>> constrains = new List<QuickTopS.Pair<string>>();
            constrains.Add(new QuickTopS.Pair<string>("футболка", "кофта"));
            constrains.Add(new QuickTopS.Pair<string>("кофта", "футболка"));
            constrains.Add(new QuickTopS.Pair<string>("футболка", "шапка"));
            QuickTopS.UsualTopSort<string> test = new QuickTopS.UsualTopSort<string>();
            ClassQuickTopologicalSorting<string> tq = new ClassQuickTopologicalSorting<string>();

            List<string> rs = tq.QTopSort(elems, constrains).Item1;
            List<string> res = test.TopSort(elems, constrains);
            Console.WriteLine("FastSort");
            foreach (string s in rs)
                Console.Write("{0} ", s);
            Console.WriteLine();
            Console.WriteLine("UsualSort");
            foreach (string s in res)
                Console.Write("{0} ", s);
        }

        public static void testSort5()
        {
            RandomGraph R = new(30);
            R.FillTree();
            List<int> elems = Convertion.GetListElems(R.GetMatrixAdj()) ;
            List<QuickTopS.Pair<int>> constrains = Convertion.GetListConstrains(R.GetMatrixAdj());
            QuickTopS.UsualTopSort<int> test = new QuickTopS.UsualTopSort<int>();
            ClassQuickTopologicalSorting<int> tq = new ClassQuickTopologicalSorting<int>();

            List<int> rs = tq.QTopSort(elems, constrains).Item1;
            List<int> res = test.TopSort(elems, constrains);
            Console.WriteLine("FastSort");
            foreach (int s in rs)
                Console.Write("{0} ", s);
            Console.WriteLine();
            Console.WriteLine("UsualSort");
            foreach (int s in res)
                Console.Write("{0} ", s);
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("===Test===\n");
            Console.WriteLine("***Простое множество элементов связанных линейно***\n");
            testSort();//Простое множество элементов связанных линейно.
            Console.WriteLine("\n");
            Console.WriteLine("***Существует элемент, которого нету в списке, но есть в ограничении.***\n");
            //testSort1();//Существует элемент, которого нету в списке, но есть в ограничении.
            Console.WriteLine("\n");
            Console.WriteLine("***Граф в виде дерева.***\n");
            testSort2();
            Console.WriteLine("\n");
            Console.WriteLine("***Зациклованный граф***\n");
            testSort3();
            Console.WriteLine("\n");
            Console.WriteLine("***Еще один зациклованный граф***\n");
            testSort4();
            Console.WriteLine("\n");
            Console.WriteLine("***Случайный граф***\n");
            testSort5();

        }
    }
}