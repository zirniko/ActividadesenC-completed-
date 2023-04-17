namespace Actividad1
{
    partial class Form2
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.tbxCapacidad = new System.Windows.Forms.TextBox();
            this.tbxPiso = new System.Windows.Forms.TextBox();
            this.lblInformatica = new System.Windows.Forms.Label();
            this.chbEsInformatica = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(122, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingrese Laboratorio";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(82, 92);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(61, 13);
            this.lblCapacidad.TabIndex = 1;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(82, 134);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "Piso:";
            // 
            // tbxCapacidad
            // 
            this.tbxCapacidad.Location = new System.Drawing.Point(149, 89);
            this.tbxCapacidad.Name = "tbxCapacidad";
            this.tbxCapacidad.Size = new System.Drawing.Size(100, 20);
            this.tbxCapacidad.TabIndex = 3;
            // 
            // tbxPiso
            // 
            this.tbxPiso.Location = new System.Drawing.Point(149, 131);
            this.tbxPiso.Name = "tbxPiso";
            this.tbxPiso.Size = new System.Drawing.Size(100, 20);
            this.tbxPiso.TabIndex = 4;
            // 
            // lblInformatica
            // 
            this.lblInformatica.AutoSize = true;
            this.lblInformatica.Location = new System.Drawing.Point(82, 183);
            this.lblInformatica.Name = "lblInformatica";
            this.lblInformatica.Size = new System.Drawing.Size(92, 13);
            this.lblInformatica.TabIndex = 5;
            this.lblInformatica.Text = "Es de Informatica:";
            this.lblInformatica.Click += new System.EventHandler(this.label4_Click);
            // 
            // chbEsInformatica
            // 
            this.chbEsInformatica.AutoSize = true;
            this.chbEsInformatica.Location = new System.Drawing.Point(180, 183);
            this.chbEsInformatica.Name = "chbEsInformatica";
            this.chbEsInformatica.Size = new System.Drawing.Size(15, 14);
            this.chbEsInformatica.TabIndex = 6;
            this.chbEsInformatica.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Location = new System.Drawing.Point(111, 236);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 39);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(149, 52);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(100, 21);
            this.cmbLaboratorio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Laboratorio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Funciona :)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLaboratorio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chbEsInformatica);
            this.Controls.Add(this.lblInformatica);
            this.Controls.Add(this.tbxPiso);
            this.Controls.Add(this.tbxCapacidad);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox tbxCapacidad;
        private System.Windows.Forms.TextBox tbxPiso;
        private System.Windows.Forms.Label lblInformatica;
        private System.Windows.Forms.CheckBox chbEsInformatica;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbLaboratorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}