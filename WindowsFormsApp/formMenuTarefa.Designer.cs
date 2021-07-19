
namespace WindowsFormsApp
{
    partial class formMenuTarefa
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
            this.menuTarefas = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTarefa = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tckPrioridade = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrioridade = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateCriacao = new System.Windows.Forms.DateTimePicker();
            this.dateConclusao = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddTarefa = new System.Windows.Forms.Button();
            this.btnEditTarefa = new System.Windows.Forms.Button();
            this.btnDeleteTarefa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckPrioridade)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTarefas
            // 
            this.menuTarefas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTarefas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuTarefas.Location = new System.Drawing.Point(0, 0);
            this.menuTarefas.Name = "menuTarefas";
            this.menuTarefas.Size = new System.Drawing.Size(800, 25);
            this.menuTarefas.TabIndex = 1;
            this.menuTarefas.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.toolStripSeparator1,
            this.voltarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // dgvTarefa
            // 
            this.dgvTarefa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTarefa.Location = new System.Drawing.Point(12, 178);
            this.dgvTarefa.Name = "dgvTarefa";
            this.dgvTarefa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarefa.Size = new System.Drawing.Size(776, 216);
            this.dgvTarefa.TabIndex = 2;
            this.dgvTarefa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefa_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(114, 54);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(225, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titulo :";
            // 
            // tckPrioridade
            // 
            this.tckPrioridade.Location = new System.Drawing.Point(368, 55);
            this.tckPrioridade.Maximum = 2;
            this.tckPrioridade.Name = "tckPrioridade";
            this.tckPrioridade.Size = new System.Drawing.Size(104, 45);
            this.tckPrioridade.TabIndex = 7;
            this.tckPrioridade.TickFrequency = 0;
            this.tckPrioridade.Value = 1;
            this.tckPrioridade.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prioridade :";
            // 
            // textPrioridade
            // 
            this.textPrioridade.AutoSize = true;
            this.textPrioridade.Location = new System.Drawing.Point(441, 35);
            this.textPrioridade.Name = "textPrioridade";
            this.textPrioridade.Size = new System.Drawing.Size(13, 13);
            this.textPrioridade.TabIndex = 9;
            this.textPrioridade.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "1 - Baixa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "2 - Normal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "3 - Alta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Percentual :";
            // 
            // txtPercentual
            // 
            this.txtPercentual.Location = new System.Drawing.Point(596, 52);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(81, 20);
            this.txtPercentual.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data de Criação :";
            // 
            // dateCriacao
            // 
            this.dateCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCriacao.Location = new System.Drawing.Point(15, 116);
            this.dateCriacao.Name = "dateCriacao";
            this.dateCriacao.Size = new System.Drawing.Size(101, 20);
            this.dateCriacao.TabIndex = 16;
            // 
            // dateConclusao
            // 
            this.dateConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateConclusao.Location = new System.Drawing.Point(158, 116);
            this.dateConclusao.Name = "dateConclusao";
            this.dateConclusao.Size = new System.Drawing.Size(101, 20);
            this.dateConclusao.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Data de Conclusão :";
            // 
            // btnAddTarefa
            // 
            this.btnAddTarefa.Location = new System.Drawing.Point(483, 132);
            this.btnAddTarefa.Name = "btnAddTarefa";
            this.btnAddTarefa.Size = new System.Drawing.Size(75, 23);
            this.btnAddTarefa.TabIndex = 19;
            this.btnAddTarefa.Text = "Adicionar";
            this.btnAddTarefa.UseVisualStyleBackColor = true;
            this.btnAddTarefa.Click += new System.EventHandler(this.btnAddTarefa_Click);
            // 
            // btnEditTarefa
            // 
            this.btnEditTarefa.Location = new System.Drawing.Point(582, 132);
            this.btnEditTarefa.Name = "btnEditTarefa";
            this.btnEditTarefa.Size = new System.Drawing.Size(75, 23);
            this.btnEditTarefa.TabIndex = 20;
            this.btnEditTarefa.Text = "Editar";
            this.btnEditTarefa.UseVisualStyleBackColor = true;
            this.btnEditTarefa.Click += new System.EventHandler(this.btnEditTarefa_Click);
            // 
            // btnDeleteTarefa
            // 
            this.btnDeleteTarefa.Location = new System.Drawing.Point(677, 132);
            this.btnDeleteTarefa.Name = "btnDeleteTarefa";
            this.btnDeleteTarefa.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTarefa.TabIndex = 21;
            this.btnDeleteTarefa.Text = "Excluir";
            this.btnDeleteTarefa.UseVisualStyleBackColor = true;
            this.btnDeleteTarefa.Click += new System.EventHandler(this.btnDeleteTarefa_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::WindowsFormsApp.Properties.Resources.round_close_black_24dp1;
            this.btnExit.Location = new System.Drawing.Point(757, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formMenuTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteTarefa);
            this.Controls.Add(this.btnEditTarefa);
            this.Controls.Add(this.btnAddTarefa);
            this.Controls.Add(this.dateConclusao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateCriacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPercentual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrioridade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tckPrioridade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvTarefa);
            this.Controls.Add(this.menuTarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMenuTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu para Tarefas ";
            this.menuTarefas.ResumeLayout(false);
            this.menuTarefas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckPrioridade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuTarefas;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTarefa;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tckPrioridade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textPrioridade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateCriacao;
        private System.Windows.Forms.DateTimePicker dateConclusao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddTarefa;
        private System.Windows.Forms.Button btnEditTarefa;
        private System.Windows.Forms.Button btnDeleteTarefa;
        private System.Windows.Forms.Button btnExit;
    }
}