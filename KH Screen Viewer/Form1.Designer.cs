﻿namespace KH_Screen_Viewer
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.closeDisplay = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.ImageButton1 = new System.Windows.Forms.Button();
            this.ImageButton2 = new System.Windows.Forms.Button();
            this.ImageButton3 = new System.Windows.Forms.Button();
            this.ImageButton4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClearButton1 = new System.Windows.Forms.Button();
            this.ClearButton2 = new System.Windows.Forms.Button();
            this.ClearButton3 = new System.Windows.Forms.Button();
            this.ClearButton4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.videoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.22985F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.77014F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.closeDisplay);
            this.flowLayoutPanel1.Controls.Add(this.black);
            this.flowLayoutPanel1.Controls.Add(this.ImageButton1);
            this.flowLayoutPanel1.Controls.Add(this.ImageButton2);
            this.flowLayoutPanel1.Controls.Add(this.ImageButton3);
            this.flowLayoutPanel1.Controls.Add(this.ImageButton4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(140, 363);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(614, 61);
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
            this.ImageButton4.Location = new System.Drawing.Point(3, 65);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 363);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "View Monitor 2";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ClearButton1);
            this.flowLayoutPanel2.Controls.Add(this.ClearButton2);
            this.flowLayoutPanel2.Controls.Add(this.ClearButton3);
            this.flowLayoutPanel2.Controls.Add(this.ClearButton4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(346, 430);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(209, 3, 3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(408, 32);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // ClearButton1
            // 
            this.ClearButton1.Location = new System.Drawing.Point(3, 3);
            this.ClearButton1.Name = "ClearButton1";
            this.ClearButton1.Size = new System.Drawing.Size(97, 29);
            this.ClearButton1.TabIndex = 0;
            this.ClearButton1.Text = "Clear Image";
            this.ClearButton1.UseVisualStyleBackColor = true;
            this.ClearButton1.Click += new System.EventHandler(this.ClearButton1_Click);
            // 
            // ClearButton2
            // 
            this.ClearButton2.Location = new System.Drawing.Point(106, 3);
            this.ClearButton2.Name = "ClearButton2";
            this.ClearButton2.Size = new System.Drawing.Size(97, 29);
            this.ClearButton2.TabIndex = 1;
            this.ClearButton2.Text = "Clear Image";
            this.ClearButton2.UseVisualStyleBackColor = true;
            this.ClearButton2.Click += new System.EventHandler(this.ClearButton2_Click);
            // 
            // ClearButton3
            // 
            this.ClearButton3.Location = new System.Drawing.Point(209, 3);
            this.ClearButton3.Name = "ClearButton3";
            this.ClearButton3.Size = new System.Drawing.Size(97, 29);
            this.ClearButton3.TabIndex = 2;
            this.ClearButton3.Text = "Clear Image";
            this.ClearButton3.UseVisualStyleBackColor = true;
            this.ClearButton3.Click += new System.EventHandler(this.ClearButton3_Click);
            // 
            // ClearButton4
            // 
            this.ClearButton4.Location = new System.Drawing.Point(3, 38);
            this.ClearButton4.Name = "ClearButton4";
            this.ClearButton4.Size = new System.Drawing.Size(97, 29);
            this.ClearButton4.TabIndex = 3;
            this.ClearButton4.Text = "Clear Image";
            this.ClearButton4.UseVisualStyleBackColor = true;
            this.ClearButton4.Click += new System.EventHandler(this.ClearButton4_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.videoButton);
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 430);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(131, 32);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // videoButton
            // 
            this.videoButton.AllowDrop = true;
            this.videoButton.Location = new System.Drawing.Point(3, 3);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(75, 23);
            this.videoButton.TabIndex = 0;
            this.videoButton.Text = "Video";
            this.videoButton.UseVisualStyleBackColor = true;
            this.videoButton.Click += new System.EventHandler(this.videoButton_Click);
            this.videoButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.videoButton_DragDrop);
            this.videoButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.videoButton_DragEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(773, 503);
            this.Name = "Form1";
            this.Text = "KH Screen Viewer";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button ClearButton1;
        private System.Windows.Forms.Button ClearButton2;
        private System.Windows.Forms.Button ClearButton3;
        private System.Windows.Forms.Button ClearButton4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.Button button1;
    }
}

