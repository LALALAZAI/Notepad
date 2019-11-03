using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Width = this.Width;
            richTextBox1.Height = this.Height;
            this.Text = "���±�";
            //this.Icon = new Icon("Koala.jpg");
            toolStripStatusLabel1.Text = "��м��±�";
            statusStrip1.Visible = false;
            �Զ�����WToolStripMenuItem.Checked = true;
            richTextBox1.WordWrap = true;
           
            
        }
        private void ��ɫToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
           
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void ����FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Width = this.Width;
            richTextBox1.Height = this.Height;
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("�Ƿ񽫸��ı��棿", "���±�", MessageBoxButtons.YesNoCancel);

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�Ƿ񽫸��ı��棿", "���±�", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else 
            {
                e.Cancel = true;
            }

        }

        

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void ճ��AToolStripMenuItem_Click(object sender, EventArgs e)
        {
             richTextBox1.Paste();
            
        }

        private void ����TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void ����UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void ״̬��SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (״̬��SToolStripMenuItem.Checked == true)
            {
                ״̬��SToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
            else
            {
                ״̬��SToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }
        }

        private void �Զ�����WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (�Զ�����WToolStripMenuItem.Checked == true)
            {
                richTextBox1.WordWrap = false;
                �Զ�����WToolStripMenuItem.Checked = false;
                this.AutoScroll = true;
                //if (richTextBox1.Lines.GetLength(0) < 100) 
                //{
                //    richTextBox1.Text += "\n";
                //}
                
            }
            else
            {
                richTextBox1.WordWrap = true;
                �Զ�����WToolStripMenuItem.Checked = true;
            }
        }

        private void ȫѡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void �½�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //f.MdiParent = this;
            //f.TopMost = true;
            f.Show();
        }

        

        
    }
}