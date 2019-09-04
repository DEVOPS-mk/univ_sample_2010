namespace Univer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem1
            // 
            this.MenuItem1.AutoToolTip = true;
            this.MenuItem1.Checked = true;
            this.MenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StMenuItem,
            this.ProfMenuItem,
            this.LesMenuItem});
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.RightToLeftAutoMirrorImage = true;
            this.MenuItem1.Size = new System.Drawing.Size(36, 20);
            this.MenuItem1.Text = "منو";
            this.MenuItem1.ToolTipText = "منو";
            // 
            // StMenuItem
            // 
            this.StMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddsMenuItem,
            this.ShowMenuItem});
            this.StMenuItem.Name = "StMenuItem";
            this.StMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StMenuItem.Text = "دانشجو";
            this.StMenuItem.Click += new System.EventHandler(this.StMenuItem_Click);
            // 
            // AddsMenuItem
            // 
            this.AddsMenuItem.Name = "AddsMenuItem";
            this.AddsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddsMenuItem.Text = "مشاهده";
            this.AddsMenuItem.Click += new System.EventHandler(this.AddsMenuItem_Click);
            // 
            // ShowMenuItem
            // 
            this.ShowMenuItem.Name = "ShowMenuItem";
            this.ShowMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ShowMenuItem.Text = "افزودن";
            this.ShowMenuItem.Click += new System.EventHandler(this.ShowMenuItem_Click);
            // 
            // ProfMenuItem
            // 
            this.ProfMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPMenuItem1,
            this.ShowMenuItem1});
            this.ProfMenuItem.Name = "ProfMenuItem";
            this.ProfMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ProfMenuItem.Text = "استاد";
            // 
            // AddPMenuItem1
            // 
            this.AddPMenuItem1.Name = "AddPMenuItem1";
            this.AddPMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.AddPMenuItem1.Text = "افزودن";
            this.AddPMenuItem1.Click += new System.EventHandler(this.AddPMenuItem1_Click);
            // 
            // ShowMenuItem1
            // 
            this.ShowMenuItem1.Name = "ShowMenuItem1";
            this.ShowMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ShowMenuItem1.Text = "مشاهده";
            this.ShowMenuItem1.Click += new System.EventHandler(this.ShowMenuItem1_Click);
            // 
            // LesMenuItem
            // 
            this.LesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLMenuItem2,
            this.ShowLMenuItem2});
            this.LesMenuItem.Name = "LesMenuItem";
            this.LesMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LesMenuItem.Text = "درس";
            // 
            // addLMenuItem2
            // 
            this.addLMenuItem2.Name = "addLMenuItem2";
            this.addLMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.addLMenuItem2.Text = "افزودن";
            // 
            // ShowLMenuItem2
            // 
            this.ShowLMenuItem2.Name = "ShowLMenuItem2";
            this.ShowLMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.ShowLMenuItem2.Text = "مشاهده";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(399, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "تست پایگاه داده ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(413, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "با تکنولوژی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(966, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem StMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ShowMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addLMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ShowLMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

