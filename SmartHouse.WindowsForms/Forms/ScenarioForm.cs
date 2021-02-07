using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using SmartHouse.Presentation.Views;
using SmartHouse.Presentation.Views.ViewModels;

namespace SmartHouse.WindowsForms.Forms
{
    public partial class ScenarioForm : Form, IScenariosView
    {
        public event Action NewScript;
        public event Action<ScriptViewModel> EditScript;
        public event Action<ScriptViewModel> RemoveScript;

        public IEnumerable<ScriptViewModel> SourceScripts
        {
            set => listBoxScripts.DataSource = value;
        }

        public ScenarioForm()
        {
            InitializeComponent();
            listBoxScripts.DisplayMember = nameof(ScriptViewModel.Name);
            buttonCreateScript.Click += (sender, args) => NewScript?.Invoke();
            buttonEditScript.Click += ButtonEditScriptOnClick;
            buttonRemoveScript.Click += ButtonRemoveScriptOnClick;
        }

        private void ButtonRemoveScriptOnClick(object sender, EventArgs e)
        {
            var script = GetSelectedScript();
            if (script != null)
            {
                RemoveScript?.Invoke(script);
            }
        }

        private void ButtonEditScriptOnClick(object sender, EventArgs e)
        {
            var script = GetSelectedScript();
            if (script != null)
            {
                EditScript?.Invoke(script);
            }
        }

        private ScriptViewModel GetSelectedScript()
        {
            return listBoxScripts.SelectedItem as ScriptViewModel;
        }

        public new void Show()
        {
            ShowDialog();
        }
    }
}
