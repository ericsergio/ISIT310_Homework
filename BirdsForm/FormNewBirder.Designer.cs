namespace BirdsForm
{
    partial class FormNewBirder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBirderFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNewBirder = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxBirderPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxBirderLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a new Birder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // textBoxBirderFirstName
            // 
            this.textBoxBirderFirstName.Location = new System.Drawing.Point(523, 300);
            this.textBoxBirderFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxBirderFirstName.Name = "textBoxBirderFirstName";
            this.textBoxBirderFirstName.Size = new System.Drawing.Size(448, 31);
            this.textBoxBirderFirstName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 485);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 50);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone Number";
            // 
            // buttonNewBirder
            // 
            this.buttonNewBirder.Location = new System.Drawing.Point(523, 585);
            this.buttonNewBirder.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNewBirder.Name = "buttonNewBirder";
            this.buttonNewBirder.Size = new System.Drawing.Size(448, 44);
            this.buttonNewBirder.TabIndex = 11;
            this.buttonNewBirder.Text = "Click to Enter New Birder";
            this.buttonNewBirder.UseVisualStyleBackColor = true;
            this.buttonNewBirder.Click += new System.EventHandler(this.buttonNewBirder_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(356, 592);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(103, 37);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "status";
            // 
            // textBoxBirderPhoneNumber
            // 
            this.textBoxBirderPhoneNumber.Location = new System.Drawing.Point(523, 420);
            this.textBoxBirderPhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxBirderPhoneNumber.Name = "textBoxBirderPhoneNumber";
            this.textBoxBirderPhoneNumber.Size = new System.Drawing.Size(448, 31);
            this.textBoxBirderPhoneNumber.TabIndex = 14;
            // 
            // textBoxBirderLastName
            // 
            this.textBoxBirderLastName.Location = new System.Drawing.Point(523, 359);
            this.textBoxBirderLastName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxBirderLastName.Name = "textBoxBirderLastName";
            this.textBoxBirderLastName.Size = new System.Drawing.Size(448, 31);
            this.textBoxBirderLastName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Last Name";
            // 
            // FormNewBirder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 969);
            this.Controls.Add(this.textBoxBirderLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBirderPhoneNumber);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonNewBirder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBirderFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormNewBirder";
            this.Text = "FormNewBirder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBirderFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNewBirder;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxBirderPhoneNumber;
        private System.Windows.Forms.TextBox textBoxBirderLastName;
        private System.Windows.Forms.Label label5;
    }
}