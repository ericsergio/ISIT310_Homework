namespace BirdsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRegions = new System.Windows.Forms.ListBox();
            this.buttonAddRegion = new System.Windows.Forms.Button();
            this.buttonAddBirdType = new System.Windows.Forms.Button();
            this.buttonAddBirder = new System.Windows.Forms.Button();
            this.listBoxBird = new System.Windows.Forms.ListBox();
            this.listBoxBirder = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.homeForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(767, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(630, 60);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 2;
            this.textBoxCount.Text = "14";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(630, 23);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 3;
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAddEvent.Location = new System.Drawing.Point(604, 92);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(142, 23);
            this.buttonAddEvent.TabIndex = 4;
            this.buttonAddEvent.Text = "Add Event";
            this.buttonAddEvent.UseVisualStyleBackColor = false;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // listBoxRegions
            // 
            this.listBoxRegions.FormattingEnabled = true;
            this.listBoxRegions.Location = new System.Drawing.Point(117, 31);
            this.listBoxRegions.Name = "listBoxRegions";
            this.listBoxRegions.Size = new System.Drawing.Size(120, 95);
            this.listBoxRegions.TabIndex = 7;
            // 
            // buttonAddRegion
            // 
            this.buttonAddRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAddRegion.Location = new System.Drawing.Point(226, 390);
            this.buttonAddRegion.Name = "buttonAddRegion";
            this.buttonAddRegion.Size = new System.Drawing.Size(159, 23);
            this.buttonAddRegion.TabIndex = 8;
            this.buttonAddRegion.Text = "Add New Region";
            this.buttonAddRegion.UseVisualStyleBackColor = false;
            this.buttonAddRegion.Click += new System.EventHandler(this.buttonAddRegion_Click);
            // 
            // buttonAddBirdType
            // 
            this.buttonAddBirdType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddBirdType.Location = new System.Drawing.Point(39, 390);
            this.buttonAddBirdType.Name = "buttonAddBirdType";
            this.buttonAddBirdType.Size = new System.Drawing.Size(146, 23);
            this.buttonAddBirdType.TabIndex = 9;
            this.buttonAddBirdType.Text = "Add New Type of Bird";
            this.buttonAddBirdType.UseVisualStyleBackColor = false;
            this.buttonAddBirdType.Click += new System.EventHandler(this.buttonAddBirdType_Click);
            // 
            // buttonAddBirder
            // 
            this.buttonAddBirder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddBirder.Location = new System.Drawing.Point(419, 390);
            this.buttonAddBirder.Name = "buttonAddBirder";
            this.buttonAddBirder.Size = new System.Drawing.Size(149, 23);
            this.buttonAddBirder.TabIndex = 10;
            this.buttonAddBirder.Text = "Add New Birder";
            this.buttonAddBirder.UseVisualStyleBackColor = false;
            this.buttonAddBirder.Click += new System.EventHandler(this.buttonAddBirder_Click);
            // 
            // listBoxBird
            // 
            this.listBoxBird.FormattingEnabled = true;
            this.listBoxBird.Location = new System.Drawing.Point(261, 31);
            this.listBoxBird.Name = "listBoxBird";
            this.listBoxBird.Size = new System.Drawing.Size(120, 95);
            this.listBoxBird.TabIndex = 11;
            // 
            // listBoxBirder
            // 
            this.listBoxBirder.FormattingEnabled = true;
            this.listBoxBirder.Location = new System.Drawing.Point(409, 31);
            this.listBoxBirder.Name = "listBoxBirder";
            this.listBoxBirder.Size = new System.Drawing.Size(120, 95);
            this.listBoxBirder.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "RelatedData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeForm
            // 
            this.homeForm.BackColor = System.Drawing.Color.SteelBlue;
            this.homeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeForm.ForeColor = System.Drawing.Color.White;
            this.homeForm.Location = new System.Drawing.Point(12, 31);
            this.homeForm.Name = "homeForm";
            this.homeForm.Size = new System.Drawing.Size(70, 28);
            this.homeForm.TabIndex = 14;
            this.homeForm.Text = "Home";
            this.homeForm.UseVisualStyleBackColor = false;
            this.homeForm.Click += new System.EventHandler(this.homeForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 516);
            this.Controls.Add(this.homeForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxBirder);
            this.Controls.Add(this.listBoxBird);
            this.Controls.Add(this.buttonAddBirder);
            this.Controls.Add(this.buttonAddBirdType);
            this.Controls.Add(this.buttonAddRegion);
            this.Controls.Add(this.listBoxRegions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddRegion;
        private System.Windows.Forms.Button buttonAddBirdType;
        private System.Windows.Forms.Button buttonAddBirder;
        private System.Windows.Forms.ListBox listBoxRegions;
        private System.Windows.Forms.ListBox listBoxBird;
        private System.Windows.Forms.ListBox listBoxBirder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button homeForm;
    }
}

