using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.View
{
    public partial class TelaPesquisar : Form
    {
        public TelaPesquisar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(TelaPesquisar));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            tbx_codigoAgendamento = new TextBox();
            cbx_horarioAgendamento = new ComboBox();
            dateDataAgendamento = new DateTimePicker();
            tbx_codigoCliente = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            btx_pesquisarAgendamento = new Button();
            btx_deletarAgendamento = new Button();
            cbx_tipoDeServico = new ComboBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 231);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(601, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Crimson;
            label1.Font = new Font("Forte", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(394, 26);
            label1.TabIndex = 5;
            label1.Text = "Pesquisar Dados do Agendamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 49);
            label3.Name = "label3";
            label3.Size = new Size(181, 17);
            label3.TabIndex = 6;
            label3.Text = "Código do Agendamento:";
            // 
            // tbx_codigoAgendamento
            // 
            tbx_codigoAgendamento.Location = new Point(199, 43);
            tbx_codigoAgendamento.Name = "tbx_codigoAgendamento";
            tbx_codigoAgendamento.Size = new Size(207, 23);
            tbx_codigoAgendamento.TabIndex = 18;
            // 
            // cbx_horarioAgendamento
            // 
            cbx_horarioAgendamento.FormattingEnabled = true;
            cbx_horarioAgendamento.Location = new Point(204, 176);
            cbx_horarioAgendamento.Name = "cbx_horarioAgendamento";
            cbx_horarioAgendamento.Size = new Size(265, 23);
            cbx_horarioAgendamento.TabIndex = 30;
            // 
            // dateDataAgendamento
            // 
            dateDataAgendamento.Location = new Point(189, 149);
            dateDataAgendamento.Name = "dateDataAgendamento";
            dateDataAgendamento.Size = new Size(280, 23);
            dateDataAgendamento.TabIndex = 29;
            // 
            // tbx_codigoCliente
            // 
            tbx_codigoCliente.Location = new Point(255, 94);
            tbx_codigoCliente.Name = "tbx_codigoCliente";
            tbx_codigoCliente.Size = new Size(214, 23);
            tbx_codigoCliente.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(134, 179);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 26;
            label4.Text = "Horário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(134, 151);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 25;
            label2.Text = "Data:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(134, 124);
            label6.Name = "label6";
            label6.Size = new Size(120, 17);
            label6.TabIndex = 24;
            label6.Text = "Tipo de Serviço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(134, 96);
            label5.Name = "label5";
            label5.Size = new Size(115, 17);
            label5.TabIndex = 23;
            label5.Text = "Código Cliente:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(107, 82);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(404, 131);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // btx_pesquisarAgendamento
            // 
            btx_pesquisarAgendamento.BackColor = Color.LawnGreen;
            btx_pesquisarAgendamento.Location = new Point(446, 43);
            btx_pesquisarAgendamento.Name = "btx_pesquisarAgendamento";
            btx_pesquisarAgendamento.Size = new Size(65, 23);
            btx_pesquisarAgendamento.TabIndex = 31;
            btx_pesquisarAgendamento.Text = "Pesquisar";
            btx_pesquisarAgendamento.UseVisualStyleBackColor = false;
            // 
            // btx_deletarAgendamento
            // 
            btx_deletarAgendamento.BackColor = Color.Red;
            btx_deletarAgendamento.Location = new Point(517, 43);
            btx_deletarAgendamento.Name = "btx_deletarAgendamento";
            btx_deletarAgendamento.Size = new Size(63, 23);
            btx_deletarAgendamento.TabIndex = 32;
            btx_deletarAgendamento.Text = "Deletar";
            btx_deletarAgendamento.UseVisualStyleBackColor = false;
            // 
            // cbx_tipoDeServico
            // 
            cbx_tipoDeServico.FormattingEnabled = true;
            cbx_tipoDeServico.Location = new Point(260, 121);
            cbx_tipoDeServico.Name = "cbx_tipoDeServico";
            cbx_tipoDeServico.Size = new Size(209, 23);
            cbx_tipoDeServico.TabIndex = 33;
            // 
            // TelaPesquisar
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(600, 433);
            Controls.Add(cbx_tipoDeServico);
            Controls.Add(btx_deletarAgendamento);
            Controls.Add(btx_pesquisarAgendamento);
            Controls.Add(cbx_horarioAgendamento);
            Controls.Add(dateDataAgendamento);
            Controls.Add(tbx_codigoCliente);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(tbx_codigoAgendamento);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaPesquisar";
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TextBox tbx_codigoAgendamento;
        private ComboBox cbx_horarioAgendamento;
        private DateTimePicker dateDataAgendamento;
        private TextBox tbx_codigoCliente;
        private Label label4;
        private Label label2;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox4;
        private Button btx_pesquisarAgendamento;
        private Button btx_deletarAgendamento;
        private ComboBox cbx_tipoDeServico;
    }
}
