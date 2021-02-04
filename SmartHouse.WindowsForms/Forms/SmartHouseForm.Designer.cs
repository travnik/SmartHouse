
namespace SmartHouse.WindowsForms.Forms
{
    partial class SmartHouseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlDevices = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabControlDevices
            // 
            this.tabControlDevices.Location = new System.Drawing.Point(1, 1);
            this.tabControlDevices.Name = "tabControlDevices";
            this.tabControlDevices.SelectedIndex = 0;
            this.tabControlDevices.Size = new System.Drawing.Size(787, 300);
            this.tabControlDevices.TabIndex = 0;
            // 
            // SmartHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlDevices);
            this.Name = "SmartHouseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDevices;
    }
}

