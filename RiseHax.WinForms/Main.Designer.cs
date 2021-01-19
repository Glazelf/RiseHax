
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
            this.btnLiveHax = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLiveHax
            // 
            this.btnLiveHax.AccessibleName = "buttonLiveHax";
            this.btnLiveHax.Location = new System.Drawing.Point(64, 17);
            this.btnLiveHax.Name = "btnLiveHax";
            this.btnLiveHax.Size = new System.Drawing.Size(150, 52);
            this.btnLiveHax.TabIndex = 0;
            this.btnLiveHax.Text = "LiveHax";
            this.btnLiveHax.UseVisualStyleBackColor = true;
            this.btnLiveHax.Click += new System.EventHandler(this.btnLiveHax_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.AccessibleName = "buttonSaveEdit";
            this.btnSaveEdit.Location = new System.Drawing.Point(64, 87);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(150, 52);
            this.btnSaveEdit.TabIndex = 1;
            this.btnSaveEdit.Text = "Save Edit";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 166);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.btnLiveHax);
            this.Icon = global::RiseHax.WinForms.Properties.Resources.icon;
            this.Name = "Main";
            this.Text = "RiseHax";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnLiveHax;
        private System.Windows.Forms.Button btnSaveEdit;

    }
}

