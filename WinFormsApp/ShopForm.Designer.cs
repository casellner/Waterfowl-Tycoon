namespace WinFormsApp
{
    partial class ShopForm
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
            buyButton = new Button();
            SuspendLayout();
            // 
            // buyButton
            // 
            buyButton.Location = new Point(523, 58);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(112, 34);
            buyButton.TabIndex = 0;
            buyButton.Text = "buy";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buyButton);
            Name = "ShopForm";
            Text = "ShopForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buyButton;
    }
}