namespace Session2
{
    partial class ManageForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxReverse = new System.Windows.Forms.CheckBox();
            this.checkBoxOut = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.dtpOutbound = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbFlyNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.dataGridSchedules = new System.Windows.Forms.DataGridView();
            this.btnCancelFly = new System.Windows.Forms.Button();
            this.btnEditFly = new System.Windows.Forms.Button();
            this.btnImportChanges = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.checkBoxReverse);
            this.groupBox1.Controls.Add(this.checkBoxOut);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.dtpOutbound);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mtbFlyNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // checkBoxReverse
            // 
            this.checkBoxReverse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBoxReverse.BackgroundImage")));
            this.checkBoxReverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxReverse.Location = new System.Drawing.Point(810, 38);
            this.checkBoxReverse.Name = "checkBoxReverse";
            this.checkBoxReverse.Size = new System.Drawing.Size(59, 17);
            this.checkBoxReverse.TabIndex = 10;
            this.checkBoxReverse.UseVisualStyleBackColor = true;
            this.checkBoxReverse.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // checkBoxOut
            // 
            this.checkBoxOut.Location = new System.Drawing.Point(35, 82);
            this.checkBoxOut.Name = "checkBoxOut";
            this.checkBoxOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxOut.Size = new System.Drawing.Size(93, 22);
            this.checkBoxOut.TabIndex = 9;
            this.checkBoxOut.Text = "Outbound";
            this.checkBoxOut.UseVisualStyleBackColor = true;
            this.checkBoxOut.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnApply.Location = new System.Drawing.Point(654, 80);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(150, 25);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dtpOutbound
            // 
            this.dtpOutbound.Enabled = false;
            this.dtpOutbound.Location = new System.Drawing.Point(134, 81);
            this.dtpOutbound.Name = "dtpOutbound";
            this.dtpOutbound.Size = new System.Drawing.Size(174, 22);
            this.dtpOutbound.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(323, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Flight number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbFlyNumber
            // 
            this.mtbFlyNumber.Location = new System.Drawing.Point(425, 81);
            this.mtbFlyNumber.Mask = "0000";
            this.mtbFlyNumber.Name = "mtbFlyNumber";
            this.mtbFlyNumber.Size = new System.Drawing.Size(129, 22);
            this.mtbFlyNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(595, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sort by";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Date-Time",
            "Price",
            "Confirmed"});
            this.cbSort.Location = new System.Drawing.Point(654, 35);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(150, 24);
            this.cbSort.TabIndex = 4;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(354, 35);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(200, 24);
            this.cbTo.TabIndex = 2;
            this.cbTo.SelectedIndexChanged += new System.EventHandler(this.cbTo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(108, 35);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(200, 24);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // dataGridSchedules
            // 
            this.dataGridSchedules.AllowUserToAddRows = false;
            this.dataGridSchedules.AllowUserToDeleteRows = false;
            this.dataGridSchedules.AllowUserToResizeColumns = false;
            this.dataGridSchedules.AllowUserToResizeRows = false;
            this.dataGridSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSchedules.Location = new System.Drawing.Point(12, 139);
            this.dataGridSchedules.MultiSelect = false;
            this.dataGridSchedules.Name = "dataGridSchedules";
            this.dataGridSchedules.ReadOnly = true;
            this.dataGridSchedules.RowHeadersVisible = false;
            this.dataGridSchedules.RowHeadersWidth = 51;
            this.dataGridSchedules.RowTemplate.Height = 24;
            this.dataGridSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSchedules.Size = new System.Drawing.Size(858, 271);
            this.dataGridSchedules.TabIndex = 1;
            // 
            // btnCancelFly
            // 
            this.btnCancelFly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnCancelFly.Location = new System.Drawing.Point(47, 416);
            this.btnCancelFly.Name = "btnCancelFly";
            this.btnCancelFly.Size = new System.Drawing.Size(140, 28);
            this.btnCancelFly.TabIndex = 2;
            this.btnCancelFly.Text = "Confirm/Unconfirm";
            this.btnCancelFly.UseVisualStyleBackColor = true;
            this.btnCancelFly.Click += new System.EventHandler(this.btnCancelFly_Click);
            // 
            // btnEditFly
            // 
            this.btnEditFly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnEditFly.Location = new System.Drawing.Point(193, 416);
            this.btnEditFly.Name = "btnEditFly";
            this.btnEditFly.Size = new System.Drawing.Size(140, 28);
            this.btnEditFly.TabIndex = 3;
            this.btnEditFly.Text = "Edit Flight";
            this.btnEditFly.UseVisualStyleBackColor = true;
            this.btnEditFly.Click += new System.EventHandler(this.btnEditFly_Click);
            // 
            // btnImportChanges
            // 
            this.btnImportChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnImportChanges.Location = new System.Drawing.Point(696, 416);
            this.btnImportChanges.Name = "btnImportChanges";
            this.btnImportChanges.Size = new System.Drawing.Size(120, 28);
            this.btnImportChanges.TabIndex = 4;
            this.btnImportChanges.Text = "Import Changes";
            this.btnImportChanges.UseVisualStyleBackColor = true;
            this.btnImportChanges.Click += new System.EventHandler(this.btnImportChanges_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.btnImportChanges);
            this.Controls.Add(this.btnEditFly);
            this.Controls.Add(this.btnCancelFly);
            this.Controls.Add(this.dataGridSchedules);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Flight Schedules";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DateTimePicker dtpOutbound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbFlyNumber;
        private System.Windows.Forms.DataGridView dataGridSchedules;
        private System.Windows.Forms.Button btnCancelFly;
        private System.Windows.Forms.Button btnEditFly;
        private System.Windows.Forms.Button btnImportChanges;
        private System.Windows.Forms.CheckBox checkBoxOut;
        private System.Windows.Forms.CheckBox checkBoxReverse;
    }
}

