
namespace Spotify1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstViewPlaylist = new System.Windows.Forms.ListBox();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(95, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 20);
            this.lblUserName.TabIndex = 1;
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.ItemHeight = 16;
            this.lstPlaylists.Location = new System.Drawing.Point(12, 70);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.Size = new System.Drawing.Size(168, 340);
            this.lstPlaylists.TabIndex = 2;
            this.lstPlaylists.SelectedIndexChanged += new System.EventHandler(this.lstPlaylists_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Playlists:";
            // 
            // lstViewPlaylist
            // 
            this.lstViewPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewPlaylist.FormattingEnabled = true;
            this.lstViewPlaylist.ItemHeight = 16;
            this.lstViewPlaylist.Location = new System.Drawing.Point(199, 70);
            this.lstViewPlaylist.Name = "lstViewPlaylist";
            this.lstViewPlaylist.Size = new System.Drawing.Size(168, 340);
            this.lstViewPlaylist.TabIndex = 4;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(205, 50);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(63, 17);
            this.lblPlaylistName.TabIndex = 5;
            this.lblPlaylistName.Text = "Playlists:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.lstViewPlaylist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPlaylists);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ListBox lstPlaylists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstViewPlaylist;
        private System.Windows.Forms.Label lblPlaylistName;
    }
}