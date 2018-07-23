using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGit
{
    public class Profesion
    {
        public string NombreProfesion { get; set; }

        public Profesion()
        {
            this.Init();
        }

        private void Init()
        {
            this.NombreProfesion = string.Empty;
        }
    }
}
