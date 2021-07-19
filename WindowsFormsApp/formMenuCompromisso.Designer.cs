
namespace WindowsFormsApp
{
    partial class formMenuCompromisso
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskLink = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textAssunto = new System.Windows.Forms.TextBox();
            this.dgvCompromisso = new System.Windows.Forms.DataGridView();
            this.btnDeleteCompromisso = new System.Windows.Forms.Button();
            this.btnEditCompromisso = new System.Windows.Forms.Button();
            this.btnAddCompromisso = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mskInicio = new System.Windows.Forms.MaskedTextBox();
            this.mskTermino = new System.Windows.Forms.MaskedTextBox();
            this.txtIdCompromisso = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtContatoBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisso)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Local :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Id :";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(101, 57);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(136, 20);
            this.txtLocal.TabIndex = 49;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 48;
            // 
            // dateInicial
            // 
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicial.Location = new System.Drawing.Point(257, 54);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(101, 20);
            this.dateInicial.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Data  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Hora de Inicio :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Hora de Término :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Link :";
            // 
            // maskLink
            // 
            this.maskLink.Location = new System.Drawing.Point(598, 55);
            this.maskLink.Name = "maskLink";
            this.maskLink.Size = new System.Drawing.Size(127, 20);
            this.maskLink.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Assunto da reuniao :";
            // 
            // textAssunto
            // 
            this.textAssunto.Location = new System.Drawing.Point(12, 115);
            this.textAssunto.Multiline = true;
            this.textAssunto.Name = "textAssunto";
            this.textAssunto.Size = new System.Drawing.Size(244, 58);
            this.textAssunto.TabIndex = 65;
            // 
            // dgvCompromisso
            // 
            this.dgvCompromisso.AllowUserToAddRows = false;
            this.dgvCompromisso.AllowUserToDeleteRows = false;
            this.dgvCompromisso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromisso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompromisso.Location = new System.Drawing.Point(12, 196);
            this.dgvCompromisso.Name = "dgvCompromisso";
            this.dgvCompromisso.Size = new System.Drawing.Size(776, 216);
            this.dgvCompromisso.TabIndex = 66;
            this.dgvCompromisso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompromisso_CellClick);
            // 
            // btnDeleteCompromisso
            // 
            this.btnDeleteCompromisso.Location = new System.Drawing.Point(689, 150);
            this.btnDeleteCompromisso.Name = "btnDeleteCompromisso";
            this.btnDeleteCompromisso.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCompromisso.TabIndex = 69;
            this.btnDeleteCompromisso.Text = "Excluir";
            this.btnDeleteCompromisso.UseVisualStyleBackColor = true;
            this.btnDeleteCompromisso.Click += new System.EventHandler(this.btnDeleteCompromisso_Click);
            // 
            // btnEditCompromisso
            // 
            this.btnEditCompromisso.Location = new System.Drawing.Point(598, 150);
            this.btnEditCompromisso.Name = "btnEditCompromisso";
            this.btnEditCompromisso.Size = new System.Drawing.Size(75, 23);
            this.btnEditCompromisso.TabIndex = 68;
            this.btnEditCompromisso.Text = "Editar";
            this.btnEditCompromisso.UseVisualStyleBackColor = true;
            this.btnEditCompromisso.Click += new System.EventHandler(this.btnEditCompromisso_Click);
            // 
            // btnAddCompromisso
            // 
            this.btnAddCompromisso.Location = new System.Drawing.Point(507, 150);
            this.btnAddCompromisso.Name = "btnAddCompromisso";
            this.btnAddCompromisso.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompromisso.TabIndex = 67;
            this.btnAddCompromisso.Text = "Adicionar";
            this.btnAddCompromisso.UseVisualStyleBackColor = true;
            this.btnAddCompromisso.Click += new System.EventHandler(this.btnAddCompromisso_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 70;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // mskInicio
            // 
            this.mskInicio.Location = new System.Drawing.Point(389, 56);
            this.mskInicio.Mask = "##:##";
            this.mskInicio.Name = "mskInicio";
            this.mskInicio.Size = new System.Drawing.Size(57, 20);
            this.mskInicio.TabIndex = 72;
            // 
            // mskTermino
            // 
            this.mskTermino.Location = new System.Drawing.Point(495, 56);
            this.mskTermino.Mask = "##:##";
            this.mskTermino.Name = "mskTermino";
            this.mskTermino.Size = new System.Drawing.Size(57, 20);
            this.mskTermino.TabIndex = 73;
            // 
            // txtIdCompromisso
            // 
            this.txtIdCompromisso.Location = new System.Drawing.Point(288, 115);
            this.txtIdCompromisso.Name = "txtIdCompromisso";
            this.txtIdCompromisso.Size = new System.Drawing.Size(70, 20);
            this.txtIdCompromisso.TabIndex = 74;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtContatoBuscar
            // 
            this.txtContatoBuscar.Location = new System.Drawing.Point(288, 157);
            this.txtContatoBuscar.Name = "txtContatoBuscar";
            this.txtContatoBuscar.Size = new System.Drawing.Size(70, 20);
            this.txtContatoBuscar.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "ID Do Compromisso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Contato";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::WindowsFormsApp.Properties.Resources.round_close_black_24dp1;
            this.btnExit.Location = new System.Drawing.Point(757, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 23);
            this.btnExit.TabIndex = 71;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formMenuCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContatoBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdCompromisso);
            this.Controls.Add(this.mskTermino);
            this.Controls.Add(this.mskInicio);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteCompromisso);
            this.Controls.Add(this.btnEditCompromisso);
            this.Controls.Add(this.btnAddCompromisso);
            this.Controls.Add(this.dgvCompromisso);
            this.Controls.Add(this.textAssunto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMenuCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMenuCompromisso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisso)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAssunto;
        private System.Windows.Forms.DataGridView dgvCompromisso;
        private System.Windows.Forms.Button btnDeleteCompromisso;
        private System.Windows.Forms.Button btnEditCompromisso;
        private System.Windows.Forms.Button btnAddCompromisso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MaskedTextBox mskInicio;
        private System.Windows.Forms.MaskedTextBox mskTermino;
        private System.Windows.Forms.TextBox txtIdCompromisso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtContatoBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}