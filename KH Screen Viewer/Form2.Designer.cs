namespace KH_Screen_Viewer
{
    partial class Form2
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.displayBox1 = new System.Windows.Forms.PictureBox();
            this.VLCPlugin = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlugin)).BeginInit();
            this.SuspendLayout();
            // 
            // displayBox1
            // 
            this.displayBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.displayBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayBox1.Location = new System.Drawing.Point(0, 0);
            this.displayBox1.Name = "displayBox1";
            this.displayBox1.Size = new System.Drawing.Size(800, 450);
            this.displayBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayBox1.TabIndex = 0;
            this.displayBox1.TabStop = false;
            // 
            // VLCPlugin
            // 
            this.VLCPlugin.Enabled = true;
            this.VLCPlugin.Location = new System.Drawing.Point(0, 0);
            this.VLCPlugin.Name = "VLCPlugin";
            this.VLCPlugin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VLCPlugin.OcxState")));
            this.VLCPlugin.Size = new System.Drawing.Size(800, 449);
            this.VLCPlugin.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VLCPlugin);
            this.Controls.Add(this.displayBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.displayBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlugin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox displayBox1;
        public AxAXVLC.AxVLCPlugin2 VLCPlugin;
    }
}