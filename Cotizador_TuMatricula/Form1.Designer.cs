namespace Cotizador_TuMatricula
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
            txtHuesped = new TextBox();
            nudNoches = new NumericUpDown();
            nudTarifa = new NumericUpDown();
            lstResultados = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            nudTasa = new NumericUpDown();
            btnPesos = new Button();
            label5 = new Label();
            nudPersonas = new NumericUpDown();
            btnPorPersona = new Button();
            btnDeposito = new Button();
            chkFinSemana = new CheckBox();
            btnFinSemana = new Button();
            btnDesglose = new Button();
            btnTraslado = new Button();
            btnExcursion = new Button();
            btnMinibar = new Button();
            btnCuentaTotal = new Button();
            btnViejo = new Button();
            btnFactura = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            SuspendLayout();
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(21, 56);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(158, 27);
            txtHuesped.TabIndex = 0;
            txtHuesped.Text = "Frankeny Castillo";
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(12, 145);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(150, 27);
            nudNoches.TabIndex = 1;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudTarifa
            // 
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Location = new Point(15, 225);
            nudTarifa.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(150, 27);
            nudTarifa.TabIndex = 2;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(519, 33);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(437, 604);
            lstResultados.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 33);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 109);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 5;
            label2.Text = "Cantidad Noches:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 202);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 6;
            label3.Text = "Tarifa Noches:";
            // 
            // button1
            // 
            button1.Location = new Point(222, 12);
            button1.Name = "button1";
            button1.Size = new Size(274, 25);
            button1.TabIndex = 7;
            button1.Text = "Comprobaciones de nivel 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 270);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 8;
            label4.Text = "Tasa del dolar:";
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(12, 307);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(150, 27);
            nudTasa.TabIndex = 9;
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(12, 521);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(150, 41);
            btnPesos.TabIndex = 10;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 358);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 11;
            label5.Text = "Cantidad Personas:";
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(12, 392);
            nudPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(150, 27);
            nudPersonas.TabIndex = 12;
            nudPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPorPersona
            // 
            btnPorPersona.Location = new Point(193, 521);
            btnPorPersona.Name = "btnPorPersona";
            btnPorPersona.Size = new Size(151, 41);
            btnPorPersona.TabIndex = 13;
            btnPorPersona.Text = "Total Por Persona";
            btnPorPersona.UseVisualStyleBackColor = true;
            btnPorPersona.Click += btnPorPersona_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(12, 580);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(147, 35);
            btnDeposito.TabIndex = 14;
            btnDeposito.Text = "Depósito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Location = new Point(119, 466);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(178, 24);
            chkFinSemana.TabIndex = 15;
            chkFinSemana.Text = "Fin de semana (+15%)";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(193, 586);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(151, 40);
            btnFinSemana.TabIndex = 16;
            btnFinSemana.Text = "Fin de Semana";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // btnDesglose
            // 
            btnDesglose.Location = new Point(12, 634);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(139, 44);
            btnDesglose.TabIndex = 17;
            btnDesglose.Text = "Ver Desglose";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // btnTraslado
            // 
            btnTraslado.Location = new Point(356, 332);
            btnTraslado.Name = "btnTraslado";
            btnTraslado.Size = new Size(140, 37);
            btnTraslado.TabIndex = 18;
            btnTraslado.Text = "Traslado";
            btnTraslado.UseVisualStyleBackColor = true;
            btnTraslado.Click += btnTraslado_Click;
            // 
            // btnExcursion
            // 
            btnExcursion.Location = new Point(356, 235);
            btnExcursion.Name = "btnExcursion";
            btnExcursion.Size = new Size(140, 37);
            btnExcursion.TabIndex = 19;
            btnExcursion.Text = "Excursión";
            btnExcursion.UseVisualStyleBackColor = true;
            btnExcursion.Click += btnExcursion_Click;
            // 
            // btnMinibar
            // 
            btnMinibar.Location = new Point(356, 135);
            btnMinibar.Name = "btnMinibar";
            btnMinibar.Size = new Size(140, 37);
            btnMinibar.TabIndex = 20;
            btnMinibar.Text = "Consumo Mini bar";
            btnMinibar.UseVisualStyleBackColor = true;
            btnMinibar.Click += btnMinibar_Click;
            // 
            // btnCuentaTotal
            // 
            btnCuentaTotal.Location = new Point(193, 642);
            btnCuentaTotal.Name = "btnCuentaTotal";
            btnCuentaTotal.Size = new Size(151, 36);
            btnCuentaTotal.TabIndex = 21;
            btnCuentaTotal.Text = "Cuenta Total";
            btnCuentaTotal.UseVisualStyleBackColor = true;
            btnCuentaTotal.Click += btnCuentaTotal_Click;
            // 
            // btnViejo
            // 
            btnViejo.Location = new Point(554, 664);
            btnViejo.Name = "btnViejo";
            btnViejo.Size = new Size(156, 35);
            btnViejo.TabIndex = 22;
            btnViejo.Text = "Probar Sistema Viejo";
            btnViejo.UseVisualStyleBackColor = true;
            btnViejo.Click += btnViejo_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(756, 664);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(163, 35);
            btnFactura.TabIndex = 23;
            btnFactura.Text = "Factura Completa";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 730);
            Controls.Add(btnFactura);
            Controls.Add(btnViejo);
            Controls.Add(btnCuentaTotal);
            Controls.Add(btnMinibar);
            Controls.Add(btnExcursion);
            Controls.Add(btnTraslado);
            Controls.Add(btnDesglose);
            Controls.Add(btnFinSemana);
            Controls.Add(chkFinSemana);
            Controls.Add(btnDeposito);
            Controls.Add(btnPorPersona);
            Controls.Add(nudPersonas);
            Controls.Add(label5);
            Controls.Add(btnPesos);
            Controls.Add(nudTasa);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstResultados);
            Controls.Add(nudTarifa);
            Controls.Add(nudNoches);
            Controls.Add(txtHuesped);
            Name = "Form1";
            Text = "Frankeny Castillo 2025-0794";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHuesped;
        private NumericUpDown nudNoches;
        private NumericUpDown nudTarifa;
        private ListBox lstResultados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private NumericUpDown nudTasa;
        private Button btnPesos;
        private Label label5;
        private NumericUpDown nudPersonas;
        private Button btnPorPersona;
        private Button btnDeposito;
        private CheckBox chkFinSemana;
        private Button btnFinSemana;
        private Button btnDesglose;
        private Button btnTraslado;
        private Button btnExcursion;
        private Button btnMinibar;
        private Button btnCuentaTotal;
        private Button btnViejo;
        private Button btnFactura;
    }
}
