using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            this.Width =800;
            this.Height = 600;
            richTextBox1.Width = this.Width;
            richTextBox1.Height = this.Height;
            this.Text = "记事本";
            //this.Icon = new Icon("Koala.jpg");
            toolStripStatusLabel1.Text = "这叫记事本";
            statusStrip1.Visible = false;
            自动换行WToolStripMenuItem.Checked = true;
            richTextBox1.WordWrap = true;
            DateTime time = System.DateTime.Now;
            toolStripStatusLabel2.Text = time.ToString();
            timer1.Interval = 1000;
            
        }
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置保存类型 文字说明|类型
            saveFileDialog1.Filter = @"文本文件(*.txt)|*.txt|所以格式|*.txt;*.doc;*.cs;*.rtf";

            if (richTextBox1.Text=="") //如果内容为空
            {
                if (openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            else
            {
                if (MessageBox.Show("是否保存当前文件？", "保存为", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==DialogResult.OK)
                {
                    richTextBox1.SaveFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                else
                {
                    richTextBox1.Text = "";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
            }
           
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置保存类型 文字说明|类型
            saveFileDialog1.Filter = @"文本文件(*.txt)|*.txt|所以格式|*.txt;*.doc;*.cs;*.rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void 字体FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //richTextBox1.Width = this.Width;
            //richTextBox1.Height = this.Height;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"文本文件(*.txt)|*.txt|所以格式|*.txt;*.doc;*.cs;*.rtf";
            if (richTextBox1.Text =="")
            {
                System.Environment.Exit(0);
            }
            else
            {
                if (MessageBox.Show("是否将更改保存？", "记事本", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        System.Environment.Exit(0);
                    }
                }
                else
                {
                    System.Environment.Exit(0);
                }             
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            //if (MessageBox.Show("是否将更改保存？", "记事本", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    e.Cancel = false;
            //}
            saveFileDialog1.Filter = @"文本文件(*.txt)|*.txt|所以格式|*.txt;*.doc;*.cs;*.rtf";
            if (richTextBox1.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                if (MessageBox.Show("是否保存文本？", "记事本", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                else
                {
                    e.Cancel = false;
                }
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
                timer1.Enabled = false;
            }
            else
            {
                状态栏SToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
                timer1.Enabled = true;
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
                this.AutoScroll = false;
            }
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置保存类型 文字说明|类型
            saveFileDialog1.Filter = @"文本文件(*.txt)|*.txt|所以格式|*.txt;*.doc;*.cs;*.rtf";
            if (richTextBox1.Text != "")
            {
                if (MessageBox.Show("是否保存当前文件？", "保存为", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
                        richTextBox1.Text = "";
                    }
                    else
                    {
                        richTextBox1.Text = "";
                    }
                }
                else
                {
                    richTextBox1.Text = "";
                }
                
                
                
            }
            else
            {
                richTextBox1.Text = "";
            }
            
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置保存类型 文字说明|类型
            saveFileDialog1.Filter = @"文本文件(*.txt)|*.txt|所以格式|*.txt;*.doc;*.cs;*.rtf";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
            }
        
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            richTextBox1.Width = this.Width;
            richTextBox1.Height = this.Height;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = System.DateTime.Now;
            toolStripStatusLabel2.Text = time.ToString();
        }

        private void 页面设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PrintDocument myDoc = new PrintDocument();

            PageSetupDialog dia = new PageSetupDialog();
            dia.PageSettings = (PageSettings)myDoc.DefaultPageSettings.Clone();
            dia.PageSettings.Margins = PrinterUnitConvert.Convert(dia.PageSettings.Margins, PrinterUnit.Display, PrinterUnit.TenthsOfAMillimeter);

            dia.AllowMargins = true;
            dia.AllowPaper = true;
            dia.AllowPrinter = true;

            if (dia.ShowDialog() == DialogResult.OK)
            {
                myDoc.DefaultPageSettings = dia.PageSettings;
            }
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void 关于记事本AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("个人学习制作Windows记事本,如有不足还请指正！！！ 时间：2019-10-1  作者：江锐","啦啦啦",MessageBoxButtons.OK);
        }

        private void 查看帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("如有疑问还请咨询作者 邮箱地址：1515065962@qq.com", "作者邮箱", MessageBoxButtons.OK);
        }
    }
}