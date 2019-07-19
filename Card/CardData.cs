using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PCSC;

namespace Card
{
    public partial class CardData : Form
    {
        public CardData()
        {
            InitializeComponent();
            RefreshCardData();
        }

        private void CardData_Load(object sender, EventArgs e)
        {

        }

        public void RefreshCardData()
        {
            SCardContext card = new SCardContext();
            
            card.Establish(SCardScope.System);
            string[] readers = card.GetReaders();
            SCardReaderState status = card.GetReaderStatus(readers[0]);
            CardDataBox.Text += status.UserData + " - User Data\n"+Environment.NewLine;
            CardDataBox.Text += status.ReaderName + " - Reader\n" + Environment.NewLine;
            CardDataBox.Text += status.CurrentStateValue + " - Curent State Value\n" + Environment.NewLine;
            CardDataBox.Text += BitConverter.ToString(status.Atr ?? new byte[0]) + " - Answer to Reset\n" + Environment.NewLine;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RefreshCardData();
        }
    }


}
