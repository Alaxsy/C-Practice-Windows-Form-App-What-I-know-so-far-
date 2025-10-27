// Target framework for the code: .NET Framework 4.8.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Namespace for the Windows Form Application.
namespace C__Practice__Windows_Form_App_What_I_know_so_far__
{
    //Main form class.
    public partial class FrmWhatIKnowSoFar : Form
    {
        //Constructor for the main form.
        public FrmWhatIKnowSoFar()
        {
            InitializeComponent();
        }
        private void FrmWhatIKnowSoFar_Load(object sender, EventArgs e)
        {

        }

        //This opens the "Radio Buttons" form when clicked.
        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadioButtons radioButtons = new FrmRadioButtons();
            radioButtons.Show();
        }

        //This opens the "Buttons" form when clicked.
        private void buttonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmButtons buttons = new FrmButtons();
            buttons.Show();
        }



        //This button will close the main form and exit the application.
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
