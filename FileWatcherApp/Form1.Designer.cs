namespace FileWatcherApp
{
    partial class Form1
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
            textBoxPath = new TextBox();
            buttonSelectFolder = new Button();
            buttonStartStop = new Button();
            checkBoxNotify = new CheckBox();
            listBoxLogs = new ListBox();
            labelName = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(149, 67);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.ReadOnly = true;
            textBoxPath.Size = new Size(639, 27);
            textBoxPath.TabIndex = 0;
            // 
            // buttonSelectFolder
            // 
            buttonSelectFolder.BackColor = Color.Gainsboro;
            buttonSelectFolder.FlatAppearance.BorderSize = 0;
            buttonSelectFolder.FlatStyle = FlatStyle.Flat;
            buttonSelectFolder.ForeColor = Color.Black;
            buttonSelectFolder.Location = new Point(149, 121);
            buttonSelectFolder.Name = "buttonSelectFolder";
            buttonSelectFolder.Size = new Size(166, 29);
            buttonSelectFolder.TabIndex = 1;
            buttonSelectFolder.Text = "Обрати папку";
            buttonSelectFolder.UseVisualStyleBackColor = false;
            buttonSelectFolder.Click += buttonSelectFolder_Click;
            // 
            // buttonStartStop
            // 
            buttonStartStop.BackColor = Color.LightGreen;
            buttonStartStop.FlatAppearance.BorderSize = 0;
            buttonStartStop.FlatStyle = FlatStyle.Flat;
            buttonStartStop.Location = new Point(321, 121);
            buttonStartStop.Name = "buttonStartStop";
            buttonStartStop.Size = new Size(177, 29);
            buttonStartStop.TabIndex = 2;
            buttonStartStop.Text = "Запустити моніторинг";
            buttonStartStop.UseVisualStyleBackColor = false;
            buttonStartStop.Click += buttonStartStop_Click;
            // 
            // checkBoxNotify
            // 
            checkBoxNotify.AutoSize = true;
            checkBoxNotify.Location = new Point(545, 126);
            checkBoxNotify.Name = "checkBoxNotify";
            checkBoxNotify.Size = new Size(180, 24);
            checkBoxNotify.TabIndex = 3;
            checkBoxNotify.Text = "Сповіщати про зміни";
            checkBoxNotify.UseVisualStyleBackColor = true;
            // 
            // listBoxLogs
            // 
            listBoxLogs.FormattingEnabled = true;
            listBoxLogs.Location = new Point(11, 193);
            listBoxLogs.Name = "listBoxLogs";
            listBoxLogs.Size = new Size(777, 244);
            listBoxLogs.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName.Location = new Point(321, 22);
            labelName.Name = "labelName";
            labelName.Size = new Size(147, 31);
            labelName.TabIndex = 5;
            labelName.Text = "File Watcher";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(11, 67);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 6;
            label1.Text = "Шлях до папки:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelName);
            Controls.Add(listBoxLogs);
            Controls.Add(checkBoxNotify);
            Controls.Add(buttonStartStop);
            Controls.Add(buttonSelectFolder);
            Controls.Add(textBoxPath);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPath;
        private Button buttonSelectFolder;
        private Button buttonStartStop;
        private CheckBox checkBoxNotify;
        private ListBox listBoxLogs;
        private Label labelName;
        private Label label1;
    }
}
