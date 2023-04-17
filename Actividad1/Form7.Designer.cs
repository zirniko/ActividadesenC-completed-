
namespace Actividad1
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Btn_buscarModulo = new System.Windows.Forms.Button();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.chbModuloActivo = new System.Windows.Forms.CheckBox();
            this.Btn_ActualizarModulo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // Btn_buscarModulo
            // 
            this.Btn_buscarModulo.Location = new System.Drawing.Point(315, 72);
            this.Btn_buscarModulo.Name = "Btn_buscarModulo";
            this.Btn_buscarModulo.Size = new System.Drawing.Size(122, 50);
            this.Btn_buscarModulo.TabIndex = 2;
            this.Btn_buscarModulo.Text = "Buscar";
            this.Btn_buscarModulo.UseVisualStyleBackColor = true;
            this.Btn_buscarModulo.Click += new System.EventHandler(this.Btn_buscarModulo_Click);
            // 
            // cmbModulo
            // 
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(105, 83);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(152, 21);
            this.cmbModulo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 163);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // chbModuloActivo
            // 
            this.chbModuloActivo.AutoSize = true;
            this.chbModuloActivo.Location = new System.Drawing.Point(105, 216);
            this.chbModuloActivo.Name = "chbModuloActivo";
            this.chbModuloActivo.Size = new System.Drawing.Size(15, 14);
            this.chbModuloActivo.TabIndex = 7;
            this.chbModuloActivo.UseVisualStyleBackColor = true;
            // 
            // Btn_ActualizarModulo
            // 
            this.Btn_ActualizarModulo.Location = new System.Drawing.Point(315, 174);
            this.Btn_ActualizarModulo.Name = "Btn_ActualizarModulo";
            this.Btn_ActualizarModulo.Size = new System.Drawing.Size(122, 61);
            this.Btn_ActualizarModulo.TabIndex = 8;
            this.Btn_ActualizarModulo.Text = "Actualizar";
            this.Btn_ActualizarModulo.UseVisualStyleBackColor = true;
            this.Btn_ActualizarModulo.Click += new System.EventHandler(this.Btn_ActualizarModulo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Activo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Modulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "este formulario Funciona";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 265);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_ActualizarModulo);
            this.Controls.Add(this.chbModuloActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.Btn_buscarModulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button Btn_buscarModulo;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox chbModuloActivo;
        private System.Windows.Forms.Button Btn_ActualizarModulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}