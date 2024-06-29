using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AnotaRtf
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            editRtf1.Carregar(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "anotacoes.rtf"));
        }
    }
}
