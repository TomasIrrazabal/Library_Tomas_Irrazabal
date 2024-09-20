using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Tomas_Irrazabal
{
    internal class LIFO
    {
        public Node first {  get; set; }
        public Node last { get; set; }
        public LIFO()
        {
            first = null;
            last = null;
        }
        public void Insert(Node nuevo)
        {
            if (first == null) 
            {
                first = nuevo;
                last = nuevo;
            }
            else 
            {
                nuevo.previus = last;
                last = nuevo;
            }
        }
        public Node Remove()
        {
            Node aux = null;
            if (last != null) 
            {
                aux = last; 
                if (first == last && first != null) 
                {
                    first = null;
                    last = null;
                }
                else 
                {
                    last = last.previus;
                }
            }
            return aux;
        }
        public List<Node> Tolist()
        {
            List<Node> nodos = new List<Node>(); 
            Node aux = last; 
            while (aux != null)
            {
                nodos.Add(aux); 
                aux = aux.previus; 
            }
            return nodos;
        }
        public Node Find(Object var)
        {
            Node node = null;
            Node aux = last; 
            while (aux != null)
            {
                if (aux.value == Convert.ToInt32(var))
                {
                    node = aux;
                    return node;
                }
                aux = aux.previus; 
            }
            return node; 
        }
    }
}
