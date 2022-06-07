
namespace SupermarketManagementSystem
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.progressBar1.Location = new System.Drawing.Point(0, 542);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(900, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(120, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 96);
            this.label1.TabIndex = 4;
            this.label1.Text = "Family Supermarket";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2ImageCheckBox1
            // 
            this.guna2ImageCheckBox1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageCheckBox1.CheckedState.Image")));
            this.guna2ImageCheckBox1.CheckedState.ImageSize = new System.Drawing.Size(128, 128);
            this.guna2ImageCheckBox1.CheckedState.Parent = this.guna2ImageCheckBox1;
            this.guna2ImageCheckBox1.HoverState.Parent = this.guna2ImageCheckBox1;
            this.guna2ImageCheckBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageCheckBox1.Image")));
            this.guna2ImageCheckBox1.ImageSize = new System.Drawing.Size(128, 128);
            this.guna2ImageCheckBox1.IndicateFocus = false;
            this.guna2ImageCheckBox1.Location = new System.Drawing.Point(445, 249);
            this.guna2ImageCheckBox1.Name = "guna2ImageCheckBox1";
            this.guna2ImageCheckBox1.PressedState.Parent = this.guna2ImageCheckBox1;
            this.guna2ImageCheckBox1.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageCheckBox1.TabIndex = 7;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.guna2ImageCheckBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox1;
    }
}