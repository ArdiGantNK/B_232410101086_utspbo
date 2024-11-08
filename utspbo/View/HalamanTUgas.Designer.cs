namespace utspbo.View
{
    partial class HalamanTUgas
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
            Tugas = new Label();
            SuspendLayout();
            // 
            // Tugas
            // 
            Tugas.AutoSize = true;
            Tugas.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tugas.Location = new Point(325, 32);
            Tugas.Name = "Tugas";
            Tugas.Size = new Size(293, 48);
            Tugas.TabIndex = 0;
            Tugas.Text = "Halaman Tugas";
            // 
            // HalamanTUgas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tugas);
            Name = "HalamanTUgas";
            Text = "HalamanTUgas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tugas;
    }
}