using lection1404;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lection1404.QuickTopS;

namespace Forms.ClassForTSotr
{
    internal class randomElemsCreate
    {
        int n;
        int[,] mtx;
        public randomElemsCreate(int n)
        {
            this.n = n;
            mtx = new int[n,n];
        }
        public int[,] FillTree()
        {
            CreateTreeGraph(n);
            return mtx;
        }
        public int[,] FillOriented()
        {
            CreateOrientedGraph(n);
            return mtx;
        }
        public int[,] GetMatrixAdj()
        {
            return mtx;
        }
        private void CreateOrientedGraph(int n)
        {
            Random r = new Random();
            int[,] res = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                    res[i, j] = r.Next(0, 2);
            }
            mtx = res;
        }
        private void CreateTreeGraph(int n)
        {
            List<int>[] ListAdj;
            List<int> Vertexes;
            Random r = new Random();

            ListAdj = new List<int>[n];
            //
            for (int i = 0; i < n; i++)
            {
                int numOfV = r.Next(1, 4);
                ListAdj[i] = new List<int>();

                for (int j = 1; j < numOfV + 1; j++)
                {
                    if (i + j < n)
                        ListAdj[i].Add(i + j);
                }
                i += (numOfV - 1);
            }
            //convert to matrix adj'
            ConvertToMtxAdj(ListAdj, n);
        }

        private void ConvertToMtxAdj(List<int>[] L, int n)
        {
            int[,] res = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                if (L[i] == null)
                    continue;
                foreach (int k in L[i])
                    res[i, k] = 1;
            }
            mtx = res;
        }

    }
    static class Convertion
    {
        static public List<int> GetListElems(int[,] mtx)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < Math.Max(mtx.GetLength(0), mtx.GetLength(1)); i++)
                list.Add(i);

            return list;

        }

        static public List<QuickTopS.Pair<int>> GetListConstrains(int[,] mtx)
        {
            List<QuickTopS.Pair<int>> constrains = new List<QuickTopS.Pair<int>>();

            for (int i = 0; i < mtx.GetLength(0); i++)
                for (int j = i + 1; j < mtx.GetLength(1); j++)
                    if (mtx[i, j] != 0)
                        constrains.Add(
                            new Pair<int>(i, j)
                            );

            return constrains;
        }
    }
}
