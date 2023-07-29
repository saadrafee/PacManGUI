
namespace PacManGUI
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
            components = new System.ComponentModel.Container();
            gameLoop = new System.Windows.Forms.Timer(components);
            lblMarks = new Label();
            lblScoreValue = new Label();
            SuspendLayout();
            // 
            // gameLoop
            // 
            gameLoop.Enabled = true;
            gameLoop.Tick += gameLoop_Tick;
            // 
            // lblMarks
            // 
            lblMarks.AutoSize = true;
            lblMarks.BackColor = Color.White;
            lblMarks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarks.Location = new Point(14, 557);
            lblMarks.Margin = new Padding(4, 0, 4, 0);
            lblMarks.Name = "lblMarks";
            lblMarks.Size = new Size(55, 20);
            lblMarks.TabIndex = 0;
            lblMarks.Text = "Score:";
            // 
            // lblScoreValue
            // 
            lblScoreValue.AutoSize = true;
            lblScoreValue.BackColor = Color.White;
            lblScoreValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblScoreValue.Location = new Point(85, 557);
            lblScoreValue.Margin = new Padding(4, 0, 4, 0);
            lblScoreValue.Name = "lblScoreValue";
            lblScoreValue.Size = new Size(18, 20);
            lblScoreValue.TabIndex = 1;
            lblScoreValue.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1370, 749);
            Controls.Add(lblScoreValue);
            Controls.Add(lblMarks);
            ForeColor = Color.Black;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private Label lblMarks;
        private Label lblScoreValue;
    }
}

