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
            this.gbxBaggage = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblSeatNum = new System.Windows.Forms.Label();
            this.lblFlightNum = new System.Windows.Forms.Label();
            this.numBaggage = new System.Windows.Forms.NumericUpDown();
            this.lblOutputSeat = new System.Windows.Forms.Label();
            this.lblOutputFlight = new System.Windows.Forms.Label();
            this.gbxConfirm = new System.Windows.Forms.GroupBox();
            this.lbxConfirm = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxInfo.SuspendLayout();
            this.gbxBaggage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBaggage)).BeginInit();
            this.gbxConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.textBox2);
            this.gbxInfo.Controls.Add(this.lblEmail);
            this.gbxInfo.Controls.Add(this.textBox1);
            this.gbxInfo.Controls.Add(this.lblSurname);
            this.gbxInfo.Controls.Add(this.txtName);
            this.gbxInfo.Controls.Add(this.lblName);
            this.gbxInfo.Controls.Add(this.gbxBaggage);
            this.gbxInfo.ForeColor = System.Drawing.Color.White;
            this.gbxInfo.Location = new System.Drawing.Point(19, 24);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(367, 322);
            this.gbxInfo.TabIndex = 0;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Passenger Info";
            // 
            // gbxBaggage
            // 
            this.gbxBaggage.Controls.Add(this.lblOutputFlight);
            this.gbxBaggage.Controls.Add(this.lblOutputSeat);
            this.gbxBaggage.Controls.Add(this.numBaggage);
            this.gbxBaggage.Controls.Add(this.lblFlightNum);
            this.gbxBaggage.Controls.Add(this.lblSeatNum);
            this.gbxBaggage.Controls.Add(this.lblNum);
            this.gbxBaggage.ForeColor = System.Drawing.Color.White;
            this.gbxBaggage.Location = new System.Drawing.Point(9, 163);
            this.gbxBaggage.Name = "gbxBaggage";
            this.gbxBaggage.Size = new System.Drawing.Size(352, 153);
            this.gbxBaggage.TabIndex = 0;
            this.gbxBaggage.TabStop = false;
            this.gbxBaggage.Text = "Baggage and Seat Information";
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 25);
            this.txtName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 4;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 25);
            this.textBox2.TabIndex = 6;
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
            // lblSeatNum
            // 
            this.lblSeatNum.AutoSize = true;
            this.lblSeatNum.Location = new System.Drawing.Point(17, 78);
            this.lblSeatNum.Name = "lblSeatNum";
            this.lblSeatNum.Size = new System.Drawing.Size(89, 17);
            this.lblSeatNum.TabIndex = 7;
            this.lblSeatNum.Text = "Seat Number:";
            // 
            // lblFlightNum
            // 
            this.lblFlightNum.AutoSize = true;
            this.lblFlightNum.Location = new System.Drawing.Point(17, 120);
            this.lblFlightNum.Name = "lblFlightNum";
            this.lblFlightNum.Size = new System.Drawing.Size(95, 17);
            this.lblFlightNum.TabIndex = 8;
            this.lblFlightNum.Text = "Flight Number:";
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
            // 
            // lblOutputSeat
            // 
            this.lblOutputSeat.AutoSize = true;
            this.lblOutputSeat.Location = new System.Drawing.Point(204, 78);
            this.lblOutputSeat.Name = "lblOutputSeat";
            this.lblOutputSeat.Size = new System.Drawing.Size(0, 17);
            this.lblOutputSeat.TabIndex = 10;
            // 
            // lblOutputFlight
            // 
            this.lblOutputFlight.AutoSize = true;
            this.lblOutputFlight.Location = new System.Drawing.Point(204, 120);
            this.lblOutputFlight.Name = "lblOutputFlight";
            this.lblOutputFlight.Size = new System.Drawing.Size(0, 17);
            this.lblOutputFlight.TabIndex = 11;
            // 
            // gbxConfirm
            // 
            this.gbxConfirm.Controls.Add(this.lbxConfirm);
            this.gbxConfirm.ForeColor = System.Drawing.Color.White;
            this.gbxConfirm.Location = new System.Drawing.Point(435, 24);
            this.gbxConfirm.Name = "gbxConfirm";
            this.gbxConfirm.Size = new System.Drawing.Size(326, 322);
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
            this.lbxConfirm.Size = new System.Drawing.Size(313, 276);
            this.lbxConfirm.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(28, 352);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 39);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit Info";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(236, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear Fields";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAdd_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(814, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxConfirm);
            this.Controls.Add(this.gbxInfo);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxBaggage;
        private System.Windows.Forms.NumericUpDown numBaggage;
        private System.Windows.Forms.Label lblFlightNum;
        private System.Windows.Forms.Label lblSeatNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblOutputFlight;
        private System.Windows.Forms.Label lblOutputSeat;
        private System.Windows.Forms.GroupBox gbxConfirm;
        private System.Windows.Forms.ListBox lbxConfirm;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button1;
    }
}