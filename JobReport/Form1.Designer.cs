namespace JobReport
{
    partial class JobReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobReport));
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblProblem = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.txtProblem = new System.Windows.Forms.RichTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.RichTextBox();
            this.txtOther = new System.Windows.Forms.RichTextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblMini = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.RichTextBox();
            this.cmbReq = new System.Windows.Forms.ComboBox();
            this.lblReq = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbShift
            // 
            this.cmbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(140, 144);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(149, 28);
            this.cmbShift.TabIndex = 1;
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.BackColor = System.Drawing.Color.Transparent;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.ForeColor = System.Drawing.Color.White;
            this.lblShift.Location = new System.Drawing.Point(8, 144);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(127, 22);
            this.lblShift.TabIndex = 3;
            this.lblShift.Text = "SHIFT            :";
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.BackColor = System.Drawing.Color.Transparent;
            this.lblProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblem.ForeColor = System.Drawing.Color.White;
            this.lblProblem.Location = new System.Drawing.Point(8, 189);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(127, 22);
            this.lblProblem.TabIndex = 4;
            this.lblProblem.Text = "PROBLEM     :";
            // 
            // lblSolution
            // 
            this.lblSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSolution.AutoSize = true;
            this.lblSolution.BackColor = System.Drawing.Color.Transparent;
            this.lblSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolution.ForeColor = System.Drawing.Color.White;
            this.lblSolution.Location = new System.Drawing.Point(519, 189);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(162, 22);
            this.lblSolution.TabIndex = 5;
            this.lblSolution.Text = "SOLUTION           :";
            // 
            // txtProblem
            // 
            this.txtProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProblem.Location = new System.Drawing.Point(140, 189);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(373, 162);
            this.txtProblem.TabIndex = 2;
            this.txtProblem.Text = "";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Silver;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(12, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(102, 22);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "WELCOME";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(925, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 51);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "S A V E";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderSize = 2;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(774, 540);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(145, 51);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "E X P O R T";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(994, 5);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(77, 17);
            this.lblExit.TabIndex = 11;
            this.lblExit.Text = "[ E X I T ]";
            this.lblExit.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSolution
            // 
            this.txtSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolution.Location = new System.Drawing.Point(698, 187);
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(373, 162);
            this.txtSolution.TabIndex = 3;
            this.txtSolution.Text = "";
            // 
            // txtOther
            // 
            this.txtOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOther.Location = new System.Drawing.Point(140, 369);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(373, 162);
            this.txtOther.TabIndex = 4;
            this.txtOther.Text = "";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.BackColor = System.Drawing.Color.Transparent;
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.ForeColor = System.Drawing.Color.White;
            this.lblOther.Location = new System.Drawing.Point(6, 369);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(129, 22);
            this.lblOther.TabIndex = 15;
            this.lblOther.Text = "OTHER JOB  :";
            // 
            // lblMini
            // 
            this.lblMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMini.AutoSize = true;
            this.lblMini.BackColor = System.Drawing.Color.Transparent;
            this.lblMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMini.ForeColor = System.Drawing.Color.White;
            this.lblMini.Location = new System.Drawing.Point(956, 5);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(37, 17);
            this.lblMini.TabIndex = 16;
            this.lblMini.Text = "[ _ ]";
            this.lblMini.Click += new System.EventHandler(this.lblMini_Click);
            // 
            // lblJob
            // 
            this.lblJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.White;
            this.lblJob.Location = new System.Drawing.Point(519, 369);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(167, 22);
            this.lblJob.TabIndex = 17;
            this.lblJob.Text = "JOB PROGRESS  :";
            // 
            // txtJob
            // 
            this.txtJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJob.Location = new System.Drawing.Point(698, 367);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(373, 162);
            this.txtJob.TabIndex = 5;
            this.txtJob.Text = "";
            // 
            // cmbReq
            // 
            this.cmbReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReq.FormattingEnabled = true;
            this.cmbReq.Location = new System.Drawing.Point(364, 144);
            this.cmbReq.Name = "cmbReq";
            this.cmbReq.Size = new System.Drawing.Size(149, 28);
            this.cmbReq.TabIndex = 6;
            // 
            // lblReq
            // 
            this.lblReq.AutoSize = true;
            this.lblReq.BackColor = System.Drawing.Color.Transparent;
            this.lblReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReq.ForeColor = System.Drawing.Color.White;
            this.lblReq.Location = new System.Drawing.Point(304, 144);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(54, 22);
            this.lblReq.TabIndex = 20;
            this.lblReq.Text = "PIC  :";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleDescription = "";
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Transparent;
            this.btnReset.Location = new System.Drawing.Point(698, 540);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 51);
            this.btnReset.TabIndex = 21;
            this.btnReset.Tag = "";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("EngraversGothic BT", 70F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(296, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(571, 100);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "JOB REPORT";
            // 
            // JobReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 603);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.cmbReq);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblMini);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtSolution);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.lblProblem);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.cmbShift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Report";
            this.Load += new System.EventHandler(this.JobReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.RichTextBox txtProblem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.RichTextBox txtSolution;
        private System.Windows.Forms.RichTextBox txtOther;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.RichTextBox txtJob;
        private System.Windows.Forms.ComboBox cmbReq;
        private System.Windows.Forms.Label lblReq;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTitle;
    }
}

