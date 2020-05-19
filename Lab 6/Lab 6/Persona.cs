using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Persona
    {
        string name;
        string lastname;
        int ID;
        string charge;

        public Persona(string name, string lastname, int ID, string charge)
        {
            this.name = name;
            this.lastname = lastname;
            this.ID = ID;
            this.charge = charge;
        }
    }
}
