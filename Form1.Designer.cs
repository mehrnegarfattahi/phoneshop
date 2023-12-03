
namespace PhoneShop
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
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnphone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncustomer
            // 
            this.btncustomer.Location = new System.Drawing.Point(83, 82);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(144, 77);
            this.btncustomer.TabIndex = 0;
            this.btncustomer.Text = "customer";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnphone
            // 
            this.btnphone.Location = new System.Drawing.Point(305, 82);
            this.btnphone.Name = "btnphone";
            this.btnphone.Size = new System.Drawing.Size(125, 77);
            this.btnphone.TabIndex = 1;
            this.btnphone.Text = "phone";
            this.btnphone.UseVisualStyleBackColor = true;
            this.btnphone.Click += new System.EventHandler(this.btnphone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 243);
            this.Controls.Add(this.btnphone);
            this.Controls.Add(this.btncustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnphone;
    }
}

