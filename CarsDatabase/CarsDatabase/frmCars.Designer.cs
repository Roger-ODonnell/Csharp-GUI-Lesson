namespace CarsDatabase
{
    partial class Form1
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
            this.Header = new System.Windows.Forms.Label();
            this.frmVehicleRegLabel = new System.Windows.Forms.Label();
            this.frmVehicleMakeLabel = new System.Windows.Forms.Label();
            this.frmVehicleEngineLabel = new System.Windows.Forms.Label();
            this.frmVehicleDateRegLabel = new System.Windows.Forms.Label();
            this.frmVehicleRentLabel = new System.Windows.Forms.Label();
            this.frmVehicleAvailLabel = new System.Windows.Forms.Label();
            this.vehicleRegInput = new System.Windows.Forms.TextBox();
            this.vehicleMakeInput = new System.Windows.Forms.TextBox();
            this.vehicleEngineInput = new System.Windows.Forms.TextBox();
            this.dateRegInput = new System.Windows.Forms.TextBox();
            this.rentPerDayInput = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pageCountDisplay = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.availCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(427, 35);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(253, 37);
            this.Header.TabIndex = 0;
            this.Header.Text = "Bowmans Car Hire";
            // 
            // frmVehicleRegLabel
            // 
            this.frmVehicleRegLabel.AutoSize = true;
            this.frmVehicleRegLabel.BackColor = System.Drawing.SystemColors.Control;
            this.frmVehicleRegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVehicleRegLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.frmVehicleRegLabel.Location = new System.Drawing.Point(12, 129);
            this.frmVehicleRegLabel.Name = "frmVehicleRegLabel";
            this.frmVehicleRegLabel.Size = new System.Drawing.Size(285, 25);
            this.frmVehicleRegLabel.TabIndex = 1;
            this.frmVehicleRegLabel.Text = "Vehicle Registration Number";
            this.frmVehicleRegLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmVehicleMakeLabel
            // 
            this.frmVehicleMakeLabel.AutoSize = true;
            this.frmVehicleMakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVehicleMakeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.frmVehicleMakeLabel.Location = new System.Drawing.Point(15, 171);
            this.frmVehicleMakeLabel.Name = "frmVehicleMakeLabel";
            this.frmVehicleMakeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.frmVehicleMakeLabel.Size = new System.Drawing.Size(65, 25);
            this.frmVehicleMakeLabel.TabIndex = 2;
            this.frmVehicleMakeLabel.Text = "Make";
            this.frmVehicleMakeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmVehicleEngineLabel
            // 
            this.frmVehicleEngineLabel.AutoSize = true;
            this.frmVehicleEngineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVehicleEngineLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.frmVehicleEngineLabel.Location = new System.Drawing.Point(12, 220);
            this.frmVehicleEngineLabel.Name = "frmVehicleEngineLabel";
            this.frmVehicleEngineLabel.Size = new System.Drawing.Size(127, 25);
            this.frmVehicleEngineLabel.TabIndex = 3;
            this.frmVehicleEngineLabel.Text = "Engine Size";
            this.frmVehicleEngineLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmVehicleDateRegLabel
            // 
            this.frmVehicleDateRegLabel.AutoSize = true;
            this.frmVehicleDateRegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVehicleDateRegLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.frmVehicleDateRegLabel.Location = new System.Drawing.Point(12, 271);
            this.frmVehicleDateRegLabel.Name = "frmVehicleDateRegLabel";
            this.frmVehicleDateRegLabel.Size = new System.Drawing.Size(167, 25);
            this.frmVehicleDateRegLabel.TabIndex = 4;
            this.frmVehicleDateRegLabel.Text = "Date Registered";
            // 
            // frmVehicleRentLabel
            // 
            this.frmVehicleRentLabel.AutoSize = true;
            this.frmVehicleRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVehicleRentLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.frmVehicleRentLabel.Location = new System.Drawing.Point(12, 332);
            this.frmVehicleRentLabel.Name = "frmVehicleRentLabel";
            this.frmVehicleRentLabel.Size = new System.Drawing.Size(157, 25);
            this.frmVehicleRentLabel.TabIndex = 5;
            this.frmVehicleRentLabel.Text = "Rental Per Day";
            // 
            // frmVehicleAvailLabel
            // 
            this.frmVehicleAvailLabel.AutoSize = true;
            this.frmVehicleAvailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVehicleAvailLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.frmVehicleAvailLabel.Location = new System.Drawing.Point(10, 386);
            this.frmVehicleAvailLabel.Name = "frmVehicleAvailLabel";
            this.frmVehicleAvailLabel.Size = new System.Drawing.Size(100, 25);
            this.frmVehicleAvailLabel.TabIndex = 6;
            this.frmVehicleAvailLabel.Text = "Available";
            // 
            // vehicleRegInput
            // 
            this.vehicleRegInput.Location = new System.Drawing.Point(364, 134);
            this.vehicleRegInput.Name = "vehicleRegInput";
            this.vehicleRegInput.Size = new System.Drawing.Size(199, 20);
            this.vehicleRegInput.TabIndex = 7;
            // 
            // vehicleMakeInput
            // 
            this.vehicleMakeInput.Location = new System.Drawing.Point(364, 177);
            this.vehicleMakeInput.Name = "vehicleMakeInput";
            this.vehicleMakeInput.Size = new System.Drawing.Size(199, 20);
            this.vehicleMakeInput.TabIndex = 8;
            // 
            // vehicleEngineInput
            // 
            this.vehicleEngineInput.Location = new System.Drawing.Point(364, 225);
            this.vehicleEngineInput.Name = "vehicleEngineInput";
            this.vehicleEngineInput.Size = new System.Drawing.Size(199, 20);
            this.vehicleEngineInput.TabIndex = 9;
            // 
            // dateRegInput
            // 
            this.dateRegInput.Location = new System.Drawing.Point(364, 276);
            this.dateRegInput.Name = "dateRegInput";
            this.dateRegInput.Size = new System.Drawing.Size(199, 20);
            this.dateRegInput.TabIndex = 10;
            // 
            // rentPerDayInput
            // 
            this.rentPerDayInput.Location = new System.Drawing.Point(364, 337);
            this.rentPerDayInput.Name = "rentPerDayInput";
            this.rentPerDayInput.Size = new System.Drawing.Size(199, 20);
            this.rentPerDayInput.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(969, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 50);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(969, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 50);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(969, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 50);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(969, 289);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 50);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(969, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 50);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(969, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 50);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(139, 527);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(165, 50);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(310, 527);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(165, 50);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // pageCountDisplay
            // 
            this.pageCountDisplay.Location = new System.Drawing.Point(481, 543);
            this.pageCountDisplay.Name = "pageCountDisplay";
            this.pageCountDisplay.Size = new System.Drawing.Size(121, 20);
            this.pageCountDisplay.TabIndex = 21;
            this.pageCountDisplay.Text = "1 of 15";
            this.pageCountDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(608, 527);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 50);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(779, 527);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(165, 50);
            this.btnLast.TabIndex = 23;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // availCheck
            // 
            this.availCheck.AutoSize = true;
            this.availCheck.Location = new System.Drawing.Point(364, 397);
            this.availCheck.MinimumSize = new System.Drawing.Size(10, 10);
            this.availCheck.Name = "availCheck";
            this.availCheck.Size = new System.Drawing.Size(15, 14);
            this.availCheck.TabIndex = 24;
            this.availCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1153, 589);
            this.Controls.Add(this.availCheck);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pageCountDisplay);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rentPerDayInput);
            this.Controls.Add(this.dateRegInput);
            this.Controls.Add(this.vehicleEngineInput);
            this.Controls.Add(this.vehicleMakeInput);
            this.Controls.Add(this.vehicleRegInput);
            this.Controls.Add(this.frmVehicleAvailLabel);
            this.Controls.Add(this.frmVehicleRentLabel);
            this.Controls.Add(this.frmVehicleDateRegLabel);
            this.Controls.Add(this.frmVehicleEngineLabel);
            this.Controls.Add(this.frmVehicleMakeLabel);
            this.Controls.Add(this.frmVehicleRegLabel);
            this.Controls.Add(this.Header);
            this.Name = "Form1";
            this.Text = "Task A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label frmVehicleRegLabel;
        private System.Windows.Forms.Label frmVehicleMakeLabel;
        private System.Windows.Forms.Label frmVehicleEngineLabel;
        private System.Windows.Forms.Label frmVehicleDateRegLabel;
        private System.Windows.Forms.Label frmVehicleRentLabel;
        private System.Windows.Forms.Label frmVehicleAvailLabel;
        private System.Windows.Forms.TextBox vehicleRegInput;
        private System.Windows.Forms.TextBox vehicleMakeInput;
        private System.Windows.Forms.TextBox vehicleEngineInput;
        private System.Windows.Forms.TextBox dateRegInput;
        private System.Windows.Forms.TextBox rentPerDayInput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox pageCountDisplay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.CheckBox availCheck;
    }
}

