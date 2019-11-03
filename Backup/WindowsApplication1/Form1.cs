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
            this.Text = "记事本";
            //this.Icon = new Icon("Koala.jpg");
            toolStripStatusLabel1.Text = "这叫记事本";
            statusStrip1.Visible = false;
            自动换行WToolStripMenuItem.Checked = true;
            richTextBox1.WordWrap = true;
           
            
        }
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
           
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void 字体FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Width = this.Width;
            richTextBox1.Height = this.Height;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("是否将更改保存？", "记事本", MessageBoxButtons.YesNoCancel);

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否将更改保存？", "记事本", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else 
            {
                e.Cancel = true;
            }

        }

        

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 粘贴AToolStripMenuItem_Click(object sender, EventArgs e)
        {
             richTextBox1.Paste();
            
        }

        private void 剪贴TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 撤销UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 状态栏SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (状态栏SToolStripMenuItem.Checked == true)
            {
                状态栏SToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
            else
            {
                状态栏SToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }
        }

        private void 自动换行WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行WToolStripMenuItem.Checked == true)
            {
                richTextBox1.WordWrap = false;
                自动换行WToolStripMenuItem.Checked = false;
                this.AutoScroll = true;
                //if (richTextBox1.Lines.GetLength(0) < 100) 
                //{
                //    richTextBox1.Text += "\n";
                //}
                
            }
            else
            {
                richTextBox1.WordWrap = true;
                自动换行WToolStripMenuItem.Checked = true;
            }
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
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