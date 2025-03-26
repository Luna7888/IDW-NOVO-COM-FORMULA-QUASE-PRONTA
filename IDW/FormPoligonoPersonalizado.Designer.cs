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
            lblEscala = new Label();
            label1 = new Label();
            txbPPI = new TextBox();
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            gpAdicionandoValores.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Painel
            // 
            Painel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Painel.BackColor = SystemColors.Control;
            Painel.DisplayScale = 1F;
            Painel.Location = new Point(0, 0);
            Painel.Name = "Painel";
            Painel.Size = new Size(738, 601);
            Painel.TabIndex = 2;
            // 
            // gpAdicionandoValores
            // 
            gpAdicionandoValores.Controls.Add(lblEscala);
            gpAdicionandoValores.Controls.Add(label1);
            gpAdicionandoValores.Controls.Add(txbPPI);
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
            gpAdicionandoValores.Size = new Size(403, 450);
            gpAdicionandoValores.TabIndex = 15;
            gpAdicionandoValores.TabStop = false;
            gpAdicionandoValores.Text = "Adicionando Valores";
            gpAdicionandoValores.Enter += gpAdicionandoValores_Enter;
            // 
            // lblEscala
            // 
            lblEscala.AutoSize = true;
            lblEscala.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEscala.Location = new Point(6, 32);
            lblEscala.Name = "lblEscala";
            lblEscala.Size = new Size(54, 18);
            lblEscala.TabIndex = 19;
            lblEscala.Text = "Escala:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 336);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 18;
            label1.Text = "PPI";
            // 
            // txbPPI
            // 
            txbPPI.BackColor = Color.White;
            txbPPI.Location = new Point(151, 354);
            txbPPI.Name = "txbPPI";
            txbPPI.Size = new Size(100, 23);
            txbPPI.TabIndex = 17;
            txbPPI.Text = "96";
            txbPPI.TextAlign = HorizontalAlignment.Center;
            // 
            // cbUnidadedemedida
            // 
            cbUnidadedemedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnidadedemedida.FormattingEnabled = true;
            cbUnidadedemedida.Items.AddRange(new object[] { "Centimetros", "Milimetros", "Pixel" });
            cbUnidadedemedida.Location = new Point(156, 31);
            cbUnidadedemedida.Name = "cbUnidadedemedida";
            cbUnidadedemedida.Size = new Size(102, 23);
            cbUnidadedemedida.TabIndex = 16;
            // 
            // btnCarregarCSV
            // 
            btnCarregarCSV.Location = new Point(279, 32);
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
            lsvValoresAdicionados.Location = new Point(30, 60);
            lsvValoresAdicionados.Name = "lsvValoresAdicionados";
            lsvValoresAdicionados.Size = new Size(335, 189);
            lsvValoresAdicionados.TabIndex = 14;
            lsvValoresAdicionados.UseCompatibleStateImageBehavior = false;
            lsvValoresAdicionados.View = View.Details;
            // 
            // txbEixoX
            // 
            txbEixoX.Location = new Point(75, 286);
            txbEixoX.Name = "txbEixoX";
            txbEixoX.Size = new Size(89, 23);
            txbEixoX.TabIndex = 10;
            txbEixoX.TextAlign = HorizontalAlignment.Center;
            txbEixoX.KeyPress += txbEixoX_KeyPress;
            // 
            // txbEixoY
            // 
            txbEixoY.Location = new Point(234, 286);
            txbEixoY.Name = "txbEixoY";
            txbEixoY.Size = new Size(89, 23);
            txbEixoY.TabIndex = 11;
            txbEixoY.TextAlign = HorizontalAlignment.Center;
            txbEixoY.KeyPress += txbEixoY_KeyPress;
            // 
            // btnEnviarValores
            // 
            btnEnviarValores.Location = new Point(75, 393);
            btnEnviarValores.Name = "btnEnviarValores";
            btnEnviarValores.Size = new Size(248, 40);
            btnEnviarValores.TabIndex = 2;
            btnEnviarValores.Text = "Enviar Ponto";
            btnEnviarValores.UseVisualStyleBackColor = true;
            btnEnviarValores.Click += btnEnviarValores_Click;
            // 
            // lblEixoX
            // 
            lblEixoX.AutoSize = true;
            lblEixoX.Location = new Point(112, 268);
            lblEixoX.Name = "lblEixoX";
            lblEixoX.Size = new Size(14, 15);
            lblEixoX.TabIndex = 3;
            lblEixoX.Text = "X";
            // 
            // lblEixoY
            // 
            lblEixoY.AutoSize = true;
            lblEixoY.Location = new Point(269, 268);
            lblEixoY.Name = "lblEixoY";
            lblEixoY.Size = new Size(14, 15);
            lblEixoY.TabIndex = 4;
            lblEixoY.Text = "Y";
            // 
            // btnEnviaPoligono
            // 
            btnEnviaPoligono.Anchor = AnchorStyles.None;
            btnEnviaPoligono.Location = new Point(0, 456);
            btnEnviaPoligono.Name = "btnEnviaPoligono";
            btnEnviaPoligono.Size = new Size(400, 167);
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
            panel2.Location = new Point(738, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 626);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(Painel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(738, 626);
            panel3.TabIndex = 19;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 604);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(738, 22);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(207, 17);
            toolStripStatusLabel1.Text = "Aguardando Conclusão do Desenho...";
            // 
            // FormPoligonoPersonalizado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 626);
            Controls.Add(statusStrip1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormPoligonoPersonalizado";
            Text = "Personalização de Plano";
            Load += FormPoligonoPersonalizado_Load;
            gpAdicionandoValores.ResumeLayout(false);
            gpAdicionandoValores.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label1;
        private TextBox txbPPI;
        private Label lblEscala;
    }
}