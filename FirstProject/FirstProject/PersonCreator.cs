using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class ObjectCreator
    {
        public T CreateFromTypeUsingDefaultConstructor<T>(string typeName) where T : class, new()
        {
            T element = null; 

            Type t = Type.GetType(typeName, false);
            if (t != null)
            {
                element = (T)Activator.CreateInstance(t);
            }

            return element; 
        }

    }
}
