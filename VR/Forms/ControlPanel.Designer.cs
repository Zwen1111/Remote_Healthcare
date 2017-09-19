﻿namespace VR
{
    partial class ControlPanel
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
            this.AddTree = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Speed_Model_Btn = new System.Windows.Forms.Button();
            this.Add_Terrain_By_Picture_Btn = new System.Windows.Forms.Button();
            this.Add_Standard_Model_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTree
            // 
            this.AddTree.Location = new System.Drawing.Point(12, 41);
            this.AddTree.Name = "AddTree";
            this.AddTree.Size = new System.Drawing.Size(171, 23);
            this.AddTree.TabIndex = 0;
            this.AddTree.Text = "Add model";
            this.AddTree.UseVisualStyleBackColor = true;
            this.AddTree.Click += new System.EventHandler(this.Add_Model_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add terrain";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Terrain_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete model";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete terrain";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add route";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Add_Route_Btn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(186, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Delete route";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Make model follow route";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Model_Follow_Route_Btn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(11, 176);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Add road to route";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Add_Road_Btn_Click);
            // 
            // Speed_Model_Btn
            // 
            this.Speed_Model_Btn.Location = new System.Drawing.Point(12, 234);
            this.Speed_Model_Btn.Name = "Speed_Model_Btn";
            this.Speed_Model_Btn.Size = new System.Drawing.Size(171, 23);
            this.Speed_Model_Btn.TabIndex = 8;
            this.Speed_Model_Btn.Text = "Change speed of model";
            this.Speed_Model_Btn.UseVisualStyleBackColor = true;
            this.Speed_Model_Btn.Click += new System.EventHandler(this.Speed_Model_Btn_Click);
            // 
            // Add_Terrain_By_Picture_Btn
            // 
            this.Add_Terrain_By_Picture_Btn.Location = new System.Drawing.Point(12, 99);
            this.Add_Terrain_By_Picture_Btn.Name = "Add_Terrain_By_Picture_Btn";
            this.Add_Terrain_By_Picture_Btn.Size = new System.Drawing.Size(171, 23);
            this.Add_Terrain_By_Picture_Btn.TabIndex = 9;
            this.Add_Terrain_By_Picture_Btn.Text = "Add terrain by picture";
            this.Add_Terrain_By_Picture_Btn.UseVisualStyleBackColor = true;
            this.Add_Terrain_By_Picture_Btn.Click += new System.EventHandler(this.Add_Terrain_By_Picture_Btn_Click);
            // 
            // Add_Standard_Model_Btn
            // 
            this.Add_Standard_Model_Btn.Location = new System.Drawing.Point(12, 12);
            this.Add_Standard_Model_Btn.Name = "Add_Standard_Model_Btn";
            this.Add_Standard_Model_Btn.Size = new System.Drawing.Size(171, 23);
            this.Add_Standard_Model_Btn.TabIndex = 10;
            this.Add_Standard_Model_Btn.Text = "Add standard model";
            this.Add_Standard_Model_Btn.UseVisualStyleBackColor = true;
            this.Add_Standard_Model_Btn.Click += new System.EventHandler(this.Add_Standard_Model_Btn_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 284);
            this.Controls.Add(this.Add_Standard_Model_Btn);
            this.Controls.Add(this.Add_Terrain_By_Picture_Btn);
            this.Controls.Add(this.Speed_Model_Btn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddTree);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddTree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Speed_Model_Btn;
        private System.Windows.Forms.Button Add_Terrain_By_Picture_Btn;
        private System.Windows.Forms.Button Add_Standard_Model_Btn;
    }
}