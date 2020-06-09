namespace CentralitaForm
{
    partial class FrmLlamador
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
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbBoxFranja = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.groupBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(264, 163);
            this.btnLlamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(150, 38);
            this.btnLlamar.TabIndex = 0;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(264, 237);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 35);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbBoxFranja
            // 
            this.cmbBoxFranja.Enabled = false;
            this.cmbBoxFranja.FormattingEnabled = true;
            this.cmbBoxFranja.Location = new System.Drawing.Point(42, 460);
            this.cmbBoxFranja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoxFranja.Name = "cmbBoxFranja";
            this.cmbBoxFranja.Size = new System.Drawing.Size(367, 28);
            this.cmbBoxFranja.TabIndex = 2;
            this.cmbBoxFranja.Text = "Franja";
            this.cmbBoxFranja.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFranja_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(264, 365);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 43);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(24, 29);
            this.btnUno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(46, 43);
            this.btnUno.TabIndex = 5;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDestino.Location = new System.Drawing.Point(42, 49);
            this.txtNroDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroDestino.Multiline = true;
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.ReadOnly = true;
            this.txtNroDestino.Size = new System.Drawing.Size(367, 42);
            this.txtNroDestino.TabIndex = 6;
            this.txtNroDestino.Text = "Nro Destino ";
            this.txtNroDestino.TextChanged += new System.EventHandler(this.txtNroDestino_TextChanged);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Location = new System.Drawing.Point(264, 306);
            this.txtNroOrigen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(148, 26);
            this.txtNroOrigen.TabIndex = 7;
            this.txtNroOrigen.Text = "Nro Origen ";
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(93, 29);
            this.btnDos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(46, 43);
            this.btnDos.TabIndex = 19;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(164, 29);
            this.btnTres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(46, 43);
            this.btnTres.TabIndex = 20;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(164, 95);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(46, 43);
            this.btnSeis.TabIndex = 23;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(93, 95);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(46, 43);
            this.btnCinco.TabIndex = 22;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(24, 95);
            this.btnCuatro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(46, 43);
            this.btnCuatro.TabIndex = 21;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(164, 165);
            this.btnNueve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(46, 43);
            this.btnNueve.TabIndex = 26;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(93, 165);
            this.btnOcho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(46, 43);
            this.btnOcho.TabIndex = 25;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(24, 165);
            this.btnSiete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(46, 43);
            this.btnSiete.TabIndex = 24;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(164, 231);
            this.btnNumeral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(46, 43);
            this.btnNumeral.TabIndex = 29;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnNumeral_Click);
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(93, 231);
            this.btnCero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(46, 43);
            this.btnCero.TabIndex = 28;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(24, 231);
            this.btnAsterisco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(46, 43);
            this.btnAsterisco.TabIndex = 27;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnAsterisco_Click);
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.Controls.Add(this.btnUno);
            this.groupBoxPanel.Controls.Add(this.btnNumeral);
            this.groupBoxPanel.Controls.Add(this.btnDos);
            this.groupBoxPanel.Controls.Add(this.btnCero);
            this.groupBoxPanel.Controls.Add(this.btnTres);
            this.groupBoxPanel.Controls.Add(this.btnAsterisco);
            this.groupBoxPanel.Controls.Add(this.btnCuatro);
            this.groupBoxPanel.Controls.Add(this.btnNueve);
            this.groupBoxPanel.Controls.Add(this.btnCinco);
            this.groupBoxPanel.Controls.Add(this.btnOcho);
            this.groupBoxPanel.Controls.Add(this.btnSeis);
            this.groupBoxPanel.Controls.Add(this.btnSiete);
            this.groupBoxPanel.Location = new System.Drawing.Point(18, 134);
            this.groupBoxPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPanel.Size = new System.Drawing.Size(237, 289);
            this.groupBoxPanel.TabIndex = 30;
            this.groupBoxPanel.TabStop = false;
            this.groupBoxPanel.Text = "Panel";
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 525);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.txtNroDestino);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbBoxFranja);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.groupBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbBoxFranja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.GroupBox groupBoxPanel;
    }
}