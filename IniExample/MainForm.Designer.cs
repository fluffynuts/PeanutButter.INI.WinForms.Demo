namespace IniExample
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ColorDisplay = new System.Windows.Forms.Label();
            this.LoadConfig1Button = new System.Windows.Forms.Button();
            this.SaveCurrentConfigButton = new System.Windows.Forms.Button();
            this.LoadConfig2Button = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.ColorList = new IniExample.ColorPicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favorite color";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorDisplay
            // 
            this.ColorDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ColorDisplay.Location = new System.Drawing.Point(17, 63);
            this.ColorDisplay.Name = "ColorDisplay";
            this.ColorDisplay.Size = new System.Drawing.Size(422, 39);
            this.ColorDisplay.TabIndex = 1;
            this.ColorDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadConfig1Button
            // 
            this.LoadConfig1Button.Location = new System.Drawing.Point(15, 213);
            this.LoadConfig1Button.Name = "LoadConfig1Button";
            this.LoadConfig1Button.Size = new System.Drawing.Size(185, 31);
            this.LoadConfig1Button.TabIndex = 2;
            this.LoadConfig1Button.Text = "Load Config 1";
            this.LoadConfig1Button.UseVisualStyleBackColor = true;
            this.LoadConfig1Button.Click += new System.EventHandler(this.LoadConfig1Button_Click);
            // 
            // SaveCurrentConfigButton
            // 
            this.SaveCurrentConfigButton.Location = new System.Drawing.Point(251, 252);
            this.SaveCurrentConfigButton.Name = "SaveCurrentConfigButton";
            this.SaveCurrentConfigButton.Size = new System.Drawing.Size(185, 31);
            this.SaveCurrentConfigButton.TabIndex = 3;
            this.SaveCurrentConfigButton.Text = "Save current config";
            this.SaveCurrentConfigButton.UseVisualStyleBackColor = true;
            this.SaveCurrentConfigButton.Click += new System.EventHandler(this.SaveCurrentConfigButton_Click);
            // 
            // LoadConfig2Button
            // 
            this.LoadConfig2Button.Location = new System.Drawing.Point(17, 252);
            this.LoadConfig2Button.Name = "LoadConfig2Button";
            this.LoadConfig2Button.Size = new System.Drawing.Size(185, 31);
            this.LoadConfig2Button.TabIndex = 4;
            this.LoadConfig2Button.Text = "Load Config 2";
            this.LoadConfig2Button.UseVisualStyleBackColor = true;
            this.LoadConfig2Button.Click += new System.EventHandler(this.LoadConfig2Button_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.Location = new System.Drawing.Point(139, 115);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(80, 31);
            this.ChangeLabel.TabIndex = 6;
            this.ChangeLabel.Text = "Change to:";
            this.ChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ColorList
            // 
            this.ColorList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ColorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorList.FormattingEnabled = true;
            this.ColorList.Location = new System.Drawing.Point(243, 120);
            this.ColorList.Name = "ColorList";
            this.ColorList.SelectedItem = null;
            this.ColorList.SelectedValue = System.Drawing.Color.White;
            this.ColorList.Size = new System.Drawing.Size(194, 24);
            this.ColorList.TabIndex = 7;
            this.ColorList.SelectedIndexChanged += new System.EventHandler(this.ColorList_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 305);
            this.Controls.Add(this.ColorList);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.LoadConfig2Button);
            this.Controls.Add(this.SaveCurrentConfigButton);
            this.Controls.Add(this.LoadConfig1Button);
            this.Controls.Add(this.ColorDisplay);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "INI Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button LoadConfig1Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadConfig2Button;
        private System.Windows.Forms.Button SaveCurrentConfigButton;
        private System.Windows.Forms.Label ColorDisplay;
        private IniExample.ColorPicker ColorList;
        private System.Windows.Forms.Label ChangeLabel;
    }
}