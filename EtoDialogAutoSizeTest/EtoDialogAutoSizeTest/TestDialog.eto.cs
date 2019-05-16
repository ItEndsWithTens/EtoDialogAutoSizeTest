using Eto.Forms;

namespace EtoDialogAutoSizeTest
{
    public partial class TestDialog : Dialog
    {
        private bool _tabs;
        private bool _posNegButtons;

        void InitializeComponent()
        {
            Resizable = true;

            var tblGroups = new TableLayout(1, 2);
            tblGroups.Add(new GroupBox { Text = "Upper", Content = new Button { Text = "Upper Button" } }, 0, 0);
            tblGroups.Add(new GroupBox { Text = "Lower", Content = new Button { Text = "Lower Button" } }, 0, 1);

            tblGroups.SetRowScale(0, true);
            tblGroups.SetRowScale(1, true);

            if (_tabs)
            {
                Content = new TabControl
                {
                    Pages =
                    {
                        new TabPage
                        {
                            Text = "TabPage",
                            Content = tblGroups
                        }
                    }
                };
            }
            else
            {
                Content = tblGroups;
            }

            if (_posNegButtons)
            {
                PositiveButtons.Add(new Button { Text = "OK" });
                NegativeButtons.Add(new Button { Text = "Cancel" });
            }
        }
    }
}
