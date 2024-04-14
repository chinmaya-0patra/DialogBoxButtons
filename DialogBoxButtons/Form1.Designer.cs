namespace DialogBoxButtons
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
            btnYes = new Button();
            lblHighlight = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.Location = new Point(445, 309);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(101, 40);
            btnYes.TabIndex = 0;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // lblHighlight
            // 
            lblHighlight.AutoSize = true;
            lblHighlight.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHighlight.ForeColor = Color.LightCoral;
            lblHighlight.Location = new Point(383, 406);
            lblHighlight.Name = "lblHighlight";
            lblHighlight.Size = new Size(58, 25);
            lblHighlight.TabIndex = 1;
            lblHighlight.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 77);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 2;
            label1.Text = "Purchase Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(357, 164);
            label2.Name = "label2";
            label2.Size = new Size(246, 28);
            label2.TabIndex = 3;
            label2.Text = "Our softwares, your safety";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(368, 247);
            label3.Name = "label3";
            label3.Size = new Size(244, 28);
            label3.TabIndex = 4;
            label3.Text = "Do you want to purchase?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 587);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHighlight);
            Controls.Add(btnYes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYes;
        private Label lblHighlight;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
