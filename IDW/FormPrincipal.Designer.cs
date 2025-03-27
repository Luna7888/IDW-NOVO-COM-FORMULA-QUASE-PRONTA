
namespace IDW
{
    partial class FormPrincipal
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
            menuAdicionar = new MenuStrip();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            planoToolStripMenuItem = new ToolStripMenuItem();
            personalizadoToolStripMenuItem = new ToolStripMenuItem();
            gpAdicionandoValores = new GroupBox();
            txbEscala = new TextBox();
            lblEscala = new Label();
            txbPeso = new TextBox();
            lblPeso = new Label();
            txbEixoX = new TextBox();
            txbEixoY = new TextBox();
            txbIntensidade = new TextBox();
            btnCarregaCSV = new Button();
            lsvValoresAdicionados = new ListView();
            lblIntensidade = new Label();
            btnEnviarValores = new Button();
            lblEixoX = new Label();
            lblEixoY = new Label();
            PainelPrincipal = new ScottPlot.WinForms.FormsPlot();
            btnCriarGrafico = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuAdicionar.SuspendLayout();
            gpAdicionandoValores.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuAdicionar
            // 
            menuAdicionar.Items.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem });
            menuAdicionar.Location = new Point(0, 0);
            menuAdicionar.Name = "menuAdicionar";
            menuAdicionar.Size = new Size(1146, 24);
            menuAdicionar.TabIndex = 17;
            menuAdicionar.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { planoToolStripMenuItem });
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(70, 20);
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // planoToolStripMenuItem
            // 
            planoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalizadoToolStripMenuItem });
            planoToolStripMenuItem.Name = "planoToolStripMenuItem";
            planoToolStripMenuItem.Size = new Size(104, 22);
            planoToolStripMenuItem.Text = "Plano";
            // 
            // personalizadoToolStripMenuItem
            // 
            personalizadoToolStripMenuItem.Name = "personalizadoToolStripMenuItem";
            personalizadoToolStripMenuItem.Size = new Size(147, 22);
            personalizadoToolStripMenuItem.Text = "Personalizado";
            personalizadoToolStripMenuItem.Click += personalizadoToolStripMenuItem_Click;
            // 
            // gpAdicionandoValores
            // 
            gpAdicionandoValores.Controls.Add(txbEscala);
            gpAdicionandoValores.Controls.Add(lblEscala);
            gpAdicionandoValores.Controls.Add(txbPeso);
            gpAdicionandoValores.Controls.Add(lblPeso);
            gpAdicionandoValores.Controls.Add(txbEixoX);
            gpAdicionandoValores.Controls.Add(txbEixoY);
            gpAdicionandoValores.Controls.Add(txbIntensidade);
            gpAdicionandoValores.Controls.Add(btnCarregaCSV);
            gpAdicionandoValores.Controls.Add(lsvValoresAdicionados);
            gpAdicionandoValores.Controls.Add(lblIntensidade);
            gpAdicionandoValores.Controls.Add(btnEnviarValores);
            gpAdicionandoValores.Controls.Add(lblEixoX);
            gpAdicionandoValores.Controls.Add(lblEixoY);
            gpAdicionandoValores.Dock = DockStyle.Top;
            gpAdicionandoValores.Location = new Point(0, 0);
            gpAdicionandoValores.Name = "gpAdicionandoValores";
            gpAdicionandoValores.Size = new Size(410, 453);
            gpAdicionandoValores.TabIndex = 14;
            gpAdicionandoValores.TabStop = false;
            gpAdicionandoValores.Text = "Adicionando Valores";
            // 
            // txbEscala
            // 
            txbEscala.Enabled = false;
            txbEscala.Location = new Point(22, 406);
            txbEscala.Name = "txbEscala";
            txbEscala.Size = new Size(94, 23);
            txbEscala.TabIndex = 18;
            txbEscala.Text = "1";
            txbEscala.TextAlign = HorizontalAlignment.Center;
            txbEscala.TextChanged += txbEscala_TextChanged;
            // 
            // lblEscala
            // 
            lblEscala.AutoSize = true;
            lblEscala.Location = new Point(27, 388);
            lblEscala.Name = "lblEscala";
            lblEscala.Size = new Size(84, 15);
            lblEscala.TabIndex = 17;
            lblEscala.Text = "Valor da Escala";
            // 
            // txbPeso
            // 
            txbPeso.Enabled = false;
            txbPeso.Location = new Point(288, 406);
            txbPeso.MaximumSize = new Size(1000, 0);
            txbPeso.Name = "txbPeso";
            txbPeso.Size = new Size(97, 23);
            txbPeso.TabIndex = 15;
            txbPeso.Text = "1";
            txbPeso.TextAlign = HorizontalAlignment.Center;
            txbPeso.KeyPress += txbPeso_KeyPress;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(321, 388);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 16;
            lblPeso.Text = "Peso";
            // 
            // txbEixoX
            // 
            txbEixoX.Enabled = false;
            txbEixoX.Location = new Point(22, 279);
            txbEixoX.Name = "txbEixoX";
            txbEixoX.Size = new Size(94, 23);
            txbEixoX.TabIndex = 10;
            txbEixoX.TextAlign = HorizontalAlignment.Center;
            txbEixoX.KeyPress += txbEixoX_KeyPress;
            // 
            // txbEixoY
            // 
            txbEixoY.Enabled = false;
            txbEixoY.Location = new Point(150, 279);
            txbEixoY.Name = "txbEixoY";
            txbEixoY.Size = new Size(94, 23);
            txbEixoY.TabIndex = 11;
            txbEixoY.TextAlign = HorizontalAlignment.Center;
            txbEixoY.KeyPress += txbEixoY_KeyPress;
            // 
            // txbIntensidade
            // 
            txbIntensidade.Enabled = false;
            txbIntensidade.Location = new Point(288, 279);
            txbIntensidade.Name = "txbIntensidade";
            txbIntensidade.Size = new Size(94, 23);
            txbIntensidade.TabIndex = 12;
            txbIntensidade.TextAlign = HorizontalAlignment.Center;
            txbIntensidade.KeyPress += txbIntensidade_KeyPress;
            // 
            // btnCarregaCSV
            // 
            btnCarregaCSV.Enabled = false;
            btnCarregaCSV.Location = new Point(283, 27);
            btnCarregaCSV.Name = "btnCarregaCSV";
            btnCarregaCSV.Size = new Size(99, 23);
            btnCarregaCSV.TabIndex = 15;
            btnCarregaCSV.Text = "Carregar Arquivo";
            btnCarregaCSV.UseVisualStyleBackColor = true;
            btnCarregaCSV.Click += btnCarregaCSV_Click;
            // 
            // lsvValoresAdicionados
            // 
            lsvValoresAdicionados.Cursor = Cursors.Cross;
            lsvValoresAdicionados.GridLines = true;
            lsvValoresAdicionados.LabelEdit = true;
            lsvValoresAdicionados.Location = new Point(22, 56);
            lsvValoresAdicionados.Name = "lsvValoresAdicionados";
            lsvValoresAdicionados.Size = new Size(360, 189);
            lsvValoresAdicionados.TabIndex = 14;
            lsvValoresAdicionados.UseCompatibleStateImageBehavior = false;
            lsvValoresAdicionados.View = View.Details;
            // 
            // lblIntensidade
            // 
            lblIntensidade.AutoSize = true;
            lblIntensidade.Location = new Point(305, 261);
            lblIntensidade.Name = "lblIntensidade";
            lblIntensidade.Size = new Size(68, 15);
            lblIntensidade.TabIndex = 9;
            lblIntensidade.Text = "Intensidade";
            // 
            // btnEnviarValores
            // 
            btnEnviarValores.Enabled = false;
            btnEnviarValores.Location = new Point(22, 308);
            btnEnviarValores.Name = "btnEnviarValores";
            btnEnviarValores.Size = new Size(360, 23);
            btnEnviarValores.TabIndex = 2;
            btnEnviarValores.Text = "Enviar";
            btnEnviarValores.UseVisualStyleBackColor = true;
            btnEnviarValores.Click += btnEnviarValores_Click;
            // 
            // lblEixoX
            // 
            lblEixoX.AutoSize = true;
            lblEixoX.Location = new Point(62, 257);
            lblEixoX.Name = "lblEixoX";
            lblEixoX.Size = new Size(14, 15);
            lblEixoX.TabIndex = 3;
            lblEixoX.Text = "X";
            // 
            // lblEixoY
            // 
            lblEixoY.AutoSize = true;
            lblEixoY.Location = new Point(197, 257);
            lblEixoY.Name = "lblEixoY";
            lblEixoY.Size = new Size(14, 15);
            lblEixoY.TabIndex = 4;
            lblEixoY.Text = "Y";
            // 
            // PainelPrincipal
            // 
            PainelPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PainelPrincipal.BackColor = SystemColors.Control;
            PainelPrincipal.DisplayScale = 1F;
            PainelPrincipal.Location = new Point(0, 0);
            PainelPrincipal.Name = "PainelPrincipal";
            PainelPrincipal.Size = new Size(736, 561);
            PainelPrincipal.TabIndex = 1;
            // 
            // btnCriarGrafico
            // 
            btnCriarGrafico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnCriarGrafico.Location = new Point(0, 459);
            btnCriarGrafico.Name = "btnCriarGrafico";
            btnCriarGrafico.Size = new Size(410, 127);
            btnCriarGrafico.TabIndex = 15;
            btnCriarGrafico.Text = "Criar Gráfico";
            btnCriarGrafico.UseVisualStyleBackColor = true;
            btnCriarGrafico.Click += btnCriarGrafico_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(gpAdicionandoValores);
            panel1.Controls.Add(btnCriarGrafico);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(736, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 586);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(PainelPrincipal);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 586);
            panel2.TabIndex = 19;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 588);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(736, 22);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(174, 17);
            toolStripStatusLabel1.Text = "Aguardando o Envio do Plano...";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 610);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuAdicionar);
            MainMenuStrip = menuAdicionar;
            Name = "FormPrincipal";
            Text = "Gráfico";
            Load += Form1_Load;
            menuAdicionar.ResumeLayout(false);
            menuAdicionar.PerformLayout();
            gpAdicionandoValores.ResumeLayout(false);
            gpAdicionandoValores.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuAdicionar;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem planoToolStripMenuItem;
        private ToolStripMenuItem personalizadoToolStripMenuItem;
        private GroupBox gpAdicionandoValores;
        private Label lblPeso;
        private TextBox txbPeso;
        private TextBox txbEixoX;
        private TextBox txbEixoY;
        private TextBox txbIntensidade;
        private Button btnCarregaCSV;
        private ListView lsvValoresAdicionados;
        private Label lblIntensidade;
        private Button btnEnviarValores;
        private Label lblEixoX;
        private Label lblEixoY;
        public ScottPlot.WinForms.FormsPlot PainelPrincipal;
        private Button btnCriarGrafico;
        private Panel panel1;
        private Panel panel2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label lblEscala;
        private TextBox txbEscala;
    }
}
