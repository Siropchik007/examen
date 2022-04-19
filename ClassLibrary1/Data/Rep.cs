using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data
{
    public class Rep
    {
        public List<Class2> listrep;

        public Rep()
        {
            listrep = new List<Class2>()
            {
                new Class2(){Id = 1, Name = "Imya1"},
                new Class2(){Id = 2, Name = "Imya2"},
                new Class2(){Id = 3, Name = "Imya3"}
            };
        }
    }
}
