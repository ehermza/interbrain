
namespace CtrldeCredito
{
    partial class frmListReservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btcancel = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.Location = new System.Drawing.Point(12, 24);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.Size = new System.Drawing.Size(654, 291);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedRowsButton_Click);
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(12, 321);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(130, 32);
            this.btcancel.TabIndex = 1;
            this.btcancel.Text = "CANCELAR RESERVA";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(148, 320);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(120, 33);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Cerrar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmListReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 355);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.dtgv);
            this.Name = "frmListReservas";
            this.Text = "RESERVAS";
            this.Load += new System.EventHandler(this.frmListReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btClose;
    }
}