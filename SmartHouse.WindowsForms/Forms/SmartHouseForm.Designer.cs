
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
            this.buttonScripts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControlDevices
            // 
            this.tabControlDevices.Location = new System.Drawing.Point(1, 1);
            this.tabControlDevices.Name = "tabControlDevices";
            this.tabControlDevices.SelectedIndex = 0;
            this.tabControlDevices.Size = new System.Drawing.Size(800, 332);
            this.tabControlDevices.TabIndex = 0;
            // 
            // buttonScripts
            // 
            this.buttonScripts.Location = new System.Drawing.Point(244, 439);
            this.buttonScripts.Name = "buttonScripts";
            this.buttonScripts.Size = new System.Drawing.Size(363, 58);
            this.buttonScripts.TabIndex = 1;
            this.buttonScripts.Text = "Скрипты";
            this.buttonScripts.UseVisualStyleBackColor = true;
            // 
            // SmartHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.buttonScripts);
            this.Controls.Add(this.tabControlDevices);
            this.Name = "SmartHouseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDevices;
        private System.Windows.Forms.Button buttonScripts;
    }
}

