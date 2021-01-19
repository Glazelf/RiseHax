
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonLiveHax = new System.Windows.Forms.Button();
            this.ButtonSaveEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLiveHax
            // 
            this.ButtonLiveHax.Location = new System.Drawing.Point(75, 20);
            this.ButtonLiveHax.Name = "ButtonLiveHax";
            this.ButtonLiveHax.Size = new System.Drawing.Size(175, 60);
            this.ButtonLiveHax.TabIndex = 0;
            this.ButtonLiveHax.Text = "LiveHax";
            this.ButtonLiveHax.UseVisualStyleBackColor = true;
            // 
            // ButtonSaveEdit
            // 
            this.ButtonSaveEdit.Location = new System.Drawing.Point(75, 100);
            this.ButtonSaveEdit.Name = "ButtonSaveEdit";
            this.ButtonSaveEdit.Size = new System.Drawing.Size(175, 60);
            this.ButtonSaveEdit.TabIndex = 1;
            this.ButtonSaveEdit.Text = "Save Edit";
            this.ButtonSaveEdit.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 191);
            this.Controls.Add(this.ButtonSaveEdit);
            this.Controls.Add(this.ButtonLiveHax);
            this.Name = "Main";
            this.Text = "RiseHax";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLiveHax;
        private System.Windows.Forms.Button ButtonSaveEdit;
    }
}

