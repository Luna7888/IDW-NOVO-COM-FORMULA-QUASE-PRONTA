namespace IDW
{
    partial class FormPoligonoPersonalizado
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
            Painel = new ScottPlot.WinForms.FormsPlot();
            gpAdicionandoValores = new GroupBox();
            cbUnidadedemedida = new ComboBox();
            btnCarregarCSV = new Button();
            lsvValoresAdicionados = new ListView();
            txbEixoX = new TextBox();
            txbEixoY = new TextBox();
            btnEnviarValores = new Button();
            lblEixoX = new Label();
            lblEixoY = new Label();
            btnEnviaPoligono = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            gpAdicionandoValores.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Painel
            // 
            Painel.BackColor = SystemColors.Control;
            Painel.DisplayScale = 1F;
            Painel.Dock = DockStyle.Fill;
            Painel.Location = new Point(0, 0);
            Painel.Name = "Painel";
            Painel.Size = new Size(654, 584);
            Painel.TabIndex = 2;
            // 
            // gpAdicionandoValores
            // 
            gpAdicionandoValores.Controls.Add(cbUnidadedemedida);
            gpAdicionandoValores.Controls.Add(btnCarregarCSV);
            gpAdicionandoValores.Controls.Add(lsvValoresAdicionados);
            gpAdicionandoValores.Controls.Add(txbEixoX);
            gpAdicionandoValores.Controls.Add(txbEixoY);
            gpAdicionandoValores.Controls.Add(btnEnviarValores);
            gpAdicionandoValores.Controls.Add(lblEixoX);
            gpAdicionandoValores.Controls.Add(lblEixoY);
            gpAdicionandoValores.Dock = DockStyle.Top;
            gpAdicionandoValores.Location = new Point(0, 0);
            gpAdicionandoValores.Name = "gpAdicionandoValores";
            gpAdicionandoValores.Size = new Size(362, 450);
            gpAdicionandoValores.TabIndex = 15;
            gpAdicionandoValores.TabStop = false;
            gpAdicionandoValores.Text = "Adicionando Valores";
            // 
            // cbUnidadedemedida
            // 
            cbUnidadedemedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnidadedemedida.FormattingEnabled = true;
            cbUnidadedemedida.Items.AddRange(new object[] { "Centimetros", "Milimetros", "Pixel" });
            cbUnidadedemedida.Location = new Point(9, 29);
            cbUnidadedemedida.Name = "cbUnidadedemedida";
            cbUnidadedemedida.Size = new Size(102, 23);
            cbUnidadedemedida.TabIndex = 16;
            // 
            // btnCarregarCSV
            // 
            btnCarregarCSV.Location = new Point(257, 22);
            btnCarregarCSV.Name = "btnCarregarCSV";
            btnCarregarCSV.Size = new Size(86, 23);
            btnCarregarCSV.TabIndex = 15;
            btnCarregarCSV.Text = "Carregar";
            btnCarregarCSV.UseVisualStyleBackColor = true;
            btnCarregarCSV.Click += btnCarregarCSV_Click;
            // 
            // lsvValoresAdicionados
            // 
            lsvValoresAdicionados.GridLines = true;
            lsvValoresAdicionados.LabelEdit = true;
            lsvValoresAdicionados.Location = new Point(8, 58);
            lsvValoresAdicionados.Name = "lsvValoresAdicionados";
            lsvValoresAdicionados.Size = new Size(335, 189);
            lsvValoresAdicionados.TabIndex = 14;
            lsvValoresAdicionados.UseCompatibleStateImageBehavior = false;
            lsvValoresAdicionados.View = View.Details;
            // 
            // txbEixoX
            // 
            txbEixoX.Location = new Point(48, 283);
            txbEixoX.Name = "txbEixoX";
            txbEixoX.Size = new Size(89, 23);
            txbEixoX.TabIndex = 10;
            txbEixoX.KeyPress += txbEixoX_KeyPress;
            // 
            // txbEixoY
            // 
            txbEixoY.Location = new Point(207, 283);
            txbEixoY.Name = "txbEixoY";
            txbEixoY.Size = new Size(89, 23);
            txbEixoY.TabIndex = 11;
            txbEixoY.KeyPress += txbEixoY_KeyPress;
            // 
            // btnEnviarValores
            // 
            btnEnviarValores.Location = new Point(48, 312);
            btnEnviarValores.Name = "btnEnviarValores";
            btnEnviarValores.Size = new Size(248, 40);
            btnEnviarValores.TabIndex = 2;
            btnEnviarValores.Text = "Enviar";
            btnEnviarValores.UseVisualStyleBackColor = true;
            btnEnviarValores.Click += btnEnviarValores_Click;
            // 
            // lblEixoX
            // 
            lblEixoX.AutoSize = true;
            lblEixoX.Location = new Point(85, 265);
            lblEixoX.Name = "lblEixoX";
            lblEixoX.Size = new Size(14, 15);
            lblEixoX.TabIndex = 3;
            lblEixoX.Text = "X";
            // 
            // lblEixoY
            // 
            lblEixoY.AutoSize = true;
            lblEixoY.Location = new Point(242, 265);
            lblEixoY.Name = "lblEixoY";
            lblEixoY.Size = new Size(14, 15);
            lblEixoY.TabIndex = 4;
            lblEixoY.Text = "Y";
            // 
            // btnEnviaPoligono
            // 
            btnEnviaPoligono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnEnviaPoligono.Location = new Point(3, 456);
            btnEnviaPoligono.Name = "btnEnviaPoligono";
            btnEnviaPoligono.Size = new Size(356, 125);
            btnEnviaPoligono.TabIndex = 16;
            btnEnviaPoligono.Text = "Enviar para o Plano";
            btnEnviaPoligono.UseVisualStyleBackColor = true;
            btnEnviaPoligono.Click += btnEnviaPoligono_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(663, 714);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Controls.Add(gpAdicionandoValores);
            panel2.Controls.Add(btnEnviaPoligono);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(654, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 584);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(Painel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(654, 584);
            panel3.TabIndex = 19;
            // 
            // FormPoligonoPersonalizado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 584);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.SizeNESW;
            Name = "FormPoligonoPersonalizado";
            Text = "Personalização de Plano";
            Load += FormPoligonoPersonalizado_Load;
            gpAdicionandoValores.ResumeLayout(false);
            gpAdicionandoValores.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot Painel;
        private GroupBox gpAdicionandoValores;
        private ListView lsvValoresAdicionados;
        private TextBox txbEixoX;
        private TextBox txbEixoY;
        private Button btnEnviarValores;
        private Label lblEixoX;
        private Label lblEixoY;
        private Button btnEnviaPoligono;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnCarregarCSV;
        private ComboBox cbUnidadedemedida;
    }
}