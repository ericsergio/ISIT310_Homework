namespace BirdsForm
{
    partial class FormNewBird
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
            this.textBoxBirdName = new System.Windows.Forms.TextBox();
            this.buttonNewBird = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new type of Bird";
            // 
            // textBoxBirdName
            // 
            this.textBoxBirdName.Location = new System.Drawing.Point(460, 235);
            this.textBoxBirdName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxBirdName.Name = "textBoxBirdName";
            this.textBoxBirdName.Size = new System.Drawing.Size(448, 31);
            this.textBoxBirdName.TabIndex = 1;
            // 
            // buttonNewBird
            // 
            this.buttonNewBird.Location = new System.Drawing.Point(460, 501);
            this.buttonNewBird.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonNewBird.Name = "buttonNewBird";
            this.buttonNewBird.Size = new System.Drawing.Size(376, 43);
            this.buttonNewBird.TabIndex = 2;
            this.buttonNewBird.Text = "Click to Enter New Bird Type";
            this.buttonNewBird.UseVisualStyleBackColor = true;
            this.buttonNewBird.Click += new System.EventHandler(this.buttonNewBird_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(242, 508);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(103, 37);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "status";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(460, 309);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(448, 31);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(460, 384);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(448, 31);
            this.textBoxDesc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "DESCRIPTION";
            // 
            // FormNewBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 927);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonNewBird);
            this.Controls.Add(this.textBoxBirdName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormNewBird";
            this.Text = "FormNewBird";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBirdName;
        private System.Windows.Forms.Button buttonNewBird;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}