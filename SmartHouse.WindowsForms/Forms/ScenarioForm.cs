using System.Windows.Forms;
using SmartHouse.Presentation.Views;

namespace SmartHouse.WindowsForms.Forms
{
    public partial class ScenarioForm : Form, IScenariosView
    {
        public ScenarioForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            ShowDialog();
        }
    }
}
