using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasics.Interface
{
    public interface ISample
    {
        void Add(string name);
        string Get(int id);
    }
    public class SampleBase : ISample
    {
        public string[] collection = new string[5];
        public void Add(string name)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == null)
                {
                    collection[i] = name;
                    break;
                }
            }
        }
        public string Get(int id)
        {
            string name = string.Empty;
            if (collection != null && (id > 0 && id <= collection.Length))
            {
                name = collection[id];
            }

            return name;
        }
    }

}
