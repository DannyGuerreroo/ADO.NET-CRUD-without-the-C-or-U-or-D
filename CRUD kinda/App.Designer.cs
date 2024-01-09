namespace CRUD_kinda
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
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.SelectedLabel1 = new System.Windows.Forms.Label();
            this.SelectedLabel2 = new System.Windows.Forms.Label();
            this.SelectedLabel3 = new System.Windows.Forms.Label();
            this.SelectedLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameComboBox
            // 
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(23, 25);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(166, 21);
            this.NameComboBox.TabIndex = 0;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(210, 25);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseButton.TabIndex = 1;
            this.ChooseButton.Text = "Choose";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // SelectedLabel1
            // 
            this.SelectedLabel1.AutoSize = true;
            this.SelectedLabel1.Location = new System.Drawing.Point(207, 90);
            this.SelectedLabel1.Name = "SelectedLabel1";
            this.SelectedLabel1.Size = new System.Drawing.Size(87, 13);
            this.SelectedLabel1.TabIndex = 2;
            this.SelectedLabel1.Text = "Choose a person";
            // 
            // SelectedLabel2
            // 
            this.SelectedLabel2.AutoSize = true;
            this.SelectedLabel2.Location = new System.Drawing.Point(207, 117);
            this.SelectedLabel2.Name = "SelectedLabel2";
            this.SelectedLabel2.Size = new System.Drawing.Size(54, 13);
            this.SelectedLabel2.TabIndex = 3;
            this.SelectedLabel2.Text = "in order to";
            this.SelectedLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SelectedLabel3
            // 
            this.SelectedLabel3.AutoSize = true;
            this.SelectedLabel3.Location = new System.Drawing.Point(207, 145);
            this.SelectedLabel3.Name = "SelectedLabel3";
            this.SelectedLabel3.Size = new System.Drawing.Size(52, 13);
            this.SelectedLabel3.TabIndex = 4;
            this.SelectedLabel3.Text = "view their";
            this.SelectedLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SelectedLabel4
            // 
            this.SelectedLabel4.AutoSize = true;
            this.SelectedLabel4.Location = new System.Drawing.Point(207, 171);
            this.SelectedLabel4.Name = "SelectedLabel4";
            this.SelectedLabel4.Size = new System.Drawing.Size(58, 13);
            this.SelectedLabel4.TabIndex = 5;
            this.SelectedLabel4.Text = "information";
            this.SelectedLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 318);
            this.Controls.Add(this.SelectedLabel4);
            this.Controls.Add(this.SelectedLabel3);
            this.Controls.Add(this.SelectedLabel2);
            this.Controls.Add(this.SelectedLabel1);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.NameComboBox);
            this.Name = "App";
            this.Text = "PersonViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Label SelectedLabel1;
        private System.Windows.Forms.Label SelectedLabel2;
        private System.Windows.Forms.Label SelectedLabel3;
        private System.Windows.Forms.Label SelectedLabel4;
    }
}

