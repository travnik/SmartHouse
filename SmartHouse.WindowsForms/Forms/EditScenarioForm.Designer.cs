
namespace SmartHouse.WindowsForms.Forms
{
    partial class EditScenarioForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.listBoxScript = new System.Windows.Forms.ListBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.buttonAddCommand = new System.Windows.Forms.Button();
            this.buttonDeleteCommand = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonSaveScript = new System.Windows.Forms.Button();
            this.buttonRunScript = new System.Windows.Forms.Button();
            this.textBoxScriptName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxScriptName);
            this.groupBox1.Controls.Add(this.listBoxCommands);
            this.groupBox1.Controls.Add(this.listBoxScript);
            this.groupBox1.Controls.Add(this.comboBoxDevices);
            this.groupBox1.Controls.Add(this.buttonAddCommand);
            this.groupBox1.Controls.Add(this.buttonDeleteCommand);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 323);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка скрипта";
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.ItemHeight = 15;
            this.listBoxCommands.Location = new System.Drawing.Point(270, 22);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.Size = new System.Drawing.Size(258, 259);
            this.listBoxCommands.TabIndex = 7;
            // 
            // listBoxScript
            // 
            this.listBoxScript.FormattingEnabled = true;
            this.listBoxScript.ItemHeight = 15;
            this.listBoxScript.Location = new System.Drawing.Point(643, 22);
            this.listBoxScript.Name = "listBoxScript";
            this.listBoxScript.Size = new System.Drawing.Size(212, 259);
            this.listBoxScript.TabIndex = 0;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(17, 41);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(239, 23);
            this.comboBoxDevices.TabIndex = 1;
            // 
            // buttonAddCommand
            // 
            this.buttonAddCommand.Location = new System.Drawing.Point(551, 62);
            this.buttonAddCommand.Name = "buttonAddCommand";
            this.buttonAddCommand.Size = new System.Drawing.Size(75, 55);
            this.buttonAddCommand.TabIndex = 3;
            this.buttonAddCommand.Text = "Добавить команду";
            this.buttonAddCommand.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCommand
            // 
            this.buttonDeleteCommand.Location = new System.Drawing.Point(551, 165);
            this.buttonDeleteCommand.Name = "buttonDeleteCommand";
            this.buttonDeleteCommand.Size = new System.Drawing.Size(77, 67);
            this.buttonDeleteCommand.TabIndex = 4;
            this.buttonDeleteCommand.Text = "Удалить команду";
            this.buttonDeleteCommand.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(149, 354);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(718, 164);
            this.textBoxLog.TabIndex = 8;
            // 
            // buttonSaveScript
            // 
            this.buttonSaveScript.Location = new System.Drawing.Point(29, 354);
            this.buttonSaveScript.Name = "buttonSaveScript";
            this.buttonSaveScript.Size = new System.Drawing.Size(99, 65);
            this.buttonSaveScript.TabIndex = 5;
            this.buttonSaveScript.Text = "Сохранить скрипт";
            this.buttonSaveScript.UseVisualStyleBackColor = true;
            // 
            // buttonRunScript
            // 
            this.buttonRunScript.Location = new System.Drawing.Point(29, 437);
            this.buttonRunScript.Name = "buttonRunScript";
            this.buttonRunScript.Size = new System.Drawing.Size(104, 65);
            this.buttonRunScript.TabIndex = 6;
            this.buttonRunScript.Text = "Выполнить скрипт";
            this.buttonRunScript.UseVisualStyleBackColor = true;
            // 
            // textBoxScriptName
            // 
            this.textBoxScriptName.Location = new System.Drawing.Point(17, 287);
            this.textBoxScriptName.Name = "textBoxScriptName";
            this.textBoxScriptName.Size = new System.Drawing.Size(239, 23);
            this.textBoxScriptName.TabIndex = 8;
            // 
            // EditScenarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonRunScript);
            this.Controls.Add(this.buttonSaveScript);
            this.Name = "EditScenarioForm";
            this.Text = "EditScenarioForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxCommands;
        private System.Windows.Forms.ListBox listBoxScript;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Button buttonAddCommand;
        private System.Windows.Forms.Button buttonDeleteCommand;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonSaveScript;
        private System.Windows.Forms.Button buttonRunScript;
        private System.Windows.Forms.TextBox textBoxScriptName;
    }
}