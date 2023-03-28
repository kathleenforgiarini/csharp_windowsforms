namespace finalProject
{
    partial class Temperature
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
            this.cTof = new System.Windows.Forms.RadioButton();
            this.fToc = new System.Windows.Forms.RadioButton();
            this.fromTextbox = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.toTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cTof
            // 
            this.cTof.AutoSize = true;
            this.cTof.Location = new System.Drawing.Point(154, 25);
            this.cTof.Name = "cTof";
            this.cTof.Size = new System.Drawing.Size(91, 20);
            this.cTof.TabIndex = 0;
            this.cTof.TabStop = true;
            this.cTof.Text = "from C to F";
            this.cTof.UseVisualStyleBackColor = true;
            this.cTof.CheckedChanged += new System.EventHandler(this.cTof_CheckedChanged);
            // 
            // fToc
            // 
            this.fToc.AutoSize = true;
            this.fToc.Location = new System.Drawing.Point(154, 71);
            this.fToc.Name = "fToc";
            this.fToc.Size = new System.Drawing.Size(91, 20);
            this.fToc.TabIndex = 1;
            this.fToc.TabStop = true;
            this.fToc.Text = "from F to C";
            this.fToc.UseVisualStyleBackColor = true;
            // 
            // fromTextbox
            // 
            this.fromTextbox.Location = new System.Drawing.Point(40, 117);
            this.fromTextbox.Name = "fromTextbox";
            this.fromTextbox.Size = new System.Drawing.Size(131, 22);
            this.fromTextbox.TabIndex = 2;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(94, 149);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(22, 20);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "C";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(282, 149);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 20);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "F";
            // 
            // toTextbox
            // 
            this.toTextbox.Location = new System.Drawing.Point(227, 117);
            this.toTextbox.Name = "toTextbox";
            this.toTextbox.ReadOnly = true;
            this.toTextbox.Size = new System.Drawing.Size(131, 22);
            this.toTextbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(13, 282);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(103, 26);
            this.convert.TabIndex = 9;
            this.convert.Text = "&Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(147, 282);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(103, 26);
            this.read.TabIndex = 10;
            this.read.Text = "&Read File";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(281, 282);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(103, 26);
            this.exit.TabIndex = 11;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(12, 226);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 16);
            this.message.TabIndex = 12;
            // 
            // Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 324);
            this.Controls.Add(this.message);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.read);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.toTextbox);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.fromTextbox);
            this.Controls.Add(this.fToc);
            this.Controls.Add(this.cTof);
            this.Name = "Temperature";
            this.Text = "Temp App - Kathleen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton cTof;
        private System.Windows.Forms.RadioButton fToc;
        private System.Windows.Forms.TextBox fromTextbox;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox toTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label message;
    }
}