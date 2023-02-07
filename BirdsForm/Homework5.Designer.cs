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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeForm
            // 
            this.homeForm.BackColor = System.Drawing.Color.SteelBlue;
            this.homeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeForm.ForeColor = System.Drawing.Color.White;
            this.homeForm.Location = new System.Drawing.Point(58, 79);
            this.homeForm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.homeForm.Name = "homeForm";
            this.homeForm.Size = new System.Drawing.Size(140, 54);
            this.homeForm.TabIndex = 15;
            this.homeForm.Text = "Home";
            this.homeForm.UseVisualStyleBackColor = false;
            this.homeForm.Click += new System.EventHandler(this.homeForm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 680);
            this.dataGridView1.TabIndex = 16;
            // 
            // Homework5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.homeForm);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Homework5";
            this.Text = "Homework5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeForm;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}