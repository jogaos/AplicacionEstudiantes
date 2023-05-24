namespace AplicacionEstudiantes
{
    partial class Notas
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
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCarnet.Location = new System.Drawing.Point(157, 54);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(291, 38);
            this.txtCarnet.TabIndex = 3;
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarnet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCarnet.Location = new System.Drawing.Point(48, 61);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCarnet.Size = new System.Drawing.Size(86, 31);
            this.lblCarnet.TabIndex = 2;
            this.lblCarnet.Text = "Carnet:";
            // 
            // txtCurso
            // 
            this.txtCurso.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCurso.Location = new System.Drawing.Point(157, 143);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(291, 38);
            this.txtCurso.TabIndex = 5;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCurso.Location = new System.Drawing.Point(48, 150);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurso.Size = new System.Drawing.Size(77, 31);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Curso:";
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNota.Location = new System.Drawing.Point(157, 242);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(291, 38);
            this.txtNota.TabIndex = 7;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNota.Location = new System.Drawing.Point(48, 249);
            this.lblNota.Name = "lblNota";
            this.lblNota.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNota.Size = new System.Drawing.Size(69, 31);
            this.lblNota.TabIndex = 6;
            this.lblNota.Text = "Nota:";
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarNota.Location = new System.Drawing.Point(328, 333);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(120, 37);
            this.btnGuardarNota.TabIndex = 8;
            this.btnGuardarNota.Text = "Guardar";
            this.btnGuardarNota.UseVisualStyleBackColor = true;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click);
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.btnGuardarNota);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.lblCarnet);
            this.Name = "Notas";
            this.Text = "Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCarnet;
        private Label lblCarnet;
        private TextBox txtCurso;
        private Label lblCurso;
        private TextBox txtNota;
        private Label lblNota;
        private Button btnGuardarNota;
    }
}