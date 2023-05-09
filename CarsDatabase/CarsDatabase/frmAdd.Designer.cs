namespace CarsDatabase
{
    partial class frmAdd
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
            this.vehicleRegLabel = new System.Windows.Forms.Label();
            this.vehicleMakeLabel = new System.Windows.Forms.Label();
            this.vehicleEngineLabel = new System.Windows.Forms.Label();
            this.vehicleDateRegLabel = new System.Windows.Forms.Label();
            this.vehicleRentLabel = new System.Windows.Forms.Label();
            this.vehicleAvailLabel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.vehicleRegInput = new System.Windows.Forms.TextBox();
            this.vehicleMakeInput = new System.Windows.Forms.TextBox();
            this.vehicleEngineInput = new System.Windows.Forms.TextBox();
            this.vehicleDateRegInput = new System.Windows.Forms.TextBox();
            this.vehicleRentPerDayInput = new System.Windows.Forms.NumericUpDown();
            this.vehicleAvailCheck = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRentPerDayInput)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleRegLabel
            // 
            this.vehicleRegLabel.AutoSize = true;
            this.vehicleRegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleRegLabel.Location = new System.Drawing.Point(26, 44);
            this.vehicleRegLabel.Name = "vehicleRegLabel";
            this.vehicleRegLabel.Size = new System.Drawing.Size(188, 24);
            this.vehicleRegLabel.TabIndex = 0;
            this.vehicleRegLabel.Text = "Vehicle Reg Number";
            // 
            // vehicleMakeLabel
            // 
            this.vehicleMakeLabel.AutoSize = true;
            this.vehicleMakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleMakeLabel.Location = new System.Drawing.Point(26, 93);
            this.vehicleMakeLabel.Name = "vehicleMakeLabel";
            this.vehicleMakeLabel.Size = new System.Drawing.Size(56, 24);
            this.vehicleMakeLabel.TabIndex = 1;
            this.vehicleMakeLabel.Text = "Make";
            // 
            // vehicleEngineLabel
            // 
            this.vehicleEngineLabel.AutoSize = true;
            this.vehicleEngineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleEngineLabel.Location = new System.Drawing.Point(26, 133);
            this.vehicleEngineLabel.Name = "vehicleEngineLabel";
            this.vehicleEngineLabel.Size = new System.Drawing.Size(112, 24);
            this.vehicleEngineLabel.TabIndex = 2;
            this.vehicleEngineLabel.Text = "Engine Size";
            // 
            // vehicleDateRegLabel
            // 
            this.vehicleDateRegLabel.AutoSize = true;
            this.vehicleDateRegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleDateRegLabel.Location = new System.Drawing.Point(26, 183);
            this.vehicleDateRegLabel.Name = "vehicleDateRegLabel";
            this.vehicleDateRegLabel.Size = new System.Drawing.Size(144, 24);
            this.vehicleDateRegLabel.TabIndex = 3;
            this.vehicleDateRegLabel.Text = "Date Registered";
            // 
            // vehicleRentLabel
            // 
            this.vehicleRentLabel.AutoSize = true;
            this.vehicleRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleRentLabel.Location = new System.Drawing.Point(26, 230);
            this.vehicleRentLabel.Name = "vehicleRentLabel";
            this.vehicleRentLabel.Size = new System.Drawing.Size(132, 24);
            this.vehicleRentLabel.TabIndex = 4;
            this.vehicleRentLabel.Text = "Rental Per day";
            // 
            // vehicleAvailLabel
            // 
            this.vehicleAvailLabel.AutoSize = true;
            this.vehicleAvailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleAvailLabel.Location = new System.Drawing.Point(26, 276);
            this.vehicleAvailLabel.Name = "vehicleAvailLabel";
            this.vehicleAvailLabel.Size = new System.Drawing.Size(86, 24);
            this.vehicleAvailLabel.TabIndex = 5;
            this.vehicleAvailLabel.Text = "Available";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(108, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 75);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // vehicleRegInput
            // 
            this.vehicleRegInput.Location = new System.Drawing.Point(276, 48);
            this.vehicleRegInput.Name = "vehicleRegInput";
            this.vehicleRegInput.Size = new System.Drawing.Size(255, 20);
            this.vehicleRegInput.TabIndex = 9;
            // 
            // vehicleMakeInput
            // 
            this.vehicleMakeInput.Location = new System.Drawing.Point(276, 93);
            this.vehicleMakeInput.Name = "vehicleMakeInput";
            this.vehicleMakeInput.Size = new System.Drawing.Size(255, 20);
            this.vehicleMakeInput.TabIndex = 10;
            // 
            // vehicleEngineInput
            // 
            this.vehicleEngineInput.Location = new System.Drawing.Point(276, 133);
            this.vehicleEngineInput.Name = "vehicleEngineInput";
            this.vehicleEngineInput.Size = new System.Drawing.Size(255, 20);
            this.vehicleEngineInput.TabIndex = 11;
            // 
            // vehicleDateRegInput
            // 
            this.vehicleDateRegInput.Location = new System.Drawing.Point(276, 183);
            this.vehicleDateRegInput.Name = "vehicleDateRegInput";
            this.vehicleDateRegInput.Size = new System.Drawing.Size(255, 20);
            this.vehicleDateRegInput.TabIndex = 12;
            // 
            // vehicleRentPerDayInput
            // 
            this.vehicleRentPerDayInput.Location = new System.Drawing.Point(276, 230);
            this.vehicleRentPerDayInput.Name = "vehicleRentPerDayInput";
            this.vehicleRentPerDayInput.Size = new System.Drawing.Size(117, 20);
            this.vehicleRentPerDayInput.TabIndex = 13;
            // 
            // vehicleAvailCheck
            // 
            this.vehicleAvailCheck.AutoSize = true;
            this.vehicleAvailCheck.Location = new System.Drawing.Point(276, 276);
            this.vehicleAvailCheck.Name = "vehicleAvailCheck";
            this.vehicleAvailCheck.Size = new System.Drawing.Size(15, 14);
            this.vehicleAvailCheck.TabIndex = 14;
            this.vehicleAvailCheck.UseVisualStyleBackColor = true;
            this.vehicleAvailCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(300, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 75);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(489, 363);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 75);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.vehicleAvailCheck);
            this.Controls.Add(this.vehicleRentPerDayInput);
            this.Controls.Add(this.vehicleDateRegInput);
            this.Controls.Add(this.vehicleEngineInput);
            this.Controls.Add(this.vehicleMakeInput);
            this.Controls.Add(this.vehicleRegInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.vehicleAvailLabel);
            this.Controls.Add(this.vehicleRentLabel);
            this.Controls.Add(this.vehicleDateRegLabel);
            this.Controls.Add(this.vehicleEngineLabel);
            this.Controls.Add(this.vehicleMakeLabel);
            this.Controls.Add(this.vehicleRegLabel);
            this.Name = "frmAdd";
            this.Text = "Task A Roger O\'Donnell";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRentPerDayInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vehicleRegLabel;
        private System.Windows.Forms.Label vehicleMakeLabel;
        private System.Windows.Forms.Label vehicleEngineLabel;
        private System.Windows.Forms.Label vehicleDateRegLabel;
        private System.Windows.Forms.Label vehicleRentLabel;
        private System.Windows.Forms.Label vehicleAvailLabel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox vehicleRegInput;
        private System.Windows.Forms.TextBox vehicleMakeInput;
        private System.Windows.Forms.TextBox vehicleEngineInput;
        private System.Windows.Forms.TextBox vehicleDateRegInput;
        private System.Windows.Forms.NumericUpDown vehicleRentPerDayInput;
        private System.Windows.Forms.CheckBox vehicleAvailCheck;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}