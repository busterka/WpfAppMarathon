using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMarathon
{
    class Core
    {
        public static Entites.MarathonSkillsEntities2 DB = new Entites.MarathonSkillsEntities2();

        public object FirtsName { get; internal set; }
        public string LastName { get; internal set; }
        public string Email { get; internal set; }
    }

}
