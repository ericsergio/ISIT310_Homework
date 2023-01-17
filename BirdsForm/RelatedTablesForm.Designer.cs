namespace BirdsForm
{
    partial class RelatedTablesForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.moveFirst = new System.Windows.Forms.Button();
            this.moveNext = new System.Windows.Forms.Button();
            this.movePrev = new System.Windows.Forms.Button();
            this.moveLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(686, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(88, 289);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(686, 189);
            this.dataGridView2.TabIndex = 1;
            // 
            // moveFirst
            // 
            this.moveFirst.Location = new System.Drawing.Point(844, 46);
            this.moveFirst.Name = "moveFirst";
            this.moveFirst.Size = new System.Drawing.Size(285, 39);
            this.moveFirst.TabIndex = 2;
            this.moveFirst.Text = "Move First";
            this.moveFirst.UseVisualStyleBackColor = true;
            this.moveFirst.Click += new System.EventHandler(this.moveFirst_Click);
            // 
            // moveNext
            // 
            this.moveNext.Location = new System.Drawing.Point(844, 136);
            this.moveNext.Name = "moveNext";
            this.moveNext.Size = new System.Drawing.Size(285, 38);
            this.moveNext.TabIndex = 3;
            this.moveNext.Text = "Move Next";
            this.moveNext.UseVisualStyleBackColor = true;
            this.moveNext.Click += new System.EventHandler(this.moveNext_Click);
            // 
            // movePrev
            // 
            this.movePrev.Location = new System.Drawing.Point(844, 231);
            this.movePrev.Name = "movePrev";
            this.movePrev.Size = new System.Drawing.Size(285, 38);
            this.movePrev.TabIndex = 5;
            this.movePrev.Text = "Move Previous";
            this.movePrev.UseVisualStyleBackColor = true;
            this.movePrev.Click += new System.EventHandler(this.movePrev_Click);
            // 
            // moveLast
            // 
            this.moveLast.Location = new System.Drawing.Point(844, 328);
            this.moveLast.Name = "moveLast";
            this.moveLast.Size = new System.Drawing.Size(285, 39);
            this.moveLast.TabIndex = 4;
            this.moveLast.Text = "Move Last";
            this.moveLast.UseVisualStyleBackColor = true;
            this.moveLast.Click += new System.EventHandler(this.moveLast_Click);
            // 
            // RelatedTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 550);
            this.Controls.Add(this.movePrev);
            this.Controls.Add(this.moveLast);
            this.Controls.Add(this.moveNext);
            this.Controls.Add(this.moveFirst);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RelatedTablesForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RelatedTablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button moveFirst;
        private System.Windows.Forms.Button moveNext;
        private System.Windows.Forms.Button movePrev;
        private System.Windows.Forms.Button moveLast;
    }
}