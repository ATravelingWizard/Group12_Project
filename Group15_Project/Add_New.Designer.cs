namespace Group15_Project
{
    partial class frmAdd_New
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
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxBaggage = new System.Windows.Forms.GroupBox();
            this.numBaggage = new System.Windows.Forms.NumericUpDown();
            this.lblNum = new System.Windows.Forms.Label();
            this.gbxConfirm = new System.Windows.Forms.GroupBox();
            this.lbxConfirm = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbxInfo.SuspendLayout();
            this.gbxBaggage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBaggage)).BeginInit();
            this.gbxConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.txtEmail);
            this.gbxInfo.Controls.Add(this.lblEmail);
            this.gbxInfo.Controls.Add(this.txtSurname);
            this.gbxInfo.Controls.Add(this.lblSurname);
            this.gbxInfo.Controls.Add(this.txtName);
            this.gbxInfo.Controls.Add(this.lblName);
            this.gbxInfo.Controls.Add(this.gbxBaggage);
            this.gbxInfo.ForeColor = System.Drawing.Color.White;
            this.gbxInfo.Location = new System.Drawing.Point(19, 24);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(367, 242);
            this.gbxInfo.TabIndex = 0;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Passenger Info";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(216, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 25);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(216, 91);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 25);
            this.txtSurname.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 94);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(62, 17);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 25);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // gbxBaggage
            // 
            this.gbxBaggage.Controls.Add(this.numBaggage);
            this.gbxBaggage.Controls.Add(this.lblNum);
            this.gbxBaggage.ForeColor = System.Drawing.Color.White;
            this.gbxBaggage.Location = new System.Drawing.Point(6, 163);
            this.gbxBaggage.Name = "gbxBaggage";
            this.gbxBaggage.Size = new System.Drawing.Size(355, 74);
            this.gbxBaggage.TabIndex = 0;
            this.gbxBaggage.TabStop = false;
            this.gbxBaggage.Text = "Baggage and Seat Information";
            // 
            // numBaggage
            // 
            this.numBaggage.DecimalPlaces = 2;
            this.numBaggage.Location = new System.Drawing.Point(207, 33);
            this.numBaggage.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numBaggage.Name = "numBaggage";
            this.numBaggage.Size = new System.Drawing.Size(132, 25);
            this.numBaggage.TabIndex = 9;
            this.numBaggage.ValueChanged += new System.EventHandler(this.numBaggage_ValueChanged);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(17, 35);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(179, 17);
            this.lblNum.TabIndex = 6;
            this.lblNum.Text = "Baggage Weight (Max 25KG):";
            this.lblNum.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // gbxConfirm
            // 
            this.gbxConfirm.Controls.Add(this.lbxConfirm);
            this.gbxConfirm.ForeColor = System.Drawing.Color.White;
            this.gbxConfirm.Location = new System.Drawing.Point(435, 24);
            this.gbxConfirm.Name = "gbxConfirm";
            this.gbxConfirm.Size = new System.Drawing.Size(326, 242);
            this.gbxConfirm.TabIndex = 1;
            this.gbxConfirm.TabStop = false;
            this.gbxConfirm.Text = "Confirm Information";
            // 
            // lbxConfirm
            // 
            this.lbxConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbxConfirm.ForeColor = System.Drawing.Color.White;
            this.lbxConfirm.FormattingEnabled = true;
            this.lbxConfirm.ItemHeight = 17;
            this.lbxConfirm.Location = new System.Drawing.Point(7, 25);
            this.lbxConfirm.Name = "lbxConfirm";
            this.lbxConfirm.Size = new System.Drawing.Size(313, 208);
            this.lbxConfirm.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(19, 272);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 39);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit Info";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(242, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(525, 272);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 39);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm Passenger";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmAdd_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(784, 326);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxConfirm);
            this.Controls.Add(this.gbxInfo);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdd_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New";
            this.Load += new System.EventHandler(this.frmAdd_New_Load);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.gbxBaggage.ResumeLayout(false);
            this.gbxBaggage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBaggage)).EndInit();
            this.gbxConfirm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxBaggage;
        private System.Windows.Forms.NumericUpDown numBaggage;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.GroupBox gbxConfirm;
        private System.Windows.Forms.ListBox lbxConfirm;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
    }
}