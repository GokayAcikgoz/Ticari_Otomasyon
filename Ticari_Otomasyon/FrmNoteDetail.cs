using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmNoteDetail : Form
    {
        public FrmNoteDetail()
        {
            InitializeComponent();
        }

        public string message;
        private void FrmNoteDetail_Load(object sender, EventArgs e)
        {
           richTextBox1.Text = message;
        }
    }
}
