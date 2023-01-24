namespace BirdsForm
{
    partial class XMLtoDB
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
            this.gridXML = new System.Windows.Forms.DataGridView();
            this.gridSQL = new System.Windows.Forms.DataGridView();
            this.mergeXml = new System.Windows.Forms.Button();
            this.showDb = new System.Windows.Forms.Button();
            this.showXml = new System.Windows.Forms.Button();
            this.goHome = new System.Windows.Forms.Button();
            this.saveXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridXML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // gridXML
            // 
            this.gridXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridXML.GridColor = System.Drawing.Color.DarkSlateGray;
            this.gridXML.Location = new System.Drawing.Point(163, 33);
            this.gridXML.Name = "gridXML";
            this.gridXML.Size = new System.Drawing.Size(671, 160);
            this.gridXML.TabIndex = 0;
            // 
            // gridSQL
            // 
            this.gridSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSQL.Location = new System.Drawing.Point(163, 233);
            this.gridSQL.Name = "gridSQL";
            this.gridSQL.Size = new System.Drawing.Size(671, 281);
            this.gridSQL.TabIndex = 2;
            // 
            // mergeXml
            // 
            this.mergeXml.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mergeXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeXml.ForeColor = System.Drawing.Color.White;
            this.mergeXml.Location = new System.Drawing.Point(33, 338);
            this.mergeXml.Name = "mergeXml";
            this.mergeXml.Size = new System.Drawing.Size(97, 32);
            this.mergeXml.TabIndex = 6;
            this.mergeXml.Text = "testXML";
            this.mergeXml.UseVisualStyleBackColor = false;
            this.mergeXml.Click += new System.EventHandler(this.mergeXml_Click);
            // 
            // showDb
            // 
            this.showDb.BackColor = System.Drawing.Color.DarkSlateGray;
            this.showDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDb.ForeColor = System.Drawing.Color.White;
            this.showDb.Location = new System.Drawing.Point(399, 198);
            this.showDb.Name = "showDb";
            this.showDb.Size = new System.Drawing.Size(200, 32);
            this.showDb.TabIndex = 7;
            this.showDb.Text = "Display BirdCount Table";
            this.showDb.UseVisualStyleBackColor = false;
            this.showDb.Click += new System.EventHandler(this.showDb_Click);
            // 
            // showXml
            // 
            this.showXml.BackColor = System.Drawing.Color.DarkSlateGray;
            this.showXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showXml.ForeColor = System.Drawing.Color.White;
            this.showXml.Location = new System.Drawing.Point(163, 198);
            this.showXml.Name = "showXml";
            this.showXml.Size = new System.Drawing.Size(200, 32);
            this.showXml.TabIndex = 8;
            this.showXml.Text = "Import Data";
            this.showXml.UseVisualStyleBackColor = false;
            this.showXml.Click += new System.EventHandler(this.showXml_Click);
            // 
            // goHome
            // 
            this.goHome.BackColor = System.Drawing.Color.SteelBlue;
            this.goHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goHome.ForeColor = System.Drawing.Color.White;
            this.goHome.Location = new System.Drawing.Point(12, 33);
            this.goHome.Name = "goHome";
            this.goHome.Size = new System.Drawing.Size(70, 28);
            this.goHome.TabIndex = 9;
            this.goHome.Text = "Home";
            this.goHome.UseVisualStyleBackColor = false;
            this.goHome.Click += new System.EventHandler(this.goHome_Click);
            // 
            // saveXml
            // 
            this.saveXml.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveXml.ForeColor = System.Drawing.Color.White;
            this.saveXml.Location = new System.Drawing.Point(634, 199);
            this.saveXml.Name = "saveXml";
            this.saveXml.Size = new System.Drawing.Size(200, 32);
            this.saveXml.TabIndex = 10;
            this.saveXml.Text = "Add Data to BirdCount";
            this.saveXml.UseVisualStyleBackColor = false;
            this.saveXml.Click += new System.EventHandler(this.saveXml_Click);
            // 
            // XMLtoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 528);
            this.Controls.Add(this.saveXml);
            this.Controls.Add(this.goHome);
            this.Controls.Add(this.showXml);
            this.Controls.Add(this.showDb);
            this.Controls.Add(this.mergeXml);
            this.Controls.Add(this.gridSQL);
            this.Controls.Add(this.gridXML);
            this.Name = "XMLtoDB";
            this.Text = "XMLtoDB";
            ((System.ComponentModel.ISupportInitialize)(this.gridXML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridXML;
        private System.Windows.Forms.DataGridView gridSQL;
        private System.Windows.Forms.Button mergeXml;
        private System.Windows.Forms.Button showDb;
        private System.Windows.Forms.Button showXml;
        private System.Windows.Forms.Button goHome;
        private System.Windows.Forms.Button saveXml;
    }
}