namespace PetShop.View
{
    partial class TelaAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAgendamento));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            tbx_codigoCliente = new TextBox();
            dateDataAgendamento = new DateTimePicker();
            cbx_horarioAgendamento = new ComboBox();
            btx_agendarAgendamento = new Button();
            btx_deletarAgendamento = new Button();
            btx_gerarCodigoAgendamento = new Button();
            tbx_codigoAgendamento = new TextBox();
            cbx_tipoDeServico = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(433, 323);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(122, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(404, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(122, 68);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(404, 307);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(240, 79);
            label1.Name = "label1";
            label1.Size = new Size(164, 26);
            label1.TabIndex = 4;
            label1.Text = "Agendamento";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 524);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(149, 119);
            label3.Name = "label3";
            label3.Size = new Size(115, 17);
            label3.TabIndex = 6;
            label3.Text = "Código Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(149, 147);
            label6.Name = "label6";
            label6.Size = new Size(120, 17);
            label6.TabIndex = 9;
            label6.Text = "Tipo de Serviço:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(149, 174);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 10;
            label2.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(149, 202);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 11;
            label4.Text = "Horário:";
            // 
            // tbx_codigoCliente
            // 
            tbx_codigoCliente.Location = new Point(270, 117);
            tbx_codigoCliente.Name = "tbx_codigoCliente";
            tbx_codigoCliente.Size = new Size(214, 23);
            tbx_codigoCliente.TabIndex = 18;
            // 
            // dateDataAgendamento
            // 
            dateDataAgendamento.Location = new Point(204, 172);
            dateDataAgendamento.Name = "dateDataAgendamento";
            dateDataAgendamento.Size = new Size(280, 23);
            dateDataAgendamento.TabIndex = 20;
            // 
            // cbx_horarioAgendamento
            // 
            cbx_horarioAgendamento.FormattingEnabled = true;
            cbx_horarioAgendamento.Location = new Point(219, 199);
            cbx_horarioAgendamento.Name = "cbx_horarioAgendamento";
            cbx_horarioAgendamento.Size = new Size(265, 23);
            cbx_horarioAgendamento.TabIndex = 21;
            // 
            // btx_agendarAgendamento
            // 
            btx_agendarAgendamento.BackColor = Color.LawnGreen;
            btx_agendarAgendamento.Location = new Point(135, 323);
            btx_agendarAgendamento.Name = "btx_agendarAgendamento";
            btx_agendarAgendamento.Size = new Size(65, 23);
            btx_agendarAgendamento.TabIndex = 24;
            btx_agendarAgendamento.Text = " Agendar";
            btx_agendarAgendamento.UseVisualStyleBackColor = false;
            // 
            // btx_deletarAgendamento
            // 
            btx_deletarAgendamento.BackColor = Color.Red;
            btx_deletarAgendamento.Location = new Point(206, 323);
            btx_deletarAgendamento.Name = "btx_deletarAgendamento";
            btx_deletarAgendamento.Size = new Size(63, 23);
            btx_deletarAgendamento.TabIndex = 25;
            btx_deletarAgendamento.Text = "Deletar";
            btx_deletarAgendamento.UseVisualStyleBackColor = false;
            // 
            // btx_gerarCodigoAgendamento
            // 
            btx_gerarCodigoAgendamento.BackColor = Color.LavenderBlush;
            btx_gerarCodigoAgendamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btx_gerarCodigoAgendamento.Location = new Point(177, 246);
            btx_gerarCodigoAgendamento.Name = "btx_gerarCodigoAgendamento";
            btx_gerarCodigoAgendamento.Size = new Size(295, 25);
            btx_gerarCodigoAgendamento.TabIndex = 26;
            btx_gerarCodigoAgendamento.Text = "Gerar o Código Agendamento:";
            btx_gerarCodigoAgendamento.UseVisualStyleBackColor = false;
            // 
            // tbx_codigoAgendamento
            // 
            tbx_codigoAgendamento.Location = new Point(275, 277);
            tbx_codigoAgendamento.Name = "tbx_codigoAgendamento";
            tbx_codigoAgendamento.Size = new Size(81, 23);
            tbx_codigoAgendamento.TabIndex = 28;
            // 
            // cbx_tipoDeServico
            // 
            cbx_tipoDeServico.FormattingEnabled = true;
            cbx_tipoDeServico.Location = new Point(275, 144);
            cbx_tipoDeServico.Name = "cbx_tipoDeServico";
            cbx_tipoDeServico.Size = new Size(209, 23);
            cbx_tipoDeServico.TabIndex = 29;
            // 
            // TelaAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(662, 515);
            Controls.Add(cbx_tipoDeServico);
            Controls.Add(tbx_codigoAgendamento);
            Controls.Add(btx_gerarCodigoAgendamento);
            Controls.Add(btx_deletarAgendamento);
            Controls.Add(btx_agendarAgendamento);
            Controls.Add(cbx_horarioAgendamento);
            Controls.Add(dateDataAgendamento);
            Controls.Add(tbx_codigoCliente);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "TelaAgendamento";
            Text = "TelaAgendamento";
            Load += TelaAgendamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label4;
        private TextBox tbx_codigoCliente;
        private DateTimePicker dateDataAgendamento;
        private ComboBox cbx_horarioAgendamento;
        private Button btx_agendarAgendamento;
        private Button btx_deletarAgendamento;
        private Button btx_gerarCodigoAgendamento;
        private TextBox tbx_codigoAgendamento;
        private ComboBox cbx_tipoDeServico;
    }
}