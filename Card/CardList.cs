using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Card
{
    public partial class CardList : Form
    {
        private List<string> atrs = new List<string>();
        public CardList()
        {
            InitializeComponent();
        }

        private void CardList_Load(object sender, EventArgs e)
        {
            StreamReader io = new StreamReader("ATRs.txt");
            while (!io.EndOfStream) atrs.Add(io.ReadLine());
            io.Close();
            foreach (string atr in atrs)
            {
                int pos = Table.Rows.Add();
                Table.Rows[pos].Cells["AtrsColumn"].Value = atr;
            }
            
        }
    }
}
