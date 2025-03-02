namespace Bonificacion
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txthorasextratrabajadas = new System.Windows.Forms.TextBox();
            this.txtpagoporhoraextra = new System.Windows.Forms.TextBox();
            this.txtpagoporhoranormal = new System.Windows.Forms.TextBox();
            this.txthorasnormales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsueldoneto = new System.Windows.Forms.TextBox();
            this.txtbonificacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsueldobruto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkbonificacion = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nphijos = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nphijos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.txthorasextratrabajadas);
            this.groupBox1.Controls.Add(this.txtpagoporhoraextra);
            this.groupBox1.Controls.Add(this.txtpagoporhoranormal);
            this.groupBox1.Controls.Add(this.txthorasnormales);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jornada";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Lime;
            this.btnsalir.Location = new System.Drawing.Point(679, 128);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Lime;
            this.btncalcular.Location = new System.Drawing.Point(679, 89);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txthorasextratrabajadas
            // 
            this.txthorasextratrabajadas.Location = new System.Drawing.Point(49, 193);
            this.txthorasextratrabajadas.Name = "txthorasextratrabajadas";
            this.txthorasextratrabajadas.Size = new System.Drawing.Size(100, 22);
            this.txthorasextratrabajadas.TabIndex = 8;
            // 
            // txtpagoporhoraextra
            // 
            this.txtpagoporhoraextra.Location = new System.Drawing.Point(391, 193);
            this.txtpagoporhoraextra.Name = "txtpagoporhoraextra";
            this.txtpagoporhoraextra.Size = new System.Drawing.Size(100, 22);
            this.txtpagoporhoraextra.TabIndex = 7;
            // 
            // txtpagoporhoranormal
            // 
            this.txtpagoporhoranormal.Location = new System.Drawing.Point(391, 102);
            this.txtpagoporhoranormal.Name = "txtpagoporhoranormal";
            this.txtpagoporhoranormal.Size = new System.Drawing.Size(100, 22);
            this.txtpagoporhoranormal.TabIndex = 6;
            // 
            // txthorasnormales
            // 
            this.txthorasnormales.Location = new System.Drawing.Point(49, 89);
            this.txthorasnormales.Name = "txthorasnormales";
            this.txthorasnormales.Size = new System.Drawing.Size(100, 22);
            this.txthorasnormales.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pago por hora extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horas extra trabajadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pago por hora normal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Horas normales";
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Lime;
            this.btnnuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnuevo.Location = new System.Drawing.Point(679, 50);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtsueldoneto);
            this.groupBox2.Controls.Add(this.txtbonificacion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtsueldobruto);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(25, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sueldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sueldo neto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bonificacion";
            // 
            // txtsueldoneto
            // 
            this.txtsueldoneto.Location = new System.Drawing.Point(189, 132);
            this.txtsueldoneto.Name = "txtsueldoneto";
            this.txtsueldoneto.Size = new System.Drawing.Size(100, 22);
            this.txtsueldoneto.TabIndex = 11;
            // 
            // txtbonificacion
            // 
            this.txtbonificacion.Location = new System.Drawing.Point(189, 83);
            this.txtbonificacion.Name = "txtbonificacion";
            this.txtbonificacion.Size = new System.Drawing.Size(100, 22);
            this.txtbonificacion.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sueldo bruto";
            // 
            // txtsueldobruto
            // 
            this.txtsueldobruto.Location = new System.Drawing.Point(189, 37);
            this.txtsueldobruto.Name = "txtsueldobruto";
            this.txtsueldobruto.Size = new System.Drawing.Size(100, 22);
            this.txtsueldobruto.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkbonificacion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nphijos);
            this.groupBox3.Location = new System.Drawing.Point(498, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 211);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bonificacion";
            // 
            // checkbonificacion
            // 
            this.checkbonificacion.AutoSize = true;
            this.checkbonificacion.Location = new System.Drawing.Point(25, 107);
            this.checkbonificacion.Name = "checkbonificacion";
            this.checkbonificacion.Size = new System.Drawing.Size(139, 20);
            this.checkbonificacion.TabIndex = 10;
            this.checkbonificacion.Text = "Recibir bonificcion";
            this.checkbonificacion.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero de hijos";
            // 
            // nphijos
            // 
            this.nphijos.Location = new System.Drawing.Point(163, 41);
            this.nphijos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nphijos.Name = "nphijos";
            this.nphijos.Size = new System.Drawing.Size(120, 22);
            this.nphijos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bonificacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nphijos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txthorasextratrabajadas;
        private System.Windows.Forms.TextBox txtpagoporhoraextra;
        private System.Windows.Forms.TextBox txtpagoporhoranormal;
        private System.Windows.Forms.TextBox txthorasnormales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nphijos;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.CheckBox checkbonificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsueldoneto;
        private System.Windows.Forms.TextBox txtbonificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsueldobruto;
        
    }
}

