using System.Windows.Forms;

namespace eAgendaForms
{
    internal class formPrincipal : Form
    {
        private Button btnTarefa;
        private Button btnContato;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnCompromisso;

        private void InitializeComponent()
        {
            this.btnTarefa = new System.Windows.Forms.Button();
            this.btnContato = new System.Windows.Forms.Button();
            this.btnCompromisso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTarefa
            // 
            this.btnTarefa.Location = new System.Drawing.Point(77, 148);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(89, 32);
            this.btnTarefa.TabIndex = 0;
            this.btnTarefa.Text = "Tarefa";
            this.btnTarefa.UseVisualStyleBackColor = true;
            // 
            // btnContato
            // 
            this.btnContato.Location = new System.Drawing.Point(77, 206);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(89, 32);
            this.btnContato.TabIndex = 1;
            this.btnContato.Text = "Contato";
            this.btnContato.UseVisualStyleBackColor = true;
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.Location = new System.Drawing.Point(77, 262);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(89, 32);
            this.btnCompromisso.TabIndex = 2;
            this.btnCompromisso.Text = "Compromisso";
            this.btnCompromisso.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-Agenda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eAgendaForms.Properties.Resources.icons8_schedule_80;
            this.pictureBox1.Location = new System.Drawing.Point(80, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 87);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // formPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(273, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompromisso);
            this.Controls.Add(this.btnContato);
            this.Controls.Add(this.btnTarefa);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}