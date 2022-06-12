using System.Windows.Forms;

namespace Winform_Final.Administrator_Interfaces
{
    public partial class MainAdminInterfaces : Form
    {
        ProductManage productInterface;
        public MainAdminInterfaces()
        {
            InitializeComponent();
            productInterface = new ProductManage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.contentPanel.Controls.Add(productInterface);
            productInterface.Show();
        }
    }
}
