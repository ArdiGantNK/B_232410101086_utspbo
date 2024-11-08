namespace utspbo
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
            label1 = new Label();
            buttontugas = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 32);
            label1.Name = "label1";
            label1.Size = new Size(323, 45);
            label1.TabIndex = 0;
            label1.Text = "SELAMAT DATANG";
            // 
            // buttontugas
            // 
            buttontugas.Location = new Point(92, 124);
            buttontugas.Name = "buttontugas";
            buttontugas.Size = new Size(230, 34);
            buttontugas.TabIndex = 1;
            buttontugas.Text = "Halaman Tugas";
            buttontugas.UseVisualStyleBackColor = true;
            buttontugas.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(100, 193);
            button2.Name = "button2";
            button2.Size = new Size(222, 34);
            button2.TabIndex = 2;
            button2.Text = "Pendaftaran Pengguna";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(101, 262);
            button3.Name = "button3";
            button3.Size = new Size(221, 34);
            button3.TabIndex = 3;
            button3.Text = "Login Admin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttontugas);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttontugas;
        private Button button2;
        private Button button3;
    }
}
