namespace WinFormsApp1
{
    partial class Exibicao
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
            listaExibicao = new DataGridView();
            botaoAdicionar = new Button();
            botaoEditar = new Button();
            botaoApagar = new Button();
            ((System.ComponentModel.ISupportInitialize)listaExibicao).BeginInit();
            SuspendLayout();
            // 
            // listaExibicao
            // 
            listaExibicao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaExibicao.Location = new Point(15, 40);
            listaExibicao.Name = "listaExibicao";
            listaExibicao.RowTemplate.Height = 25;
            listaExibicao.Size = new Size(523, 369);
            listaExibicao.TabIndex = 5;
            // 
            // botaoAdicionar
            // 
            botaoAdicionar.Location = new Point(311, 415);
            botaoAdicionar.Name = "botaoAdicionar";
            botaoAdicionar.Size = new Size(75, 23);
            botaoAdicionar.TabIndex = 6;
            botaoAdicionar.Text = "Adicionar";
            botaoAdicionar.UseVisualStyleBackColor = true;
            botaoAdicionar.Click += botaoadicionar_Click;
            // 
            // botaoEditar
            // 
            botaoEditar.Location = new Point(408, 415);
            botaoEditar.Name = "botaoEditar";
            botaoEditar.Size = new Size(75, 23);
            botaoEditar.TabIndex = 7;
            botaoEditar.Text = "Editar";
            botaoEditar.UseVisualStyleBackColor = true;
            botaoEditar.Click += button1_Click;
            // 
            // botaoApagar
            // 
            botaoApagar.Location = new Point(498, 415);
            botaoApagar.Name = "botaoApagar";
            botaoApagar.Size = new Size(75, 23);
            botaoApagar.TabIndex = 8;
            botaoApagar.Text = "Apagar";
            botaoApagar.UseVisualStyleBackColor = true;
            botaoApagar.Click += button2_Click;
            // 
            // Exibicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(botaoApagar);
            Controls.Add(botaoEditar);
            Controls.Add(botaoAdicionar);
            Controls.Add(listaExibicao);
            Name = "Exibicao";
            Text = "Lista de Livros";
            Activated += form1_activated;
            ((System.ComponentModel.ISupportInitialize)listaExibicao).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView listaExibicao;
        private Button botaoAdicionar;
        private Button botaoEditar;
        private Button botaoApagar;
    }
}