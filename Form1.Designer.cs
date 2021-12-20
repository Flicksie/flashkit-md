using System;
using System.Drawing;
using System.Windows.Forms;

namespace flashkit_md
{

    public class AdvancedImageButton : Button
    {

        public Image HoverImage { get; set; }
        public Image PlainImage { get; set; }
        public Image PressedImage { get; set; }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            if (HoverImage == null) return;
            if (PlainImage == null) PlainImage = base.BackgroundImage;
            base.BackgroundImage = HoverImage;
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            if (HoverImage == null) return;
            base.BackgroundImage = PlainImage;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (PressedImage == null) return;
            if (PlainImage == null) PlainImage = base.BackgroundImage;
            base.BackgroundImage = PressedImage;
        }
    }

    partial class Form1
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_wr_rom = new flashkit_md.AdvancedImageButton();
            this.btn_rd_ram = new flashkit_md.AdvancedImageButton();
            this.btn_rd_rom = new flashkit_md.AdvancedImageButton();
            this.btn_wr_ram = new flashkit_md.AdvancedImageButton();
            this.btn_check = new flashkit_md.AdvancedImageButton();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(12, 388);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(505, 21);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 30;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.consoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.consoleBox.Location = new System.Drawing.Point(238, 33);
            this.consoleBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(463, 324);
            this.consoleBox.TabIndex = 4;
            this.consoleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(656, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Form1_Click);
            // 
            // btn_wr_rom
            // 
            this.btn_wr_rom.AllowDrop = true;
            this.btn_wr_rom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_wr_rom.BackgroundImage")));
            this.btn_wr_rom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_wr_rom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_wr_rom.FlatAppearance.BorderSize = 0;
            this.btn_wr_rom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wr_rom.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wr_rom.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_wr_rom.HoverImage = global::flashkit_md.Properties.Resources.but2;
            this.btn_wr_rom.Image = global::flashkit_md.Properties.Resources.rom_in;
            this.btn_wr_rom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_wr_rom.Location = new System.Drawing.Point(11, 96);
            this.btn_wr_rom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_wr_rom.Name = "btn_wr_rom";
            this.btn_wr_rom.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_wr_rom.PlainImage = null;
            this.btn_wr_rom.PressedImage = global::flashkit_md.Properties.Resources.but3;
            this.btn_wr_rom.Size = new System.Drawing.Size(217, 56);
            this.btn_wr_rom.TabIndex = 1;
            this.btn_wr_rom.Text = "Write ROM";
            this.btn_wr_rom.UseVisualStyleBackColor = true;
            this.btn_wr_rom.Click += new System.EventHandler(this.btn_wr_rom_Click);
            // 
            // btn_rd_ram
            // 
            this.btn_rd_ram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rd_ram.BackgroundImage")));
            this.btn_rd_ram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rd_ram.FlatAppearance.BorderSize = 0;
            this.btn_rd_ram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rd_ram.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rd_ram.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_rd_ram.HoverImage = global::flashkit_md.Properties.Resources.but2;
            this.btn_rd_ram.Image = global::flashkit_md.Properties.Resources.sram_out;
            this.btn_rd_ram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rd_ram.Location = new System.Drawing.Point(12, 164);
            this.btn_rd_ram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_rd_ram.Name = "btn_rd_ram";
            this.btn_rd_ram.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_rd_ram.PlainImage = null;
            this.btn_rd_ram.PressedImage = global::flashkit_md.Properties.Resources.but3;
            this.btn_rd_ram.Size = new System.Drawing.Size(216, 56);
            this.btn_rd_ram.TabIndex = 2;
            this.btn_rd_ram.Text = "Read RAM";
            this.btn_rd_ram.UseVisualStyleBackColor = true;
            this.btn_rd_ram.Click += new System.EventHandler(this.btn_rd_ram_Click);
            // 
            // btn_rd_rom
            // 
            this.btn_rd_rom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rd_rom.BackgroundImage")));
            this.btn_rd_rom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rd_rom.FlatAppearance.BorderSize = 0;
            this.btn_rd_rom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rd_rom.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rd_rom.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_rd_rom.HoverImage = global::flashkit_md.Properties.Resources.but2;
            this.btn_rd_rom.Image = global::flashkit_md.Properties.Resources.rom_out;
            this.btn_rd_rom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rd_rom.Location = new System.Drawing.Point(11, 35);
            this.btn_rd_rom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_rd_rom.Name = "btn_rd_rom";
            this.btn_rd_rom.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_rd_rom.PlainImage = global::flashkit_md.Properties.Resources.but1;
            this.btn_rd_rom.PressedImage = global::flashkit_md.Properties.Resources.but3;
            this.btn_rd_rom.Size = new System.Drawing.Size(217, 56);
            this.btn_rd_rom.TabIndex = 0;
            this.btn_rd_rom.Text = "Read ROM";
            this.btn_rd_rom.UseVisualStyleBackColor = true;
            this.btn_rd_rom.Click += new System.EventHandler(this.btn_rd_rom_Click);
            // 
            // btn_wr_ram
            // 
            this.btn_wr_ram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_wr_ram.BackgroundImage")));
            this.btn_wr_ram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_wr_ram.FlatAppearance.BorderSize = 0;
            this.btn_wr_ram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wr_ram.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wr_ram.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_wr_ram.HoverImage = global::flashkit_md.Properties.Resources.but2;
            this.btn_wr_ram.Image = global::flashkit_md.Properties.Resources.sram_in;
            this.btn_wr_ram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_wr_ram.Location = new System.Drawing.Point(12, 224);
            this.btn_wr_ram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_wr_ram.Name = "btn_wr_ram";
            this.btn_wr_ram.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_wr_ram.PlainImage = null;
            this.btn_wr_ram.PressedImage = global::flashkit_md.Properties.Resources.but3;
            this.btn_wr_ram.Size = new System.Drawing.Size(217, 56);
            this.btn_wr_ram.TabIndex = 3;
            this.btn_wr_ram.Text = "Write RAM";
            this.btn_wr_ram.UseVisualStyleBackColor = true;
            this.btn_wr_ram.Click += new System.EventHandler(this.btn_wr_ram_Click);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_check.BackgroundImage")));
            this.btn_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_check.HoverImage = global::flashkit_md.Properties.Resources.but2;
            this.btn_check.Image = global::flashkit_md.Properties.Resources.cart;
            this.btn_check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_check.Location = new System.Drawing.Point(12, 295);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_check.Name = "btn_check";
            this.btn_check.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_check.PlainImage = null;
            this.btn_check.PressedImage = global::flashkit_md.Properties.Resources.but3;
            this.btn_check.Size = new System.Drawing.Size(216, 56);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "Cart info";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::flashkit_md.Properties.Resources.bkg;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(725, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_wr_rom);
            this.Controls.Add(this.btn_rd_ram);
            this.Controls.Add(this.btn_rd_rom);
            this.Controls.Add(this.btn_wr_ram);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.progressBar1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flashkit-md";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private AdvancedImageButton btn_rd_rom;
        private AdvancedImageButton btn_wr_rom;
        private AdvancedImageButton btn_check;
        private AdvancedImageButton btn_wr_ram;
        private AdvancedImageButton btn_rd_ram;
        private Button button1;
    }
}

