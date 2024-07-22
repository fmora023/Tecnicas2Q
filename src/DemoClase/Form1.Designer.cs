namespace DemoClase
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
            btn_load = new Button();
            SuspendLayout();
            // 
            // btn_load
            // 
            btn_load.Location = new Point(820, 64);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(352, 29);
            btn_load.TabIndex = 0;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += Btn_Accept_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 715);
            Controls.Add(btn_load);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_load;
    }
}
