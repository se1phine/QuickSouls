namespace QuickSouls
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelDir = new System.Windows.Forms.Label();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.buttonSetDir = new System.Windows.Forms.Button();
            this.labelSeperator1 = new System.Windows.Forms.Label();
            this.labelQSKey = new System.Windows.Forms.Label();
            this.labelQLKey = new System.Windows.Forms.Label();
            this.buttonSetKey = new System.Windows.Forms.Button();
            this.labelSeperator2 = new System.Windows.Forms.Label();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.labelCredits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGame = new System.Windows.Forms.Label();
            this.buttonPTDE = new System.Windows.Forms.Button();
            this.buttonDS2 = new System.Windows.Forms.Button();
            this.buttonSOTFS = new System.Windows.Forms.Button();
            this.buttonDS3 = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonDSRE = new System.Windows.Forms.Button();
            this.hotkeyControlQL = new exscape.HotkeyControl();
            this.hotkeyControlQS = new exscape.HotkeyControl();
            this.buttonER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(16, 127);
            this.labelDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(183, 15);
            this.labelDir.TabIndex = 0;
            this.labelDir.Text = "Game Save Data Folder:";
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(189, 123);
            this.textBoxDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(392, 25);
            this.textBoxDir.TabIndex = 1;
            // 
            // buttonSetDir
            // 
            this.buttonSetDir.Location = new System.Drawing.Point(591, 121);
            this.buttonSetDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSetDir.Name = "buttonSetDir";
            this.buttonSetDir.Size = new System.Drawing.Size(104, 27);
            this.buttonSetDir.TabIndex = 2;
            this.buttonSetDir.Text = "Set";
            this.buttonSetDir.UseVisualStyleBackColor = true;
            this.buttonSetDir.Click += new System.EventHandler(this.buttonSetDir_Click);
            // 
            // labelSeperator1
            // 
            this.labelSeperator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeperator1.Location = new System.Drawing.Point(17, 156);
            this.labelSeperator1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeperator1.Name = "labelSeperator1";
            this.labelSeperator1.Size = new System.Drawing.Size(679, 2);
            this.labelSeperator1.TabIndex = 3;
            // 
            // labelQSKey
            // 
            this.labelQSKey.AutoSize = true;
            this.labelQSKey.Location = new System.Drawing.Point(17, 170);
            this.labelQSKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQSKey.Name = "labelQSKey";
            this.labelQSKey.Size = new System.Drawing.Size(143, 15);
            this.labelQSKey.TabIndex = 4;
            this.labelQSKey.Text = "Quicksave Hotkey:";
            // 
            // labelQLKey
            // 
            this.labelQLKey.AutoSize = true;
            this.labelQLKey.Location = new System.Drawing.Point(285, 170);
            this.labelQLKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQLKey.Name = "labelQLKey";
            this.labelQLKey.Size = new System.Drawing.Size(143, 15);
            this.labelQLKey.TabIndex = 6;
            this.labelQLKey.Text = "Quickload Hotkey:";
            // 
            // buttonSetKey
            // 
            this.buttonSetKey.Location = new System.Drawing.Point(591, 164);
            this.buttonSetKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSetKey.Name = "buttonSetKey";
            this.buttonSetKey.Size = new System.Drawing.Size(104, 27);
            this.buttonSetKey.TabIndex = 8;
            this.buttonSetKey.Text = "Set";
            this.buttonSetKey.UseVisualStyleBackColor = true;
            this.buttonSetKey.Click += new System.EventHandler(this.buttonSetKey_Click);
            // 
            // labelSeperator2
            // 
            this.labelSeperator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeperator2.Location = new System.Drawing.Point(16, 197);
            this.labelSeperator2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeperator2.Name = "labelSeperator2";
            this.labelSeperator2.Size = new System.Drawing.Size(679, 2);
            this.labelSeperator2.TabIndex = 9;
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(16, 210);
            this.buttonLaunch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(260, 40);
            this.buttonLaunch.TabIndex = 10;
            this.buttonLaunch.Text = "Register Hotkeys";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Checked = true;
            this.checkBoxSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSound.Location = new System.Drawing.Point(552, 213);
            this.checkBoxSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(157, 34);
            this.checkBoxSound.TabIndex = 11;
            this.checkBoxSound.Text = "Play Sound after\r\nSave/Load";
            this.checkBoxSound.UseVisualStyleBackColor = true;
            this.checkBoxSound.CheckedChanged += new System.EventHandler(this.checkBoxSound_CheckedChanged);
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.Location = new System.Drawing.Point(457, 263);
            this.labelCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(225, 17);
            this.labelCredits.TabIndex = 12;
            this.labelCredits.Text = "QuickSouls v1.3.1 by MHVuze";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 2);
            this.label1.TabIndex = 13;
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Location = new System.Drawing.Point(16, 10);
            this.labelGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(423, 15);
            this.labelGame.TabIndex = 14;
            this.labelGame.Text = "Select Game by clicking on the corresponding Button:";
            // 
            // buttonPTDE
            // 
            this.buttonPTDE.Location = new System.Drawing.Point(16, 37);
            this.buttonPTDE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPTDE.Name = "buttonPTDE";
            this.buttonPTDE.Size = new System.Drawing.Size(176, 27);
            this.buttonPTDE.TabIndex = 15;
            this.buttonPTDE.Text = "Dark Souls: PTDE";
            this.buttonPTDE.UseVisualStyleBackColor = true;
            this.buttonPTDE.Click += new System.EventHandler(this.buttonPTDE_Click);
            // 
            // buttonDS2
            // 
            this.buttonDS2.Location = new System.Drawing.Point(200, 37);
            this.buttonDS2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDS2.Name = "buttonDS2";
            this.buttonDS2.Size = new System.Drawing.Size(176, 27);
            this.buttonDS2.TabIndex = 16;
            this.buttonDS2.Text = "Dark Souls 2";
            this.buttonDS2.UseVisualStyleBackColor = true;
            this.buttonDS2.Click += new System.EventHandler(this.buttonDS2_Click);
            // 
            // buttonSOTFS
            // 
            this.buttonSOTFS.Location = new System.Drawing.Point(200, 70);
            this.buttonSOTFS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSOTFS.Name = "buttonSOTFS";
            this.buttonSOTFS.Size = new System.Drawing.Size(176, 27);
            this.buttonSOTFS.TabIndex = 17;
            this.buttonSOTFS.Text = "Dark Souls 2: SOTFS";
            this.buttonSOTFS.UseVisualStyleBackColor = true;
            this.buttonSOTFS.Click += new System.EventHandler(this.buttonSOTFS_Click);
            // 
            // buttonDS3
            // 
            this.buttonDS3.Location = new System.Drawing.Point(384, 37);
            this.buttonDS3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDS3.Name = "buttonDS3";
            this.buttonDS3.Size = new System.Drawing.Size(176, 27);
            this.buttonDS3.TabIndex = 18;
            this.buttonDS3.Text = "Dark Souls 3";
            this.buttonDS3.UseVisualStyleBackColor = true;
            this.buttonDS3.Click += new System.EventHandler(this.buttonDS3_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(284, 210);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(260, 40);
            this.buttonStop.TabIndex = 19;
            this.buttonStop.Text = "Unregister Hotkeys";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonDSRE
            // 
            this.buttonDSRE.Location = new System.Drawing.Point(16, 70);
            this.buttonDSRE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDSRE.Name = "buttonDSRE";
            this.buttonDSRE.Size = new System.Drawing.Size(176, 27);
            this.buttonDSRE.TabIndex = 20;
            this.buttonDSRE.Text = "Dark Souls: Remastered";
            this.buttonDSRE.UseVisualStyleBackColor = true;
            this.buttonDSRE.Click += new System.EventHandler(this.buttonDSRE_Click);
            // 
            // hotkeyControlQL
            // 
            this.hotkeyControlQL.Hotkey = System.Windows.Forms.Keys.F8;
            this.hotkeyControlQL.HotkeyModifiers = System.Windows.Forms.Keys.None;
            this.hotkeyControlQL.Location = new System.Drawing.Point(420, 166);
            this.hotkeyControlQL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hotkeyControlQL.Name = "hotkeyControlQL";
            this.hotkeyControlQL.Size = new System.Drawing.Size(119, 25);
            this.hotkeyControlQL.TabIndex = 7;
            this.hotkeyControlQL.Text = "F8";
            // 
            // hotkeyControlQS
            // 
            this.hotkeyControlQS.Hotkey = System.Windows.Forms.Keys.F7;
            this.hotkeyControlQS.HotkeyModifiers = System.Windows.Forms.Keys.None;
            this.hotkeyControlQS.Location = new System.Drawing.Point(156, 166);
            this.hotkeyControlQS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hotkeyControlQS.Name = "hotkeyControlQS";
            this.hotkeyControlQS.Size = new System.Drawing.Size(119, 25);
            this.hotkeyControlQS.TabIndex = 5;
            this.hotkeyControlQS.Text = "F7";
            // 
            // buttonER
            // 
            this.buttonER.Location = new System.Drawing.Point(384, 70);
            this.buttonER.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonER.Name = "buttonER";
            this.buttonER.Size = new System.Drawing.Size(176, 27);
            this.buttonER.TabIndex = 21;
            this.buttonER.Text = "Elden Ring";
            this.buttonER.UseVisualStyleBackColor = true;
            this.buttonER.Click += new System.EventHandler(this.buttonER_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 288);
            this.Controls.Add(this.buttonER);
            this.Controls.Add(this.buttonDSRE);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonDS3);
            this.Controls.Add(this.buttonSOTFS);
            this.Controls.Add(this.buttonDS2);
            this.Controls.Add(this.buttonPTDE);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCredits);
            this.Controls.Add(this.checkBoxSound);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.hotkeyControlQL);
            this.Controls.Add(this.hotkeyControlQS);
            this.Controls.Add(this.labelSeperator2);
            this.Controls.Add(this.buttonSetKey);
            this.Controls.Add(this.labelQLKey);
            this.Controls.Add(this.labelQSKey);
            this.Controls.Add(this.labelSeperator1);
            this.Controls.Add(this.buttonSetDir);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.labelDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QuickSouls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonER;

        #endregion

        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Button buttonSetDir;
        private System.Windows.Forms.Label labelSeperator1;
        private System.Windows.Forms.Label labelQSKey;
        private System.Windows.Forms.Label labelQLKey;
        private System.Windows.Forms.Button buttonSetKey;
        private System.Windows.Forms.Label labelSeperator2;
        private exscape.HotkeyControl hotkeyControlQS;
        private exscape.HotkeyControl hotkeyControlQL;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Button buttonPTDE;
        private System.Windows.Forms.Button buttonDS2;
        private System.Windows.Forms.Button buttonSOTFS;
        private System.Windows.Forms.Button buttonDS3;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonDSRE;
    }
}

