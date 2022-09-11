namespace Group15_Project
{
    partial class frmView_Passengers
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
            this.dgwFlights = new System.Windows.Forms.DataGridView();
            this.lblOpenSeats = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblPassNum = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchSurname = new System.Windows.Forms.TextBox();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.txtSearchBaggage = new System.Windows.Forms.TextBox();
            this.lblBaggage = new System.Windows.Forms.Label();
            this.txtSearchSeatcode = new System.Windows.Forms.TextBox();
            this.lblSeat = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFlights
            // 
            this.dgwFlights.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgwFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFlights.Location = new System.Drawing.Point(29, 30);
            this.dgwFlights.Name = "dgwFlights";
            this.dgwFlights.RowHeadersWidth = 51;
            this.dgwFlights.Size = new System.Drawing.Size(976, 461);
            this.dgwFlights.TabIndex = 36;
            this.dgwFlights.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwFlights_CellFormatting);
            this.dgwFlights.CellStyleChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFlights_CellStyleChanged);
            // 
            // lblOpenSeats
            // 
            this.lblOpenSeats.AutoSize = true;
            this.lblOpenSeats.Location = new System.Drawing.Point(377, 570);
            this.lblOpenSeats.Name = "lblOpenSeats";
            this.lblOpenSeats.Size = new System.Drawing.Size(123, 17);
            this.lblOpenSeats.TabIndex = 35;
            this.lblOpenSeats.Text = "Search by Surname:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(59, 570);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 17);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "Search by Name:";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(232, 514);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(119, 25);
            this.txtSearchCode.TabIndex = 26;
            this.txtSearchCode.TextChanged += new System.EventHandler(this.txtSearchCode_TextChanged);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(377, 517);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(103, 17);
            this.lblRating.TabIndex = 25;
            this.lblRating.Text = "Search by Email:";
            // 
            // lblPassNum
            // 
            this.lblPassNum.AutoSize = true;
            this.lblPassNum.Location = new System.Drawing.Point(59, 517);
            this.lblPassNum.Name = "lblPassNum";
            this.lblPassNum.Size = new System.Drawing.Size(167, 17);
            this.lblPassNum.TabIndex = 24;
            this.lblPassNum.Text = "Search by Passenger Code:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(232, 567);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(119, 25);
            this.txtSearchName.TabIndex = 37;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // txtSearchSurname
            // 
            this.txtSearchSurname.Location = new System.Drawing.Point(506, 567);
            this.txtSearchSurname.Name = "txtSearchSurname";
            this.txtSearchSurname.Size = new System.Drawing.Size(119, 25);
            this.txtSearchSurname.TabIndex = 38;
            this.txtSearchSurname.TextChanged += new System.EventHandler(this.txtSearchSurname_TextChanged);
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(506, 514);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(119, 25);
            this.txtSearchEmail.TabIndex = 39;
            this.txtSearchEmail.TextChanged += new System.EventHandler(this.txtSearchEmail_TextChanged);
            // 
            // txtSearchBaggage
            // 
            this.txtSearchBaggage.Location = new System.Drawing.Point(852, 514);
            this.txtSearchBaggage.Name = "txtSearchBaggage";
            this.txtSearchBaggage.Size = new System.Drawing.Size(119, 25);
            this.txtSearchBaggage.TabIndex = 41;
            this.txtSearchBaggage.TextChanged += new System.EventHandler(this.txtSearchBaggage_TextChanged);
            // 
            // lblBaggage
            // 
            this.lblBaggage.AutoSize = true;
            this.lblBaggage.Location = new System.Drawing.Point(661, 517);
            this.lblBaggage.Name = "lblBaggage";
            this.lblBaggage.Size = new System.Drawing.Size(159, 17);
            this.lblBaggage.TabIndex = 40;
            this.lblBaggage.Text = "Search by Baggage Code:";
            // 
            // txtSearchSeatcode
            // 
            this.txtSearchSeatcode.Location = new System.Drawing.Point(852, 567);
            this.txtSearchSeatcode.Name = "txtSearchSeatcode";
            this.txtSearchSeatcode.Size = new System.Drawing.Size(119, 25);
            this.txtSearchSeatcode.TabIndex = 43;
            this.txtSearchSeatcode.TextChanged += new System.EventHandler(this.txtSearchSeatcode_TextChanged);
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(661, 570);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(132, 17);
            this.lblSeat.TabIndex = 42;
            this.lblSeat.Text = "Search by Seat Code:";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(852, 613);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 35);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete Selected ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(506, 613);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 35);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Text = "Edit Selected ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(232, 613);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 35);
            this.btnGenerate.TabIndex = 44;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmView_Passengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1038, 660);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtSearchSeatcode);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.txtSearchBaggage);
            this.Controls.Add(this.lblBaggage);
            this.Controls.Add(this.txtSearchEmail);
            this.Controls.Add(this.txtSearchSurname);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.dgwFlights);
            this.Controls.Add(this.lblOpenSeats);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtSearchCode);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblPassNum);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmView_Passengers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Passengers";
            this.Load += new System.EventHandler(this.frmView_Passengers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFlights;
        private System.Windows.Forms.Label lblOpenSeats;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblPassNum;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchSurname;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.TextBox txtSearchBaggage;
        private System.Windows.Forms.Label lblBaggage;
        private System.Windows.Forms.TextBox txtSearchSeatcode;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGenerate;
    }
}