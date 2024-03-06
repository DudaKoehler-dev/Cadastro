namespace _221039.models
{
    partial class frmmarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvmarca = new System.Windows.Forms.DataGridView();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btbalterar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lk = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmarca
            // 
            this.dgvmarca.AllowUserToAddRows = false;
            this.dgvmarca.AllowUserToDeleteRows = false;
            this.dgvmarca.AllowUserToOrderColumns = true;
            this.dgvmarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmarca.Location = new System.Drawing.Point(32, 237);
            this.dgvmarca.Name = "dgvmarca";
            this.dgvmarca.ReadOnly = true;
            this.dgvmarca.Size = new System.Drawing.Size(405, 172);
            this.dgvmarca.TabIndex = 30;
            this.dgvmarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmarca_CellContentClick);
            // 
            // btnfechar
            // 
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(348, 118);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 23);
            this.btnfechar.TabIndex = 29;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click_1);
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisa.Location = new System.Drawing.Point(348, 194);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(89, 23);
            this.btnpesquisa.TabIndex = 28;
            this.btnpesquisa.Text = "Pesquisar";
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click_1);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(269, 118);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 27;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click_1);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(185, 118);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(81, 23);
            this.btncancelar.TabIndex = 26;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click_1);
            // 
            // btbalterar
            // 
            this.btbalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbalterar.Location = new System.Drawing.Point(107, 118);
            this.btbalterar.Name = "btbalterar";
            this.btbalterar.Size = new System.Drawing.Size(75, 23);
            this.btbalterar.TabIndex = 25;
            this.btbalterar.Text = "Alterar";
            this.btbalterar.UseVisualStyleBackColor = true;
            this.btbalterar.Click += new System.EventHandler(this.btbalterar_Click_1);
            // 
            // btnincluir
            // 
            this.btnincluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincluir.Location = new System.Drawing.Point(29, 118);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 24;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click_1);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(29, 197);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(315, 20);
            this.txtPesquisa.TabIndex = 23;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(90, 72);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(338, 20);
            this.txtmarca.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(29, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(135, 20);
            this.txtID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Digite o nome da marca para pesquisa:";
            // 
            // lk
            // 
            this.lk.AutoSize = true;
            this.lk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lk.Location = new System.Drawing.Point(30, 72);
            this.lk.Name = "lk";
            this.lk.Size = new System.Drawing.Size(54, 16);
            this.lk.TabIndex = 17;
            this.lk.Text = "Marca:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(29, 17);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(61, 16);
            this.l.TabIndex = 16;
            this.l.Text = "Código:";
            // 
            // frmmarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgvmarca);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnpesquisa);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btbalterar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lk);
            this.Controls.Add(this.l);
            this.Name = "frmmarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "marca";
            this.Load += new System.EventHandler(this.frmmarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmarca;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btbalterar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lk;
        private System.Windows.Forms.Label l;
    }
}