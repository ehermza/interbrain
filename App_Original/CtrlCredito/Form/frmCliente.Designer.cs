namespace CtrldeCredito
{
    partial class frmCliente
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
            this.components = new System.ComponentModel.Container();
            this.tbDetalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbDocNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EP1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSalas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtimepick = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EP1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDetalle
            // 
            this.tbDetalle.Location = new System.Drawing.Point(122, 201);
            this.tbDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDetalle.MaxLength = 127;
            this.tbDetalle.Name = "tbDetalle";
            this.tbDetalle.Size = new System.Drawing.Size(428, 20);
            this.tbDetalle.TabIndex = 3;
            this.tbDetalle.TextChanged += new System.EventHandler(this.tbDetalle_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Observacion:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(418, 142);
            this.tbCelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCelular.MaxLength = 63;
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(132, 20);
            this.tbCelular.TabIndex = 4;
            this.tbCelular.TextChanged += new System.EventHandler(this.tbCelular_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 36;
            this.label5.Text = "Telefono: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(122, 87);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNombre.MaxLength = 63;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(428, 44);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.Text = "tbNombre";
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 48);
            this.label7.TabIndex = 34;
            this.label7.Text = "Apellido y Nombre:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(438, 292);
            this.btOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(112, 28);
            this.btOK.TabIndex = 7;
            this.btOK.Text = "Ingresar Registro";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(438, 333);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 28);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cerrar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbDocNumber
            // 
            this.tbDocNumber.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F);
            this.tbDocNumber.Location = new System.Drawing.Point(122, 139);
            this.tbDocNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDocNumber.MaxLength = 63;
            this.tbDocNumber.Name = "tbDocNumber";
            this.tbDocNumber.Size = new System.Drawing.Size(172, 44);
            this.tbDocNumber.TabIndex = 2;
            this.tbDocNumber.Text = "tbDocNumber";
            this.tbDocNumber.TextChanged += new System.EventHandler(this.tbDocNumber_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "DNI:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EP1
            // 
            this.EP1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(556, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(556, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 56;
            this.label11.Text = "*";
            // 
            // cbSalas
            // 
            this.cbSalas.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F);
            this.cbSalas.FormattingEnabled = true;
            this.cbSalas.Location = new System.Drawing.Point(122, 258);
            this.cbSalas.Name = "cbSalas";
            this.cbSalas.Size = new System.Drawing.Size(252, 36);
            this.cbSalas.TabIndex = 60;
            this.cbSalas.SelectedIndexChanged += new System.EventHandler(this.cbSalas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 61;
            this.label2.Text = "Reservar Sala:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 62;
            this.label1.Text = "label1";
            // 
            // dtimepick
            // 
            this.dtimepick.CustomFormat = "yy/MM/dd HH:mm:ss";
            this.dtimepick.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimepick.Location = new System.Drawing.Point(122, 318);
            this.dtimepick.Name = "dtimepick";
            this.dtimepick.Size = new System.Drawing.Size(252, 37);
            this.dtimepick.TabIndex = 63;
            this.dtimepick.Value = new System.DateTime(2021, 5, 8, 8, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 64;
            this.button1.Text = "Reservas hechas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCliente
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtimepick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSalas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDocNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTERBRAIN";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbDocNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider EP1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSalas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtimepick;
        private System.Windows.Forms.Button button1;
    }
}

