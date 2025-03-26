namespace SMS.App
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
            textBoxId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            label1 = new Label();
            buttonShow = new Button();
            labelAddedInformation = new Label();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(203, 102);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(229, 23);
            textBoxId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 145);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 185);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(203, 184);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(229, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(203, 143);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(229, 23);
            textBoxName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 105);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(149, 49);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(283, 35);
            buttonShow.TabIndex = 8;
            buttonShow.Text = "Show Information";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // labelAddedInformation
            // 
            labelAddedInformation.AutoSize = true;
            labelAddedInformation.Location = new Point(207, 216);
            labelAddedInformation.Name = "labelAddedInformation";
            labelAddedInformation.Size = new Size(108, 15);
            labelAddedInformation.TabIndex = 9;
            labelAddedInformation.Text = "Added Information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 272);
            Controls.Add(labelAddedInformation);
            Controls.Add(buttonShow);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxId;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private Label label1;
        private Button buttonShow;
        private Label labelAddedInformation;
    }
}
