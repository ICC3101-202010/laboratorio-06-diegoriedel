using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    [Serializable]
    class Empresa
    {
        
        public string name;
        public int ID;

        public Empresa(string name, int ID)
        {
            this.name = name;
            this.ID = ID;
            this.divisiones = divisiones;
        }
        public List<Division> divisiones;
    }
}