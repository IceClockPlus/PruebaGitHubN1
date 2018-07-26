using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGit
{
    public class Colegio
    {
        public string Nombre { get; set; }

        public int AnnoInicio { get; set; }

        public Colegio()
        {
            this.Init();
        }

        private void Init()
        {
            this.Nombre = string.Empty;
            this.AnnoInicio = 0;
        }




    }
}
