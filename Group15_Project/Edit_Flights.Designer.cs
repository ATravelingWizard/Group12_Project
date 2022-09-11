namespace Group15_Project
{
    partial class Edit_Flights
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
            this.lblBaggage = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblFlightOut = new System.Windows.Forms.Label();
            this.lblFlightID = new System.Windows.Forms.Label();
            this.gbxDestination = new System.Windows.Forms.GroupBox();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.lblDestinationID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateArrival = new System.Windows.Forms.DateTimePicker();
            this.dateDeparture = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numBaggageOut = new System.Windows.Forms.NumericUpDown();
            this.numSeatOut = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFlightOut2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSeatsOut = new System.Windows.Forms.Label();
            this.lblBaggageOut = new System.Windows.Forms.Label();
            this.lblDepTimeOut = new System.Windows.Forms.Label();
            this.lblArriveOut = new System.Windows.Forms.Label();
            this.lblDestOut = new System.Windows.Forms.Label();
            this.gbxInfo.SuspendLayout();
            this.gbxDestination.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBaggageOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatOut)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.lblBaggageOut);
            this.gbxInfo.Controls.Add(this.lblSeatsOut);
            this.gbxInfo.Controls.Add(this.lblBaggage);
            this.gbxInfo.Controls.Add(this.lblSeats);
            this.gbxInfo.Controls.Add(this.lblFlightOut);
            this.gbxInfo.Controls.Add(this.lblFlightID);
            this.gbxInfo.Controls.Add(this.gbxDestination);
            this.gbxInfo.ForeColor = System.Drawing.Color.White;
            this.gbxInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(367, 251);
            this.gbxInfo.TabIndex = 6;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Flight Info";
            // 
            // lblBaggage
            // 
            this.lblBaggage.AutoSize = true;
            this.lblBaggage.Location = new System.Drawing.Point(6, 91);
            this.lblBaggage.Name = "lblBaggage";
            this.lblBaggage.Size = new System.Drawing.Size(80, 13);
            this.lblBaggage.TabIndex = 6;
            this.lblBaggage.Text = "Total Baggage:";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(6, 53);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(110, 13);
            this.lblSeats.TabIndex = 3;
            this.lblSeats.Text = "Total Seats Available:";
            // 
            // lblFlightOut
            // 
            this.lblFlightOut.AutoSize = true;
            this.lblFlightOut.Location = new System.Drawing.Point(190, 25);
            this.lblFlightOut.Name = "lblFlightOut";
            this.lblFlightOut.Size = new System.Drawing.Size(149, 13);
            this.lblFlightOut.TabIndex = 2;
            this.lblFlightOut.Text = "Randomly Generated Flight ID";
            // 
            // lblFlightID
            // 
            this.lblFlightID.AutoSize = true;
            this.lblFlightID.Location = new System.Drawing.Point(6, 25);
            this.lblFlightID.Name = "lblFlightID";
            this.lblFlightID.Size = new System.Drawing.Size(49, 13);
            this.lblFlightID.TabIndex = 1;
            this.lblFlightID.Text = "Flight ID:";
            // 
            // gbxDestination
            // 
            this.gbxDestination.Controls.Add(this.lblDestOut);
            this.gbxDestination.Controls.Add(this.lblArriveOut);
            this.gbxDestination.Controls.Add(this.lblDepTimeOut);
            this.gbxDestination.Controls.Add(this.lblDestinationID);
            this.gbxDestination.Controls.Add(this.label2);
            this.gbxDestination.Controls.Add(this.label1);
            this.gbxDestination.ForeColor = System.Drawing.Color.White;
            this.gbxDestination.Location = new System.Drawing.Point(6, 125);
            this.gbxDestination.Name = "gbxDestination";
            this.gbxDestination.Size = new System.Drawing.Size(355, 121);
            this.gbxDestination.TabIndex = 0;
            this.gbxDestination.TabStop = false;
            this.gbxDestination.Text = "Time and Date Information";
            // 
            // cbxDestination
            // 
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Location = new System.Drawing.Point(149, 87);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(200, 21);
            this.cbxDestination.TabIndex = 5;
            // 
            // lblDestinationID
            // 
            this.lblDestinationID.AutoSize = true;
            this.lblDestinationID.Location = new System.Drawing.Point(6, 90);
            this.lblDestinationID.Name = "lblDestinationID";
            this.lblDestinationID.Size = new System.Drawing.Size(77, 13);
            this.lblDestinationID.TabIndex = 4;
            this.lblDestinationID.Text = "Destination ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arrival Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departure Time:";
            // 
            // dateArrival
            // 
            this.dateArrival.Location = new System.Drawing.Point(149, 57);
            this.dateArrival.Name = "dateArrival";
            this.dateArrival.Size = new System.Drawing.Size(200, 20);
            this.dateArrival.TabIndex = 1;
            // 
            // dateDeparture
            // 
            this.dateDeparture.Location = new System.Drawing.Point(149, 19);
            this.dateDeparture.Name = "dateDeparture";
            this.dateDeparture.Size = new System.Drawing.Size(200, 20);
            this.dateDeparture.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numBaggageOut);
            this.groupBox1.Controls.Add(this.numSeatOut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblFlightOut2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(421, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 251);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Baggage:";
            // 
            // numBaggageOut
            // 
            this.numBaggageOut.DecimalPlaces = 2;
            this.numBaggageOut.Location = new System.Drawing.Point(193, 89);
            this.numBaggageOut.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numBaggageOut.Name = "numBaggageOut";
            this.numBaggageOut.Size = new System.Drawing.Size(146, 20);
            this.numBaggageOut.TabIndex = 5;
            // 
            // numSeatOut
            // 
            this.numSeatOut.Location = new System.Drawing.Point(193, 53);
            this.numSeatOut.Name = "numSeatOut";
            this.numSeatOut.Size = new System.Drawing.Size(146, 20);
            this.numSeatOut.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Seats Available:";
            // 
            // lblFlightOut2
            // 
            this.lblFlightOut2.AutoSize = true;
            this.lblFlightOut2.Location = new System.Drawing.Point(190, 25);
            this.lblFlightOut2.Name = "lblFlightOut2";
            this.lblFlightOut2.Size = new System.Drawing.Size(148, 13);
            this.lblFlightOut2.TabIndex = 2;
            this.lblFlightOut2.Text = "Should be same as Current ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Flight ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxDestination);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateDeparture);
            this.groupBox2.Controls.Add(this.dateArrival);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 121);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time and Date Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Destination ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Arrival Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Departure Time:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirm new Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSeatsOut
            // 
            this.lblSeatsOut.AutoSize = true;
            this.lblSeatsOut.Location = new System.Drawing.Point(193, 53);
            this.lblSeatsOut.Name = "lblSeatsOut";
            this.lblSeatsOut.Size = new System.Drawing.Size(117, 13);
            this.lblSeatsOut.TabIndex = 7;
            this.lblSeatsOut.Text = "Current Seats Available";
            // 
            // lblBaggageOut
            // 
            this.lblBaggageOut.AutoSize = true;
            this.lblBaggageOut.Location = new System.Drawing.Point(193, 91);
            this.lblBaggageOut.Name = "lblBaggageOut";
            this.lblBaggageOut.Size = new System.Drawing.Size(87, 13);
            this.lblBaggageOut.TabIndex = 8;
            this.lblBaggageOut.Text = "Current Baggage";
            // 
            // lblDepTimeOut
            // 
            this.lblDepTimeOut.AutoSize = true;
            this.lblDepTimeOut.Location = new System.Drawing.Point(184, 26);
            this.lblDepTimeOut.Name = "lblDepTimeOut";
            this.lblDepTimeOut.Size = new System.Drawing.Size(113, 13);
            this.lblDepTimeOut.TabIndex = 8;
            this.lblDepTimeOut.Text = "Current Departure time";
            // 
            // lblArriveOut
            // 
            this.lblArriveOut.AutoSize = true;
            this.lblArriveOut.Location = new System.Drawing.Point(184, 57);
            this.lblArriveOut.Name = "lblArriveOut";
            this.lblArriveOut.Size = new System.Drawing.Size(99, 13);
            this.lblArriveOut.TabIndex = 9;
            this.lblArriveOut.Text = "Current Arrival Time";
            // 
            // lblDestOut
            // 
            this.lblDestOut.AutoSize = true;
            this.lblDestOut.Location = new System.Drawing.Point(184, 90);
            this.lblDestOut.Name = "lblDestOut";
            this.lblDestOut.Size = new System.Drawing.Size(97, 13);
            this.lblDestOut.TabIndex = 10;
            this.lblDestOut.Text = "Current Destination";
            // 
            // Edit_Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Flights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Flights";
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.gbxDestination.ResumeLayout(false);
            this.gbxDestination.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBaggageOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatOut)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label lblBaggage;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblFlightOut;
        private System.Windows.Forms.Label lblFlightID;
        private System.Windows.Forms.GroupBox gbxDestination;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.Label lblDestinationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateArrival;
        private System.Windows.Forms.DateTimePicker dateDeparture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBaggageOut;
        private System.Windows.Forms.NumericUpDown numSeatOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFlightOut2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBaggageOut;
        private System.Windows.Forms.Label lblSeatsOut;
        private System.Windows.Forms.Label lblDestOut;
        private System.Windows.Forms.Label lblArriveOut;
        private System.Windows.Forms.Label lblDepTimeOut;
    }
}