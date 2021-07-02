
namespace HotelReservation.userControls
{
    partial class ucChambre
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ucMenuRes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.réserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucMenuRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucMenuRes
            // 
            this.ucMenuRes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ucMenuRes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réserverToolStripMenuItem});
            this.ucMenuRes.Name = "ucMenuRes";
            this.ucMenuRes.Size = new System.Drawing.Size(211, 56);
            this.ucMenuRes.Opening += new System.ComponentModel.CancelEventHandler(this.ucMenuRes_Opening);
            // 
            // réserverToolStripMenuItem
            // 
            this.réserverToolStripMenuItem.Name = "réserverToolStripMenuItem";
            this.réserverToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.réserverToolStripMenuItem.Text = "Réserver";
            // 
            // ucChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ContextMenuStrip = this.ucMenuRes;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucChambre";
            this.Size = new System.Drawing.Size(180, 168);
            this.Load += new System.EventHandler(this.ucChambre_Load);
            this.ucMenuRes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ucMenuRes;
        private System.Windows.Forms.ToolStripMenuItem réserverToolStripMenuItem;
    }
}
