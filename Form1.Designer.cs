namespace ConeccionDB
{
    partial class MainLogin
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.LblEst = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtEst = new System.Windows.Forms.TextBox();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnElimi = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtDir = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.LblDir = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.llblCod = new System.Windows.Forms.Label();
            this.TxtTip_Cod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(72, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(142, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese su nombre";
            // 
            // LblEst
            // 
            this.LblEst.AutoSize = true;
            this.LblEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEst.Location = new System.Drawing.Point(72, 128);
            this.LblEst.Name = "LblEst";
            this.LblEst.Size = new System.Drawing.Size(137, 20);
            this.LblEst.TabIndex = 1;
            this.LblEst.Text = "Ingrese su estado";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(242, 81);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(100, 20);
            this.TxtNom.TabIndex = 2;
            // 
            // TxtEst
            // 
            this.TxtEst.Location = new System.Drawing.Point(242, 128);
            this.TxtEst.Name = "TxtEst";
            this.TxtEst.Size = new System.Drawing.Size(100, 20);
            this.TxtEst.TabIndex = 3;
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Location = new System.Drawing.Point(410, 192);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(125, 50);
            this.BtnCrear.TabIndex = 4;
            this.BtnCrear.Text = "Crear usuario";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(172, 192);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(125, 50);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar usuario";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnElimi
            // 
            this.BtnElimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimi.Location = new System.Drawing.Point(410, 270);
            this.BtnElimi.Name = "BtnElimi";
            this.BtnElimi.Size = new System.Drawing.Size(125, 50);
            this.BtnElimi.TabIndex = 6;
            this.BtnElimi.Text = "Eliminar";
            this.BtnElimi.UseVisualStyleBackColor = true;
            this.BtnElimi.Click += new System.EventHandler(this.BtnElimi_Click);
            // 
            // btnAct
            // 
            this.btnAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAct.Location = new System.Drawing.Point(172, 270);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(125, 50);
            this.btnAct.TabIndex = 7;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(72, 36);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(102, 20);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Ingrese su Id";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(242, 36);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 9;
            // 
            // TxtDir
            // 
            this.TxtDir.Location = new System.Drawing.Point(548, 81);
            this.TxtDir.Name = "TxtDir";
            this.TxtDir.Size = new System.Drawing.Size(100, 20);
            this.TxtDir.TabIndex = 10;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(548, 128);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(100, 20);
            this.TxtTel.TabIndex = 11;
            // 
            // LblDir
            // 
            this.LblDir.AutoSize = true;
            this.LblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDir.Location = new System.Drawing.Point(355, 81);
            this.LblDir.Name = "LblDir";
            this.LblDir.Size = new System.Drawing.Size(151, 20);
            this.LblDir.TabIndex = 12;
            this.LblDir.Text = "Ingrese su direccion";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTel.Location = new System.Drawing.Point(355, 128);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(146, 20);
            this.LblTel.TabIndex = 13;
            this.LblTel.Text = "Ingrese su telefono";
            // 
            // llblCod
            // 
            this.llblCod.AutoSize = true;
            this.llblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCod.Location = new System.Drawing.Point(348, 36);
            this.llblCod.Name = "llblCod";
            this.llblCod.Size = new System.Drawing.Size(187, 20);
            this.llblCod.TabIndex = 14;
            this.llblCod.Text = "Ingrese su tipo de codigo";
            // 
            // TxtTip_Cod
            // 
            this.TxtTip_Cod.Location = new System.Drawing.Point(548, 36);
            this.TxtTip_Cod.Name = "TxtTip_Cod";
            this.TxtTip_Cod.Size = new System.Drawing.Size(100, 20);
            this.TxtTip_Cod.TabIndex = 15;
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtTip_Cod);
            this.Controls.Add(this.llblCod);
            this.Controls.Add(this.LblTel);
            this.Controls.Add(this.LblDir);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtDir);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.BtnElimi);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.TxtEst);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.LblEst);
            this.Controls.Add(this.lblNombre);
            this.Name = "MainLogin";
            this.Text = "Registros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label LblEst;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtEst;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnElimi;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtDir;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Label LblDir;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.Label llblCod;
        private System.Windows.Forms.TextBox TxtTip_Cod;
    }
}

