namespace BirdsForm
{
    partial class Homework5
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
            this.homeForm = new System.Windows.Forms.Button();
            this.gridEntityData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntityData)).BeginInit();
            this.SuspendLayout();
            // 
            // homeForm
            // 
            this.homeForm.BackColor = System.Drawing.Color.SteelBlue;
            this.homeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeForm.ForeColor = System.Drawing.Color.White;
            this.homeForm.Location = new System.Drawing.Point(29, 41);
            this.homeForm.Name = "homeForm";
            this.homeForm.Size = new System.Drawing.Size(70, 28);
            this.homeForm.TabIndex = 15;
            this.homeForm.Text = "Home";
            this.homeForm.UseVisualStyleBackColor = false;
            this.homeForm.Click += new System.EventHandler(this.homeForm_Click);
            // 
            // gridEntityData
            // 
            this.gridEntityData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEntityData.Location = new System.Drawing.Point(136, 41);
            this.gridEntityData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridEntityData.Name = "gridEntityData";
            this.gridEntityData.RowHeadersWidth = 82;
            this.gridEntityData.RowTemplate.Height = 33;
            this.gridEntityData.Size = new System.Drawing.Size(578, 354);
            this.gridEntityData.TabIndex = 16;
            // 
            // Homework5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 498);
            this.Controls.Add(this.gridEntityData);
            this.Controls.Add(this.homeForm);
            this.Name = "Homework5";
            this.Text = "Homework5";
            this.Load += new System.EventHandler(this.Homework5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEntityData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeForm;
        private System.Windows.Forms.DataGridView gridEntityData;
    }
}