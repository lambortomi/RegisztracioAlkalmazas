namespace _13T_OpenSave
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Fb = new System.Windows.Forms.RadioButton();
            this.Rb = new System.Windows.Forms.RadioButton();
            this.lNev = new System.Windows.Forms.Label();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.lszuldat = new System.Windows.Forms.Label();
            this.lnem = new System.Windows.Forms.Label();
            this.lkedvenhobbi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(440, 102);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(120, 95);
            this.lista.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Betöltés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(305, 25);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(100, 20);
            this.text.TabIndex = 3;
            this.text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(440, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Fb
            // 
            this.Fb.AutoSize = true;
            this.Fb.Location = new System.Drawing.Point(305, 102);
            this.Fb.Name = "Fb";
            this.Fb.Size = new System.Drawing.Size(31, 17);
            this.Fb.TabIndex = 6;
            this.Fb.TabStop = true;
            this.Fb.Text = "F";
            this.Fb.UseVisualStyleBackColor = true;
            // 
            // Rb
            // 
            this.Rb.AutoSize = true;
            this.Rb.Location = new System.Drawing.Point(372, 102);
            this.Rb.Name = "Rb";
            this.Rb.Size = new System.Drawing.Size(33, 17);
            this.Rb.TabIndex = 7;
            this.Rb.TabStop = true;
            this.Rb.Text = "R";
            this.Rb.UseVisualStyleBackColor = true;
            // 
            // lNev
            // 
            this.lNev.AutoSize = true;
            this.lNev.Location = new System.Drawing.Point(191, 25);
            this.lNev.Name = "lNev";
            this.lNev.Size = new System.Drawing.Size(30, 13);
            this.lNev.TabIndex = 8;
            this.lNev.Text = "Név:";
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(440, 232);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 9;
            this.btnHozzaad.Text = "Hozzáad";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            // 
            // lszuldat
            // 
            this.lszuldat.AutoSize = true;
            this.lszuldat.Location = new System.Drawing.Point(191, 67);
            this.lszuldat.Name = "lszuldat";
            this.lszuldat.Size = new System.Drawing.Size(65, 13);
            this.lszuldat.TabIndex = 10;
            this.lszuldat.Text = "Szül. dátum:";
            this.lszuldat.Click += new System.EventHandler(this.lszuldat_Click);
            // 
            // lnem
            // 
            this.lnem.AutoSize = true;
            this.lnem.Location = new System.Drawing.Point(191, 104);
            this.lnem.Name = "lnem";
            this.lnem.Size = new System.Drawing.Size(32, 13);
            this.lnem.TabIndex = 11;
            this.lnem.Text = "Nem:";
            // 
            // lkedvenhobbi
            // 
            this.lkedvenhobbi.AutoSize = true;
            this.lkedvenhobbi.Location = new System.Drawing.Point(437, 67);
            this.lkedvenhobbi.Name = "lkedvenhobbi";
            this.lkedvenhobbi.Size = new System.Drawing.Size(82, 13);
            this.lkedvenhobbi.TabIndex = 12;
            this.lkedvenhobbi.Text = "Kedvenc hobbi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 379);
            this.Controls.Add(this.lkedvenhobbi);
            this.Controls.Add(this.lnem);
            this.Controls.Add(this.lszuldat);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.lNev);
            this.Controls.Add(this.Rb);
            this.Controls.Add(this.Fb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton Fb;
        private System.Windows.Forms.RadioButton Rb;
        private System.Windows.Forms.Label lNev;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Label lszuldat;
        private System.Windows.Forms.Label lnem;
        private System.Windows.Forms.Label lkedvenhobbi;
    }
}

