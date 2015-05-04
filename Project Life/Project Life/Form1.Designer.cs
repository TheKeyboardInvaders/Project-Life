namespace Project_Life
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRandomPlacement = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnNextStep = new MetroFramework.Controls.MetroButton();
            this.btnRun = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.controlsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pField = new Project_Life.DoubleBufferedPanel();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preset1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preset2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preset3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.presetsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(2, 8);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(245, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(145, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveAsImageToolStripMenuItem.Text = "Save as image";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnRandomPlacement
            // 
            this.btnRandomPlacement.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRandomPlacement.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnRandomPlacement.Location = new System.Drawing.Point(630, 99);
            this.btnRandomPlacement.Name = "btnRandomPlacement";
            this.btnRandomPlacement.Size = new System.Drawing.Size(115, 50);
            this.btnRandomPlacement.Style = MetroFramework.MetroColorStyle.Green;
            this.btnRandomPlacement.TabIndex = 1;
            this.btnRandomPlacement.TabStop = false;
            this.btnRandomPlacement.Text = "Random";
            this.btnRandomPlacement.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRandomPlacement.UseCustomBackColor = true;
            this.btnRandomPlacement.UseCustomForeColor = true;
            this.btnRandomPlacement.UseSelectable = true;
            this.btnRandomPlacement.UseStyleColors = true;
            this.btnRandomPlacement.Click += new System.EventHandler(this.btnRandomPlacement_Click);
            // 
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClear.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnClear.Location = new System.Drawing.Point(630, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 50);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Green;
            this.btnClear.TabIndex = 4;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear Field";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseCustomForeColor = true;
            this.btnClear.UseSelectable = true;
            this.btnClear.UseStyleColors = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNextStep.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnNextStep.Location = new System.Drawing.Point(630, 41);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(115, 50);
            this.btnNextStep.Style = MetroFramework.MetroColorStyle.Green;
            this.btnNextStep.TabIndex = 0;
            this.btnNextStep.TabStop = false;
            this.btnNextStep.Text = "Next Step";
            this.btnNextStep.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnNextStep.UseCustomBackColor = true;
            this.btnNextStep.UseCustomForeColor = true;
            this.btnNextStep.UseSelectable = true;
            this.btnNextStep.UseStyleColors = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnRun
            // 
            this.btnRun.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRun.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnRun.Location = new System.Drawing.Point(630, 155);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(115, 50);
            this.btnRun.Style = MetroFramework.MetroColorStyle.Green;
            this.btnRun.TabIndex = 2;
            this.btnRun.TabStop = false;
            this.btnRun.Text = "Run";
            this.btnRun.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRun.UseCustomBackColor = true;
            this.btnRun.UseCustomForeColor = true;
            this.btnRun.UseSelectable = true;
            this.btnRun.UseStyleColors = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStop.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnStop.Location = new System.Drawing.Point(630, 211);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 50);
            this.btnStop.Style = MetroFramework.MetroColorStyle.Green;
            this.btnStop.TabIndex = 3;
            this.btnStop.TabStop = false;
            this.btnStop.Text = "Stop";
            this.btnStop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnStop.UseCustomBackColor = true;
            this.btnStop.UseCustomForeColor = true;
            this.btnStop.UseSelectable = true;
            this.btnStop.UseStyleColors = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // controlsTooltip
            // 
            this.controlsTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.controlsTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.controlsTooltip_Popup);
            // 
            // pField
            // 
            this.pField.BackColor = System.Drawing.Color.White;
            this.pField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pField.Location = new System.Drawing.Point(12, 41);
            this.pField.Name = "pField";
            this.pField.Size = new System.Drawing.Size(603, 399);
            this.pField.TabIndex = 0;
            this.pField.Paint += new System.Windows.Forms.PaintEventHandler(this.pField_Paint);
            this.pField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pField_MouseDown);
            this.pField.MouseHover += new System.EventHandler(this.pField_MouseHover);
            this.pField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pField_MouseUp);
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preset1ToolStripMenuItem,
            this.preset2ToolStripMenuItem,
            this.preset3ToolStripMenuItem});
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.presetsToolStripMenuItem.Text = "Presets";
            // 
            // preset1ToolStripMenuItem
            // 
            this.preset1ToolStripMenuItem.Name = "preset1ToolStripMenuItem";
            this.preset1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.preset1ToolStripMenuItem.Text = "Preset 1";
            this.preset1ToolStripMenuItem.Click += new System.EventHandler(this.preset1ToolStripMenuItem_Click);
            // 
            // preset2ToolStripMenuItem
            // 
            this.preset2ToolStripMenuItem.Name = "preset2ToolStripMenuItem";
            this.preset2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.preset2ToolStripMenuItem.Text = "Preset 2";
            this.preset2ToolStripMenuItem.Click += new System.EventHandler(this.preset2ToolStripMenuItem_Click);
            // 
            // preset3ToolStripMenuItem
            // 
            this.preset3ToolStripMenuItem.Name = "preset3ToolStripMenuItem";
            this.preset3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.preset3ToolStripMenuItem.Text = "Preset 3";
            this.preset3ToolStripMenuItem.Click += new System.EventHandler(this.preset3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 453);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRandomPlacement);
            this.Controls.Add(this.pField);
            this.Controls.Add(this.menuStrip);
            this.DisplayHeader = false;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnRandomPlacement;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnNextStep;
        private MetroFramework.Controls.MetroButton btnRun;
        private MetroFramework.Controls.MetroButton btnStop;
        private DoubleBufferedPanel pField;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;        
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolTip controlsTooltip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preset1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preset2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preset3ToolStripMenuItem;
    }
}

