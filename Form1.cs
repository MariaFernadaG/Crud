using MySql.Data.MySqlClient;

namespace Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //verificaçao se todos campos estao preenchidos 
                if (!txtNome.Text.Equals("") &&!txtEmail.Text.Equals("") && !txtCpf.Text.Equals("") &&!txtEndereco.Text.Equals("") )
                {
                   Funcionario cadFuncionario = new Funcionario();
                    cadFuncionario.Nome = txtNome.Text;
                    cadFuncionario.Email = txtEmail.Text;
                    cadFuncionario.Cpf = txtCpf.Text;  
                    cadFuncionario.Endereco = txtEndereco.Text; 

                    //verificar comando de cadastrar funciona
                    if (cadFuncionario.cadastrarFuncionario())
                    {
                        MessageBox.Show($"O funcionarios{cadFuncionario.Nome} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Não foi possivel cadastrar funcionario {cadFuncionario.Nome} ");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos campos corretamente!");
                    txtNome.Clear();   
                    txtEmail.Clear();
                    txtCpf.Clear();
                    txtEndereco.Clear();    
                    txtNome.Focus();
                }
            }catch  (Exception ex) { }
            {
                MessageBox.Show("Error ao cadastrar funcionario");
            }
        }
    }
}