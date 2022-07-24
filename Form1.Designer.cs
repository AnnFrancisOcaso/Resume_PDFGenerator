
namespace JSON_RESUME_TO_PDF
{
    partial class pdfgenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pdfgenerator));
            this.Generatebttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generatebttn
            // 
            this.Generatebttn.BackColor = System.Drawing.Color.MistyRose;
            this.Generatebttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generatebttn.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generatebttn.Location = new System.Drawing.Point(101, 218);
            this.Generatebttn.Name = "Generatebttn";
            this.Generatebttn.Size = new System.Drawing.Size(273, 49);
            this.Generatebttn.TabIndex = 0;
            this.Generatebttn.Text = "Generate PDF here";
            this.Generatebttn.UseVisualStyleBackColor = false;
            // 
            // pdfgenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(467, 313);
            this.Controls.Add(this.Generatebttn);
            this.Name = "pdfgenerator";
            this.Text = "PDF Generator";
            this.Load += new System.EventHandler(this.pdfgenerator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generatebttn;
    }
}

