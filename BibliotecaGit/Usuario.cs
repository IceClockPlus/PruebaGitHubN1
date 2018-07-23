using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGit
{
    public class Usuario
    {
        public string Nombre { get; set; }

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
