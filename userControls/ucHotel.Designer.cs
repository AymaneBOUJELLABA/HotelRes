
namespace HotelReservation.userControls
{
    partial class ucHotel
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
            this.ucChambre2 = new HotelReservation.userControls.ucChambre();
            this.ucChambre1 = new HotelReservation.userControls.ucChambre();
            this.SuspendLayout();
            // 
            // ucChambre2
            // 
            this.ucChambre2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucChambre2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucChambre2.Location = new System.Drawing.Point(15, 19);
            this.ucChambre2.Name = "ucChambre2";
            this.ucChambre2.Size = new System.Drawing.Size(180, 168);
            this.ucChambre2.TabIndex = 1;
            // 
            // ucChambre1
            // 
            this.ucChambre1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucChambre1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucChambre1.Location = new System.Drawing.Point(213, 19);
            this.ucChambre1.Name = "ucChambre1";
            this.ucChambre1.Size = new System.Drawing.Size(180, 168);
            this.ucChambre1.TabIndex = 0;
            // 
            // ucHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucChambre2);
            this.Controls.Add(this.ucChambre1);
            this.Name = "ucHotel";
            this.Size = new System.Drawing.Size(410, 209);
            this.ResumeLayout(false);

        }

        #endregion

        private ucChambre ucChambre1;
        private ucChambre ucChambre2;
    }
}
