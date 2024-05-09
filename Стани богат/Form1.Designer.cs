namespace Стани_богат
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
            pictureBox1 = new PictureBox();
            btnStart = new Button();
            pictureBox2 = new PictureBox();
            lblQuestion = new Label();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._2113033355;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1045, 550);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkBlue;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(436, 409);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(119, 94);
            btnStart.TabIndex = 1;
            btnStart.Text = "Започни игра";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._317189;
            pictureBox2.Location = new Point(133, 103);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(801, 277);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(468, 171);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(73, 25);
            lblQuestion.TabIndex = 3;
            lblQuestion.Text = "Въпрос";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(225, 260);
            lblA.Name = "lblA";
            lblA.Size = new Size(28, 25);
            lblA.TabIndex = 4;
            lblA.Text = "А.";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(577, 260);
            lblB.Name = "lblB";
            lblB.Size = new Size(26, 25);
            lblB.TabIndex = 5;
            lblB.Text = "B.";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(225, 324);
            lblC.Name = "lblC";
            lblC.Size = new Size(27, 25);
            lblC.TabIndex = 6;
            lblC.Text = "C.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(577, 324);
            label4.Name = "label4";
            label4.Size = new Size(29, 25);
            label4.TabIndex = 7;
            label4.Text = "D.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 550);
            Controls.Add(label4);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblQuestion);
            Controls.Add(pictureBox2);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnStart;
        private PictureBox pictureBox2;
        private Label lblQuestion;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Label label4;
    }
}
