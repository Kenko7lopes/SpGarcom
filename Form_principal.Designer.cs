namespace SpG
{
    partial class Form_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.grid_cozinha = new System.Windows.Forms.DataGridView();
            this.pedidoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidomesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidopratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedido_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grid_copa = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_novop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cozinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_copa)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_cozinha
            // 
            this.grid_cozinha.AutoGenerateColumns = false;
            this.grid_cozinha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_cozinha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_cozinha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cozinha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pedidoidDataGridViewTextBoxColumn,
            this.pedidomesaDataGridViewTextBoxColumn,
            this.pedidoclienteDataGridViewTextBoxColumn,
            this.pedidopratoDataGridViewTextBoxColumn,
            this.pedido_status});
            this.grid_cozinha.DataSource = this.pedidoBindingSource;
            this.grid_cozinha.Location = new System.Drawing.Point(25, 121);
            this.grid_cozinha.Name = "grid_cozinha";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.grid_cozinha.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_cozinha.Size = new System.Drawing.Size(651, 130);
            this.grid_cozinha.TabIndex = 0;
            // 
            // pedidoidDataGridViewTextBoxColumn
            // 
            this.pedidoidDataGridViewTextBoxColumn.DataPropertyName = "pedido_id";
            this.pedidoidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pedidoidDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.pedidoidDataGridViewTextBoxColumn.Name = "pedidoidDataGridViewTextBoxColumn";
            this.pedidoidDataGridViewTextBoxColumn.Width = 70;
            // 
            // pedidomesaDataGridViewTextBoxColumn
            // 
            this.pedidomesaDataGridViewTextBoxColumn.DataPropertyName = "pedido_mesa";
            this.pedidomesaDataGridViewTextBoxColumn.HeaderText = "Mesa";
            this.pedidomesaDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.pedidomesaDataGridViewTextBoxColumn.Name = "pedidomesaDataGridViewTextBoxColumn";
            this.pedidomesaDataGridViewTextBoxColumn.Width = 77;
            // 
            // pedidoclienteDataGridViewTextBoxColumn
            // 
            this.pedidoclienteDataGridViewTextBoxColumn.DataPropertyName = "pedido_cliente";
            this.pedidoclienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.pedidoclienteDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.pedidoclienteDataGridViewTextBoxColumn.Name = "pedidoclienteDataGridViewTextBoxColumn";
            this.pedidoclienteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pedidopratoDataGridViewTextBoxColumn
            // 
            this.pedidopratoDataGridViewTextBoxColumn.DataPropertyName = "pedido_prato";
            this.pedidopratoDataGridViewTextBoxColumn.HeaderText = "Prato";
            this.pedidopratoDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.pedidopratoDataGridViewTextBoxColumn.Name = "pedidopratoDataGridViewTextBoxColumn";
            this.pedidopratoDataGridViewTextBoxColumn.Width = 250;
            // 
            // pedido_status
            // 
            this.pedido_status.DataPropertyName = "pedido_status";
            this.pedido_status.HeaderText = "Status";
            this.pedido_status.Name = "pedido_status";
            this.pedido_status.Width = 88;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(SpG.model.Pedido);
            // 
            // grid_copa
            // 
            this.grid_copa.AutoGenerateColumns = false;
            this.grid_copa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_copa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_copa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_copa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.grid_copa.DataSource = this.pedidoBindingSource;
            this.grid_copa.Location = new System.Drawing.Point(25, 292);
            this.grid_copa.Name = "grid_copa";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_copa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_copa.Size = new System.Drawing.Size(651, 134);
            this.grid_copa.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pedido_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pedido_mesa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mesa";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "pedido_cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "pedido_bebida";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bebida";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pedido_status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 88;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(694, 263);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(94, 58);
            this.btn_atualizar.TabIndex = 3;
            this.btn_atualizar.Text = "Atualizar pedidos";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click_1);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_reset.Location = new System.Drawing.Point(694, 415);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 23);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Resetar";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cozinha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Copa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 175);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 175);
            this.panel2.TabIndex = 8;
            // 
            // btn_novop
            // 
            this.btn_novop.Location = new System.Drawing.Point(694, 77);
            this.btn_novop.Name = "btn_novop";
            this.btn_novop.Size = new System.Drawing.Size(94, 58);
            this.btn_novop.TabIndex = 9;
            this.btn_novop.Text = "Novo pedido";
            this.btn_novop.UseVisualStyleBackColor = true;
            this.btn_novop.Click += new System.EventHandler(this.btn_novop_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.grid_copa);
            this.Controls.Add(this.grid_cozinha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_novop);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_principal";
            this.Text = "Sistema para Garçom";
            ((System.ComponentModel.ISupportInitialize)(this.grid_cozinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_copa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_cozinha;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private System.Windows.Forms.DataGridView grid_copa;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidomesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidopratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_novop;
    }
}

