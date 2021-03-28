
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
            this.TestButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FontButton = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.AnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgessBarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(493, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flashcards";
            // 
            // prevbutton
            // 
            this.prevbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prevbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prevbutton.Location = new System.Drawing.Point(453, 570);
            this.prevbutton.Margin = new System.Windows.Forms.Padding(6);
            this.prevbutton.Name = "prevbutton";
            this.prevbutton.Size = new System.Drawing.Size(153, 54);
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
            this.flipbutton.Location = new System.Drawing.Point(746, 561);
            this.flipbutton.Margin = new System.Windows.Forms.Padding(6);
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
            this.nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextbutton.Location = new System.Drawing.Point(1053, 574);
            this.nextbutton.Margin = new System.Windows.Forms.Padding(6);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(160, 54);
            this.nextbutton.TabIndex = 4;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = false;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // randombutton
            // 
            this.randombutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.randombutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randombutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.randombutton.Location = new System.Drawing.Point(111, 718);
            this.randombutton.Margin = new System.Windows.Forms.Padding(6);
            this.randombutton.Name = "randombutton";
            this.randombutton.Size = new System.Drawing.Size(150, 55);
            this.randombutton.TabIndex = 5;
            this.randombutton.Text = "Random";
            this.randombutton.UseVisualStyleBackColor = false;
            this.randombutton.Click += new System.EventHandler(this.randombutton_Click);
            // 
            // shufflebutton
            // 
            this.shufflebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shufflebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shufflebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shufflebutton.Location = new System.Drawing.Point(1296, 718);
            this.shufflebutton.Margin = new System.Windows.Forms.Padding(6);
            this.shufflebutton.Name = "shufflebutton";
            this.shufflebutton.Size = new System.Drawing.Size(170, 52);
            this.shufflebutton.TabIndex = 6;
            this.shufflebutton.Text = "Shuffle";
            this.shufflebutton.UseVisualStyleBackColor = false;
            this.shufflebutton.Click += new System.EventHandler(this.shufflebutton_Click);
            // 
            // FilePicker
            // 
            this.FilePicker.FormattingEnabled = true;
            this.FilePicker.Location = new System.Drawing.Point(453, 183);
            this.FilePicker.Margin = new System.Windows.Forms.Padding(6);
            this.FilePicker.Name = "FilePicker";
            this.FilePicker.Size = new System.Drawing.Size(554, 33);
            this.FilePicker.TabIndex = 7;
            this.FilePicker.SelectedIndexChanged += new System.EventHandler(this.FilePicker_SelectedIndexChanged);
            // 
            // loadbutton
            // 
            this.loadbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadbutton.Location = new System.Drawing.Point(1057, 183);
            this.loadbutton.Margin = new System.Windows.Forms.Padding(6);
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
            this.browsebutton.Location = new System.Drawing.Point(1219, 183);
            this.browsebutton.Margin = new System.Windows.Forms.Padding(6);
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
            this.label2.Location = new System.Drawing.Point(386, 186);
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
            this.richTextBox1.Location = new System.Drawing.Point(453, 289);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(760, 225);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // TestButton
            // 
            this.TestButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestButton.ForeColor = System.Drawing.Color.Red;
            this.TestButton.Location = new System.Drawing.Point(93, 401);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(282, 68);
            this.TestButton.TabIndex = 12;
            this.TestButton.Text = "Test mode";
            this.TestButton.UseVisualStyleBackColor = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // FontButton
            // 
            this.FontButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FontButton.Location = new System.Drawing.Point(1254, 313);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(248, 55);
            this.FontButton.TabIndex = 13;
            this.FontButton.Text = "Change Font";
            this.FontButton.UseVisualStyleBackColor = false;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(721, 567);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(273, 57);
            this.AnswerTextBox.TabIndex = 17;
            this.AnswerTextBox.Text = "";
            this.AnswerTextBox.Visible = false;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerLabel.Location = new System.Drawing.Point(573, 578);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(142, 37);
            this.AnswerLabel.TabIndex = 18;
            this.AnswerLabel.Text = "Answer :";
            this.AnswerLabel.Visible = false;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(1040, 570);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(140, 58);
            this.EnterButton.TabIndex = 19;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Visible = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.Location = new System.Drawing.Point(111, 649);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(137, 63);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(82, 227);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(243, 36);
            this.progressBar1.TabIndex = 21;
            this.progressBar1.Visible = false;
            // 
            // ProgessBarLabel
            // 
            this.ProgessBarLabel.AutoSize = true;
            this.ProgessBarLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProgessBarLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProgessBarLabel.Location = new System.Drawing.Point(166, 278);
            this.ProgessBarLabel.Name = "ProgessBarLabel";
            this.ProgessBarLabel.Size = new System.Drawing.Size(70, 25);
            this.ProgessBarLabel.TabIndex = 22;
            this.ProgessBarLabel.Text = "label3";
            this.ProgessBarLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1557, 858);
            this.Controls.Add(this.ProgessBarLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.TestButton);
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
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Button TestButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox AnswerTextBox;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ProgessBarLabel;
    }
}

