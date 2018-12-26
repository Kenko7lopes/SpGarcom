using SpG.model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SpG
{
    public partial class Form_novoPedido : Form
    {
        public Form_novoPedido()
        {
            InitializeComponent();
        }

        private void btn_ConcluirPedido_Click(object sender, EventArgs e)
        {
            // Inserir dados no banco
            if (Conexao.db.State == ConnectionState.Closed)
            {
                Conexao.db.Open();
            }
            var stringInsert = "INSERT INTO tabelapedido(pedido_mesa,pedido_cliente,pedido_prato,pedido_bebida) VALUES ('" + txt_mesa.Text + "','" + txt_cliente.Text + "','" + txt_prato.Text + "','" + txt_bebida.Text + "')";
            SqlCommand com = new SqlCommand(stringInsert,Conexao.db);
            SqlDataReader sdr = com.ExecuteReader();
            this.Close();
            Conexao.db.Close();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
