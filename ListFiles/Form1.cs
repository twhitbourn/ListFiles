using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (!String.IsNullOrEmpty(this.tboxFiles.Text))
                {
                    string[] files = tboxFiles.Lines;
                    string dataFormat = DataFormats.FileDrop;
                    DataObject dataObject = new DataObject(dataFormat, files);

                    this.tboxFiles.DoDragDrop(dataObject, DragDropEffects.Copy);
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                this.tboxFiles.SelectAll();
            }
        }
    }
}
