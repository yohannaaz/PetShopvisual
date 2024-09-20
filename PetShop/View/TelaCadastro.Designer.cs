namespace PetShop.View
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            colorDialog1 = new ColorDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cbx_sexoPet = new ComboBox();
            cbx_portePet = new ComboBox();
            tbx_nomeTutor = new TextBox();
            tbx_telefoneTutor = new TextBox();
            tbx_enderecoTutor = new TextBox();
            tbx_cpfTutor = new TextBox();
            tbx_nomePet = new TextBox();
            tbx_racaPet = new TextBox();
            btx_cadastrarCadastro = new Button();
            btx_deletarCadastro = new Button();
            btx_gerarCodigoCliente = new Button();
            tbx_codigoCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(294, 91);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 0;
            label1.Text = "Dados do Tutor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MidnightBlue;
            label2.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(537, 91);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 1;
            label2.Text = "Dados do Pet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(294, 123);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Forte", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(419, 40);
            label4.Name = "label4";
            label4.Size = new Size(163, 38);
            label4.TabIndex = 3;
            label4.Text = "Cadastro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(739, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 457);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(754, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-2, -11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(262, 488);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(294, 188);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 7;
            label5.Text = "Endereço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(294, 156);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 8;
            label6.Text = "Telefone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(294, 224);
            label7.Name = "label7";
            label7.Size = new Size(0, 17);
            label7.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(537, 123);
            label8.Name = "label8";
            label8.Size = new Size(52, 17);
            label8.TabIndex = 10;
            label8.Text = "Nome:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(537, 224);
            label9.Name = "label9";
            label9.Size = new Size(51, 17);
            label9.TabIndex = 11;
            label9.Text = "Porte:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(537, 188);
            label10.Name = "label10";
            label10.Size = new Size(45, 17);
            label10.TabIndex = 12;
            label10.Text = "Sexo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(537, 156);
            label11.Name = "label11";
            label11.Size = new Size(48, 17);
            label11.TabIndex = 13;
            label11.Text = "Raça:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Kristen ITC", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(294, 224);
            label12.Name = "label12";
            label12.Size = new Size(41, 17);
            label12.TabIndex = 14;
            label12.Text = "CPF:";
            // 
            // cbx_sexoPet
            // 
            cbx_sexoPet.FormattingEnabled = true;
            cbx_sexoPet.Items.AddRange(new object[] { "Feminino", "Masculino" });
            cbx_sexoPet.Location = new Point(588, 182);
            cbx_sexoPet.Name = "cbx_sexoPet";
            cbx_sexoPet.Size = new Size(87, 23);
            cbx_sexoPet.TabIndex = 15;
            // 
            // cbx_portePet
            // 
            cbx_portePet.FormattingEnabled = true;
            cbx_portePet.Location = new Point(588, 218);
            cbx_portePet.Name = "cbx_portePet";
            cbx_portePet.Size = new Size(87, 23);
            cbx_portePet.TabIndex = 16;
            // 
            // tbx_nomeTutor
            // 
            tbx_nomeTutor.Location = new Point(352, 121);
            tbx_nomeTutor.Name = "tbx_nomeTutor";
            tbx_nomeTutor.Size = new Size(103, 23);
            tbx_nomeTutor.TabIndex = 17;
            // 
            // tbx_telefoneTutor
            // 
            tbx_telefoneTutor.Location = new Point(374, 150);
            tbx_telefoneTutor.Name = "tbx_telefoneTutor";
            tbx_telefoneTutor.Size = new Size(81, 23);
            tbx_telefoneTutor.TabIndex = 18;
            // 
            // tbx_enderecoTutor
            // 
            tbx_enderecoTutor.Location = new Point(374, 182);
            tbx_enderecoTutor.Name = "tbx_enderecoTutor";
            tbx_enderecoTutor.Size = new Size(81, 23);
            tbx_enderecoTutor.TabIndex = 19;
            // 
            // tbx_cpfTutor
            // 
            tbx_cpfTutor.Location = new Point(341, 218);
            tbx_cpfTutor.Name = "tbx_cpfTutor";
            tbx_cpfTutor.Size = new Size(114, 23);
            tbx_cpfTutor.TabIndex = 20;
            // 
            // tbx_nomePet
            // 
            tbx_nomePet.Location = new Point(588, 121);
            tbx_nomePet.Name = "tbx_nomePet";
            tbx_nomePet.Size = new Size(87, 23);
            tbx_nomePet.TabIndex = 21;
            // 
            // tbx_racaPet
            // 
            tbx_racaPet.Location = new Point(588, 154);
            tbx_racaPet.Name = "tbx_racaPet";
            tbx_racaPet.Size = new Size(87, 23);
            tbx_racaPet.TabIndex = 22;
            // 
            // btx_cadastrarCadastro
            // 
            btx_cadastrarCadastro.BackColor = Color.LawnGreen;
            btx_cadastrarCadastro.Location = new Point(400, 376);
            btx_cadastrarCadastro.Name = "btx_cadastrarCadastro";
            btx_cadastrarCadastro.Size = new Size(75, 23);
            btx_cadastrarCadastro.TabIndex = 23;
            btx_cadastrarCadastro.Text = "Cadastrar";
            btx_cadastrarCadastro.UseVisualStyleBackColor = false;
            // 
            // btx_deletarCadastro
            // 
            btx_deletarCadastro.BackColor = Color.Red;
            btx_deletarCadastro.Location = new Point(537, 376);
            btx_deletarCadastro.Name = "btx_deletarCadastro";
            btx_deletarCadastro.Size = new Size(63, 23);
            btx_deletarCadastro.TabIndex = 24;
            btx_deletarCadastro.Text = "Deletar";
            btx_deletarCadastro.UseVisualStyleBackColor = false;
            // 
            // btx_gerarCodigoCliente
            // 
            btx_gerarCodigoCliente.BackColor = Color.LavenderBlush;
            btx_gerarCodigoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btx_gerarCodigoCliente.Location = new Point(352, 269);
            btx_gerarCodigoCliente.Name = "btx_gerarCodigoCliente";
            btx_gerarCodigoCliente.Size = new Size(295, 25);
            btx_gerarCodigoCliente.TabIndex = 25;
            btx_gerarCodigoCliente.Text = "Gerar Código Cliente";
            btx_gerarCodigoCliente.UseVisualStyleBackColor = false;
            // 
            // tbx_codigoCliente
            // 
            tbx_codigoCliente.Location = new Point(458, 300);
            tbx_codigoCliente.Name = "tbx_codigoCliente";
            tbx_codigoCliente.Size = new Size(81, 23);
            tbx_codigoCliente.TabIndex = 27;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(723, 478);
            Controls.Add(tbx_codigoCliente);
            Controls.Add(btx_gerarCodigoCliente);
            Controls.Add(btx_deletarCadastro);
            Controls.Add(btx_cadastrarCadastro);
            Controls.Add(tbx_racaPet);
            Controls.Add(tbx_nomePet);
            Controls.Add(tbx_cpfTutor);
            Controls.Add(tbx_enderecoTutor);
            Controls.Add(tbx_telefoneTutor);
            Controls.Add(tbx_nomeTutor);
            Controls.Add(cbx_portePet);
            Controls.Add(cbx_sexoPet);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            Load += TelaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cbx_sexoPet;
        private ComboBox cbx_portePet;
        private TextBox tbx_nomeTutor;
        private TextBox tbx_telefoneTutor;
        private TextBox tbx_enderecoTutor;
        private TextBox tbx_cpfTutor;
        private TextBox tbx_nomePet;
        private TextBox tbx_racaPet;
        private Button btx_cadastrarCadastro;
        private Button btx_deletarCadastro;
        private Button btx_gerarCodigoCliente;
        private TextBox tbx_codigoCliente;
    }
}