namespace Tic_Tac_Toe
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            AITimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "Player wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(263, 18);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 1;
            label2.Text = "AI wins:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 69);
            button1.Name = "button1";
            button1.Size = new Size(119, 120);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlayerClick;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(153, 69);
            button2.Name = "button2";
            button2.Size = new Size(119, 120);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += PlayerClick;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(298, 69);
            button3.Name = "button3";
            button3.Size = new Size(119, 120);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += PlayerClick;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 195);
            button4.Name = "button4";
            button4.Size = new Size(119, 120);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            button4.Click += PlayerClick;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLightLight;
            button5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(153, 195);
            button5.Name = "button5";
            button5.Size = new Size(119, 120);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = false;
            button5.Click += PlayerClick;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(298, 195);
            button6.Name = "button6";
            button6.Size = new Size(119, 120);
            button6.TabIndex = 2;
            button6.UseVisualStyleBackColor = false;
            button6.Click += PlayerClick;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLightLight;
            button7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(12, 321);
            button7.Name = "button7";
            button7.Size = new Size(119, 120);
            button7.TabIndex = 2;
            button7.UseVisualStyleBackColor = false;
            button7.Click += PlayerClick;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLightLight;
            button8.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(153, 321);
            button8.Name = "button8";
            button8.Size = new Size(119, 120);
            button8.TabIndex = 2;
            button8.UseVisualStyleBackColor = false;
            button8.Click += PlayerClick;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLightLight;
            button9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(298, 321);
            button9.Name = "button9";
            button9.Size = new Size(119, 120);
            button9.TabIndex = 2;
            button9.UseVisualStyleBackColor = false;
            button9.Click += PlayerClick;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(130, 478);
            button10.Name = "button10";
            button10.Size = new Size(162, 40);
            button10.TabIndex = 3;
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Restart;
            // 
            // AITimer
            // 
            AITimer.Interval = 1000;
            AITimer.Tick += AIMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 540);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer AITimer;
    }
}