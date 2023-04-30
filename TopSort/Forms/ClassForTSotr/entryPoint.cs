using Forms.ClassForTSotr;
using lection1404;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lection1404.QuickTopS;
using static System.Net.Mime.MediaTypeNames;

namespace Forms.Class
{
    internal class entryPoint
    {
        private List<string> elems;
        private List<string> constrains;
        private List<int> elemsInt;
        private List<int> constrainsInt;
        List<QuickTopS.Pair<string>> constrs;
        List<QuickTopS.Pair<int>> constrsInt;
        public entryPoint(List<string> elems, List<string> constrains)
        {
            this.elems = elems;
            this.constrains = constrains;
            constrs = new List<QuickTopS.Pair<string>>();
            constrainsListToClass();
        }
        public entryPoint(List<int> elemsInt, List<QuickTopS.Pair<int>> constrsInt)
        {
            this.elemsInt = elemsInt;
            this.constrsInt = constrsInt;
        }
        public List<string> tSort()
        {
            QuickTopS.UsualTopSort<string> topSort = new QuickTopS.UsualTopSort<string>();
            List<string> result = topSort.TopSort(elems, constrs);
            return result;
        }
        public List<string> tQuickSort()
        {
            ClassQuickTopologicalSorting<string> tq = new ClassQuickTopologicalSorting<string>();
            var tRes = tq.QTopSort(elems, constrs);
            List<string> result = tRes.Item1;
            if (tRes.Item2)
            {
                return result;
            } else { return null; }
        }
        public List<int> tSortInt()
        {
            QuickTopS.UsualTopSort<int> topSort = new QuickTopS.UsualTopSort<int>();
            List<int> result = topSort.TopSort(elemsInt, constrsInt);
            return result;
        }
        public List<int> tQuickSortInt()
        {
            ClassQuickTopologicalSorting<int> tq = new ClassQuickTopologicalSorting<int>();
            var tRes = tq.QTopSort(elemsInt, constrsInt);
            List<int> result = tRes.Item1;
            if (tRes.Item2)
            {
                return result;
            }
            else { return null; }
        }


        private void constrainsListToClass()
        {
            for (int i = 0; i < constrains.Count; i += 2)
            {
                constrs.Add(new QuickTopS.Pair<string>(constrains[i], constrains[i + 1]));
            }
        }
        private void constrainsListToClassInt()
        {
            for (int i = 0; i < constrains.Count; i += 2)
            {
                constrsInt.Add(new QuickTopS.Pair<int>(constrainsInt[i], constrainsInt[i + 1]));
            }
        }
    }
}
