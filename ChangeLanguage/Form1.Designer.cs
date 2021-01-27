namespace ChangeLanguage
{
    partial class TsGUI
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
            this.fillBox = new System.Windows.Forms.TextBox();
            this.translateText = new System.Windows.Forms.Label();
            this.translateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fillBox
            // 
            this.fillBox.BackColor = System.Drawing.Color.White;
            this.fillBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.fillBox.Location = new System.Drawing.Point(0, 0);
            this.fillBox.Name = "fillBox";
            this.fillBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fillBox.Size = new System.Drawing.Size(467, 20);
            this.fillBox.TabIndex = 0;
            // 
            // translateText
            // 
            this.translateText.AutoEllipsis = true;
            this.translateText.AutoSize = true;
            this.translateText.Location = new System.Drawing.Point(-3, 23);
            this.translateText.Name = "translateText";
            this.translateText.Size = new System.Drawing.Size(51, 13);
            this.translateText.TabIndex = 1;
            this.translateText.Text = "Translate";
            // 
            // translateBtn
            // 
            this.translateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.translateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.translateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.translateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.translateBtn.Location = new System.Drawing.Point(0, 103);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(112, 43);
            this.translateBtn.TabIndex = 2;
            this.translateBtn.TabStop = false;
            this.translateBtn.Text = "Translate/Copy";
            this.translateBtn.UseVisualStyleBackColor = false;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(159)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Location = new System.Drawing.Point(118, 103);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(115, 43);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear Text";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Location = new System.Drawing.Point(371, 103);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(95, 43);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 146);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.translateBtn);
            this.Controls.Add(this.translateText);
            this.Controls.Add(this.fillBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TsGUI";
            this.Text = "TextSwitch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fillBox;
        private System.Windows.Forms.Label translateText;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

