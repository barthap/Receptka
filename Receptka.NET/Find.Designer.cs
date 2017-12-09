namespace Receptka
{
    partial class FindDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDialog));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindCancelButton = new System.Windows.Forms.Button();
            this.FindSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wpisz nazwisko lub pesel (cały lub 6 pierwszych cyfr)";
            // 
            // FindCancelButton
            // 
            this.FindCancelButton.Location = new System.Drawing.Point(306, 42);
            this.FindCancelButton.Name = "FindCancelButton";
            this.FindCancelButton.Size = new System.Drawing.Size(75, 23);
            this.FindCancelButton.TabIndex = 2;
            this.FindCancelButton.Text = "Anuluj";
            this.FindCancelButton.UseVisualStyleBackColor = true;
            this.FindCancelButton.Click += new System.EventHandler(this.CloseDialog);
            // 
            // FindSearchButton
            // 
            this.FindSearchButton.Location = new System.Drawing.Point(306, 9);
            this.FindSearchButton.Name = "FindSearchButton";
            this.FindSearchButton.Size = new System.Drawing.Size(75, 23);
            this.FindSearchButton.TabIndex = 2;
            this.FindSearchButton.Text = "Szukaj";
            this.FindSearchButton.UseVisualStyleBackColor = true;
            this.FindSearchButton.Click += new System.EventHandler(this.FindSearchButton_Click);
            // 
            // FindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 74);
            this.Controls.Add(this.FindCancelButton);
            this.Controls.Add(this.FindSearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindDialog";
            this.ShowInTaskbar = false;
            this.Text = "Znajdź";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindCancelButton;
        private System.Windows.Forms.Button FindSearchButton;
    }
}