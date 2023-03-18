namespace finalProject
{
    partial class Lotto649
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotto649));
            this.l649Label = new System.Windows.Forms.Label();
            this.l649Exit = new System.Windows.Forms.Button();
            this.l649Read = new System.Windows.Forms.Button();
            this.l649Generate = new System.Windows.Forms.Button();
            this.l649Textbox = new System.Windows.Forms.TextBox();
            this.l649 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.l649)).BeginInit();
            this.SuspendLayout();
            // 
            // l649Label
            // 
            this.l649Label.AutoSize = true;
            this.l649Label.Location = new System.Drawing.Point(103, 261);
            this.l649Label.Name = "l649Label";
            this.l649Label.Size = new System.Drawing.Size(0, 16);
            this.l649Label.TabIndex = 13;
            // 
            // l649Exit
            // 
            this.l649Exit.Location = new System.Drawing.Point(249, 301);
            this.l649Exit.Name = "l649Exit";
            this.l649Exit.Size = new System.Drawing.Size(92, 26);
            this.l649Exit.TabIndex = 12;
            this.l649Exit.Text = "E&xit";
            this.l649Exit.UseVisualStyleBackColor = true;
            this.l649Exit.Click += new System.EventHandler(this.l649Exit_Click);
            // 
            // l649Read
            // 
            this.l649Read.Location = new System.Drawing.Point(139, 301);
            this.l649Read.Name = "l649Read";
            this.l649Read.Size = new System.Drawing.Size(92, 26);
            this.l649Read.TabIndex = 11;
            this.l649Read.Text = "&Read File";
            this.l649Read.UseVisualStyleBackColor = true;
            this.l649Read.Click += new System.EventHandler(this.l649Read_Click);
            // 
            // l649Generate
            // 
            this.l649Generate.Location = new System.Drawing.Point(28, 301);
            this.l649Generate.Name = "l649Generate";
            this.l649Generate.Size = new System.Drawing.Size(92, 26);
            this.l649Generate.TabIndex = 10;
            this.l649Generate.Text = "&Generate";
            this.l649Generate.UseVisualStyleBackColor = true;
            this.l649Generate.Click += new System.EventHandler(this.l649Generate_Click);
            // 
            // l649Textbox
            // 
            this.l649Textbox.BackColor = System.Drawing.SystemColors.Window;
            this.l649Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l649Textbox.Location = new System.Drawing.Point(257, 26);
            this.l649Textbox.Multiline = true;
            this.l649Textbox.Name = "l649Textbox";
            this.l649Textbox.ReadOnly = true;
            this.l649Textbox.Size = new System.Drawing.Size(76, 251);
            this.l649Textbox.TabIndex = 7;
            // 
            // l649
            // 
            this.l649.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("l649.BackgroundImage")));
            this.l649.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.l649.ErrorImage = null;
            this.l649.Location = new System.Drawing.Point(32, 49);
            this.l649.Name = "l649";
            this.l649.Size = new System.Drawing.Size(190, 190);
            this.l649.TabIndex = 9;
            this.l649.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "The winning numbers are:";
            // 
            // Lotto649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 341);
            this.Controls.Add(this.l649Label);
            this.Controls.Add(this.l649Exit);
            this.Controls.Add(this.l649Read);
            this.Controls.Add(this.l649Generate);
            this.Controls.Add(this.l649Textbox);
            this.Controls.Add(this.l649);
            this.Controls.Add(this.label1);
            this.Name = "Lotto649";
            this.Text = "Lotto649 - Kathleen";
            ((System.ComponentModel.ISupportInitialize)(this.l649)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l649Label;
        private System.Windows.Forms.Button l649Exit;
        private System.Windows.Forms.Button l649Read;
        private System.Windows.Forms.Button l649Generate;
        private System.Windows.Forms.TextBox l649Textbox;
        private System.Windows.Forms.PictureBox l649;
        private System.Windows.Forms.Label label1;
    }
}