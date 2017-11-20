namespace Program2
{
    partial class program2Form
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
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.classGroupBox = new System.Windows.Forms.GroupBox();
            this.freshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.sophomoreRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.registrationTimeButton = new System.Windows.Forms.Button();
            this.registrationTimeLabel = new System.Windows.Forms.Label();
            this.registrationOutputLabel = new System.Windows.Forms.Label();
            this.classGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(92, 50);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(94, 32);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(96, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Enter Last Name:";
            // 
            // classGroupBox
            // 
            this.classGroupBox.Controls.Add(this.seniorRadioButton);
            this.classGroupBox.Controls.Add(this.juniorRadioButton);
            this.classGroupBox.Controls.Add(this.sophomoreRadioButton);
            this.classGroupBox.Controls.Add(this.freshmanRadioButton);
            this.classGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classGroupBox.Location = new System.Drawing.Point(69, 76);
            this.classGroupBox.Name = "classGroupBox";
            this.classGroupBox.Size = new System.Drawing.Size(147, 113);
            this.classGroupBox.TabIndex = 2;
            this.classGroupBox.TabStop = false;
            this.classGroupBox.Text = "Class Standing";
            // 
            // freshmanRadioButton
            // 
            this.freshmanRadioButton.AutoSize = true;
            this.freshmanRadioButton.Location = new System.Drawing.Point(6, 19);
            this.freshmanRadioButton.Name = "freshmanRadioButton";
            this.freshmanRadioButton.Size = new System.Drawing.Size(77, 19);
            this.freshmanRadioButton.TabIndex = 0;
            this.freshmanRadioButton.TabStop = true;
            this.freshmanRadioButton.Text = "Freshman";
            this.freshmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadioButton
            // 
            this.sophomoreRadioButton.AutoSize = true;
            this.sophomoreRadioButton.Location = new System.Drawing.Point(6, 42);
            this.sophomoreRadioButton.Name = "sophomoreRadioButton";
            this.sophomoreRadioButton.Size = new System.Drawing.Size(87, 19);
            this.sophomoreRadioButton.TabIndex = 1;
            this.sophomoreRadioButton.TabStop = true;
            this.sophomoreRadioButton.Text = "Sophomore";
            this.sophomoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(6, 65);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(57, 19);
            this.juniorRadioButton.TabIndex = 2;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(6, 88);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(58, 19);
            this.seniorRadioButton.TabIndex = 3;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // registrationTimeButton
            // 
            this.registrationTimeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationTimeButton.Location = new System.Drawing.Point(74, 195);
            this.registrationTimeButton.Name = "registrationTimeButton";
            this.registrationTimeButton.Size = new System.Drawing.Size(137, 23);
            this.registrationTimeButton.TabIndex = 3;
            this.registrationTimeButton.Text = "Find Registration Time";
            this.registrationTimeButton.UseVisualStyleBackColor = true;
            this.registrationTimeButton.Click += new System.EventHandler(this.registrationTimeButton_Click);
            // 
            // registrationTimeLabel
            // 
            this.registrationTimeLabel.AutoSize = true;
            this.registrationTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationTimeLabel.Location = new System.Drawing.Point(87, 230);
            this.registrationTimeLabel.Name = "registrationTimeLabel";
            this.registrationTimeLabel.Size = new System.Drawing.Size(111, 15);
            this.registrationTimeLabel.TabIndex = 4;
            this.registrationTimeLabel.Text = "Your Registration is:";
            // 
            // registrationOutputLabel
            // 
            this.registrationOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationOutputLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationOutputLabel.Location = new System.Drawing.Point(40, 258);
            this.registrationOutputLabel.Name = "registrationOutputLabel";
            this.registrationOutputLabel.Size = new System.Drawing.Size(204, 29);
            this.registrationOutputLabel.TabIndex = 5;
            this.registrationOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // program2Form
            // 
            this.AcceptButton = this.registrationTimeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.registrationOutputLabel);
            this.Controls.Add(this.registrationTimeLabel);
            this.Controls.Add(this.registrationTimeButton);
            this.Controls.Add(this.classGroupBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Name = "program2Form";
            this.Text = "Program 2";
            this.classGroupBox.ResumeLayout(false);
            this.classGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.GroupBox classGroupBox;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton sophomoreRadioButton;
        private System.Windows.Forms.RadioButton freshmanRadioButton;
        private System.Windows.Forms.Button registrationTimeButton;
        private System.Windows.Forms.Label registrationTimeLabel;
        private System.Windows.Forms.Label registrationOutputLabel;
    }
}

