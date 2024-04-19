namespace W06___Class_Assignment___Puzzle
{
    partial class Puzzle
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
            this.panel_InputView = new System.Windows.Forms.Panel();
            this.btn_Play = new System.Windows.Forms.Button();
            this.tB_Input = new System.Windows.Forms.TextBox();
            this.lb_Input = new System.Windows.Forms.Label();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.lb_Red = new System.Windows.Forms.Label();
            this.lb_Blue = new System.Windows.Forms.Label();
            this.lb_CountRed = new System.Windows.Forms.Label();
            this.lb_CountBlue = new System.Windows.Forms.Label();
            this.panel_Score = new System.Windows.Forms.Panel();
            this.panel_InputView.SuspendLayout();
            this.panel_Score.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_InputView
            // 
            this.panel_InputView.Controls.Add(this.btn_Play);
            this.panel_InputView.Controls.Add(this.tB_Input);
            this.panel_InputView.Controls.Add(this.lb_Input);
            this.panel_InputView.Controls.Add(this.lb_Welcome);
            this.panel_InputView.Location = new System.Drawing.Point(4, 12);
            this.panel_InputView.Name = "panel_InputView";
            this.panel_InputView.Size = new System.Drawing.Size(267, 193);
            this.panel_InputView.TabIndex = 0;
            this.panel_InputView.VisibleChanged += new System.EventHandler(this.panel_InputView_VisibleChanged);
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(103, 143);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(49, 23);
            this.btn_Play.TabIndex = 3;
            this.btn_Play.Text = "PLAY";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // tB_Input
            // 
            this.tB_Input.Location = new System.Drawing.Point(86, 107);
            this.tB_Input.Name = "tB_Input";
            this.tB_Input.Size = new System.Drawing.Size(87, 20);
            this.tB_Input.TabIndex = 2;
            this.tB_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Input_KeyPress);
            // 
            // lb_Input
            // 
            this.lb_Input.AutoSize = true;
            this.lb_Input.Location = new System.Drawing.Point(72, 81);
            this.lb_Input.Name = "lb_Input";
            this.lb_Input.Size = new System.Drawing.Size(113, 13);
            this.lb_Input.TabIndex = 1;
            this.lb_Input.Text = "Input Your Puzzle Size";
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Location = new System.Drawing.Point(100, 38);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(52, 13);
            this.lb_Welcome.TabIndex = 0;
            this.lb_Welcome.Text = "Welcome";
            // 
            // lb_Red
            // 
            this.lb_Red.AutoSize = true;
            this.lb_Red.Location = new System.Drawing.Point(19, 18);
            this.lb_Red.Name = "lb_Red";
            this.lb_Red.Size = new System.Drawing.Size(30, 13);
            this.lb_Red.TabIndex = 1;
            this.lb_Red.Text = "RED";
            // 
            // lb_Blue
            // 
            this.lb_Blue.AutoSize = true;
            this.lb_Blue.Location = new System.Drawing.Point(95, 18);
            this.lb_Blue.Name = "lb_Blue";
            this.lb_Blue.Size = new System.Drawing.Size(35, 13);
            this.lb_Blue.TabIndex = 2;
            this.lb_Blue.Text = "BLUE";
            // 
            // lb_CountRed
            // 
            this.lb_CountRed.AutoSize = true;
            this.lb_CountRed.Location = new System.Drawing.Point(19, 50);
            this.lb_CountRed.Name = "lb_CountRed";
            this.lb_CountRed.Size = new System.Drawing.Size(13, 13);
            this.lb_CountRed.TabIndex = 3;
            this.lb_CountRed.Text = "0";
            // 
            // lb_CountBlue
            // 
            this.lb_CountBlue.AutoSize = true;
            this.lb_CountBlue.Location = new System.Drawing.Point(95, 50);
            this.lb_CountBlue.Name = "lb_CountBlue";
            this.lb_CountBlue.Size = new System.Drawing.Size(13, 13);
            this.lb_CountBlue.TabIndex = 4;
            this.lb_CountBlue.Text = "0";
            // 
            // panel_Score
            // 
            this.panel_Score.Controls.Add(this.lb_CountBlue);
            this.panel_Score.Controls.Add(this.lb_CountRed);
            this.panel_Score.Controls.Add(this.lb_Blue);
            this.panel_Score.Controls.Add(this.lb_Red);
            this.panel_Score.Location = new System.Drawing.Point(277, 23);
            this.panel_Score.Name = "panel_Score";
            this.panel_Score.Size = new System.Drawing.Size(156, 93);
            this.panel_Score.TabIndex = 5;
            this.panel_Score.Visible = false;
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 379);
            this.Controls.Add(this.panel_Score);
            this.Controls.Add(this.panel_InputView);
            this.Name = "Puzzle";
            this.Text = "Puzzle";
            this.panel_InputView.ResumeLayout(false);
            this.panel_InputView.PerformLayout();
            this.panel_Score.ResumeLayout(false);
            this.panel_Score.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_InputView;
        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.TextBox tB_Input;
        private System.Windows.Forms.Label lb_Input;
        private System.Windows.Forms.Label lb_Red;
        private System.Windows.Forms.Label lb_Blue;
        private System.Windows.Forms.Label lb_CountRed;
        private System.Windows.Forms.Label lb_CountBlue;
        private System.Windows.Forms.Panel panel_Score;
    }
}

