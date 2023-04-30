using lection1404;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Forms.ClassForTSotr
{
    internal class randElemHandler
    {
        private bool type;
        private int n;
        private int[,] elems;
        public List<QuickTopS.Pair<int>> cnst;
        public List<int> elements; 
        public randElemHandler(int n, bool type)
        {
            this.n = n;
            this.type = type;
            getElems();
        }

        private void getElems()
        {
            if (type)
            {
                getLinearSet();

            } else { getBranchSet(); }
            elements = Convertion.GetListElems(elems);
            cnst = Convertion.GetListConstrains(elems);
        }

        private void getLinearSet()
        {
            randomElemsCreate rnd = new(n);
            elems = rnd.FillTree();
            
        }
        private void getBranchSet()
        {
            randomElemsCreate rnd = new(n);
            elems = rnd.FillOriented();
        }
    }
}
