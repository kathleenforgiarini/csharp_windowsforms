namespace finalProject
{
    partial class LottoMax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LottoMax));
            this.label1 = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.PictureBox();
            this.maxTextbox = new System.Windows.Forms.TextBox();
            this.maxGenerate = new System.Windows.Forms.Button();
            this.maxRead = new System.Windows.Forms.Button();
            this.maxExit = new System.Windows.Forms.Button();
            this.maxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "The winning numbers are:";
            // 
            // max
            // 
            this.max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("max.BackgroundImage")));
            this.max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.max.ErrorImage = null;
            this.max.Location = new System.Drawing.Point(35, 48);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(190, 190);
            this.max.TabIndex = 1;
            this.max.TabStop = false;
            // 
            // maxTextbox
            // 
            this.maxTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.maxTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTextbox.Location = new System.Drawing.Point(260, 25);
            this.maxTextbox.Multiline = true;
            this.maxTextbox.Name = "maxTextbox";
            this.maxTextbox.ReadOnly = true;
            this.maxTextbox.Size = new System.Drawing.Size(76, 251);
            this.maxTextbox.TabIndex = 0;
            // 
            // maxGenerate
            // 
            this.maxGenerate.Location = new System.Drawing.Point(31, 300);
            this.maxGenerate.Name = "maxGenerate";
            this.maxGenerate.Size = new System.Drawing.Size(92, 26);
            this.maxGenerate.TabIndex = 3;
            this.maxGenerate.Text = "&Generate";
            this.maxGenerate.UseVisualStyleBackColor = true;
            this.maxGenerate.Click += new System.EventHandler(this.maxGenerate_Click);
            // 
            // maxRead
            // 
            this.maxRead.Location = new System.Drawing.Point(142, 300);
            this.maxRead.Name = "maxRead";
            this.maxRead.Size = new System.Drawing.Size(92, 26);
            this.maxRead.TabIndex = 4;
            this.maxRead.Text = "&Read File";
            this.maxRead.UseVisualStyleBackColor = true;
            this.maxRead.Click += new System.EventHandler(this.maxRead_Click);
            // 
            // maxExit
            // 
            this.maxExit.Location = new System.Drawing.Point(252, 300);
            this.maxExit.Name = "maxExit";
            this.maxExit.Size = new System.Drawing.Size(92, 26);
            this.maxExit.TabIndex = 5;
            this.maxExit.Text = "E&xit";
            this.maxExit.UseVisualStyleBackColor = true;
            this.maxExit.Click += new System.EventHandler(this.maxExit_Click);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(103, 260);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(0, 16);
            this.maxLabel.TabIndex = 6;
            // 
            // LottoMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 348);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.maxExit);
            this.Controls.Add(this.maxRead);
            this.Controls.Add(this.maxGenerate);
            this.Controls.Add(this.maxTextbox);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label1);
            this.Name = "LottoMax";
            this.Text = "LottoMax - Kathleen";
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox max;
        private System.Windows.Forms.TextBox maxTextbox;
        private System.Windows.Forms.Button maxGenerate;
        private System.Windows.Forms.Button maxRead;
        private System.Windows.Forms.Button maxExit;
        private System.Windows.Forms.Label maxLabel;
    }
}