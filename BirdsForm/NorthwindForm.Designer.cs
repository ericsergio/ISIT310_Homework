namespace BirdsForm
{
    partial class NorthwindForm
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
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.goHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AllowUserToOrderColumns = true;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(101, 19);
            this.grid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid1.Name = "grid1";
            this.grid1.RowHeadersWidth = 82;
            this.grid1.RowTemplate.Height = 33;
            this.grid1.Size = new System.Drawing.Size(668, 581);
            this.grid1.TabIndex = 0;
            // 
            // goHome
            // 
            this.goHome.BackColor = System.Drawing.Color.SteelBlue;
            this.goHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goHome.ForeColor = System.Drawing.Color.White;
            this.goHome.Location = new System.Drawing.Point(13, 19);
            this.goHome.Name = "goHome";
            this.goHome.Size = new System.Drawing.Size(70, 28);
            this.goHome.TabIndex = 10;
            this.goHome.Text = "Home";
            this.goHome.UseVisualStyleBackColor = false;
            this.goHome.Click += new System.EventHandler(this.goHome_Click);
            // 
            // NorthwindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 650);
            this.Controls.Add(this.goHome);
            this.Controls.Add(this.grid1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NorthwindForm";
            this.Text = "NorthwindForm";
            this.Load += new System.EventHandler(this.NorthwindForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Button goHome;
    }
}