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

namespace Ababei23._04._2021
{
    public partial class Form1 : Form
    {
        string[] buttonsTexts = new string[] { "Parte 3", "Parte 4", "Parte 5", "Parte 6", "Parte 7","Facoltativo" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 90;
            int left = 50;

            for (int i = 0; i < 6; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Height = 50;
                button.Width = 100;
                button.Text = buttonsTexts[i];
                button.Click += new EventHandler(button_Click);
                this.Controls.Add(button);
                top += button.Height + 3;

            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Text)
            {
                case "Parte 3":
                    DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler uscire?", "Chiusura esercizio", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    break;
                case "Parte 4":
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "Text|*.txt|All|*.*";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Path: " + openFileDialog.FileName);
                           
                        }
                    }
                    break;
                case "Parte 5":
                    SaveFileDialog saveFile = new SaveFileDialog();
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Path:" + saveFile.FileName);
                    }
                    break;
               case "Parte 6":
                    string nomeCognome = "Edoardo Ababei";
                    DateTime datetime = DateTime.Now;
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\matte\Desktop\Ababei23.04.2021\Ababei23.04.2021\bin\Debug\salvataggio.txt", true))
                    {
                        writer.WriteLine(nomeCognome+"\n"+datetime);
                    }
                    break;
                case "Parte 7":
                    string content = File.ReadAllText(Directory.GetCurrentDirectory() + @"\salvataggio.txt", Encoding.UTF8);
                    MessageBox.Show(content);

                    break;
                case "Facoltativo":
                    if (File.Exists(Directory.GetCurrentDirectory() + @"\salvataggio.txt")) //controllo l' esistenza del file nella directory
                    {
                        Form form = new Form();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Il file non esiste!!");
                    }
                    break;



                  
            }
          
           
        }
       
    }
}
