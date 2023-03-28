using System;
using System.Collections.Generic;
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
using AppWpf.Formularios;
using AppWpf.Contexto;
using AppWpf.RegrasDeNegocios;
using MySql.Data.MySqlClient;

namespace AppWpf.Formularios
{
    /// <summary>
    /// Lógica interna para CadastrarContato.xaml
    /// </summary>
    public partial class CadastrarContato : Window
    {
        private MySqlConnection _conexao;
        public CadastrarContato()
        {
            InitializeComponent();
            Conexao();

            tbEmail.IsEnabled = false;
            tbNome.IsEnabled = false;
            tbTelefone.IsEnabled = false;
            dtpDataNascimento.IsEnabled = false;
            tbSexo.IsEnabled = false;
            btCancelar.IsEnabled = false;
            btSalvar.IsEnabled = false;
        }
        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }
        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            tbEmail.IsEnabled = true;
            tbNome.IsEnabled = true;
            tbTelefone.IsEnabled = true;
            dtpDataNascimento.IsEnabled = true;
            tbSexo.IsEnabled = true;
            btSalvar.IsEnabled = true;
            btCancelar.IsEnabled = true;
            btAdd.IsEnabled = false;
        }
        private void btCalcelar_Click(object sender, RoutedEventArgs e)
        {
            tbEmail.IsEnabled = false;
            tbNome.IsEnabled = false;
            tbTelefone.IsEnabled = false;
            dtpDataNascimento.IsEnabled = false;
            tbSexo.IsEnabled = false;
            btCancelar.IsEnabled = false;
            btSalvar.IsEnabled = false;
            btAdd.IsEnabled = true;
            tbEmail.Clear();
            tbNome.Clear();
            tbTelefone.Clear();
            tbSexo.Clear();
        }
        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var nome = tbNome.Text;
                var data = dtpDataNascimento.Text;
                var sexo = tbSexo.Text;
                var email = tbEmail.Text;
                var telefone = tbTelefone.Text;

                if (dtpDataNascimento.SelectedDate != null)
                {
                    DateTime dataNasc = (DateTime)dtpDataNascimento.SelectedDate;

                    var sql = "INSERT INTO contato (nome_con, data_nasc_con, sexo_con, email_con, telefone_con) VALUES (@_nome, @_data_nasc, @_sexo, @_email, @_telefone);";
                    var comando = new MySqlCommand(sql, _conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_data_nasc", dataNasc.ToString("yyyy-mm-dd"));
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("SALVO COM SUCESSO!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Ocorreram erros ao salvar as informçães! " + "Contate a equipe de suporte do sistema. (CAD 10)");
            }
            Cadastramento objcadastramento = new Cadastramento();
            objcadastramento.Email = tbEmail.Text;
            objcadastramento.Nome = tbNome.Text;
            objcadastramento.Telefone = tbTelefone.Text;
            objcadastramento.Data = dtpDataNascimento;
            objcadastramento.Sexo = tbSexo.Text;
            DadosContato.lista.Add(objcadastramento);
            tbEmail.IsEnabled = false;
            tbNome.IsEnabled = false;
            tbTelefone.IsEnabled = false;
            dtpDataNascimento.IsEnabled = false;
            tbSexo.IsEnabled = false;
            btCancelar.IsEnabled = false;
            btSalvar.IsEnabled = false;
            btAdd.IsEnabled = true;
            tbEmail.Clear();
            tbNome.Clear();
            tbTelefone.Clear();
            tbSexo.Clear();
        }
    }
}