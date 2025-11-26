namespace SomarNumeros
{
    partial class Frm_TelaInicial
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
            label1 = new Label();
            Lbl_EntradaUm = new Label();
            Txt_EntradaUm = new TextBox();
            Txt_EntradaDois = new TextBox();
            Lbl_EntradaDois = new Label();
            Btn_Somar = new Button();
            Btn_Limpar = new Button();
            Lbl_TituloResultado = new Label();
            Lbl_Resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Somar Números Digitados";
            // 
            // Lbl_EntradaUm
            // 
            Lbl_EntradaUm.AutoSize = true;
            Lbl_EntradaUm.Location = new Point(12, 41);
            Lbl_EntradaUm.Name = "Lbl_EntradaUm";
            Lbl_EntradaUm.Size = new Size(59, 15);
            Lbl_EntradaUm.TabIndex = 1;
            Lbl_EntradaUm.Text = "Entrada 1:";
            // 
            // Txt_EntradaUm
            // 
            Txt_EntradaUm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_EntradaUm.Location = new Point(12, 59);
            Txt_EntradaUm.Name = "Txt_EntradaUm";
            Txt_EntradaUm.Size = new Size(210, 23);
            Txt_EntradaUm.TabIndex = 2;
            // 
            // Txt_EntradaDois
            // 
            Txt_EntradaDois.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_EntradaDois.Location = new Point(12, 110);
            Txt_EntradaDois.Name = "Txt_EntradaDois";
            Txt_EntradaDois.Size = new Size(210, 23);
            Txt_EntradaDois.TabIndex = 4;
            // 
            // Lbl_EntradaDois
            // 
            Lbl_EntradaDois.AutoSize = true;
            Lbl_EntradaDois.Location = new Point(12, 92);
            Lbl_EntradaDois.Name = "Lbl_EntradaDois";
            Lbl_EntradaDois.Size = new Size(59, 15);
            Lbl_EntradaDois.TabIndex = 3;
            Lbl_EntradaDois.Text = "Entrada 2:";
            // 
            // Btn_Somar
            // 
            Btn_Somar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Somar.Location = new Point(147, 151);
            Btn_Somar.Name = "Btn_Somar";
            Btn_Somar.Size = new Size(75, 23);
            Btn_Somar.TabIndex = 5;
            Btn_Somar.Text = "Somar";
            Btn_Somar.UseVisualStyleBackColor = true;
            Btn_Somar.Click += Btn_Somar_Click;
            // 
            // Btn_Limpar
            // 
            Btn_Limpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Limpar.Location = new Point(66, 151);
            Btn_Limpar.Name = "Btn_Limpar";
            Btn_Limpar.Size = new Size(75, 23);
            Btn_Limpar.TabIndex = 6;
            Btn_Limpar.Text = "Limpar";
            Btn_Limpar.UseVisualStyleBackColor = true;
            Btn_Limpar.Click += Btn_Limpar_Click;
            // 
            // Lbl_TituloResultado
            // 
            Lbl_TituloResultado.AutoSize = true;
            Lbl_TituloResultado.Font = new Font("Segoe UI", 9F);
            Lbl_TituloResultado.Location = new Point(12, 200);
            Lbl_TituloResultado.Name = "Lbl_TituloResultado";
            Lbl_TituloResultado.Size = new Size(62, 15);
            Lbl_TituloResultado.TabIndex = 7;
            Lbl_TituloResultado.Text = "Resultado:";
            // 
            // Lbl_Resultado
            // 
            Lbl_Resultado.AutoSize = true;
            Lbl_Resultado.ForeColor = SystemColors.Highlight;
            Lbl_Resultado.Location = new Point(12, 225);
            Lbl_Resultado.Name = "Lbl_Resultado";
            Lbl_Resultado.Size = new Size(12, 15);
            Lbl_Resultado.TabIndex = 8;
            Lbl_Resultado.Text = "-";
            // 
            // Frm_TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 263);
            Controls.Add(Lbl_Resultado);
            Controls.Add(Lbl_TituloResultado);
            Controls.Add(Btn_Limpar);
            Controls.Add(Btn_Somar);
            Controls.Add(Txt_EntradaDois);
            Controls.Add(Lbl_EntradaDois);
            Controls.Add(Txt_EntradaUm);
            Controls.Add(Lbl_EntradaUm);
            Controls.Add(label1);
            Name = "Frm_TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Somar Números Digitados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Lbl_EntradaUm;
        private TextBox Txt_EntradaUm;
        private TextBox Txt_EntradaDois;
        private Label Lbl_EntradaDois;
        private Button Btn_Somar;
        private Button Btn_Limpar;
        private Label Lbl_TituloResultado;
        private Label Lbl_Resultado;
    }
}
