using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppWpf.Formularios
{
    /// <summary>
    /// Lógica interna para ListarContato.xaml
    /// </summary>
    public partial class ListarContato : Window
    {
        private MySqlConnection _conexao;
        public ListarContato()
        {
            InitializeComponent();
            Conexao();
            Listar();
        }
        public void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }
     private void Listar()
        {
            string sql = "Select * from Contato";
            var comando = new MySqlCommand(sql, _conexao);
            var reader = comando.ExecuteReader();
            var lista = new List<Object>();

            while (reader.Read())
            {
                string data = "";
                try
                {
                    data = reader.GetDateTime("data_nasc_con").ToString("dd/mm/yyyy");
                }
                catch { }

                var contato = new
                {
                    Nome = reader.GetString(1),
                    Data_Nascimento = data,
                    Sexo = reader.GetString(3),
                    Email = reader.GetString(4),
                    Telefone = reader.GetString(5),
                };
                lista.Add(contato);
            }
            dgvListarContato1.ItemsSource = lista;
        }
    }
}