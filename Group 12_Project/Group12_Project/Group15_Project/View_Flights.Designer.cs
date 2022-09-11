namespace Group15_Project
{
    partial class frmView_Flights
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
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.txtFlightNum = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblFlightNum = new System.Windows.Forms.Label();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrive = new System.Windows.Forms.Label();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.numBaggage = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOpenSeats = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dgwFlights = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBaggage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDestination
            // 
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Location = new System.Drawing.Point(460, 500);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(119, 25);
            this.cbxDestination.TabIndex = 13;
            this.cbxDestination.SelectedIndexChanged += new System.EventHandler(this.cbxDestination_SelectedIndexChanged);
            // 
            // txtFlightNum
            // 
            this.txtFlightNum.Location = new System.Drawing.Point(174, 500);
            this.txtFlightNum.Name = "txtFlightNum";
            this.txtFlightNum.Size = new System.Drawing.Size(119, 25);
            this.txtFlightNum.TabIndex = 11;
            this.txtFlightNum.TextChanged += new System.EventHandler(this.txtFlightNum_TextChanged);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(334, 500);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(114, 17);
            this.lblRating.TabIndex = 10;
            this.lblRating.Text = "Select Destination:";
            // 
            // lblFlightNum
            // 
            this.lblFlightNum.AutoSize = true;
            this.lblFlightNum.Location = new System.Drawing.Point(30, 500);
            this.lblFlightNum.Name = "lblFlightNum";
            this.lblFlightNum.Size = new System.Drawing.Size(138, 17);
            this.lblFlightNum.TabIndex = 8;
            this.lblFlightNum.Text = "Search by Flight Code:";
            // 
            // dtpDepart
            // 
            this.dtpDepart.Checked = false;
            this.dtpDepart.CustomFormat = "";
            this.dtpDepart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepart.Location = new System.Drawing.Point(735, 497);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(200, 25);
            this.dtpDepart.TabIndex = 15;
            this.dtpDepart.ValueChanged += new System.EventHandler(this.dtpDepart_ValueChanged);
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(623, 500);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(102, 17);
            this.lblDepart.TabIndex = 16;
            this.lblDepart.Text = "Departure Time:";
            // 
            // lblArrive
            // 
            this.lblArrive.AutoSize = true;
            this.lblArrive.Location = new System.Drawing.Point(623, 548);
            this.lblArrive.Name = "lblArrive";
            this.lblArrive.Size = new System.Drawing.Size(80, 17);
            this.lblArrive.TabIndex = 18;
            this.lblArrive.Text = "Arrival Time:";
            // 
            // dtpArrival
            // 
            this.dtpArrival.Location = new System.Drawing.Point(735, 545);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(200, 25);
            this.dtpArrival.TabIndex = 17;
            this.dtpArrival.ValueChanged += new System.EventHandler(this.dtpArrival_ValueChanged);
            // 
            // numBaggage
            // 
            this.numBaggage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBaggage.Location = new System.Drawing.Point(174, 549);
            this.numBaggage.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numBaggage.Name = "numBaggage";
            this.numBaggage.Size = new System.Drawing.Size(119, 25);
            this.numBaggage.TabIndex = 19;
            this.numBaggage.ValueChanged += new System.EventHandler(this.numBaggage_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(30, 553);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 17);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total Baggage:";
            // 
            // lblOpenSeats
            // 
            this.lblOpenSeats.AutoSize = true;
            this.lblOpenSeats.Location = new System.Drawing.Point(334, 553);
            this.lblOpenSeats.Name = "lblOpenSeats";
            this.lblOpenSeats.Size = new System.Drawing.Size(78, 17);
            this.lblOpenSeats.TabIndex = 22;
            this.lblOpenSeats.Text = "Open Seats:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(460, 549);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(119, 25);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dgwFlights
            // 
            this.dgwFlights.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgwFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFlights.Location = new System.Drawing.Point(13, 13);
            this.dgwFlights.Name = "dgwFlights";
            this.dgwFlights.RowHeadersWidth = 51;
            this.dgwFlights.Size = new System.Drawing.Size(976, 461);
            this.dgwFlights.TabIndex = 23;
            this.dgwFlights.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwFlights_CellFormatting);
            // 
            // btnGenerate
            // 
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(174, 596);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 35);
            this.btnGenerate.TabIndex = 24;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(460, 596);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 35);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit Selected ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(735, 596);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 35);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete Selected ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmView_Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1004, 643);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgwFlights);
            this.Controls.Add(this.lblOpenSeats);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.numBaggage);
            this.Controls.Add(this.lblArrive);
            this.Controls.Add(this.dtpArrival);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.dtpDepart);
            this.Controls.Add(this.cbxDestination);
            this.Controls.Add(this.txtFlightNum);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblFlightNum);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmView_Flights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Flights";
            this.Load += new System.EventHandler(this.frmView_Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBaggage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.TextBox txtFlightNum;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblFlightNum;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrive;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.NumericUpDown numBaggage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOpenSeats;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dgwFlights;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}