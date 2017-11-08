using System.Windows.Forms;

namespace mRemoteNG.UI.Controls
{
    partial class MultiSshToolStrip
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMultiSSH = new ToolStripLabel();
            this.txtMultiSSH = new ToolStripTextBox();
            this.SuspendLayout();
            // 
            // lblMultiSSH
            // 
            this.lblMultiSSH.Name = "lblMultiSSH";
            this.lblMultiSSH.Size = new System.Drawing.Size(77, 22);
            this.lblMultiSSH.Text = "Multi SSH:";
            // 
            // txtMultiSSH
            // 
            this.txtMultiSSH.Name = "txtMultiSSH";
            this.txtMultiSSH.Size = new System.Drawing.Size(300, 25);
            this.txtMultiSSH.ToolTipText = "Press ENTER to send. Ctrl+C is sent immediately.";
            // 
            // MultiSshToolStrip
            // 
            this.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblMultiSSH,
                this.txtMultiSSH});
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Name = "MultiSshToolStrip";
            this.Size = new System.Drawing.Size(430, 25);
            this.TabIndex = 0;
            this.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripLabel lblMultiSSH;
        private System.Windows.Forms.ToolStripTextBox txtMultiSSH;
    }
}
