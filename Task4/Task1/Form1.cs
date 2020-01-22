using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(helpTextbox.Text) && !String.IsNullOrEmpty(openFileDialog.FileName))
            {
                System.IO.File.WriteAllText(openFileDialog.FileName, view_richTextBox.Text + "\r\n" + helpTextbox.Text);
                view_richTextBox.Lines = File.ReadAllLines(openFileDialog.FileName).ToArray();
                MessageBox.Show("Файл успешно отредактирован");
            }
            else
            {
                MessageBox.Show("Пустая строка или файл для редактирования не выбран");
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            openFileDialog.FileName = "SiteList";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                checkGroupTextbox.Text = openFileDialog.FileName;
                view_richTextBox.Lines = File.ReadAllLines(openFileDialog.FileName).ToArray();
            }
        }

        private void checkGroup_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(openFileDialog.FileName))
            {
                CheckNetwork check = new CheckNetwork();
                List<string> results = check.CheckGroup(checkGroupTextbox.Text);
                foreach (string s in results)
                {
                    resultTextBox.AppendText(s);
                }
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(helpTextbox.Text) && !String.IsNullOrEmpty(openFileDialog.FileName))
            {
                CheckNetwork check = new CheckNetwork();
                check.Delete(openFileDialog.FileName, helpTextbox.Text);
                view_richTextBox.Lines = File.ReadAllLines(openFileDialog.FileName).ToArray();
                MessageBox.Show("Файл успешно отредактирован");
            }
            else
            {
                MessageBox.Show("Пустая строка или файл для редактирования не выбран");
            }
        }

    }
}
