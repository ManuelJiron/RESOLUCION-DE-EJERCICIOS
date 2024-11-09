namespace ejercicio1sem12
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcarg = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblsueldo = new System.Windows.Forms.Label();
            this.txtsueld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(294, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Determinar sueldo de un empleado";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblnombre.Location = new System.Drawing.Point(53, 153);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(114, 32);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblcargo.Location = new System.Drawing.Point(53, 232);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(85, 32);
            this.lblcargo.TabIndex = 2;
            this.lblcargo.Text = "cargo";
            this.lblcargo.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(245, 158);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(190, 26);
            this.txtname.TabIndex = 3;
            // 
            // txtcarg
            // 
            this.txtcarg.Location = new System.Drawing.Point(245, 237);
            this.txtcarg.Name = "txtcarg";
            this.txtcarg.Size = new System.Drawing.Size(190, 26);
            this.txtcarg.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btncalcular.Location = new System.Drawing.Point(59, 341);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(179, 68);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnNuevo.Location = new System.Drawing.Point(351, 341);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(179, 68);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnsalir.Location = new System.Drawing.Point(631, 341);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(179, 68);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblsueldo
            // 
            this.lblsueldo.AutoSize = true;
            this.lblsueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsueldo.Location = new System.Drawing.Point(53, 516);
            this.lblsueldo.Name = "lblsueldo";
            this.lblsueldo.Size = new System.Drawing.Size(316, 32);
            this.lblsueldo.TabIndex = 8;
            this.lblsueldo.Text = "Sueldo correspondiente";
            // 
            // txtsueld
            // 
            this.txtsueld.Location = new System.Drawing.Point(427, 521);
            this.txtsueld.Name = "txtsueld";
            this.txtsueld.Size = new System.Drawing.Size(229, 26);
            this.txtsueld.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 631);
            this.Controls.Add(this.txtsueld);
            this.Controls.Add(this.lblsueldo);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtcarg);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcarg;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblsueldo;
        private System.Windows.Forms.TextBox txtsueld;
    }
}

