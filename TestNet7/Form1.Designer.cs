namespace TestNet7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStrings = new System.Windows.Forms.Button();
            this.btnSpan = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStrings
            // 
            this.btnStrings.Location = new System.Drawing.Point(29, 40);
            this.btnStrings.Name = "btnStrings";
            this.btnStrings.Size = new System.Drawing.Size(75, 23);
            this.btnStrings.TabIndex = 0;
            this.btnStrings.Text = "Strings";
            this.btnStrings.UseVisualStyleBackColor = true;
            this.btnStrings.Click += new System.EventHandler(this.btnStrings_Click);
            // 
            // btnSpan
            // 
            this.btnSpan.Location = new System.Drawing.Point(110, 40);
            this.btnSpan.Name = "btnSpan";
            this.btnSpan.Size = new System.Drawing.Size(75, 23);
            this.btnSpan.TabIndex = 1;
            this.btnSpan.Text = "Span";
            this.btnSpan.UseVisualStyleBackColor = true;
            this.btnSpan.Click += new System.EventHandler(this.btnSpan_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(191, 40);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(75, 23);
            this.btnLoop.TabIndex = 2;
            this.btnLoop.Text = "Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.btnSpan);
            this.Controls.Add(this.btnStrings);
            this.Name = "Form1";
            this.Text = ".NET 7";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStrings;
        private Button btnSpan;
        private Button btnLoop;
    }
}