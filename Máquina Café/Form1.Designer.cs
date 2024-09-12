namespace Máquina_Café
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_MaquinaCafé = new Label();
            btn_cafe = new Button();
            btn_chocolate = new Button();
            btn_cha = new Button();
            btn_cappuccino = new Button();
            btn_Pagar = new Button();
            btn_cancelar = new Button();
            txt_EscolhaCafé = new TextBox();
            txt_Mensagem = new TextBox();
            txt_EscreverValor = new TextBox();
            pictureBox1 = new PictureBox();
            lbl_Pedido = new Label();
            lbl_MostrarTroco = new Label();
            lbl_Moedeiro = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_MaquinaCafé
            // 
            lbl_MaquinaCafé.BackColor = Color.DarkSeaGreen;
            lbl_MaquinaCafé.Font = new Font("Cascadia Code", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_MaquinaCafé.ForeColor = SystemColors.ActiveCaptionText;
            lbl_MaquinaCafé.Location = new Point(202, 31);
            lbl_MaquinaCafé.Name = "lbl_MaquinaCafé";
            lbl_MaquinaCafé.Size = new Size(360, 84);
            lbl_MaquinaCafé.TabIndex = 0;
            lbl_MaquinaCafé.Text = "Máquina de Café";
            lbl_MaquinaCafé.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_cafe
            // 
            btn_cafe.BackColor = Color.DarkSeaGreen;
            btn_cafe.Font = new Font("Cascadia Code", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_cafe.Location = new Point(42, 246);
            btn_cafe.Name = "btn_cafe";
            btn_cafe.Size = new Size(153, 59);
            btn_cafe.TabIndex = 1;
            btn_cafe.Text = "Café";
            btn_cafe.UseVisualStyleBackColor = false;
            btn_cafe.Click += btn_cafe_Click;
            // 
            // btn_chocolate
            // 
            btn_chocolate.BackColor = Color.DarkSeaGreen;
            btn_chocolate.Font = new Font("Cascadia Code", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_chocolate.Location = new Point(42, 422);
            btn_chocolate.Name = "btn_chocolate";
            btn_chocolate.Size = new Size(153, 59);
            btn_chocolate.TabIndex = 3;
            btn_chocolate.Text = "Chocolate";
            btn_chocolate.UseVisualStyleBackColor = false;
            btn_chocolate.Click += btn_chocolate_Click;
            // 
            // btn_cha
            // 
            btn_cha.BackColor = Color.DarkSeaGreen;
            btn_cha.Font = new Font("Cascadia Code", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_cha.Location = new Point(42, 510);
            btn_cha.Name = "btn_cha";
            btn_cha.Size = new Size(153, 59);
            btn_cha.TabIndex = 4;
            btn_cha.Text = "Chá";
            btn_cha.UseVisualStyleBackColor = false;
            btn_cha.Click += btn_cha_Click;
            // 
            // btn_cappuccino
            // 
            btn_cappuccino.BackColor = Color.DarkSeaGreen;
            btn_cappuccino.Font = new Font("Cascadia Code", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_cappuccino.Location = new Point(42, 334);
            btn_cappuccino.Name = "btn_cappuccino";
            btn_cappuccino.Size = new Size(153, 59);
            btn_cappuccino.TabIndex = 2;
            btn_cappuccino.Text = "Cappuccino";
            btn_cappuccino.UseVisualStyleBackColor = false;
            btn_cappuccino.Click += btn_cappuccino_Click;
            // 
            // btn_Pagar
            // 
            btn_Pagar.BackColor = Color.DarkSeaGreen;
            btn_Pagar.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Pagar.Location = new Point(411, 230);
            btn_Pagar.Name = "btn_Pagar";
            btn_Pagar.Size = new Size(151, 59);
            btn_Pagar.TabIndex = 5;
            btn_Pagar.Text = "Pagar";
            btn_Pagar.UseVisualStyleBackColor = false;
            btn_Pagar.Click += btn_Pagar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.DarkSeaGreen;
            btn_cancelar.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.Location = new Point(411, 527);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(151, 59);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txt_EscolhaCafé
            // 
            txt_EscolhaCafé.BackColor = Color.DarkSeaGreen;
            txt_EscolhaCafé.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_EscolhaCafé.ForeColor = SystemColors.InfoText;
            txt_EscolhaCafé.Location = new Point(227, 141);
            txt_EscolhaCafé.Name = "txt_EscolhaCafé";
            txt_EscolhaCafé.Size = new Size(317, 31);
            txt_EscolhaCafé.TabIndex = 6;
            txt_EscolhaCafé.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Mensagem
            // 
            txt_Mensagem.BackColor = Color.Silver;
            txt_Mensagem.Font = new Font("Cascadia Code", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Mensagem.Location = new Point(42, 604);
            txt_Mensagem.Multiline = true;
            txt_Mensagem.Name = "txt_Mensagem";
            txt_Mensagem.Size = new Size(520, 56);
            txt_Mensagem.TabIndex = 7;
            txt_Mensagem.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_EscreverValor
            // 
            txt_EscreverValor.BackColor = Color.DarkSeaGreen;
            txt_EscreverValor.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_EscreverValor.Location = new Point(411, 305);
            txt_EscreverValor.Name = "txt_EscreverValor";
            txt_EscreverValor.Size = new Size(151, 25);
            txt_EscreverValor.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.café_removebg_preview;
            pictureBox1.Location = new Point(42, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lbl_Pedido
            // 
            lbl_Pedido.BackColor = Color.Silver;
            lbl_Pedido.Font = new Font("Cascadia Code", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Pedido.Location = new Point(227, 230);
            lbl_Pedido.Name = "lbl_Pedido";
            lbl_Pedido.Size = new Size(159, 156);
            lbl_Pedido.TabIndex = 10;
            // 
            // lbl_MostrarTroco
            // 
            lbl_MostrarTroco.BackColor = Color.Silver;
            lbl_MostrarTroco.Font = new Font("Cascadia Code", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MostrarTroco.Location = new Point(227, 420);
            lbl_MostrarTroco.Name = "lbl_MostrarTroco";
            lbl_MostrarTroco.Size = new Size(159, 166);
            lbl_MostrarTroco.TabIndex = 10;
            // 
            // lbl_Moedeiro
            // 
            lbl_Moedeiro.BackColor = Color.Silver;
            lbl_Moedeiro.Font = new Font("Cascadia Code", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Moedeiro.Location = new Point(411, 348);
            lbl_Moedeiro.Name = "lbl_Moedeiro";
            lbl_Moedeiro.Size = new Size(151, 163);
            lbl_Moedeiro.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(615, 681);
            Controls.Add(lbl_Moedeiro);
            Controls.Add(lbl_MostrarTroco);
            Controls.Add(lbl_Pedido);
            Controls.Add(pictureBox1);
            Controls.Add(txt_EscreverValor);
            Controls.Add(txt_Mensagem);
            Controls.Add(txt_EscolhaCafé);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_Pagar);
            Controls.Add(btn_cappuccino);
            Controls.Add(btn_cha);
            Controls.Add(btn_chocolate);
            Controls.Add(btn_cafe);
            Controls.Add(lbl_MaquinaCafé);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício Máquina de Café";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_MaquinaCafé;
        private Button btn_cafe;
        private Button btn_chocolate;
        private Button btn_cha;
        private Button btn_cappuccino;
        private Button btn_Pagar;
        private Button btn_cancelar;
        private TextBox txt_EscolhaCafé;
        private TextBox txt_Mensagem;
        private TextBox txt_EscreverValor;
        private PictureBox pictureBox1;
        private Label lbl_Pedido;
        private Label lbl_MostrarTroco;
        private Label lbl_Moedeiro;
    }
}
