using System.Windows.Forms;
using mRemoteNG.Tools;

namespace mRemoteNG.UI.Controls
{
    public partial class MultiSshToolStrip : ToolStrip
    {
        private MultiSSHController _multiSshController;

        public MultiSshToolStrip()
        {
            InitializeComponent();
            _multiSshController = new MultiSSHController(txtMultiSSH);
        }
    }
}
