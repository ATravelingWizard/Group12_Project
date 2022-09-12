namespace Group15_Project
{
    partial class Edit_Passenger
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
            this.lblOutputFlight = new System.Windows.Forms.Label();
            this.lblOutputSeat = new System.Windows.Forms.Label();
            this.numBaggage = new System.Windows.Forms.NumericUpDown();
            this.lblNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmailOut = new System.Windows.Forms.Label();
            this.lblOutSurname = new System.Windows.Forms.Label();
            this.lblOutName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOutWeight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxInfo.SuspendLayout();
            this.gbxBaggage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBaggage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.gbxInfo.Location = new System.Drawing.Point(399, 12);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(367, 241);
            this.gbxInfo.TabIndex = 1;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "New Passenger Info";
            this.gbxInfo.Enter += new System.EventHandler(this.gbxInfo_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(216, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(216, 91);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 94);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // gbxBaggage
            // 
            this.gbxBaggage.Controls.Add(this.lblOutputFlight);
            this.gbxBaggage.Controls.Add(this.lblOutputSeat);
            this.gbxBaggage.Controls.Add(this.numBaggage);
            this.gbxBaggage.Controls.Add(this.lblNum);
            this.gbxBaggage.ForeColor = System.Drawing.Color.White;
            this.gbxBaggage.Location = new System.Drawing.Point(6, 163);
            this.gbxBaggage.Name = "gbxBaggage";
            this.gbxBaggage.Size = new System.Drawing.Size(355, 69);
            this.gbxBaggage.TabIndex = 0;
            this.gbxBaggage.TabStop = false;
            this.gbxBaggage.Text = "Baggage";
            // 
            // lblOutputFlight
            // 
            this.lblOutputFlight.AutoSize = true;
            this.lblOutputFlight.Location = new System.Drawing.Point(204, 120);
            this.lblOutputFlight.Name = "lblOutputFlight";
            this.lblOutputFlight.Size = new System.Drawing.Size(0, 13);
            this.lblOutputFlight.TabIndex = 11;
            // 
            // lblOutputSeat
            // 
            this.lblOutputSeat.AutoSize = true;
            this.lblOutputSeat.Location = new System.Drawing.Point(204, 78);
            this.lblOutputSeat.Name = "lblOutputSeat";
            this.lblOutputSeat.Size = new System.Drawing.Size(0, 13);
            this.lblOutputSeat.TabIndex = 10;
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
            this.numBaggage.Size = new System.Drawing.Size(132, 20);
            this.numBaggage.TabIndex = 9;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(17, 35);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(149, 13);
            this.lblNum.TabIndex = 6;
            this.lblNum.Text = "Baggage Weight (Max 25KG):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm new Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmailOut);
            this.groupBox1.Controls.Add(this.lblOutSurname);
            this.groupBox1.Controls.Add(this.lblOutName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 241);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Passenger Info";
            // 
            // lblEmailOut
            // 
            this.lblEmailOut.AutoSize = true;
            this.lblEmailOut.Location = new System.Drawing.Point(129, 135);
            this.lblEmailOut.Name = "lblEmailOut";
            this.lblEmailOut.Size = new System.Drawing.Size(232, 13);
            this.lblEmailOut.TabIndex = 8;
            this.lblEmailOut.Text = "Current Database value should be inserted here";
            // 
            // lblOutSurname
            // 
            this.lblOutSurname.AutoSize = true;
            this.lblOutSurname.Location = new System.Drawing.Point(129, 98);
            this.lblOutSurname.Name = "lblOutSurname";
            this.lblOutSurname.Size = new System.Drawing.Size(232, 13);
            this.lblOutSurname.TabIndex = 7;
            this.lblOutSurname.Text = "Current Database value should be inserted here";
            // 
            // lblOutName
            // 
            this.lblOutName.AutoSize = true;
            this.lblOutName.Location = new System.Drawing.Point(129, 56);
            this.lblOutName.Name = "lblOutName";
            this.lblOutName.Size = new System.Drawing.Size(232, 13);
            this.lblOutName.TabIndex = 6;
            this.lblOutName.Text = "Current Database value should be inserted here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOutWeight);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 69);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baggage ";
            // 
            // lblOutWeight
            // 
            this.lblOutWeight.AutoSize = true;
            this.lblOutWeight.Location = new System.Drawing.Point(194, 35);
            this.lblOutWeight.Name = "lblOutWeight";
            this.lblOutWeight.Size = new System.Drawing.Size(112, 13);
            this.lblOutWeight.TabIndex = 12;
            this.lblOutWeight.Text = "Current DB value here";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Baggage Weight (Max 25KG):";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edit_Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(784, 328);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit_Passenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Passenger";
            this.Load += new System.EventHandler(this.Edit_Passenger_Load);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.gbxBaggage.ResumeLayout(false);
            this.gbxBaggage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBaggage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lblOutputFlight;
        private System.Windows.Forms.Label lblOutputSeat;
        private System.Windows.Forms.NumericUpDown numBaggage;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEmailOut;
        private System.Windows.Forms.Label lblOutSurname;
        private System.Windows.Forms.Label lblOutName;
        private System.Windows.Forms.Label lblOutWeight;
        private System.Windows.Forms.Button button2;
    }
}