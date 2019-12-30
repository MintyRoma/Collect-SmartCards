using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCSC;
using Microsoft.Win32;

namespace Card
{
    public partial class MainForm : Form
    {
        private SCardReaderState card;
        private string reader = "";
        private SCardContext context;
        InsertCard ins = new InsertCard();
        private bool adding = false;

        public MainForm()
        {
            InitializeComponent();
            context = new SCardContext();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (adding) AddCard();
            else CheckCard();
        }

        private void AddCard()
        {
            System.Threading.Thread.Sleep(10);
            context.Establish(SCardScope.System);
            
            if (context.GetReaders().Count() == 0)
            {
                ins.Close();
                adding = false;
                MessageBox.Show("Install reader first", "No reader", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                return;
            }
            reader = context.GetReaders().ToList()[0];
            card = context.GetReaderStatus(reader);
            string atr = BitConverter.ToString(card.Atr);
            Dictionary<string, string> atrs = ImportCards();
            if (atrs.ContainsKey(atr))
            {
                ins.Close();
                adding = false;
                MessageBox.Show("Such card is already has a PIN", "Existed card", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                return;
            }
            RegistryKey folder = Registry.CurrentUser;
            folder = folder.OpenSubKey("SOFTWARE", true);
            if (!folder.GetSubKeyNames().Contains("Cardel"))
            {
                folder.CreateSubKey("Cardel");
            }
            if (atr == "") return;
            folder = folder.OpenSubKey("Cardel",true);
            folder.CreateSubKey(atr);
            folder.SetValue(atr, pass_txtboxwrite.Text);
            folder.Close();
            ins.Close();
            adding = false;
            MessageBox.Show("Card was succesfully writed","Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void CheckCard()
        {
            {
                atr_txtbox.Text = "";
                pass_txtbox.Text = "";
                context.Establish(SCardScope.System);
                if (context.GetReaders().Count()==0)
                {
                    status_label.Text = "NO READER";
                    status_label.ForeColor = Color.IndianRed;
                    return;
                }
                reader = context.GetReaders().ToList()[0];
                card = context.GetReaderStatus(reader);
                string atr = BitConverter.ToString(card.Atr);
                if (atr=="")
                {
                    status_label.Text = "WAIT FOR CARD";
                    status_label.ForeColor = Color.Orange;
                    return;
                }
                Dictionary <string,string> atrs = ImportCards();
                if (atrs.ContainsKey(atr))
                {
                    status_label.Text = "SUCCES";
                    status_label.ForeColor = Color.Green;
                    atr_txtbox.Text = atr;
                    pass_txtbox.Text = atrs[atr];
                    SendKeys.Send(atrs[atr]+"{ENTER}");
                    return;
                }
                else
                {
                    status_label.Text = "DENY";
                    status_label.ForeColor = Color.Red;
                    atr_txtbox.Text = atr;
                    pass_txtbox.Text = "";
                    return;
                }
            }
        }

        private Dictionary<string, string> ImportCards()
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            RegistryKey folder = Registry.LocalMachine;
            folder = folder.OpenSubKey("SOFTWARE",true);
            if (!folder.GetSubKeyNames().Contains("Cardel"))
            {
                folder.CreateSubKey("Cardel");
            }
            folder = folder.OpenSubKey("Cardel");
            List<RegistryKey> keys = new List<RegistryKey>();
            foreach(string key in folder.GetSubKeyNames())
            {
                res.Add(key, (string)folder.GetValue(key));
            }
            folder.Close();
            return res;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (pass_txtboxwrite.Text!="")
            adding = true;
            ins.ShowDialog();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (status_label.Text=="SUCCES")
            {
                string atr = atr_txtbox.Text;
                RegistryKey folder = Registry.LocalMachine;
                folder = folder.OpenSubKey("SOFTWARE", true);
                folder = folder.OpenSubKey("Cardel", true);
                folder.DeleteSubKey(atr);
                folder.Close();
            }
        }
    }
}
