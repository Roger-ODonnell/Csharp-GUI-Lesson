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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VehicleRegInput = new System.Windows.Forms.TextBox();
            this.makeInput = new System.Windows.Forms.TextBox();
            this.engineInput = new System.Windows.Forms.TextBox();
            this.dateRegInput = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Registration Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(15, 171);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Make";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Engine Size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Registered";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rental Per Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(10, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Available";
            // 
            // VehicleRegInput
            // 
            this.VehicleRegInput.Location = new System.Drawing.Point(364, 129);
            this.VehicleRegInput.Name = "VehicleRegInput";
            this.VehicleRegInput.Size = new System.Drawing.Size(199, 20);
            this.VehicleRegInput.TabIndex = 7;
            // 
            // makeInput
            // 
            this.makeInput.Location = new System.Drawing.Point(364, 176);
            this.makeInput.Name = "makeInput";
            this.makeInput.Size = new System.Drawing.Size(199, 20);
            this.makeInput.TabIndex = 8;
            // 
            // engineInput
            // 
            this.engineInput.Location = new System.Drawing.Point(364, 220);
            this.engineInput.Name = "engineInput";
            this.engineInput.Size = new System.Drawing.Size(199, 20);
            this.engineInput.TabIndex = 9;
            // 
            // dateRegInput
            // 
            this.dateRegInput.Location = new System.Drawing.Point(364, 271);
            this.dateRegInput.Name = "dateRegInput";
            this.dateRegInput.Size = new System.Drawing.Size(199, 20);
            this.dateRegInput.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(364, 332);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(199, 20);
            this.textBox5.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(969, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(969, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(969, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 50);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(969, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 50);
            this.button4.TabIndex = 16;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(969, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 50);
            this.button5.TabIndex = 17;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(969, 434);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 50);
            this.button6.TabIndex = 18;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(139, 527);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 50);
            this.button7.TabIndex = 19;
            this.button7.Text = "First";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(310, 527);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 50);
            this.button8.TabIndex = 20;
            this.button8.Text = "Previous";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(481, 543);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 21;
            this.textBox7.Text = "1 of 15";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(608, 527);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(165, 50);
            this.button9.TabIndex = 22;
            this.button9.Text = "Next";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(779, 527);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(165, 50);
            this.button10.TabIndex = 23;
            this.button10.Text = "Last";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(364, 395);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1153, 589);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dateRegInput);
            this.Controls.Add(this.engineInput);
            this.Controls.Add(this.makeInput);
            this.Controls.Add(this.VehicleRegInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Header);
            this.Name = "Form1";
            this.Text = "Task A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VehicleRegInput;
        private System.Windows.Forms.TextBox makeInput;
        private System.Windows.Forms.TextBox engineInput;
        private System.Windows.Forms.TextBox dateRegInput;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

