namespace AppComMultiplasJanelas
{
    partial class FormNovoProduto
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
            buttonOk = new Button();
            buttonCancelar = new Button();
            labelNomeProdutos = new Label();
            labelFabricante = new Label();
            labelPreçoCompra = new Label();
            labelPreçoVenda = new Label();
            textBoxProduto = new TextBox();
            textBoxFabricante = new TextBox();
            numericUpDownPreçoVenda = new NumericUpDown();
            numericUpDownPreçoCompra = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreçoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreçoCompra).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(12, 119);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(128, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(159, 119);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(127, 23);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelNomeProdutos
            // 
            labelNomeProdutos.AutoSize = true;
            labelNomeProdutos.Location = new Point(12, 9);
            labelNomeProdutos.Name = "labelNomeProdutos";
            labelNomeProdutos.Size = new Size(106, 15);
            labelNomeProdutos.TabIndex = 2;
            labelNomeProdutos.Text = "Nome do Produto:";
            // 
            // labelFabricante
            // 
            labelFabricante.AutoSize = true;
            labelFabricante.Location = new Point(12, 36);
            labelFabricante.Name = "labelFabricante";
            labelFabricante.Size = new Size(65, 15);
            labelFabricante.TabIndex = 3;
            labelFabricante.Text = "Fabricante:";
            // 
            // labelPreçoCompra
            // 
            labelPreçoCompra.AutoSize = true;
            labelPreçoCompra.Location = new Point(12, 60);
            labelPreçoCompra.Name = "labelPreçoCompra";
            labelPreçoCompra.Size = new Size(100, 15);
            labelPreçoCompra.TabIndex = 4;
            labelPreçoCompra.Text = "Preço de compra:";
            // 
            // labelPreçoVenda
            // 
            labelPreçoVenda.AutoSize = true;
            labelPreçoVenda.Location = new Point(12, 86);
            labelPreçoVenda.Name = "labelPreçoVenda";
            labelPreçoVenda.Size = new Size(91, 15);
            labelPreçoVenda.TabIndex = 5;
            labelPreçoVenda.Text = "Preço de venda:";
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(120, 6);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(166, 23);
            textBoxProduto.TabIndex = 6;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(120, 33);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(166, 23);
            textBoxFabricante.TabIndex = 7;
            // 
            // numericUpDownPreçoVenda
            // 
            numericUpDownPreçoVenda.DecimalPlaces = 2;
            numericUpDownPreçoVenda.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPreçoVenda.Location = new Point(120, 84);
            numericUpDownPreçoVenda.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPreçoVenda.Name = "numericUpDownPreçoVenda";
            numericUpDownPreçoVenda.Size = new Size(166, 23);
            numericUpDownPreçoVenda.TabIndex = 8;
            numericUpDownPreçoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownPreçoCompra
            // 
            numericUpDownPreçoCompra.DecimalPlaces = 2;
            numericUpDownPreçoCompra.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPreçoCompra.Location = new Point(120, 58);
            numericUpDownPreçoCompra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPreçoCompra.Name = "numericUpDownPreçoCompra";
            numericUpDownPreçoCompra.Size = new Size(166, 23);
            numericUpDownPreçoCompra.TabIndex = 9;
            numericUpDownPreçoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // FormNovoProduto
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(298, 154);
            Controls.Add(numericUpDownPreçoCompra);
            Controls.Add(numericUpDownPreçoVenda);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxProduto);
            Controls.Add(labelPreçoVenda);
            Controls.Add(labelPreçoCompra);
            Controls.Add(labelFabricante);
            Controls.Add(labelNomeProdutos);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Name = "FormNovoProduto";
            Text = "FormNovoProduto:";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreçoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreçoCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancelar;
        private Label labelNomeProdutos;
        private Label labelFabricante;
        private Label labelPreçoCompra;
        private Label labelPreçoVenda;
        private TextBox textBoxProduto;
        private TextBox textBoxFabricante;
        private NumericUpDown numericUpDownPreçoVenda;
        private NumericUpDown numericUpDownPreçoCompra;
    }
}