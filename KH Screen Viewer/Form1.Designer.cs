namespace KH_Screen_Viewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.closeDisplay = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.ImageButton1 = new System.Windows.Forms.Button();
            this.ImageButton2 = new System.Windows.Forms.Button();
            this.ImageButton3 = new System.Windows.Forms.Button();
            this.ImageButton4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 394);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "View Monitor 2";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.closeDisplay);
            this.flowLayoutPanel1.Controls.Add(this.black);
            this.flowLayoutPanel1.Controls.Add(this.ImageButton1);
            this.flowLayoutPanel1.Controls.Add(this.ImageButton2);
            this.flowLayoutPanel1.Controls.Add(this.ImageButton3);
            this.flowLayoutPanel1.Controls.Add(this.ImageButton4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(116, 394);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(638, 68);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // closeDisplay
            // 
            this.closeDisplay.AutoSize = true;
            this.closeDisplay.Location = new System.Drawing.Point(3, 3);
            this.closeDisplay.Name = "closeDisplay";
            this.closeDisplay.Size = new System.Drawing.Size(97, 56);
            this.closeDisplay.TabIndex = 3;
            this.closeDisplay.Text = "Clear";
            this.closeDisplay.UseVisualStyleBackColor = true;
            this.closeDisplay.Click += new System.EventHandler(this.closeDisplay_Click);
            // 
            // black
            // 
            this.black.AutoSize = true;
            this.black.Location = new System.Drawing.Point(106, 3);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(97, 56);
            this.black.TabIndex = 2;
            this.black.Text = "Black";
            this.black.UseVisualStyleBackColor = true;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // ImageButton1
            // 
            this.ImageButton1.AllowDrop = true;
            this.ImageButton1.AutoSize = true;
            this.ImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImageButton1.Location = new System.Drawing.Point(209, 3);
            this.ImageButton1.Name = "ImageButton1";
            this.ImageButton1.Size = new System.Drawing.Size(97, 56);
            this.ImageButton1.TabIndex = 1;
            this.ImageButton1.Text = "Image 1";
            this.ImageButton1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ImageButton1.UseVisualStyleBackColor = true;
            this.ImageButton1.Click += new System.EventHandler(this.ImageButton1_Click);
            this.ImageButton1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImageButton1_DragDrop);
            this.ImageButton1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImageButton1_DragEnter);
            // 
            // ImageButton2
            // 
            this.ImageButton2.AllowDrop = true;
            this.ImageButton2.AutoSize = true;
            this.ImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImageButton2.Location = new System.Drawing.Point(312, 3);
            this.ImageButton2.Name = "ImageButton2";
            this.ImageButton2.Size = new System.Drawing.Size(97, 56);
            this.ImageButton2.TabIndex = 4;
            this.ImageButton2.Text = "Image 2";
            this.ImageButton2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ImageButton2.UseVisualStyleBackColor = true;
            this.ImageButton2.Click += new System.EventHandler(this.ImageButton2_Click);
            this.ImageButton2.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImageButton2_DragDrop);
            this.ImageButton2.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImageButton2_DragEnter);
            // 
            // ImageButton3
            // 
            this.ImageButton3.AllowDrop = true;
            this.ImageButton3.AutoSize = true;
            this.ImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImageButton3.Location = new System.Drawing.Point(415, 3);
            this.ImageButton3.Name = "ImageButton3";
            this.ImageButton3.Size = new System.Drawing.Size(97, 56);
            this.ImageButton3.TabIndex = 5;
            this.ImageButton3.Text = "Image 3";
            this.ImageButton3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ImageButton3.UseVisualStyleBackColor = true;
            this.ImageButton3.Click += new System.EventHandler(this.ImageButton3_Click);
            this.ImageButton3.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImageButton3_DragDrop);
            this.ImageButton3.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImageButton3_DragEnter);
            // 
            // ImageButton4
            // 
            this.ImageButton4.AllowDrop = true;
            this.ImageButton4.AutoSize = true;
            this.ImageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImageButton4.Location = new System.Drawing.Point(518, 3);
            this.ImageButton4.Name = "ImageButton4";
            this.ImageButton4.Size = new System.Drawing.Size(97, 56);
            this.ImageButton4.TabIndex = 6;
            this.ImageButton4.Text = "Image 4";
            this.ImageButton4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ImageButton4.UseVisualStyleBackColor = true;
            this.ImageButton4.Click += new System.EventHandler(this.ImageButton4_Click);
            this.ImageButton4.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImageButton4_DragDrop);
            this.ImageButton4.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImageButton4_DragEnter);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "KH Screen Viewer";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ImageButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button closeDisplay;
        private System.Windows.Forms.Button ImageButton2;
        private System.Windows.Forms.Button ImageButton3;
        private System.Windows.Forms.Button ImageButton4;
    }
}

