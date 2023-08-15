using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ShivaInnovations
{
    public partial class Pgto : Form
    {
        DAO conectar;
        ControlCPF modelo;
        bool validar = true;
        public Pgto()
        {
            
            InitializeComponent();
            conectar = new DAO();  //Ligando o Banco de dados a tabela
            modelo = new ControlCPF();

        }//Fim do construtor

        private void button1_Click(object sender, EventArgs e)
        {


            // validando preenchimento 
            if ((maskedTextBox1.MaskCompleted == false) || (validar == false))
            {

                MessageBox.Show("O campo CPF invalido!");
                MessageBox.Show(Convert.ToString(validar));
                maskedTextBox1.BackColor = Color.Red;
            }
            else if ((maskedTextBox1.MaskCompleted == true) && (validar == true))
            {
                try
                {
                    
                    string result = conectar.Inserir(Convert.ToInt64(maskedTextBox1.Text), nomebox.Text, email.Text, telefone.Text, ingressos.Text, "Cliente");
                    MessageBox.Show(result);
                    validar = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Algo deu errado\n\n" + error);
                    MessageBox.Show(Convert.ToString(validar));
                   



                    validar = true;
                }//Fim do TryCatch
            }
        }//Botão comprar

 

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cpf = maskedTextBox1.Text.Replace(",", "").Replace("-", "");
            validar = this.modelo.Validarcpf(cpf); //Chamando o método



            if (validar)
            {
                MessageBox.Show("CPF INVÁLIDO");
            }
            else
            {
                MessageBox.Show("CPF VÁLIDO");

            }//Fim do IF...Else

        }// cpf

        private void nomebox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// nome

        private void email_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// email

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// telefone 

        private void ingressos_ValueChanged(object sender, EventArgs e)
        {

        }// ingressos

        private void Pgto_Load(object sender, EventArgs e)
        {

        }
    }//fim da classe
}//Fim do projeto
