namespace Group15_Project
{
    partial class Add_flight
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxConfirm = new System.Windows.Forms.GroupBox();
            this.lbxConfirm = new System.Windows.Forms.ListBox();
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
            this.txtSeatsAvail = new System.Windows.Forms.TextBox();
            this.txtTotalBaggage = new System.Windows.Forms.TextBox();
            this.gbxConfirm.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            this.gbxDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(536, 299);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 39);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm Flight Info";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(252, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(29, 299);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 39);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit Info";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbxConfirm
            // 
            this.gbxConfirm.Controls.Add(this.lbxConfirm);
            this.gbxConfirm.ForeColor = System.Drawing.Color.White;
            this.gbxConfirm.Location = new System.Drawing.Point(445, 42);
            this.gbxConfirm.Name = "gbxConfirm";
            this.gbxConfirm.Size = new System.Drawing.Size(326, 251);
            this.gbxConfirm.TabIndex = 6;
            this.gbxConfirm.TabStop = false;
            this.gbxConfirm.Text = "Confirm Information";
            this.gbxConfirm.Enter += new System.EventHandler(this.gbxConfirm_Enter);
            // 
            // lbxConfirm
            // 
            this.lbxConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbxConfirm.ForeColor = System.Drawing.Color.White;
            this.lbxConfirm.FormattingEnabled = true;
            this.lbxConfirm.Location = new System.Drawing.Point(7, 25);
            this.lbxConfirm.Name = "lbxConfirm";
            this.lbxConfirm.Size = new System.Drawing.Size(313, 212);
            this.lbxConfirm.TabIndex = 0;
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.txtTotalBaggage);
            this.gbxInfo.Controls.Add(this.txtSeatsAvail);
            this.gbxInfo.Controls.Add(this.lblBaggage);
            this.gbxInfo.Controls.Add(this.lblSeats);
            this.gbxInfo.Controls.Add(this.lblFlightOut);
            this.gbxInfo.Controls.Add(this.lblFlightID);
            this.gbxInfo.Controls.Add(this.gbxDestination);
            this.gbxInfo.ForeColor = System.Drawing.Color.White;
            this.gbxInfo.Location = new System.Drawing.Point(29, 42);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(367, 251);
            this.gbxInfo.TabIndex = 5;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Flight Info";
            this.gbxInfo.Enter += new System.EventHandler(this.gbxInfo_Enter);
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
            this.gbxDestination.Controls.Add(this.cbxDestination);
            this.gbxDestination.Controls.Add(this.lblDestinationID);
            this.gbxDestination.Controls.Add(this.label2);
            this.gbxDestination.Controls.Add(this.label1);
            this.gbxDestination.Controls.Add(this.dateArrival);
            this.gbxDestination.Controls.Add(this.dateDeparture);
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
            // txtSeatsAvail
            // 
            this.txtSeatsAvail.Location = new System.Drawing.Point(193, 50);
            this.txtSeatsAvail.Name = "txtSeatsAvail";
            this.txtSeatsAvail.Size = new System.Drawing.Size(146, 20);
            this.txtSeatsAvail.TabIndex = 7;
            // 
            // txtTotalBaggage
            // 
            this.txtTotalBaggage.Location = new System.Drawing.Point(193, 88);
            this.txtTotalBaggage.Name = "txtTotalBaggage";
            this.txtTotalBaggage.Size = new System.Drawing.Size(146, 20);
            this.txtTotalBaggage.TabIndex = 8;
            // 
            // Add_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxConfirm);
            this.Controls.Add(this.gbxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_flight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_flight";
            this.Load += new System.EventHandler(this.Add_flight_Load);
            this.gbxConfirm.ResumeLayout(false);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.gbxDestination.ResumeLayout(false);
            this.gbxDestination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbxConfirm;
        private System.Windows.Forms.ListBox lbxConfirm;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.GroupBox gbxDestination;
        private System.Windows.Forms.Label lblFlightOut;
        private System.Windows.Forms.Label lblFlightID;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblBaggage;
        private System.Windows.Forms.DateTimePicker dateArrival;
        private System.Windows.Forms.DateTimePicker dateDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.Label lblDestinationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalBaggage;
        private System.Windows.Forms.TextBox txtSeatsAvail;
    }
}