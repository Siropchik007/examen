using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data
{
    public class ClassAppl
    {
        private Rep _rep;
        public ClassAppl(Rep capl)
        {
            _rep = capl;
        }

        public List<Class2> GetAllList()
        {
            return _rep.listrep.ToList();
        }

        public void Delete (int dl)
        {
            var deleteList = _rep.listrep.FirstOrDefault(x => x.Id == dl);
            _rep.listrep.Remove(deleteList);
        }
        public int Add(Class2 listrep)
        {
            listrep.Id = 5;
            _rep.listrep.Add(listrep);
            return listrep.Id;
        }



    }
}
