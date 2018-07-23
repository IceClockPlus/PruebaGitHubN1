using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGit
{
    class Usuario
    {
        private string Nombre;

        public Usuario()
        {
            this.Init();
        }

        private void Init()
        {
            this.Nombre = String.Empty;
        }
    }
}
