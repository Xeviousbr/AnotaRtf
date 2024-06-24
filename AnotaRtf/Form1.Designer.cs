
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIncreaseFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDecreaseFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.tsVermelho = new System.Windows.Forms.ToolStripButton();
            this.tsAzul = new System.Windows.Forms.ToolStripButton();
            this.tsVerde = new System.Windows.Forms.ToolStripButton();
            this.tsLaranja = new System.Windows.Forms.ToolStripButton();
            this.tsPreto = new System.Windows.Forms.ToolStripButton();
            this.tsCinza = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.rtf1 = new System.Windows.Forms.RichTextBox();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.rtf2 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbModif = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonUnderline,
            this.toolStripButtonIncreaseFont,
            this.toolStripButtonDecreaseFont,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo,
            this.tsVermelho,
            this.tsAzul,
            this.tsVerde,
            this.tsLaranja,
            this.tsPreto,
            this.tsCinza,
            this.lbModif});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBold.Image")));
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBold.Text = "Negrito";
            this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonItalic.Image")));
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonItalic.Text = "Itálico";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnderline.Image")));
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUnderline.Text = "Sublinhado";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonUnderline_Click);
            // 
            // toolStripButtonIncreaseFont
            // 
            this.toolStripButtonIncreaseFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIncreaseFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIncreaseFont.Image")));
            this.toolStripButtonIncreaseFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIncreaseFont.Name = "toolStripButtonIncreaseFont";
            this.toolStripButtonIncreaseFont.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonIncreaseFont.Text = "Aumentar Fonte";
            this.toolStripButtonIncreaseFont.Click += new System.EventHandler(this.toolStripButtonIncreaseFont_Click);
            // 
            // toolStripButtonDecreaseFont
            // 
            this.toolStripButtonDecreaseFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDecreaseFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDecreaseFont.Image")));
            this.toolStripButtonDecreaseFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDecreaseFont.Name = "toolStripButtonDecreaseFont";
            this.toolStripButtonDecreaseFont.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDecreaseFont.Text = "Reduzir Fonte";
            this.toolStripButtonDecreaseFont.Click += new System.EventHandler(this.toolStripButtonDecreaseFont_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUndo.Text = "Desfazer";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRedo.Text = "Refazer";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // tsVermelho
            // 
            this.tsVermelho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsVermelho.Image = ((System.Drawing.Image)(resources.GetObject("tsVermelho.Image")));
            this.tsVermelho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVermelho.Name = "tsVermelho";
            this.tsVermelho.Size = new System.Drawing.Size(23, 22);
            this.tsVermelho.Text = "Vermelho";
            this.tsVermelho.Click += new System.EventHandler(this.tsVermelho_Click);
            // 
            // tsAzul
            // 
            this.tsAzul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAzul.Image = ((System.Drawing.Image)(resources.GetObject("tsAzul.Image")));
            this.tsAzul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAzul.Name = "tsAzul";
            this.tsAzul.Size = new System.Drawing.Size(23, 22);
            this.tsAzul.Text = "Azul";
            this.tsAzul.Click += new System.EventHandler(this.tsAzul_Click);
            // 
            // tsVerde
            // 
            this.tsVerde.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsVerde.Image = ((System.Drawing.Image)(resources.GetObject("tsVerde.Image")));
            this.tsVerde.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVerde.Name = "tsVerde";
            this.tsVerde.Size = new System.Drawing.Size(23, 22);
            this.tsVerde.Text = "Verde";
            this.tsVerde.Click += new System.EventHandler(this.tsVerde_Click);
            // 
            // tsLaranja
            // 
            this.tsLaranja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLaranja.Image = ((System.Drawing.Image)(resources.GetObject("tsLaranja.Image")));
            this.tsLaranja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLaranja.Name = "tsLaranja";
            this.tsLaranja.Size = new System.Drawing.Size(23, 22);
            this.tsLaranja.Text = "Laranja";
            this.tsLaranja.Click += new System.EventHandler(this.tsLaranja_Click);
            // 
            // tsPreto
            // 
            this.tsPreto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPreto.Image = ((System.Drawing.Image)(resources.GetObject("tsPreto.Image")));
            this.tsPreto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPreto.Name = "tsPreto";
            this.tsPreto.Size = new System.Drawing.Size(23, 22);
            this.tsPreto.Text = "Preto";
            this.tsPreto.Click += new System.EventHandler(this.tsPreto_Click);
            // 
            // tsCinza
            // 
            this.tsCinza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCinza.Image = ((System.Drawing.Image)(resources.GetObject("tsCinza.Image")));
            this.tsCinza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCinza.Name = "tsCinza";
            this.tsCinza.Size = new System.Drawing.Size(23, 22);
            this.tsCinza.Text = "toolStripButton6";
            this.tsCinza.Click += new System.EventHandler(this.tsCinza_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tb1);
            this.tabControl.Controls.Add(this.tb2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 425);
            this.tabControl.TabIndex = 2;
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.rtf1);
            this.tb1.Location = new System.Drawing.Point(4, 24);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(792, 397);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Aba Um";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // rtf1
            // 
            this.rtf1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtf1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtf1.Location = new System.Drawing.Point(3, 3);
            this.rtf1.Name = "rtf1";
            this.rtf1.Size = new System.Drawing.Size(786, 391);
            this.rtf1.TabIndex = 0;
            this.rtf1.Text = "";
            this.rtf1.TextChanged += new System.EventHandler(this.rtf1_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Controls.Add(this.rtf2);
            this.tb2.Location = new System.Drawing.Point(4, 24);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(792, 397);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "+";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // rtf2
            // 
            this.rtf2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtf2.Location = new System.Drawing.Point(3, 3);
            this.rtf2.Name = "rtf2";
            this.rtf2.Size = new System.Drawing.Size(786, 391);
            this.rtf2.TabIndex = 0;
            this.rtf2.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbModif
            // 
            this.lbModif.Name = "lbModif";
            this.lbModif.Size = new System.Drawing.Size(68, 22);
            this.lbModif.Text = "Modificado";
            this.lbModif.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AnoteitoRtf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            this.tb2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderline;
        private System.Windows.Forms.ToolStripButton toolStripButtonIncreaseFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonDecreaseFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.ToolStripButton tsVermelho;
        private System.Windows.Forms.ToolStripButton tsAzul;
        private System.Windows.Forms.ToolStripButton tsVerde;
        private System.Windows.Forms.ToolStripButton tsLaranja;
        private System.Windows.Forms.ToolStripButton tsPreto;
        private System.Windows.Forms.ToolStripButton tsCinza;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.RichTextBox rtf1;
        private System.Windows.Forms.RichTextBox rtf2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel lbModif;
    }
}

