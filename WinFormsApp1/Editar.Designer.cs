namespace WinFormsApp1
{
    partial class Editar
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
            Cancelar = new Button();
            botaoOk = new Button();
            label2 = new Label();
            label1 = new Label();
            generoTxt = new TextBox();
            tituloTxt = new TextBox();
            SuspendLayout();
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(228, 370);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 15;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // botaoOk
            // 
            botaoOk.Location = new Point(128, 364);
            botaoOk.Name = "botaoOk";
            botaoOk.Size = new Size(75, 23);
            botaoOk.TabIndex = 14;
            botaoOk.Text = "Ok";
            botaoOk.UseVisualStyleBackColor = true;
            botaoOk.Click += botaoOk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 107);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 12;
            label2.Text = "Insira o novo Gênero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 11;
            label1.Text = "Insira o novo Título";
            // 
            // generoTxt
            // 
            generoTxt.Location = new Point(28, 135);
            generoTxt.Name = "generoTxt";
            generoTxt.Size = new Size(271, 23);
            generoTxt.TabIndex = 10;
            // 
            // tituloTxt
            // 
            tituloTxt.Location = new Point(28, 53);
            tituloTxt.Name = "tituloTxt";
            tituloTxt.Size = new Size(273, 23);
            tituloTxt.TabIndex = 9;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 450);
            Controls.Add(Cancelar);
            Controls.Add(botaoOk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(generoTxt);
            Controls.Add(tituloTxt);
            Name = "Editar";
            Text = "Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelar;
        private Button botaoOk;
        private Label label2;
        private Label label1;
        private TextBox generoTxt;
        private TextBox tituloTxt;
    }
}