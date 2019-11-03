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
            this.Text = "���±�";
            //this.Icon = new Icon("Koala.jpg");
            toolStripStatusLabel1.Text = "��м��±�";
            statusStrip1.Visible = false;
            �Զ�����WToolStripMenuItem.Checked = true;
            richTextBox1.WordWrap = true;
            DateTime time = System.DateTime.Now;
            toolStripStatusLabel2.Text = time.ToString();
            timer1.Interval = 1000;
            
        }
        private void ��ɫToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���ñ������� ����˵��|����
            saveFileDialog1.Filter = @"�ı��ļ�(*.txt)|*.txt|���Ը�ʽ|*.txt;*.doc;*.cs;*.rtf";

            if (richTextBox1.Text=="") //�������Ϊ��
            {
                if (openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            else
            {
                if (MessageBox.Show("�Ƿ񱣴浱ǰ�ļ���", "����Ϊ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==DialogResult.OK)
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

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���ñ������� ����˵��|����
            saveFileDialog1.Filter = @"�ı��ļ�(*.txt)|*.txt|���Ը�ʽ|*.txt;*.doc;*.cs;*.rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void ����FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //richTextBox1.Width = this.Width;
            //richTextBox1.Height = this.Height;
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"�ı��ļ�(*.txt)|*.txt|���Ը�ʽ|*.txt;*.doc;*.cs;*.rtf";
            if (richTextBox1.Text =="")
            {
                System.Environment.Exit(0);
            }
            else
            {
                if (MessageBox.Show("�Ƿ񽫸��ı��棿", "���±�", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            
            //if (MessageBox.Show("�Ƿ񽫸��ı��棿", "���±�", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    e.Cancel = false;
            //}
            saveFileDialog1.Filter = @"�ı��ļ�(*.txt)|*.txt|���Ը�ʽ|*.txt;*.doc;*.cs;*.rtf";
            if (richTextBox1.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                if (MessageBox.Show("�Ƿ񱣴��ı���", "���±�", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                timer1.Enabled = false;
            }
            else
            {
                ״̬��SToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
                timer1.Enabled = true;
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
                this.AutoScroll = false;
            }
        }

        private void ȫѡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void �½�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���ñ������� ����˵��|����
            saveFileDialog1.Filter = @"�ı��ļ�(*.txt)|*.txt|���Ը�ʽ|*.txt;*.doc;*.cs;*.rtf";
            if (richTextBox1.Text != "")
            {
                if (MessageBox.Show("�Ƿ񱣴浱ǰ�ļ���", "����Ϊ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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

        private void ���ΪToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���ñ������� ����˵��|����
            saveFileDialog1.Filter = @"�ı��ļ�(*.txt)|*.txt|���Ը�ʽ|*.txt;*.doc;*.cs;*.rtf";
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

        private void ҳ������ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ��ӡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void ���ڼ��±�AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����ѧϰ����Windows���±�,���в��㻹��ָ�������� ʱ�䣺2019-10-1  ���ߣ�����","������",MessageBoxButtons.OK);
        }

        private void �鿴����HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������ʻ�����ѯ���� �����ַ��1515065962@qq.com", "��������", MessageBoxButtons.OK);
        }
    }
}