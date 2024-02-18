namespace WinFormsApp1
{
    partial class Form3
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(228, 364);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 36);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 13;
            label3.Text = "Insira o ID do Livro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 158);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 12;
            label2.Text = "Insira o novo Gênero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 95);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 11;
            label1.Text = "Insira o novo Título";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 176);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(271, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 23);
            textBox1.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 450);
            Controls.Add(Cancelar);
            Controls.Add(botaoOk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelar;
        private Button botaoOk;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}