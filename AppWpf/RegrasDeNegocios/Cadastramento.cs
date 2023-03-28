using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AppWpf.RegrasDeNegocios
{
    internal class Cadastramento
    {
       public string Nome { get; set; }
       public string Email { get; set; }
       public string Telefone { get; set; }
       public DatePicker Data { get; set; }
       public string Sexo { get; set; }      
    }
}