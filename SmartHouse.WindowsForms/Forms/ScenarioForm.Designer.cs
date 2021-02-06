
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxScripts = new System.Windows.Forms.ListBox();
            this.buttonCreateScript = new System.Windows.Forms.Button();
            this.buttonRemoveScript = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.buttonRemoveScript);
            this.groupBox2.Controls.Add(this.buttonCreateScript);
            this.groupBox2.Controls.Add(this.listBoxScripts);
            this.groupBox2.Location = new System.Drawing.Point(22, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 328);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Менеджер скриптов";
            // 
            // listBoxScripts
            // 
            this.listBoxScripts.FormattingEnabled = true;
            this.listBoxScripts.ItemHeight = 15;
            this.listBoxScripts.Location = new System.Drawing.Point(17, 23);
            this.listBoxScripts.Name = "listBoxScripts";
            this.listBoxScripts.Size = new System.Drawing.Size(284, 289);
            this.listBoxScripts.TabIndex = 6;
            // 
            // buttonCreateScript
            // 
            this.buttonCreateScript.Location = new System.Drawing.Point(348, 23);
            this.buttonCreateScript.Name = "buttonCreateScript";
            this.buttonCreateScript.Size = new System.Drawing.Size(166, 45);
            this.buttonCreateScript.TabIndex = 7;
            this.buttonCreateScript.Text = "Создать скрипт";
            this.buttonCreateScript.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveScript
            // 
            this.buttonRemoveScript.Location = new System.Drawing.Point(348, 168);
            this.buttonRemoveScript.Name = "buttonRemoveScript";
            this.buttonRemoveScript.Size = new System.Drawing.Size(166, 54);
            this.buttonRemoveScript.TabIndex = 8;
            this.buttonRemoveScript.Text = "Удалить скрипт";
            this.buttonRemoveScript.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Редактировать скрипт";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ScenarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 359);
            this.Controls.Add(this.groupBox2);
            this.Name = "EditScriptForm";
            this.Text = "ScenarioForm";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRemoveScript;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCreateScript;
        private System.Windows.Forms.ListBox listBoxScripts;
    }
}