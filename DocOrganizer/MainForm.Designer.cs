namespace DocOrganizer
{
    partial class MainForm
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSaveAndNext = new System.Windows.Forms.Button();
            this.listBoxTypes = new System.Windows.Forms.ListBox();
            this.listBoxDefaultNames = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInputDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendarSet = new System.Windows.Forms.MonthCalendar();
            this.textBoxOutputDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPicture = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxDoc = new System.Windows.Forms.PictureBox();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxPicture.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.buttonNext);
            this.groupBoxInfo.Controls.Add(this.buttonSaveAndNext);
            this.groupBoxInfo.Controls.Add(this.listBoxTypes);
            this.groupBoxInfo.Controls.Add(this.listBoxDefaultNames);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Controls.Add(this.textBoxName);
            this.groupBoxInfo.Controls.Add(this.textBoxInputDir);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.monthCalendarSet);
            this.groupBoxInfo.Controls.Add(this.textBoxOutputDir);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxInfo.Location = new System.Drawing.Point(684, 0);
            this.groupBoxInfo.MaximumSize = new System.Drawing.Size(300, 0);
            this.groupBoxInfo.MinimumSize = new System.Drawing.Size(300, 0);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(300, 662);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(9, 561);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(138, 89);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSaveAndNext
            // 
            this.buttonSaveAndNext.Location = new System.Drawing.Point(154, 560);
            this.buttonSaveAndNext.Name = "buttonSaveAndNext";
            this.buttonSaveAndNext.Size = new System.Drawing.Size(134, 90);
            this.buttonSaveAndNext.TabIndex = 9;
            this.buttonSaveAndNext.Text = "Save && Next";
            this.buttonSaveAndNext.UseVisualStyleBackColor = true;
            this.buttonSaveAndNext.Click += new System.EventHandler(this.buttonSaveAndNext_Click);
            // 
            // listBoxTypes
            // 
            this.listBoxTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTypes.FormattingEnabled = true;
            this.listBoxTypes.ItemHeight = 16;
            this.listBoxTypes.Location = new System.Drawing.Point(9, 277);
            this.listBoxTypes.Name = "listBoxTypes";
            this.listBoxTypes.Size = new System.Drawing.Size(139, 276);
            this.listBoxTypes.TabIndex = 8;
            this.listBoxTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxTypes_SelectedIndexChanged);
            // 
            // listBoxDefaultNames
            // 
            this.listBoxDefaultNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDefaultNames.FormattingEnabled = true;
            this.listBoxDefaultNames.ItemHeight = 16;
            this.listBoxDefaultNames.Location = new System.Drawing.Point(154, 277);
            this.listBoxDefaultNames.Name = "listBoxDefaultNames";
            this.listBoxDefaultNames.Size = new System.Drawing.Size(134, 276);
            this.listBoxDefaultNames.TabIndex = 7;
            this.listBoxDefaultNames.SelectedIndexChanged += new System.EventHandler(this.listBoxDefaultNames_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(77, 251);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(211, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxInputDir
            // 
            this.textBoxInputDir.Enabled = false;
            this.textBoxInputDir.Location = new System.Drawing.Point(77, 19);
            this.textBoxInputDir.Name = "textBoxInputDir";
            this.textBoxInputDir.Size = new System.Drawing.Size(211, 20);
            this.textBoxInputDir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inbound";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // monthCalendarSet
            // 
            this.monthCalendarSet.Location = new System.Drawing.Point(35, 77);
            this.monthCalendarSet.MaxSelectionCount = 1;
            this.monthCalendarSet.Name = "monthCalendarSet";
            this.monthCalendarSet.TabIndex = 2;
            // 
            // textBoxOutputDir
            // 
            this.textBoxOutputDir.Enabled = false;
            this.textBoxOutputDir.Location = new System.Drawing.Point(77, 45);
            this.textBoxOutputDir.Name = "textBoxOutputDir";
            this.textBoxOutputDir.Size = new System.Drawing.Size(211, 20);
            this.textBoxOutputDir.TabIndex = 1;
            this.textBoxOutputDir.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OutBound";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxPicture
            // 
            this.groupBoxPicture.Controls.Add(this.panel1);
            this.groupBoxPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPicture.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPicture.Name = "groupBoxPicture";
            this.groupBoxPicture.Size = new System.Drawing.Size(684, 662);
            this.groupBoxPicture.TabIndex = 1;
            this.groupBoxPicture.TabStop = false;
            this.groupBoxPicture.Text = "Picture";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBoxDoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 643);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxDoc
            // 
            this.pictureBoxDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDoc.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDoc.Name = "pictureBoxDoc";
            this.pictureBoxDoc.Size = new System.Drawing.Size(678, 643);
            this.pictureBoxDoc.TabIndex = 2;
            this.pictureBoxDoc.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.groupBoxPicture);
            this.Controls.Add(this.groupBoxInfo);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainForm";
            this.Text = "DocOrganizer";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxPicture.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxPicture;
        private System.Windows.Forms.TextBox textBoxOutputDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendarSet;
        private System.Windows.Forms.ListBox listBoxDefaultNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSaveAndNext;
        private System.Windows.Forms.ListBox listBoxTypes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxDoc;
    }
}

