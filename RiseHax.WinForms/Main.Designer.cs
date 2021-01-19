
namespace RiseHax.WinForms
{
    partial class Main
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ButtonLiveHax = new System.Windows.Forms.Button();
            this.ButtonSaveEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLiveHax
            // 
            this.ButtonLiveHax.Location = new System.Drawing.Point(64, 17);
            this.ButtonLiveHax.Name = "ButtonLiveHax";
            this.ButtonLiveHax.Size = new System.Drawing.Size(150, 52);
            this.ButtonLiveHax.TabIndex = 0;
            this.ButtonLiveHax.Text = "LiveHax";
            this.ButtonLiveHax.UseVisualStyleBackColor = true;
            // 
            // ButtonSaveEdit
            // 
            this.ButtonSaveEdit.Location = new System.Drawing.Point(64, 87);
            this.ButtonSaveEdit.Name = "ButtonSaveEdit";
            this.ButtonSaveEdit.Size = new System.Drawing.Size(150, 52);
            this.ButtonSaveEdit.TabIndex = 1;
            this.ButtonSaveEdit.Text = "Save Edit";
            this.ButtonSaveEdit.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 166);
            this.Controls.Add(this.ButtonSaveEdit);
            this.Controls.Add(this.ButtonLiveHax);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "RiseHax";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button ButtonLiveHax;
        private System.Windows.Forms.Button ButtonSaveEdit;
    }
}

