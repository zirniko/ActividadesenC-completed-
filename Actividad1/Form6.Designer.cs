
namespace Actividad1
{
    partial class Form6
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelGrilla = new System.Windows.Forms.Panel();
            this.dtvModulo = new System.Windows.Forms.DataGridView();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.lblModulo = new System.Windows.Forms.Label();
            this.panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvModulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(270, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 40);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelGrilla
            // 
            this.panelGrilla.Controls.Add(this.dtvModulo);
            this.panelGrilla.Location = new System.Drawing.Point(16, 93);
            this.panelGrilla.Name = "panelGrilla";
            this.panelGrilla.Size = new System.Drawing.Size(441, 205);
            this.panelGrilla.TabIndex = 6;
            // 
            // dtvModulo
            // 
            this.dtvModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvModulo.Location = new System.Drawing.Point(20, 20);
            this.dtvModulo.Name = "dtvModulo";
            this.dtvModulo.Size = new System.Drawing.Size(388, 150);
            this.dtvModulo.TabIndex = 0;
            // 
            // cmbModulo
            // 
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(91, 34);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(121, 21);
            this.cmbModulo.TabIndex = 5;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(12, 36);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(72, 20);
            this.lblModulo.TabIndex = 4;
            this.lblModulo.Text = "Módulo:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 309);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelGrilla);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.lblModulo);
            this.Name = "Form6";
            this.Text = "Form6";
            this.panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvModulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelGrilla;
        private System.Windows.Forms.DataGridView dtvModulo;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Label lblModulo;
    }
}