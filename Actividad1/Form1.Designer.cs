namespace Actividad1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConexion = new System.Windows.Forms.Button();
            this.lblNombreModulo = new System.Windows.Forms.Label();
            this.lblCodigoModulo = new System.Windows.Forms.Label();
            this.tbxNombreModulo = new System.Windows.Forms.TextBox();
            this.tbxCodigoModulo = new System.Windows.Forms.TextBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConexion
            // 
            this.btnConexion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexion.Location = new System.Drawing.Point(44, 196);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(144, 51);
            this.btnConexion.TabIndex = 0;
            this.btnConexion.Text = "Guardar";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // lblNombreModulo
            // 
            this.lblNombreModulo.AutoSize = true;
            this.lblNombreModulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreModulo.Location = new System.Drawing.Point(10, 20);
            this.lblNombreModulo.Name = "lblNombreModulo";
            this.lblNombreModulo.Size = new System.Drawing.Size(224, 21);
            this.lblNombreModulo.TabIndex = 1;
            this.lblNombreModulo.Text = "Ingerse Nombre de Módulo:";
            // 
            // lblCodigoModulo
            // 
            this.lblCodigoModulo.AutoSize = true;
            this.lblCodigoModulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoModulo.Location = new System.Drawing.Point(12, 84);
            this.lblCodigoModulo.Name = "lblCodigoModulo";
            this.lblCodigoModulo.Size = new System.Drawing.Size(193, 21);
            this.lblCodigoModulo.TabIndex = 2;
            this.lblCodigoModulo.Text = "Ingrese Código Módulo:";
            // 
            // tbxNombreModulo
            // 
            this.tbxNombreModulo.Location = new System.Drawing.Point(44, 44);
            this.tbxNombreModulo.Name = "tbxNombreModulo";
            this.tbxNombreModulo.Size = new System.Drawing.Size(161, 20);
            this.tbxNombreModulo.TabIndex = 3;
            // 
            // tbxCodigoModulo
            // 
            this.tbxCodigoModulo.Location = new System.Drawing.Point(44, 108);
            this.tbxCodigoModulo.Name = "tbxCodigoModulo";
            this.tbxCodigoModulo.Size = new System.Drawing.Size(161, 20);
            this.tbxCodigoModulo.TabIndex = 4;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(12, 144);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(63, 21);
            this.lblActivo.TabIndex = 5;
            this.lblActivo.Text = "Activo:";
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Location = new System.Drawing.Point(191, 150);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(15, 14);
            this.chbActivo.TabIndex = 6;
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 281);
            this.Controls.Add(this.chbActivo);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.tbxCodigoModulo);
            this.Controls.Add(this.tbxNombreModulo);
            this.Controls.Add(this.lblCodigoModulo);
            this.Controls.Add(this.lblNombreModulo);
            this.Controls.Add(this.btnConexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Label lblNombreModulo;
        private System.Windows.Forms.Label lblCodigoModulo;
        private System.Windows.Forms.TextBox tbxNombreModulo;
        private System.Windows.Forms.TextBox tbxCodigoModulo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.CheckBox chbActivo;
    }
}

