namespace EditorDisciples
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
            this.WidthBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplyWidth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightBar = new System.Windows.Forms.TrackBar();
            this.ApplyHeight = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.ComboBox();
            this.ApplyDif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBar)).BeginInit();
            this.SuspendLayout();
            // 
            // WidthBar
            // 
            this.WidthBar.LargeChange = 1;
            this.WidthBar.Location = new System.Drawing.Point(396, 253);
            this.WidthBar.Maximum = 20;
            this.WidthBar.Minimum = 8;
            this.WidthBar.Name = "WidthBar";
            this.WidthBar.Size = new System.Drawing.Size(104, 45);
            this.WidthBar.TabIndex = 0;
            this.WidthBar.Value = 8;
            this.WidthBar.Scroll += new System.EventHandler(this.WidthBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(355, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // ApplyWidth
            // 
            this.ApplyWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyWidth.Location = new System.Drawing.Point(507, 242);
            this.ApplyWidth.Name = "ApplyWidth";
            this.ApplyWidth.Size = new System.Drawing.Size(75, 23);
            this.ApplyWidth.TabIndex = 2;
            this.ApplyWidth.Text = "Apply";
            this.ApplyWidth.UseVisualStyleBackColor = true;
            this.ApplyWidth.Click += new System.EventHandler(this.ApplyWidth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(359, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // HeightBar
            // 
            this.HeightBar.LargeChange = 1;
            this.HeightBar.Location = new System.Drawing.Point(409, 304);
            this.HeightBar.Maximum = 20;
            this.HeightBar.Minimum = 8;
            this.HeightBar.Name = "HeightBar";
            this.HeightBar.Size = new System.Drawing.Size(104, 45);
            this.HeightBar.TabIndex = 4;
            this.HeightBar.Value = 8;
            this.HeightBar.Scroll += new System.EventHandler(this.HeightBar_Scroll);
            // 
            // ApplyHeight
            // 
            this.ApplyHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyHeight.Location = new System.Drawing.Point(520, 304);
            this.ApplyHeight.Name = "ApplyHeight";
            this.ApplyHeight.Size = new System.Drawing.Size(75, 23);
            this.ApplyHeight.TabIndex = 5;
            this.ApplyHeight.Text = "Apply";
            this.ApplyHeight.UseVisualStyleBackColor = true;
            this.ApplyHeight.Click += new System.EventHandler(this.ApplyHeight_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(442, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(445, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(335, 102);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(118, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save to xml";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(504, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Difficulty";
            // 
            // Difficulty
            // 
            this.Difficulty.FormattingEnabled = true;
            this.Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.Difficulty.Location = new System.Drawing.Point(594, 167);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(121, 21);
            this.Difficulty.TabIndex = 10;
            this.Difficulty.Text = "Easy";
            // 
            // ApplyDif
            // 
            this.ApplyDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyDif.Location = new System.Drawing.Point(710, 143);
            this.ApplyDif.Name = "ApplyDif";
            this.ApplyDif.Size = new System.Drawing.Size(75, 23);
            this.ApplyDif.TabIndex = 11;
            this.ApplyDif.Text = "Apply";
            this.ApplyDif.UseVisualStyleBackColor = true;
            this.ApplyDif.Click += new System.EventHandler(this.ApplyDif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ApplyDif);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ApplyHeight);
            this.Controls.Add(this.HeightBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApplyWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WidthBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar WidthBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ApplyWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar HeightBar;
        private System.Windows.Forms.Button ApplyHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Difficulty;
        private System.Windows.Forms.Button ApplyDif;
    }
}

