using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Tomas_Irrazabal
{
    internal class Node
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int value { get; set; }
        public Node? next { get; set; }
        public Node? prev { get; set; }
        //Value se usa como int para el ejemplo
        public Node()
        {
            id = 0;
            name = string.Empty;
            value = 0;
            next = null;
            prev = null;
        }
    }
}
