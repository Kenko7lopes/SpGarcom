using SpG.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;


namespace SpG
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }
        

        private void btn_atualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Conexao.db.State == ConnectionState.Closed)
                {
                    Conexao.db.Open();
                }
            }
            catch (Exception v)
            {
                MessageBox.Show("Erro na conexao");
                MessageBox.Show(v.ToString());
            }
            pedidoBindingSource.DataSource = Conexao.db.Query<Pedido>("SELECT * FROM tabelapedido");
        }      

        private void btn_novop_Click(object sender, EventArgs e)
        {              
            Form_novoPedido formPedido = new Form_novoPedido();
            formPedido.ShowDialog();
        }

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            var stringInsert = "delete from tabelapedido";
            if (Conexao.db.State == ConnectionState.Closed)
            {
                Conexao.db.Open();
            }
            MessageBox.Show("Dados resetados");
            SqlCommand com = new SqlCommand(stringInsert, Conexao.db);
            SqlDataReader sdr = com.ExecuteReader();
            Conexao.db.Close();
        }
    }
}
