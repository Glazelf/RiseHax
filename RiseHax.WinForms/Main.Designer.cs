
namespace RiseHax
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
            this.SaveEdit = new System.Windows.Forms.Button();
            this.LiveHax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveEdit
            // 
            this.SaveEdit.Location = new System.Drawing.Point(75, 40);
            this.SaveEdit.Name = "SaveEdit";
            this.SaveEdit.Size = new System.Drawing.Size(165, 50);
            this.SaveEdit.TabIndex = 0;
            this.SaveEdit.Text = "Save Edit";
            this.SaveEdit.UseVisualStyleBackColor = true;
            // 
            // LiveHax
            // 
            this.LiveHax.Location = new System.Drawing.Point(75, 110);
            this.LiveHax.Name = "LiveHax";
            this.LiveHax.Size = new System.Drawing.Size(165, 50);
            this.LiveHax.TabIndex = 1;
            this.LiveHax.Text = "LiveHax";
            this.LiveHax.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.LiveHax);
            this.Controls.Add(this.SaveEdit);
            this.Name = "Main";
            this.Text = "RiseHax";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveEdit;
        private System.Windows.Forms.Button LiveHax;
    }
}

