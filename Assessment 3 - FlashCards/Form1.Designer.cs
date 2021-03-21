
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
            this.label1.Location = new System.Drawing.Point(214, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flashcards";
            // 
            // prevbutton
            // 
            this.prevbutton.Location = new System.Drawing.Point(185, 309);
            this.prevbutton.Name = "prevbutton";
            this.prevbutton.Size = new System.Drawing.Size(75, 23);
            this.prevbutton.TabIndex = 2;
            this.prevbutton.Text = "Back";
            this.prevbutton.UseVisualStyleBackColor = true;
            // 
            // flipbutton
            // 
            this.flipbutton.Location = new System.Drawing.Point(345, 309);
            this.flipbutton.Name = "flipbutton";
            this.flipbutton.Size = new System.Drawing.Size(75, 23);
            this.flipbutton.TabIndex = 3;
            this.flipbutton.Text = "Flip!!";
            this.flipbutton.UseVisualStyleBackColor = true;
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(485, 309);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(75, 23);
            this.nextbutton.TabIndex = 4;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            // 
            // randombutton
            // 
            this.randombutton.Location = new System.Drawing.Point(26, 392);
            this.randombutton.Name = "randombutton";
            this.randombutton.Size = new System.Drawing.Size(75, 23);
            this.randombutton.TabIndex = 5;
            this.randombutton.Text = "Random";
            this.randombutton.UseVisualStyleBackColor = true;
            // 
            // shufflebutton
            // 
            this.shufflebutton.Location = new System.Drawing.Point(694, 392);
            this.shufflebutton.Name = "shufflebutton";
            this.shufflebutton.Size = new System.Drawing.Size(75, 23);
            this.shufflebutton.TabIndex = 6;
            this.shufflebutton.Text = "Shuffle";
            this.shufflebutton.UseVisualStyleBackColor = true;
            // 
            // FilePicker
            // 
            this.FilePicker.FormattingEnabled = true;
            this.FilePicker.Location = new System.Drawing.Point(183, 98);
            this.FilePicker.Name = "FilePicker";
            this.FilePicker.Size = new System.Drawing.Size(279, 21);
            this.FilePicker.TabIndex = 7;
            this.FilePicker.SelectedIndexChanged += new System.EventHandler(this.FilePicker_SelectedIndexChanged);
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(485, 98);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(75, 23);
            this.loadbutton.TabIndex = 8;
            this.loadbutton.Text = "Load";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // browsebutton
            // 
            this.browsebutton.Location = new System.Drawing.Point(566, 98);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(75, 23);
            this.browsebutton.TabIndex = 9;
            this.browsebutton.Text = "Browse";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(185, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(375, 119);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

