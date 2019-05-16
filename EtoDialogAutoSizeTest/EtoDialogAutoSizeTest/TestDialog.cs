using Eto.Forms;

namespace EtoDialogAutoSizeTest
{
    public partial class TestDialog : Dialog
    {
        public TestDialog(bool tabs, bool posNegButtons)
        {
            _tabs = tabs;
            _posNegButtons = posNegButtons;

            InitializeComponent();
        }
    }
}
