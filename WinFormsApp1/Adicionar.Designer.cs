namespace WinFormsApp1
{
    partial class Adicionar
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
            tituloTxt = new TextBox();
            generoTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            botaoOk = new Button();
            botaoCancelar = new Button();
            SuspendLayout();
            // 
            // tituloTxt
            // 
            tituloTxt.Location = new Point(23, 35);
            tituloTxt.Name = "tituloTxt";
            tituloTxt.Size = new Size(273, 23);
            tituloTxt.TabIndex = 1;
            // 
            // generoTxt
            // 
            generoTxt.Location = new Point(23, 98);
            generoTxt.Name = "generoTxt";
            generoTxt.Size = new Size(271, 23);
            generoTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 80);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Gênero";
            // 
            // botaoOk
            // 
            botaoOk.Location = new Point(124, 402);
            botaoOk.Name = "botaoOk";
            botaoOk.Size = new Size(75, 23);
            botaoOk.TabIndex = 6;
            botaoOk.Text = "Ok";
            botaoOk.UseVisualStyleBackColor = true;
            botaoOk.Click += botaoOk_Click;
            // 
            // botaoCancelar
            // 
            botaoCancelar.Location = new Point(224, 402);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(75, 23);
            botaoCancelar.TabIndex = 7;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += Cancelar_Click;
            // 
            // Adicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 450);
            Controls.Add(botaoCancelar);
            Controls.Add(botaoOk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(generoTxt);
            Controls.Add(tituloTxt);
            Name = "Adicionar";
            Text = "Adicionar novo livro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tituloTxt;
        private TextBox generoTxt;
        private Label label1;
        private Label label2;
        private Button botaoOk;
        private Button botaoCancelar;
    }
}