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

namespace FormTextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "https://docs.microsoft.com/ru-ru/dotnet/api/system.windows.forms.richtextbox.linkclicked?view=netframework-4.8";
            LinkLabel link1 = new LinkLabel();
           // richTextBox1.DetectUrls = false;
            link1.Text = "наука";
            // link1.LinkClicked += new LinkLabelLinkClickedEventHandler(RichTextBox1_LinkClicked);
            richTextBox1.LinkClicked += Link_Clicked;
            // dateTimePicker1
            dateTimePicker4.KeyDown += dateTimePicker2_KeyDown_1;

            Form form = new Form();
            form.IsMdiContainer = true;
            MenuStrip menuStrip1 = new MenuStrip();
            menuStrip1.Items.Add("sdf");
            this.IsMdiContainer = true;

            // form.MainMenuStrip.Items.Add("MainMenuStrip");
            this.Controls.Add(menuStrip1);
               form.Show();

            Form form2 = new Form();
            form2.MdiParent = form;

            var pp = form2.WindowState;
            form2.Icon = Properties.Resources.Tuziibanez_Profesional_Red_Network_drive_connected;
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();

            Form form3 = new Form();
            form3.MdiParent = form;

            var pp3 = form3.WindowState;
            form3.Icon = Properties.Resources.Tuziibanez_Profesional_Red_Network_drive_connected;
            form3.WindowState = FormWindowState.Maximized;
            //  form3.ShowIcon = false;
            // form3.Icon = SystemIcons.Application;
            //  form3.ControlBox = false;
            //  form3.ShowInTaskbar = false;
            form3.Show();

            //Form form4 = new Form();
            //form4.Icon = Properties.Resources.Tuziibanez_Profesional_Red_Network_drive_connected;
            //form4.WindowState = FormWindowState.Maximized;
            ////  form3.ShowIcon = false;
            //// form3.Icon = SystemIcons.Application;
            ////  form3.ControlBox = false;
            //form4.MdiParent = this;
            //form4.Show();
            ////    form.MainMenuStrip.Items.RemoveAt(0);


            // form2.StartPosition = FormStartPosition.CenterParent;
        }

        private void Link_Clicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "RichText Files (*.rtf)|*.rtf|All files (*.*)|*.*";

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.Control &&  e.KeyCode == Keys.C)
            {
                // Clipboard.SetText(((DateTimePicker)sender).Value.ToString("d"));
                Clipboard.SetText(((DateTimePicker)sender).Value.ToString());
                e.SuppressKeyPress = true; //избавляет от звука винды при некорректном действии
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
                try
                {
                   // Clipboard.SetText(((DateTimePicker)sender).Value.ToString("d"));
                     //    ((DateTimePicker)sender).Value = (DateTime)Clipboard.GetData("d");
                    ((DateTimePicker)sender).Value = Convert.ToDateTime(Clipboard.GetText());
                    e.SuppressKeyPress = true; //избавляет от звука винды при некорректном действии
                }
                catch
                {
                    
                }

                
            }
        }


        private void dateTimePicker2_KeyDown_1(object sender, KeyEventArgs e)
        {


            if (e.Control && e.KeyCode == Keys.C)
            {
                switch (((DateTimePicker)sender).Format)
                {
                    case DateTimePickerFormat.Time:
                        Clipboard.SetText(((DateTimePicker)sender).Value.ToString("T")); break;
                    case DateTimePickerFormat.Long:
                        Clipboard.SetText(((DateTimePicker)sender).Value.ToString("D"));  break;
                    case DateTimePickerFormat.Short:
                        Clipboard.SetText(((DateTimePicker)sender).Value.ToString("d")); break;
                    default:
                        Clipboard.SetText(((DateTimePicker)sender).Value.ToString()); break;
                }
                //   Clipboard.SetText(((DateTimePicker)sender).Value.ToString("d"));
              //  Clipboard.SetText(((DateTimePicker)sender).Value.ToString());
            e.SuppressKeyPress = true; //избавляет от звука винды при некорректном действии
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
            //  Clipboard.SetText(((DateTimePicker)sender).Value.ToString("d"));
            // ((DateTimePicker)sender).Value = (DateTime)Clipboard.GetData("d");
                try
                {
                    ((DateTimePicker)sender).Value = Convert.ToDateTime(Clipboard.GetText());
                    e.SuppressKeyPress = true; //избавляет от звука винды при некорректном действии
                }
                catch
                {

                }
            
            }
        }
        
    }
}
