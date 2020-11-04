using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryPOE_17597280
{
    public class idAreas
    {
        private int keys;
        private string Desriptions;

        public idAreas()
        {

        }
        public idAreas(int keys, string desriptions)
        {
            this.Keys = keys;
            Desriptions1 = desriptions;
        }

        public int Keys { get => keys; set => keys = value; }
        public string Desriptions1 { get => Desriptions; set => Desriptions = value; }

    }
}
