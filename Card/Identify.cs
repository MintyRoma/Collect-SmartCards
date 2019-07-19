using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCSC;
using PCSC.Monitoring;


namespace Card
{
    public partial class Identify : Form
    {
        private SCardReaderState card;
        private string reader = readerNoMsg;
        private SCardContext context;
        private List<string> atrs = new List<string>();
        private List<string> readers = new List<string>();
        private bool extended = false;
        private bool showatr = false;
        private bool showreader = false;

        public bool Extended
        {
            get { return extended; }
            set { extended = value;
                TransformWindow();
            }
        }

        public bool ShowAtr
        {
            get { return showatr; }
            set { showatr = value;
                TransformWindow();
            }
        }

        public bool ShowReader
        {
            get { return showreader; }
            set { showreader = value;
                TransformWindow();
            }
        }
        private void TransformWindow()
        {
            if (!Extended)
            {
                MoreSignLbl.Text = "\ue96e";
                this.Height = 280;
            }
            else
            {
                MoreSignLbl.Text = "\ue96d";
                this.Height = 435;
            }

            if (ShowAtr)
            {
                atrTxtBox.Show();
            }
            else atrTxtBox.Hide();

            if (ShowReader)
            {
                readerLabel.Show();

            }
            else readerLabel.Hide();
        }

        const string readerNoMsg = "ПОДКЛЮЧИТЕ СЧИТЫВАТЕЛЬ";


        public Identify()
        {
            InitializeComponent();
        }

        private void Identify_Load(object sender, EventArgs e)
        {
            context = new SCardContext();
            context.Establish(SCardScope.System);
            if (context.GetReaders().Count() != 0)
            {
                readers = context.GetReaders().ToList();
                reader = readers[0];
                foreach (string rd in readers)
                {
                    ReadersComboBox.Items.Add(rd);
                }
                ReadersComboBox.SelectedItem = ReadersComboBox.Items[0];
                if (ReadersComboBox.Items.Count < 2) ReadersComboBox.Enabled = false;
                else ReadersComboBox.Enabled = true;
                readerLabel.Text = reader;
                RefreshData();
            }
            else
            {
                ReadersComboBox.Items.Clear();
                reader = readerNoMsg;
                atrTxtBox.Enabled = false;
                atrTxtBox.Text = "-";
                readerLabel.Text = reader;
                statusLabel.Enabled = false;
                statusLabel.Text = "СЧИТЫВАТЕЛЬ ОТКЛЮЧЕН";
            }
            ReadAtrsFromFile();
            TransformWindow();
        }

        private void ReadAtrsFromFile()
        {
            if (!File.Exists("ATRs.txt"))
            {
                FileStream fs = File.Create("ATRs.txt");
                fs.Close();
            }
            StreamReader io = new StreamReader("ATRs.txt");
            while (!io.EndOfStream) atrs.Add(io.ReadLine());
            io.Close();
        }

        private void RefreshData()
        {
            card = context.GetReaderStatus(reader);
            string atr = BitConverter.ToString(card.Atr ?? new byte[0]);
            if (atr == "")
            {
                statusLabel.ForeColor = Color.Orange;
                statusLabel.Text = "ОЖИДАНИЕ КАРТЫ";
                atrTxtBox.Text = "ВСТАВЬТЕ КАРТУ";
            }
            else
            {
                if (atrs.Contains(atr))
                {
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "АВТОРИЗОВАНО";
                }
                else
                {
                    statusLabel.ForeColor = Color.FromArgb(220, 10, 10);
                    statusLabel.Text = "НЕ АВТОРИЗОВАНО";
                }
                atrTxtBox.Text = atr;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            CheckConnect();                
        }

        private void CheckConnect()
        {
            context.Establish(SCardScope.System);
            ReadersComboBox.Items.Clear();
            if (context.GetReaders().Count() != 0)
            {
                readers = context.GetReaders().ToList();
                reader = readers[0];
                foreach (string rd in readers)
                {
                    ReadersComboBox.Items.Add(rd);
                }
                ReadersComboBox.SelectedItem = ReadersComboBox.Items[0];
                if (ReadersComboBox.Items.Count < 2) ReadersComboBox.Enabled = false;
                else ReadersComboBox.Enabled = true;
                statusLabel.Enabled = true;
                atrTxtBox.Enabled = true;
                readerLabel.Text = reader;
                RefreshData();
            }
            else
            {
                reader = readerNoMsg;
                atrTxtBox.Enabled = false;
                atrTxtBox.Text = "-";
                readerLabel.Text = reader;
                statusLabel.Enabled = false;
                statusLabel.Text = "СЧИТЫВАТЕЛЬ ОТКЛЮЧЕН";
            }
        }

        private void StatusLabel_TextChanged(object sender, EventArgs e)
        {
            statusLabel.Left = this.Width/2 - statusLabel.Width/2;
        }

        private void AtrTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoreSignLbl_Click(object sender, EventArgs e)
        {
            Extended = !Extended;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Extended = !Extended;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowAtr = !ShowAtr;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            ShowReader = !ShowReader;
        }

        private void Identify_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete("ATRs.txt");
            FileStream fs = File.Create("ATRs.txt");
            fs.Close();
            StreamWriter io = new StreamWriter("ATRs.txt");
            
            foreach(string atr in atrs)
            {
                io.WriteLine(atr);
            }
            io.Close();
        }

        private void CardMenu_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text == "АВТОРИЗОВАНО")
            {
                DelCardMenuItem.Enabled = true;
                AddCardMeniItem.Enabled = false;
            }
            else if (statusLabel.Text=="НЕ АВТОРИЗОВАНО")
            {
                DelCardMenuItem.Enabled = false;
                AddCardMeniItem.Enabled = true;
            }
            else
            {
                DelCardMenuItem.Enabled = false;
                AddCardMeniItem.Enabled = false;
            }
        }

        private void DelCardMenuItem_Click(object sender, EventArgs e)
        {
            string atr = BitConverter.ToString(card.Atr ?? new byte[0]);
            if (atr == "") return;
            if (atrs.Contains(atr)) atrs.Remove(atr);
            else MessageBox.Show("Список карт не содержит данную карту");
        }

        private void AddCardMeniItem_Click(object sender, EventArgs e)
        {
            string atr = BitConverter.ToString(card.Atr ?? new byte[0]);
            if (atr == "") ;
            if (!atrs.Contains(atr)) atrs.Add(atr);
            else MessageBox.Show("Список карт уже содержит данную карту");
        }
    }
}
