﻿namespace Vehicle
{
    partial class Vehicle
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
            this.StartBt = new System.Windows.Forms.Button();
            this.Bicycle = new System.Windows.Forms.PictureBox();
            this.Plane = new System.Windows.Forms.PictureBox();
            this.Toyata = new System.Windows.Forms.PictureBox();
            this.Bmw = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bicycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toyata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmw)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBt
            // 
            this.StartBt.Location = new System.Drawing.Point(241, 230);
            this.StartBt.Name = "StartBt";
            this.StartBt.Size = new System.Drawing.Size(74, 48);
            this.StartBt.TabIndex = 4;
            this.StartBt.Text = "StartHere";
            this.StartBt.UseVisualStyleBackColor = true;
            this.StartBt.Click += new System.EventHandler(this.StartBt_Click);
            // 
            // Bicycle
            // 
            this.Bicycle.Image = global::Vehicle.Properties.Resources.Bicycle;
            this.Bicycle.Location = new System.Drawing.Point(9, 366);
            this.Bicycle.Name = "Bicycle";
            this.Bicycle.Size = new System.Drawing.Size(127, 75);
            this.Bicycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bicycle.TabIndex = 3;
            this.Bicycle.TabStop = false;
            // 
            // Plane
            // 
            this.Plane.Image = global::Vehicle.Properties.Resources.Plane;
            this.Plane.Location = new System.Drawing.Point(11, 255);
            this.Plane.Name = "Plane";
            this.Plane.Size = new System.Drawing.Size(126, 93);
            this.Plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Plane.TabIndex = 2;
            this.Plane.TabStop = false;
            // 
            // Toyata
            // 
            this.Toyata.Image = global::Vehicle.Properties.Resources.Toyato;
            this.Toyata.Location = new System.Drawing.Point(10, 132);
            this.Toyata.Name = "Toyata";
            this.Toyata.Size = new System.Drawing.Size(127, 105);
            this.Toyata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Toyata.TabIndex = 1;
            this.Toyata.TabStop = false;
            // 
            // Bmw
            // 
            this.Bmw.Image = global::Vehicle.Properties.Resources.Bmw;
            this.Bmw.Location = new System.Drawing.Point(9, 9);
            this.Bmw.Name = "Bmw";
            this.Bmw.Size = new System.Drawing.Size(129, 109);
            this.Bmw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bmw.TabIndex = 0;
            this.Bmw.TabStop = false;
            this.Bmw.Click += new System.EventHandler(this.Bmw_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(436, 228);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(143, 20);
            this.TextBox.TabIndex = 6;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Bt
            // 
            this.Bt.Location = new System.Drawing.Point(430, 176);
            this.Bt.Name = "Bt";
            this.Bt.Size = new System.Drawing.Size(68, 40);
            this.Bt.TabIndex = 7;
            this.Bt.Text = "Bt";
            this.Bt.UseVisualStyleBackColor = true;
            this.Bt.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.Bt);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.StartBt);
            this.Controls.Add(this.Bicycle);
            this.Controls.Add(this.Plane);
            this.Controls.Add(this.Toyata);
            this.Controls.Add(this.Bmw);
            this.Name = "Vehicle";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.Bicycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toyata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bmw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bmw;
        private System.Windows.Forms.PictureBox Toyata;
        private System.Windows.Forms.PictureBox Plane;
        private System.Windows.Forms.PictureBox Bicycle;
        private System.Windows.Forms.Button StartBt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Bt;
    }
}

