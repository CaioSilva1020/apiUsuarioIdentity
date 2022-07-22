using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClasseExemplo
    {
        public List<object> Dados { get; set; }
        public ClasseExemplo()
        {
            Dados = new List<object>();
        }

        public List<T> Retornar<T>()
        {
            List<T> retorno = new List<T>();
            foreach (object o in Dados)
            {
                if (o is T)
                    retorno.Add((T)o);
            }
            return retorno;
        }
    }
}
