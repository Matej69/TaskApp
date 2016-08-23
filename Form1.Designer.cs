namespace ManagementSystem
{
    partial class App
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
            this.drop_ChoseDay = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.textbox_newTask = new System.Windows.Forms.TextBox();
            this.listbox_tasksDisplay = new System.Windows.Forms.ListBox();
            this.button_removeTask = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // drop_ChoseDay
            // 
            this.drop_ChoseDay.FormattingEnabled = true;
            this.drop_ChoseDay.Location = new System.Drawing.Point(-1, 0);
            this.drop_ChoseDay.Name = "drop_ChoseDay";
            this.drop_ChoseDay.Size = new System.Drawing.Size(331, 21);
            this.drop_ChoseDay.TabIndex = 0;
            this.drop_ChoseDay.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.DarkGreen;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Lime;
            this.button_add.Location = new System.Drawing.Point(247, 349);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(83, 37);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.AddOnClick);
            // 
            // textbox_newTask
            // 
            this.textbox_newTask.Location = new System.Drawing.Point(88, 349);
            this.textbox_newTask.Multiline = true;
            this.textbox_newTask.Name = "textbox_newTask";
            this.textbox_newTask.Size = new System.Drawing.Size(160, 37);
            this.textbox_newTask.TabIndex = 2;
            // 
            // listbox_tasksDisplay
            // 
            this.listbox_tasksDisplay.FormattingEnabled = true;
            this.listbox_tasksDisplay.Location = new System.Drawing.Point(-1, 21);
            this.listbox_tasksDisplay.Name = "listbox_tasksDisplay";
            this.listbox_tasksDisplay.Size = new System.Drawing.Size(331, 329);
            this.listbox_tasksDisplay.TabIndex = 3;
            // 
            // button_removeTask
            // 
            this.button_removeTask.BackColor = System.Drawing.Color.DarkRed;
            this.button_removeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removeTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeTask.ForeColor = System.Drawing.Color.Red;
            this.button_removeTask.Location = new System.Drawing.Point(-1, 349);
            this.button_removeTask.Name = "button_removeTask";
            this.button_removeTask.Size = new System.Drawing.Size(88, 37);
            this.button_removeTask.TabIndex = 4;
            this.button_removeTask.Text = "Remove";
            this.button_removeTask.UseVisualStyleBackColor = false;
            this.button_removeTask.Click += new System.EventHandler(this.button_removeTask_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 386);
            this.Controls.Add(this.button_removeTask);
            this.Controls.Add(this.listbox_tasksDisplay);
            this.Controls.Add(this.textbox_newTask);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.drop_ChoseDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "App";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drop_ChoseDay;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textbox_newTask;
        private System.Windows.Forms.ListBox listbox_tasksDisplay;
        private System.Windows.Forms.Button button_removeTask;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

