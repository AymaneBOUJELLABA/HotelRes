
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
            this.libérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblReserved = new System.Windows.Forms.Label();
            this.ucMenuRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucMenuRes
            // 
            this.ucMenuRes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ucMenuRes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réserverToolStripMenuItem,
            this.libérerToolStripMenuItem});
            this.ucMenuRes.Name = "ucMenuRes";
            this.ucMenuRes.Size = new System.Drawing.Size(181, 70);
            // 
            // réserverToolStripMenuItem
            // 
            this.réserverToolStripMenuItem.Name = "réserverToolStripMenuItem";
            this.réserverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.réserverToolStripMenuItem.Text = "Réserver";
            this.réserverToolStripMenuItem.Click += new System.EventHandler(this.réserverToolStripMenuItem_Click);
            // 
            // libérerToolStripMenuItem
            // 
            this.libérerToolStripMenuItem.Name = "libérerToolStripMenuItem";
            this.libérerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.libérerToolStripMenuItem.Text = "Libérer";
            this.libérerToolStripMenuItem.Click += new System.EventHandler(this.libérerToolStripMenuItem_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.White;
            this.lblNum.Location = new System.Drawing.Point(19, 19);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(19, 13);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "N°";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(19, 57);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 13);
            this.lblType.TabIndex = 2;
            // 
            // lblReserved
            // 
            this.lblReserved.AutoSize = true;
            this.lblReserved.BackColor = System.Drawing.Color.White;
            this.lblReserved.Location = new System.Drawing.Point(19, 110);
            this.lblReserved.Name = "lblReserved";
            this.lblReserved.Size = new System.Drawing.Size(0, 13);
            this.lblReserved.TabIndex = 3;
            // 
            // ucChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.ContextMenuStrip = this.ucMenuRes;
            this.Controls.Add(this.lblReserved);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblNum);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucChambre";
            this.Size = new System.Drawing.Size(141, 162);
            this.ucMenuRes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ucMenuRes;
        private System.Windows.Forms.ToolStripMenuItem réserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libérerToolStripMenuItem;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblReserved;
    }
}
