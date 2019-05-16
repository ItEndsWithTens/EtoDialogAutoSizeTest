using System;
using Eto.Forms;
using Eto.Drawing;

namespace EtoDialogAutoSizeTest
{
    partial class MainForm : Form
    {
        void InitializeComponent()
        {
            Title = "My Eto Form";
            ClientSize = new Size(400, 350);
            Padding = 10;

            var cbxTabControl = new CheckBox { Text = "Nest TableLayout in TabControl" };
            var cbxPosNegButtons = new CheckBox { Text = "Include positive/negative buttons" };

            var btnSpawnNormal = new Button { Text = "Spawn simple Dialog" };
            btnSpawnNormal.Click += (sender, e) =>
            {
                var dialog = new TestDialog((bool)cbxTabControl.Checked, (bool)cbxPosNegButtons.Checked);

                dialog.ShowModal(this);
            };

            var btnSpawnCrazy = new Button { Text = "Spawn complex Dialog" };
            btnSpawnCrazy.Click += (sender, e) =>
            {
                var dialog = new PreferencesDialog();

                dialog.ShowModal(this);
            };

            var gbxSimple = new GroupBox
            {
                Text = "Simple dialog",
                Content = new StackLayout
                {
                    Orientation = Orientation.Vertical,
                    Spacing = 10,
                    Items =
                    {
                        cbxTabControl,
                        cbxPosNegButtons,
                        btnSpawnNormal
                    }
                }
            };

            Content = new StackLayout
            {
                Orientation = Orientation.Vertical,
                Spacing = 20,
                Items =
                {
                    gbxSimple,
                    btnSpawnCrazy
                }
            };

            var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
            quitCommand.Executed += (sender, e) => Application.Instance.Quit();

            Menu = new MenuBar
            {
                Items =
                {
					new ButtonMenuItem { Text = "&File" },
				},
                QuitItem = quitCommand
            };
        }
    }
}
