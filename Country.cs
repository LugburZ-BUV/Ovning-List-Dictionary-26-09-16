using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning_List_Dictionary_26_09_16
{
    public class Country
    {
        public string Namn { get; set; }
        public string Kod { get; set; }
        public string Huvudstad { get; set; }

        public Country (string name, string code, string capitol)
        {
            Namn = name;
            Kod = code;
            Huvudstad = capitol;
        }
    }
}
