namespace AplicacionEstudiantes
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
            this.lblCarnet = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrorCarnet = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListado = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarnet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCarnet.Location = new System.Drawing.Point(25, 53);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCarnet.Size = new System.Drawing.Size(86, 31);
            this.lblCarnet.TabIndex = 0;
            this.lblCarnet.Text = "Carnet:";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCarnet.Location = new System.Drawing.Point(134, 46);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(291, 38);
            this.txtCarnet.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(134, 168);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 38);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(25, 175);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombre.Size = new System.Drawing.Size(103, 31);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(156, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 37);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(25, 264);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(43, 17);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "label1";
            this.lblError.Visible = false;
            // 
            // lblErrorCarnet
            // 
            this.lblErrorCarnet.AutoSize = true;
            this.lblErrorCarnet.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorCarnet.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCarnet.Location = new System.Drawing.Point(134, 87);
            this.lblErrorCarnet.Name = "lblErrorCarnet";
            this.lblErrorCarnet.Size = new System.Drawing.Size(43, 17);
            this.lblErrorCarnet.TabIndex = 6;
            this.lblErrorCarnet.Text = "label2";
            this.lblErrorCarnet.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(134, 209);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(43, 17);
            this.lblErrorNombre.TabIndex = 7;
            this.lblErrorNombre.Text = "label2";
            this.lblErrorNombre.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEstudiantes,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuEstudiantes
            // 
            this.mnuEstudiantes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNotas});
            this.mnuEstudiantes.Name = "mnuEstudiantes";
            this.mnuEstudiantes.Size = new System.Drawing.Size(98, 24);
            this.mnuEstudiantes.Text = "Estudiantes";
            // 
            // mnuNotas
            // 
            this.mnuNotas.Name = "mnuNotas";
            this.mnuNotas.Size = new System.Drawing.Size(131, 26);
            this.mnuNotas.Text = "Notas";
            this.mnuNotas.Click += new System.EventHandler(this.mnuNotas_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(52, 24);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // btnListado
            // 
            this.btnListado.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListado.Location = new System.Drawing.Point(292, 294);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(133, 37);
            this.btnListado.TabIndex = 9;
            this.btnListado.Text = "Ver listado";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 359);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblErrorCarnet);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Aplicación de estudiante";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCarnet;
        private TextBox txtCarnet;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnGuardar;
        private Label lblError;
        private Label lblErrorCarnet;
        private Label lblErrorNombre;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuEstudiantes;
        private ToolStripMenuItem mnuNotas;
        private Button btnListado;
        private ToolStripMenuItem mnuSalir;
    }
}