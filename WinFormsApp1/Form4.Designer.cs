namespace WinFormsApp1
{
    partial class Form4
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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(244, 366);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 23;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // botaoOk
            // 
            botaoOk.Location = new Point(146, 367);
            botaoOk.Name = "botaoOk";
            botaoOk.Size = new Size(75, 23);
            botaoOk.TabIndex = 22;
            botaoOk.Text = "Ok";
            botaoOk.UseVisualStyleBackColor = true;
            botaoOk.Click += botaoOk_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 22);
            label3.Name = "label3";
            label3.Size = new Size(202, 15);
            label3.TabIndex = 21;
            label3.Text = "Insira o ID do Livro que deseja excluir";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 23);
            textBox1.TabIndex = 16;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 450);
            Controls.Add(Cancelar);
            Controls.Add(botaoOk);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Name = "Form4";
            Text = "Excluir livro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelar;
        private Button botaoOk;
        private Label label3;
        private TextBox textBox1;
    }
}