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
            Painel.Size = new Size(627, 576);
            Painel.TabIndex = 2;
            // 
            // gpAdicionandoValores
            // 
            gpAdicionandoValores.Controls.Add(lsvValoresAdicionados);
            gpAdicionandoValores.Controls.Add(txbEixoX);
            gpAdicionandoValores.Controls.Add(txbEixoY);
            gpAdicionandoValores.Controls.Add(btnEnviarValores);
            gpAdicionandoValores.Controls.Add(lblEixoX);
            gpAdicionandoValores.Controls.Add(lblEixoY);
            gpAdicionandoValores.Dock = DockStyle.Top;
            gpAdicionandoValores.Location = new Point(0, 0);
            gpAdicionandoValores.Name = "gpAdicionandoValores";
            gpAdicionandoValores.Size = new Size(362, 310);
            gpAdicionandoValores.TabIndex = 15;
            gpAdicionandoValores.TabStop = false;
            gpAdicionandoValores.Text = "Adicionando Valores";
            // 
            // lsvValoresAdicionados
            // 
            lsvValoresAdicionados.GridLines = true;
            lsvValoresAdicionados.LabelEdit = true;
            lsvValoresAdicionados.Location = new Point(8, 22);
            lsvValoresAdicionados.Name = "lsvValoresAdicionados";
            lsvValoresAdicionados.Size = new Size(335, 189);
            lsvValoresAdicionados.TabIndex = 14;
            lsvValoresAdicionados.UseCompatibleStateImageBehavior = false;
            lsvValoresAdicionados.View = View.Details;
            // 
            // txbEixoX
            // 
            txbEixoX.Location = new Point(48, 234);
            txbEixoX.Name = "txbEixoX";
            txbEixoX.Size = new Size(89, 23);
            txbEixoX.TabIndex = 10;
            txbEixoX.KeyPress += txbEixoX_KeyPress;
            // 
            // txbEixoY
            // 
            txbEixoY.Location = new Point(207, 234);
            txbEixoY.Name = "txbEixoY";
            txbEixoY.Size = new Size(89, 23);
            txbEixoY.TabIndex = 11;
            txbEixoY.KeyPress += txbEixoY_KeyPress;
            // 
            // btnEnviarValores
            // 
            btnEnviarValores.Location = new Point(48, 263);
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
            lblEixoX.Location = new Point(85, 216);
            lblEixoX.Name = "lblEixoX";
            lblEixoX.Size = new Size(14, 15);
            lblEixoX.TabIndex = 3;
            lblEixoX.Text = "X";
            // 
            // lblEixoY
            // 
            lblEixoY.AutoSize = true;
            lblEixoY.Location = new Point(242, 216);
            lblEixoY.Name = "lblEixoY";
            lblEixoY.Size = new Size(14, 15);
            lblEixoY.TabIndex = 4;
            lblEixoY.Text = "Y";
            // 
            // btnEnviaPoligono
            // 
            btnEnviaPoligono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnEnviaPoligono.Location = new Point(3, 330);
            btnEnviaPoligono.Name = "btnEnviaPoligono";
            btnEnviaPoligono.Size = new Size(356, 243);
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
            panel2.Location = new Point(627, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 576);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(Painel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(627, 576);
            panel3.TabIndex = 19;
            // 
            // FormPoligonoPersonalizado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 576);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormPoligonoPersonalizado";
            Text = "FormPoligonoPersonalizado";
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
    }
}