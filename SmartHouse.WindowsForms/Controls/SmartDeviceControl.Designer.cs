
using System.Windows.Forms;

namespace SmartHouse.WindowsForms.Controls
{
    partial class SmartDeviceControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelCommands = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCommands
            // 
            this.flowLayoutPanelCommands.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCommands.Dock = DockStyle.Top;
            this.flowLayoutPanelCommands.Name = "flowLayoutPanelCommands";
            this.flowLayoutPanelCommands.Size = new System.Drawing.Size(269, 180);
            this.flowLayoutPanelCommands.TabIndex = 0;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxStatus.Dock = DockStyle.Top;
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatus.Size = new System.Drawing.Size(253, 99);
            this.textBoxStatus.TabIndex = 1;
            // 
            // SmartDeviceControl
            // 
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.flowLayoutPanelCommands);
            this.Name = "SmartDeviceControl";
            this.Size = new System.Drawing.Size(369, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCommands;
        private System.Windows.Forms.TextBox textBoxStatus;
    }
}
