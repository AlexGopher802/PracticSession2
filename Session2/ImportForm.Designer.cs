namespace Session2
{
    partial class ImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            this.btnImport = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblChangesApplied = new System.Windows.Forms.Label();
            this.lblRecordsDiscarded = new System.Windows.Forms.Label();
            this.lblFieldsDiscarded = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(318, 57);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 24);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(62, 58);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(250, 22);
            this.tbFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select text file with the changes";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.lblFieldsDiscarded);
            this.groupBox1.Controls.Add(this.lblRecordsDiscarded);
            this.groupBox1.Controls.Add(this.lblChangesApplied);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Successful Changes Applied:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Duplicate Records Discarded:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Record With Missing Fields Discarded:";
            // 
            // lblChangesApplied
            // 
            this.lblChangesApplied.AutoSize = true;
            this.lblChangesApplied.Location = new System.Drawing.Point(330, 54);
            this.lblChangesApplied.Name = "lblChangesApplied";
            this.lblChangesApplied.Size = new System.Drawing.Size(32, 17);
            this.lblChangesApplied.TabIndex = 3;
            this.lblChangesApplied.Text = "000";
            // 
            // lblRecordsDiscarded
            // 
            this.lblRecordsDiscarded.AutoSize = true;
            this.lblRecordsDiscarded.Location = new System.Drawing.Point(330, 104);
            this.lblRecordsDiscarded.Name = "lblRecordsDiscarded";
            this.lblRecordsDiscarded.Size = new System.Drawing.Size(32, 17);
            this.lblRecordsDiscarded.TabIndex = 4;
            this.lblRecordsDiscarded.Text = "000";
            // 
            // lblFieldsDiscarded
            // 
            this.lblFieldsDiscarded.AutoSize = true;
            this.lblFieldsDiscarded.Location = new System.Drawing.Point(330, 154);
            this.lblFieldsDiscarded.Name = "lblFieldsDiscarded";
            this.lblFieldsDiscarded.Size = new System.Drawing.Size(32, 17);
            this.lblFieldsDiscarded.TabIndex = 5;
            this.lblFieldsDiscarded.Text = "000";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.btnImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply Chedule Changes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImportForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFieldsDiscarded;
        private System.Windows.Forms.Label lblRecordsDiscarded;
        private System.Windows.Forms.Label lblChangesApplied;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}