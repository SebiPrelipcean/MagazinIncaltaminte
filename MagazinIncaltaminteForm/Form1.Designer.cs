
namespace MagazinIncaltaminteForm
{
    partial class MainForm
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
            this.NavBarPanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.UserNameBox = new System.Windows.Forms.PictureBox();
            this.NavBarPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBarPanel
            // 
            this.NavBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.NavBarPanel.Controls.Add(this.ExitBtn);
            this.NavBarPanel.Controls.Add(this.CartButton);
            this.NavBarPanel.Controls.Add(this.ShopBtn);
            this.NavBarPanel.Controls.Add(this.UserPanel);
            this.NavBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBarPanel.Location = new System.Drawing.Point(0, 0);
            this.NavBarPanel.Name = "NavBarPanel";
            this.NavBarPanel.Padding = new System.Windows.Forms.Padding(2);
            this.NavBarPanel.Size = new System.Drawing.Size(240, 755);
            this.NavBarPanel.TabIndex = 0;
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.UsernameLabel);
            this.UserPanel.Controls.Add(this.UserNameBox);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(2, 2);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(236, 163);
            this.UserPanel.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLabel.Location = new System.Drawing.Point(60, 93);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(101, 25);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Image = global::MagazinIncaltaminteForm.Properties.Resources.external_content_duckduckgo_w7P_icon;
            this.ExitBtn.Location = new System.Drawing.Point(2, 676);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ExitBtn.Size = new System.Drawing.Size(236, 77);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CartButton
            // 
            this.CartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.CartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CartButton.FlatAppearance.BorderSize = 0;
            this.CartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CartButton.Image = global::MagazinIncaltaminteForm.Properties.Resources.external_content_duckduckgo_xXf_icon;
            this.CartButton.Location = new System.Drawing.Point(2, 265);
            this.CartButton.Name = "CartButton";
            this.CartButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.CartButton.Size = new System.Drawing.Size(236, 98);
            this.CartButton.TabIndex = 2;
            this.CartButton.Text = "Cart";
            this.CartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CartButton.UseVisualStyleBackColor = false;
            // 
            // ShopBtn
            // 
            this.ShopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.ShopBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShopBtn.FlatAppearance.BorderSize = 0;
            this.ShopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShopBtn.Image = global::MagazinIncaltaminteForm.Properties.Resources.external_content_duckduckgo_6iB_icon;
            this.ShopBtn.Location = new System.Drawing.Point(2, 165);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ShopBtn.Size = new System.Drawing.Size(236, 100);
            this.ShopBtn.TabIndex = 1;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShopBtn.UseVisualStyleBackColor = false;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Image = global::MagazinIncaltaminteForm.Properties.Resources.user;
            this.UserNameBox.Location = new System.Drawing.Point(65, 21);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(92, 69);
            this.UserNameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserNameBox.TabIndex = 0;
            this.UserNameBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 755);
            this.Controls.Add(this.NavBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.NavBarPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBarPanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox UserNameBox;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button CartButton;
    }
}

