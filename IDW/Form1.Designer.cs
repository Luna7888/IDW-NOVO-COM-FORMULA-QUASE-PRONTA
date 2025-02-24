using ScottPlot.Colormaps;
using ScottPlot.Palettes;
using ScottPlot.Plottables;

namespace IDW
{
    partial class Form1
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
            Painel = new ScottPlot.WinForms.FormsPlot();
            btnEnviarValores = new Button();
            lblEixoX = new Label();
            lblEixoY = new Label();
            lblIntensidade = new Label();
            txbEixoX = new TextBox();
            txbEixoY = new TextBox();
            txbIntensidade = new TextBox();
            gpAdicionandoValores = new GroupBox();
            lsvValoresAdicionados = new ListView();
            lblPeso = new Label();
            txbPeso = new TextBox();
            btnCriarGrafico = new Button();
            gpAdicionandoValores.SuspendLayout();
            SuspendLayout();
            // 
            // Painel
            // 
            Painel.BackColor = SystemColors.Control;
            Painel.DisplayScale = 1F;
            Painel.Location = new Point(-7, 15);
            Painel.Name = "Painel";
            Painel.Size = new Size(502, 435);
            Painel.TabIndex = 1;
            // 
            // btnEnviarValores
            // 
            btnEnviarValores.Location = new Point(8, 265);
            btnEnviarValores.Name = "btnEnviarValores";
            btnEnviarValores.Size = new Size(279, 23);
            btnEnviarValores.TabIndex = 2;
            btnEnviarValores.Text = "Enviar";
            btnEnviarValores.UseVisualStyleBackColor = true;
            btnEnviarValores.Click += btnEnviarValores_Click;
            // 
            // lblEixoX
            // 
            lblEixoX.AutoSize = true;
            lblEixoX.Location = new Point(34, 214);
            lblEixoX.Name = "lblEixoX";
            lblEixoX.Size = new Size(14, 15);
            lblEixoX.TabIndex = 3;
            lblEixoX.Text = "X";
            // 
            // lblEixoY
            // 
            lblEixoY.AutoSize = true;
            lblEixoY.Location = new Point(140, 214);
            lblEixoY.Name = "lblEixoY";
            lblEixoY.Size = new Size(14, 15);
            lblEixoY.TabIndex = 4;
            lblEixoY.Text = "Y";
            // 
            // lblIntensidade
            // 
            lblIntensidade.AutoSize = true;
            lblIntensidade.Location = new Point(215, 214);
            lblIntensidade.Name = "lblIntensidade";
            lblIntensidade.Size = new Size(68, 15);
            lblIntensidade.TabIndex = 9;
            lblIntensidade.Text = "Intensidade";
            // 
            // txbEixoX
            // 
            txbEixoX.Location = new Point(10, 236);
            txbEixoX.Name = "txbEixoX";
            txbEixoX.Size = new Size(66, 23);
            txbEixoX.TabIndex = 10;
            txbEixoX.KeyPress += txbEixoX_KeyPress;
            // 
            // txbEixoY
            // 
            txbEixoY.Location = new Point(101, 236);
            txbEixoY.Name = "txbEixoY";
            txbEixoY.Size = new Size(89, 23);
            txbEixoY.TabIndex = 11;
            txbEixoY.KeyPress += txbEixoY_KeyPress;
            // 
            // txbIntensidade
            // 
            txbIntensidade.Location = new Point(212, 236);
            txbIntensidade.Name = "txbIntensidade";
            txbIntensidade.Size = new Size(75, 23);
            txbIntensidade.TabIndex = 12;
            txbIntensidade.KeyPress += txbIntensidade_KeyPress;
            // 
            // gpAdicionandoValores
            // 
            gpAdicionandoValores.Controls.Add(lsvValoresAdicionados);
            gpAdicionandoValores.Controls.Add(txbEixoX);
            gpAdicionandoValores.Controls.Add(txbIntensidade);
            gpAdicionandoValores.Controls.Add(lblIntensidade);
            gpAdicionandoValores.Controls.Add(txbEixoY);
            gpAdicionandoValores.Controls.Add(btnEnviarValores);
            gpAdicionandoValores.Controls.Add(lblEixoX);
            gpAdicionandoValores.Controls.Add(lblEixoY);
            gpAdicionandoValores.Location = new Point(512, 12);
            gpAdicionandoValores.Name = "gpAdicionandoValores";
            gpAdicionandoValores.Size = new Size(304, 297);
            gpAdicionandoValores.TabIndex = 14;
            gpAdicionandoValores.TabStop = false;
            gpAdicionandoValores.Text = "Adicionando Valores";
            // 
            // lsvValoresAdicionados
            // 
            lsvValoresAdicionados.GridLines = true;
            lsvValoresAdicionados.LabelEdit = true;
            lsvValoresAdicionados.Location = new Point(8, 22);
            lsvValoresAdicionados.Name = "lsvValoresAdicionados";
            lsvValoresAdicionados.Size = new Size(284, 182);
            lsvValoresAdicionados.TabIndex = 14;
            lsvValoresAdicionados.UseCompatibleStateImageBehavior = false;
            lsvValoresAdicionados.View = View.Details;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(184, 8);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(35, 15);
            lblPeso.TabIndex = 16;
            lblPeso.Text = "Peso:";
            // 
            // txbPeso
            // 
            txbPeso.Location = new Point(222, 3);
            txbPeso.Name = "txbPeso";
            txbPeso.Size = new Size(75, 23);
            txbPeso.TabIndex = 15;
            txbPeso.KeyPress += txbPeso_KeyPress;
            // 
            // btnCriarGrafico
            // 
            btnCriarGrafico.Location = new Point(520, 327);
            btnCriarGrafico.Name = "btnCriarGrafico";
            btnCriarGrafico.Size = new Size(279, 98);
            btnCriarGrafico.TabIndex = 15;
            btnCriarGrafico.Text = "Criar Gráfico";
            btnCriarGrafico.UseVisualStyleBackColor = true;
            btnCriarGrafico.Click += btnCriarGrafico_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 450);
            Controls.Add(lblPeso);
            Controls.Add(btnCriarGrafico);
            Controls.Add(txbPeso);
            Controls.Add(gpAdicionandoValores);
            Controls.Add(Painel);
            Name = "Form1";
            Text = "Gráfico";
            Load += Form1_Load;
            gpAdicionandoValores.ResumeLayout(false);
            gpAdicionandoValores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ScottPlot.WinForms.FormsPlot Painel;
        private Button btnEnviarValores;
        private Label lblEixoX;
        private Label lblEixoY;
        private Label lblIntensidade;
        private TextBox txbEixoX;
        private TextBox txbEixoY;
        private TextBox txbIntensidade;
        private GroupBox gpAdicionandoValores;
        private Button btnCriarGrafico;
        private ListView lsvValoresAdicionados;
        private Label lblPeso;
        private TextBox txbPeso;
    }
}
