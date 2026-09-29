using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace CrudWinPlanoSaude
{
    public partial class Form1 : Form
    {
        SqlConnection connectionDB;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        String stringSQL;

        public Form1()
        {
            InitializeComponent();
        }

        // Este evento chamado quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Evento do botão
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Inserir dados 
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodeID.Text, out int codePlano))
            {
                return;
            }
            // bloco de exeção
            try
            {
                // instancia da string de conexão
                connectionDB = new SqlConnection(@"Server=Mari;Database=ClinicaMedica;Trusted_Connection=True;TrustServerCertificate=True");

                // comando de inclusão
                stringSQL = "INSERT INTO Tab_Planos_Saude (codigo_plano_saude, nome_plano_saude) VALUES (@codeID, @name)";
                // Comando sql            
                command = new SqlCommand(stringSQL, connectionDB);
                // Adicionando parâmetros
                command.Parameters.AddWithValue("@codeID", codePlano);
                command.Parameters.AddWithValue("@name", txtName.Text);

                connectionDB.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connectionDB.Close();
                connectionDB = null;
                command = null;
            }

        }
        // Exibir tabela
        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodeID.Text, out int codePlano))
            {
                return;
            }
            // bloco de exeção
            try
            {
                // instancia da string de conexão
                connectionDB = new SqlConnection(@"Server=Mari;Database=ClinicaMedica;Trusted_Connection=True;TrustServerCertificate=True");

                // comando de exibição
                stringSQL = "SELECT * FROM Tab_Planos_Saude";

                // criando novo dataset para preencher o datagriew
                DataSet data_set = new DataSet();
                adapter = new SqlDataAdapter(stringSQL, connectionDB);

                connectionDB.Open();
                adapter.Fill(data_set);

                // exibir datagridview
                dataGridView1.DataSource = data_set.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connectionDB.Close();
                connectionDB = null;
                command = null;
            }
        }

        // Edição de registro - EDITAR 
        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }


        // Excluir registro
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodeID.Text, out int codePlano))
            {
                return;
            }
            // bloco de exeção
            try
            {
                // instancia da string de conexão
                connectionDB = new SqlConnection(@"Server=Mari;Database=ClinicaMedica;Trusted_Connection=True;TrustServerCertificate=True");

                // comando para deletar
                stringSQL = "DELETE Tab_Planos_Saude WHERE codigo_plano_saude = @codeID";
                // Comando sql            
                command = new SqlCommand(stringSQL, connectionDB);
                // Adicionando parâmetros
                command.Parameters.AddWithValue("@codeID", codePlano);

                connectionDB.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connectionDB.Close();
                connectionDB = null;
                command = null;
            }
        }

        // Editar - Update
        private void button2_Click_2(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodeID.Text, out int codePlano)) { return; } 
            //bloco de exeção
            try {  
                //instancia da string de conexão
                connectionDB = new SqlConnection(@"Server=Mari;Database=ClinicaMedica;Trusted_Connection=True;TrustServerCertificate=True");  

                //comando de
                stringSQL = "UPDATE Tab_Planos_Saude SET nome_plano_saude = @name WHERE codigo_plano_saude = @codeID";

                //Comando sql
                command = new SqlCommand(stringSQL, connectionDB); 
                //Adicionando parâmetros
                command.Parameters.AddWithValue("@codeID", codePlano);
                command.Parameters.AddWithValue("@name", txtName.Text);

                connectionDB.Open();
                command.ExecuteNonQuery(); 
            } catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            } finally { 
                connectionDB.Close(); 
                connectionDB = null; command = null; 
            }
        }
    }
}


