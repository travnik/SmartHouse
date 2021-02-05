
namespace SmartHouse.WindowsForms.Forms
{
    partial class ScenarioForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxScript = new System.Windows.Forms.ListBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.buttonAddCommand = new System.Windows.Forms.Button();
            this.buttonDeleteCommand = new System.Windows.Forms.Button();
            this.buttonSaveScript = new System.Windows.Forms.Button();
            this.buttonRunScript = new System.Windows.Forms.Button();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxScript
            // 
            this.listBoxScript.FormattingEnabled = true;
            this.listBoxScript.ItemHeight = 15;
            this.listBoxScript.Location = new System.Drawing.Point(703, 12);
            this.listBoxScript.Name = "listBoxScript";
            this.listBoxScript.Size = new System.Drawing.Size(247, 394);
            this.listBoxScript.TabIndex = 0;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(12, 12);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(239, 23);
            this.comboBoxDevices.TabIndex = 1;
            // 
            // buttonAddCommand
            // 
            this.buttonAddCommand.Location = new System.Drawing.Point(603, 98);
            this.buttonAddCommand.Name = "buttonAddCommand";
            this.buttonAddCommand.Size = new System.Drawing.Size(75, 55);
            this.buttonAddCommand.TabIndex = 3;
            this.buttonAddCommand.Text = "Добавить команду";
            this.buttonAddCommand.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCommand
            // 
            this.buttonDeleteCommand.Location = new System.Drawing.Point(603, 200);
            this.buttonDeleteCommand.Name = "buttonDeleteCommand";
            this.buttonDeleteCommand.Size = new System.Drawing.Size(77, 67);
            this.buttonDeleteCommand.TabIndex = 4;
            this.buttonDeleteCommand.Text = "Удалить команду";
            this.buttonDeleteCommand.UseVisualStyleBackColor = true;
            // 
            // buttonSaveScript
            // 
            this.buttonSaveScript.Location = new System.Drawing.Point(22, 152);
            this.buttonSaveScript.Name = "buttonSaveScript";
            this.buttonSaveScript.Size = new System.Drawing.Size(204, 50);
            this.buttonSaveScript.TabIndex = 5;
            this.buttonSaveScript.Text = "Сохранить скрипт";
            this.buttonSaveScript.UseVisualStyleBackColor = true;
            // 
            // buttonRunScript
            // 
            this.buttonRunScript.Location = new System.Drawing.Point(22, 217);
            this.buttonRunScript.Name = "buttonRunScript";
            this.buttonRunScript.Size = new System.Drawing.Size(204, 50);
            this.buttonRunScript.TabIndex = 6;
            this.buttonRunScript.Text = "Выполнить скрипт";
            this.buttonRunScript.UseVisualStyleBackColor = true;
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.ItemHeight = 15;
            this.listBoxCommands.Location = new System.Drawing.Point(321, 12);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.Size = new System.Drawing.Size(258, 394);
            this.listBoxCommands.TabIndex = 7;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(22, 296);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(293, 142);
            this.textBoxLog.TabIndex = 8;
            // 
            // ScenarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.listBoxCommands);
            this.Controls.Add(this.buttonRunScript);
            this.Controls.Add(this.buttonSaveScript);
            this.Controls.Add(this.buttonDeleteCommand);
            this.Controls.Add(this.buttonAddCommand);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.listBoxScript);
            this.Name = "ScenarioForm";
            this.Text = "ScenarioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxScript;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Button buttonAddCommand;
        private System.Windows.Forms.Button buttonDeleteCommand;
        private System.Windows.Forms.Button buttonSaveScript;
        private System.Windows.Forms.Button buttonRunScript;
        private System.Windows.Forms.ListBox listBoxCommands;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}