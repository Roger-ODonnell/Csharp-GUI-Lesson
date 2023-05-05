namespace Form_app_in_c_
{
    partial class Form
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
            this.regInput = new System.Windows.Forms.TextBox();
            this.VehicleReg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.makeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EngineSizeInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateRegisteredInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rentPerDayInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regInput
            // 
            this.regInput.Location = new System.Drawing.Point(182, 94);
            this.regInput.Name = "regInput";
            this.regInput.Size = new System.Drawing.Size(206, 20);
            this.regInput.TabIndex = 0;
            this.regInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VehicleReg
            // 
            this.VehicleReg.AutoSize = true;
            this.VehicleReg.Location = new System.Drawing.Point(28, 101);
            this.VehicleReg.Name = "VehicleReg";
            this.VehicleReg.Size = new System.Drawing.Size(139, 13);
            this.VehicleReg.TabIndex = 1;
            this.VehicleReg.Text = "Vehicle Registration number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // makeInput
            // 
            this.makeInput.Location = new System.Drawing.Point(182, 148);
            this.makeInput.Name = "makeInput";
            this.makeInput.Size = new System.Drawing.Size(206, 20);
            this.makeInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Engine Size";
            // 
            // EngineSizeInput
            // 
            this.EngineSizeInput.Location = new System.Drawing.Point(182, 202);
            this.EngineSizeInput.Name = "EngineSizeInput";
            this.EngineSizeInput.Size = new System.Drawing.Size(206, 20);
            this.EngineSizeInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date registered";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateRegisteredInput
            // 
            this.dateRegisteredInput.Location = new System.Drawing.Point(182, 250);
            this.dateRegisteredInput.Name = "dateRegisteredInput";
            this.dateRegisteredInput.Size = new System.Drawing.Size(206, 20);
            this.dateRegisteredInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rental Per Day";
            // 
            // rentPerDayInput
            // 
            this.rentPerDayInput.Location = new System.Drawing.Point(182, 301);
            this.rentPerDayInput.Name = "rentPerDayInput";
            this.rentPerDayInput.Size = new System.Drawing.Size(206, 20);
            this.rentPerDayInput.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Available";
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.AutoSize = true;
            this.availableCheckBox.Location = new System.Drawing.Point(194, 357);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(15, 14);
            this.availableCheckBox.TabIndex = 11;
            this.availableCheckBox.UseVisualStyleBackColor = true;
            this.availableCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(927, 13);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(188, 62);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(927, 101);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(188, 62);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(927, 185);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(188, 62);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(927, 272);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(188, 62);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(927, 357);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(188, 62);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(927, 443);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(188, 62);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(36, 501);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 51);
            this.button7.TabIndex = 18;
            this.button7.Text = "First";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(230, 501);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(171, 51);
            this.button8.TabIndex = 19;
            this.button8.Text = "Previous";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(532, 501);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(173, 51);
            this.nextButton.TabIndex = 20;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(711, 501);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(168, 51);
            this.lastButton.TabIndex = 21;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(417, 517);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 22;
            this.textBox6.Text = "1 of 15";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Sans Serif Collection", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(350, 13);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(420, 67);
            this.Header.TabIndex = 23;
            this.Header.Text = "Bowmans Car Hire";
            // 
            // Form
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1136, 587);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rentPerDayInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateRegisteredInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EngineSizeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makeInput);
            this.Controls.Add(this.VehicleReg);
            this.Controls.Add(this.regInput);
            this.Name = "Form";
            this.Text = "Task A";
            this.Load += new System.EventHandler(this.Bowmans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regInput;
        private System.Windows.Forms.Label VehicleReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox makeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EngineSizeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateRegisteredInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rentPerDayInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Header;
    }
}

