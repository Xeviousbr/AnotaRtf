using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotaRtf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            if (rtf1.SelectionFont != null)
            {
                FontStyle currentStyle = rtf1.SelectionFont.Style;
                FontStyle newStyle;
                if (rtf1.SelectionFont.Bold)
                {
                    newStyle = currentStyle & ~FontStyle.Bold;
                }
                else
                {
                    newStyle = currentStyle | FontStyle.Bold;
                }
                rtf1.SelectionFont = new Font(rtf1.SelectionFont.FontFamily, rtf1.SelectionFont.Size, newStyle);
            }
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            if (rtf1.SelectionFont != null)
            {
                FontStyle currentStyle = rtf1.SelectionFont.Style;
                FontStyle newStyle;
                if (rtf1.SelectionFont.Italic)
                {
                    newStyle = currentStyle & ~FontStyle.Italic;
                }
                else
                {
                    newStyle = currentStyle | FontStyle.Italic;
                }
                rtf1.SelectionFont = new Font(rtf1.SelectionFont.FontFamily, rtf1.SelectionFont.Size, newStyle);
            }
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            if (rtf1.SelectionFont != null)
            {
                FontStyle currentStyle = rtf1.SelectionFont.Style;
                FontStyle newStyle;
                if (rtf1.SelectionFont.Underline)
                {
                    newStyle = currentStyle & ~FontStyle.Underline;
                }
                else
                {
                    newStyle = currentStyle | FontStyle.Underline;
                }
                rtf1.SelectionFont = new Font(rtf1.SelectionFont.FontFamily, rtf1.SelectionFont.Size, newStyle);
            }
        }

        private void toolStripButtonIncreaseFont_Click(object sender, EventArgs e)
        {
            float newSize = this.rtf1.SelectionFont.Size + 1;
            this.rtf1.SelectionFont = new Font(this.rtf1.SelectionFont.FontFamily, newSize, this.rtf1.SelectionFont.Style);
        }

        private void toolStripButtonDecreaseFont_Click(object sender, EventArgs e)
        {
            float newSize = this.rtf1.SelectionFont.Size - 1;
            this.rtf1.SelectionFont = new Font(this.rtf1.SelectionFont.FontFamily, Math.Max(newSize, 1), this.rtf1.SelectionFont.Style); // Garante que o tamanho mínimo seja 1
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            if (rtf1.CanUndo)
            {
                rtf1.Undo();
            }
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            if (rtf1.CanRedo)
            {
                rtf1.Redo();
            }
        }

        private void tsVermelho_Click(object sender, EventArgs e)
        {
            rtf1.SelectionColor = Color.Red;
        }

        private void tsAzul_Click(object sender, EventArgs e)
        {
            rtf1.SelectionColor = Color.Blue;
        }

        private void tsVerde_Click(object sender, EventArgs e)
        {
            rtf1.SelectionColor = Color.Green;
        }

        private void tsLaranja_Click(object sender, EventArgs e)
        {
            rtf1.SelectionColor = Color.Orange;
        }

        private void tsPreto_Click(object sender, EventArgs e)
        {
            rtf1.SelectionColor = Color.Black;
        }

        private void tsCinza_Click(object sender, EventArgs e)
        {
            rtf1.SelectionColor = Color.Gray;
        }
    }
}
