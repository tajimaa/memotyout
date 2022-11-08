using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace memotyout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            //dialog.Title = "ファイルを保存する";
            if (dialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(dialog.FileName, textBox1.Text);
        }

        private void 読み込みToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            //dialog.Title = "ファイルを読み込む";
            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.Text = File.ReadAllText(dialog.FileName);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void 元に戻すToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
