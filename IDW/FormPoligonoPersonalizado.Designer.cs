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
            gpAdicionandoValores.SuspendLayout();
            SuspendLayout();
            // 
            // Painel
            // 
            Painel.BackColor = SystemColors.Control;
            Painel.DisplayScale = 1F;
            Painel.Location = new Point(12, 12);
            Painel.Name = "Painel";
            Painel.Size = new Size(502, 435);
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
            gpAdicionandoValores.Location = new Point(520, 30);
            gpAdicionandoValores.Name = "gpAdicionandoValores";
            gpAdicionandoValores.Size = new Size(349, 310);
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
            btnEnviaPoligono.Location = new Point(520, 351);
            btnEnviaPoligono.Name = "btnEnviaPoligono";
            btnEnviaPoligono.Size = new Size(349, 80);
            btnEnviaPoligono.TabIndex = 16;
            btnEnviaPoligono.Text = "Enviar para o Plano";
            btnEnviaPoligono.UseVisualStyleBackColor = true;
            btnEnviaPoligono.Click += btnEnviaPoligono_Click;
            // 
            // FormPoligonoPersonalizado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 450);
            Controls.Add(btnEnviaPoligono);
            Controls.Add(gpAdicionandoValores);
            Controls.Add(Painel);
            Name = "FormPoligonoPersonalizado";
            Text = "FormPoligonoPersonalizado";
            Load += FormPoligonoPersonalizado_Load;
            gpAdicionandoValores.ResumeLayout(false);
            gpAdicionandoValores.PerformLayout();
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
    }
}