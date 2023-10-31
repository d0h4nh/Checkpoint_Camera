namespace VLCRTSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCap = new System.Windows.Forms.Button();
            this.txtcntrno = new System.Windows.Forms.TextBox();
            this.lblstat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkC2 = new System.Windows.Forms.CheckBox();
            this.chkC4 = new System.Windows.Forms.CheckBox();
            this.chkC1 = new System.Windows.Forms.CheckBox();
            this.chkC3 = new System.Windows.Forms.CheckBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 797);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnCap);
            this.groupBox3.Controls.Add(this.txtcntrno);
            this.groupBox3.Controls.Add(this.lblstat);
            this.groupBox3.Location = new System.Drawing.Point(12, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 79);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Container No";
            // 
            // btnCap
            // 
            this.btnCap.Location = new System.Drawing.Point(241, 23);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(75, 23);
            this.btnCap.TabIndex = 0;
            this.btnCap.Text = "Capture";
            this.btnCap.UseVisualStyleBackColor = true;
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // txtcntrno
            // 
            this.txtcntrno.Location = new System.Drawing.Point(81, 25);
            this.txtcntrno.Name = "txtcntrno";
            this.txtcntrno.Size = new System.Drawing.Size(142, 20);
            this.txtcntrno.TabIndex = 1;
            this.txtcntrno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcntrno_KeyDown);
            // 
            // lblstat
            // 
            this.lblstat.AutoSize = true;
            this.lblstat.Location = new System.Drawing.Point(6, 54);
            this.lblstat.Name = "lblstat";
            this.lblstat.Size = new System.Drawing.Size(37, 13);
            this.lblstat.TabIndex = 2;
            this.lblstat.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkC2);
            this.groupBox2.Controls.Add(this.chkC4);
            this.groupBox2.Controls.Add(this.chkC1);
            this.groupBox2.Controls.Add(this.chkC3);
            this.groupBox2.Location = new System.Drawing.Point(518, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 79);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera to capture";
            // 
            // chkC2
            // 
            this.chkC2.AutoSize = true;
            this.chkC2.Location = new System.Drawing.Point(96, 18);
            this.chkC2.Name = "chkC2";
            this.chkC2.Size = new System.Drawing.Size(71, 17);
            this.chkC2.TabIndex = 0;
            this.chkC2.Text = "Camera 2";
            this.chkC2.UseVisualStyleBackColor = true;
            // 
            // chkC4
            // 
            this.chkC4.AutoSize = true;
            this.chkC4.Location = new System.Drawing.Point(96, 41);
            this.chkC4.Name = "chkC4";
            this.chkC4.Size = new System.Drawing.Size(71, 17);
            this.chkC4.TabIndex = 0;
            this.chkC4.Text = "Camera 4";
            this.chkC4.UseVisualStyleBackColor = true;
            // 
            // chkC1
            // 
            this.chkC1.AutoSize = true;
            this.chkC1.Location = new System.Drawing.Point(10, 18);
            this.chkC1.Name = "chkC1";
            this.chkC1.Size = new System.Drawing.Size(71, 17);
            this.chkC1.TabIndex = 0;
            this.chkC1.Text = "Camera 1";
            this.chkC1.UseVisualStyleBackColor = true;
            // 
            // chkC3
            // 
            this.chkC3.AutoSize = true;
            this.chkC3.Location = new System.Drawing.Point(10, 41);
            this.chkC3.Name = "chkC3";
            this.chkC3.Size = new System.Drawing.Size(71, 17);
            this.chkC3.TabIndex = 0;
            this.chkC3.Text = "Camera 3";
            this.chkC3.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(1097, 27);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1097, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 921);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCap;
        private System.Windows.Forms.TextBox txtcntrno;
        private System.Windows.Forms.Label lblstat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.CheckBox chkC1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkC2;
        private System.Windows.Forms.CheckBox chkC4;
        private System.Windows.Forms.CheckBox chkC3;
    }
}

