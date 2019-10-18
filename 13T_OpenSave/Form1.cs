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
           

            lista.Items.Add("Úszás");
            lista.Items.Add("Horgászat");
            lista.Items.Add("Futás");
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

            if (!text.Text.Equals("") &&
                !dateTimePickerszuldat.Text.Equals("") &&
                (Fb.Checked || Nb.Checked)
                && lista.SelectedItem != null)
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ha üresen hagy mezőt, baj lesz! Irgum Burgum!");
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                using (var sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(text.Text);
                    sw.WriteLine(dateTimePickerszuldat.Text);
                    if (Fb.Checked)
                    {
                        sw.WriteLine("F");
                    }
                    if (Nb.Checked)
                    {
                        sw.WriteLine("N");
                    }
                    sw.WriteLine(lista.SelectedItem);
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

            try
            {
                using (var sr = new StreamReader(openFileDialog1.FileName))
                {
                    lista.Items.Clear();
                    lista.Items.Add("Uszás");
                    lista.Items.Add("Horgászat");
                    lista.Items.Add("Futás");
                    text.Text = sr.ReadLine();
                    dateTimePickerszuldat.Text = sr.ReadLine();
                    var nem = sr.ReadLine();
                    if (nem.Equals("F"))
                    {
                        Nb.Checked = false;
                        Fb.Checked = true;
                    }
                    if (nem.Equals("N"))
                    {
                        Fb.Checked = false;
                        Nb.Checked = true;
                    }
                    var kedvencHobbi = sr.ReadLine();
                    if (lista.Items.Contains(kedvencHobbi))
                    {
                        lista.SelectedItem = kedvencHobbi;
                    }
                    else
                    {
                        lista.Items.Add(kedvencHobbi);
                        lista.SelectedItem = kedvencHobbi;
                    }

                }

            }
            catch (IOException)
            {
                MessageBox.Show("Hiba sikertelen mentés!");
            }


        }

        private void lszuldat_Click(object sender, EventArgs e)
        {

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHozzaad_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!textBox2.Text.Trim().Equals(""))
                {
                    if (!lista.Items.Contains(textBox2.Text))
                    {
                        lista.Items.Add(textBox2.Text);
                        textBox2.Text = "";
                    }

                }
            }
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Trim().Equals(""))
            {
                if (!lista.Items.Contains(textBox2.Text))
                {
                    lista.Items.Add(textBox2.Text);
                    textBox2.Text = "";
                }

            }
            
        }
    }
}
