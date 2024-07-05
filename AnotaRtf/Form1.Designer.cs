
using System;

namespace AnotaRtf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.rtf2 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.editRtf1 = new EditRtf.EditRtf();
            this.tabControl.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tb1);
            this.tabControl.Controls.Add(this.tb2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 2;
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.editRtf1);
            this.tb1.Location = new System.Drawing.Point(4, 24);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(792, 422);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Aba Um";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // tb2
            // 
            this.tb2.Controls.Add(this.rtf2);
            this.tb2.Location = new System.Drawing.Point(4, 24);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(792, 422);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "+";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // rtf2
            // 
            this.rtf2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtf2.Location = new System.Drawing.Point(3, 3);
            this.rtf2.Name = "rtf2";
            this.rtf2.Size = new System.Drawing.Size(786, 416);
            this.rtf2.TabIndex = 0;
            this.rtf2.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // editRtf1
            // 
            this.editRtf1.Criptografato = false;
            this.editRtf1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editRtf1.Location = new System.Drawing.Point(3, 3);
            this.editRtf1.Name = "editRtf1";
            this.editRtf1.Size = new System.Drawing.Size(786, 416);
            this.editRtf1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AnoteitoRtf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            this.tb2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.RichTextBox rtf2;
        private System.Windows.Forms.Timer timer1;
        private EditRtf.EditRtf editRtf1;
    }
}

