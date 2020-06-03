namespace BlackJackDissertation.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btn_new_game = new System.Windows.Forms.Button();
            this.btn_rules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_new_game
            // 
            this.btn_new_game.BackColor = System.Drawing.Color.Silver;
            this.btn_new_game.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_new_game.FlatAppearance.BorderSize = 3;
            this.btn_new_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_game.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_new_game.Location = new System.Drawing.Point(338, 394);
            this.btn_new_game.Name = "btn_new_game";
            this.btn_new_game.Size = new System.Drawing.Size(147, 33);
            this.btn_new_game.TabIndex = 1;
            this.btn_new_game.Text = "New Game";
            this.btn_new_game.UseVisualStyleBackColor = false;
            this.btn_new_game.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_rules
            // 
            this.btn_rules.BackColor = System.Drawing.Color.Silver;
            this.btn_rules.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rules.FlatAppearance.BorderSize = 3;
            this.btn_rules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rules.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_rules.Location = new System.Drawing.Point(338, 433);
            this.btn_rules.Name = "btn_rules";
            this.btn_rules.Size = new System.Drawing.Size(147, 33);
            this.btn_rules.TabIndex = 2;
            this.btn_rules.Text = "Rules";
            this.btn_rules.UseVisualStyleBackColor = false;
            this.btn_rules.Click += new System.EventHandler(this.btn_rules_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 474);
            this.Controls.Add(this.btn_rules);
            this.Controls.Add(this.btn_new_game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_new_game;
        private System.Windows.Forms.Button btn_rules;
    }
}