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

namespace _13T_OpenSave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileOk += (sender, e) =>
            {
                try
                {
                    using (var sr = new StreamReader(openFileDialog1.FileName))
                    {
                        lista.Items.Clear();
                        while (!sr.EndOfStream)
                        {
                            lista.Items.Add(sr.ReadLine());
                        }
                    }
                }
                catch (IOException)
                {

                    MessageBox.Show("Hiba! Nem Sikerült a betöltés!");
                }
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && !text.Text.Trim().Equals(""))

            {
                lista.Items.Add(text.Text);
                text.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text file|*.txt|All files|*.*";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                using (var sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (var item in lista.Items)
                    {
                        sw.WriteLine(item); 
                    }
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Hiba. Sikertelen mentés");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void lszuldat_Click(object sender, EventArgs e)
        {

        }
    }
}
