
namespace Assessment_3___FlashCards
{
    partial class Form1
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
            this.prevbutton = new System.Windows.Forms.Button();
            this.flipbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.randombutton = new System.Windows.Forms.Button();
            this.shufflebutton = new System.Windows.Forms.Button();
            this.FilePicker = new System.Windows.Forms.ComboBox();
            this.loadbutton = new System.Windows.Forms.Button();
            this.browsebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(428, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flashcards";
            // 
            // prevbutton
            // 
            this.prevbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prevbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prevbutton.Location = new System.Drawing.Point(370, 594);
            this.prevbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.prevbutton.Name = "prevbutton";
            this.prevbutton.Size = new System.Drawing.Size(150, 44);
            this.prevbutton.TabIndex = 2;
            this.prevbutton.Text = "Back";
            this.prevbutton.UseVisualStyleBackColor = false;
            this.prevbutton.Click += new System.EventHandler(this.prevbutton_Click);
            // 
            // flipbutton
            // 
            this.flipbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flipbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipbutton.ForeColor = System.Drawing.Color.Red;
            this.flipbutton.Location = new System.Drawing.Point(672, 578);
            this.flipbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flipbutton.Name = "flipbutton";
            this.flipbutton.Size = new System.Drawing.Size(184, 70);
            this.flipbutton.TabIndex = 3;
            this.flipbutton.Text = "Flip!!";
            this.flipbutton.UseVisualStyleBackColor = false;
            this.flipbutton.Click += new System.EventHandler(this.flipbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextbutton.Location = new System.Drawing.Point(970, 594);
            this.nextbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(150, 44);
            this.nextbutton.TabIndex = 4;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = false;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // randombutton
            // 
            this.randombutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.randombutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.randombutton.Location = new System.Drawing.Point(116, 754);
            this.randombutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.randombutton.Name = "randombutton";
            this.randombutton.Size = new System.Drawing.Size(150, 44);
            this.randombutton.TabIndex = 5;
            this.randombutton.Text = "Random";
            this.randombutton.UseVisualStyleBackColor = false;
            this.randombutton.Click += new System.EventHandler(this.randombutton_Click);
            // 
            // shufflebutton
            // 
            this.shufflebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shufflebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shufflebutton.Location = new System.Drawing.Point(1316, 754);
            this.shufflebutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.shufflebutton.Name = "shufflebutton";
            this.shufflebutton.Size = new System.Drawing.Size(150, 44);
            this.shufflebutton.TabIndex = 6;
            this.shufflebutton.Text = "Shuffle";
            this.shufflebutton.UseVisualStyleBackColor = false;
            this.shufflebutton.Click += new System.EventHandler(this.shufflebutton_Click);
            // 
            // FilePicker
            // 
            this.FilePicker.FormattingEnabled = true;
            this.FilePicker.Location = new System.Drawing.Point(366, 188);
            this.FilePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilePicker.Name = "FilePicker";
            this.FilePicker.Size = new System.Drawing.Size(554, 33);
            this.FilePicker.TabIndex = 7;
            this.FilePicker.SelectedIndexChanged += new System.EventHandler(this.FilePicker_SelectedIndexChanged);
            // 
            // loadbutton
            // 
            this.loadbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadbutton.Location = new System.Drawing.Point(970, 188);
            this.loadbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(150, 44);
            this.loadbutton.TabIndex = 8;
            this.loadbutton.Text = "Load";
            this.loadbutton.UseVisualStyleBackColor = false;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // browsebutton
            // 
            this.browsebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browsebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browsebutton.Location = new System.Drawing.Point(1132, 188);
            this.browsebutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(150, 44);
            this.browsebutton.TabIndex = 9;
            this.browsebutton.Text = "Browse";
            this.browsebutton.UseVisualStyleBackColor = false;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(294, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Location = new System.Drawing.Point(370, 308);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(746, 225);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browsebutton);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.FilePicker);
            this.Controls.Add(this.shufflebutton);
            this.Controls.Add(this.randombutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.flipbutton);
            this.Controls.Add(this.prevbutton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prevbutton;
        private System.Windows.Forms.Button flipbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button randombutton;
        private System.Windows.Forms.Button shufflebutton;
        private System.Windows.Forms.ComboBox FilePicker;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

