namespace BlackJackDissertation
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.betInput = new System.Windows.Forms.TextBox();
            this.playerCard5 = new System.Windows.Forms.PictureBox();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.dealerCard2 = new System.Windows.Forms.PictureBox();
            this.dealerCard3 = new System.Windows.Forms.PictureBox();
            this.dealerCard1 = new System.Windows.Forms.PictureBox();
            this.dealerCard4 = new System.Windows.Forms.PictureBox();
            this.dealerCard5 = new System.Windows.Forms.PictureBox();
            this.btn_stand = new System.Windows.Forms.Button();
            this.hitBtn = new System.Windows.Forms.Button();
            this.pb_bet = new System.Windows.Forms.PictureBox();
            this.pb_bank = new System.Windows.Forms.PictureBox();
            this.lbl_dealer_score = new System.Windows.Forms.Label();
            this.lbl_player_score = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_bet_ammount = new System.Windows.Forms.Label();
            this.lbl_bank_ammount = new System.Windows.Forms.Label();
            this.lbl_bet_title = new System.Windows.Forms.Label();
            this.btn_all_in = new System.Windows.Forms.Button();
            this.pb_chip_500 = new System.Windows.Forms.PictureBox();
            this.pb_chip_100 = new System.Windows.Forms.PictureBox();
            this.pb_chip_50 = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_wins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chip_500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chip_100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chip_50)).BeginInit();
            this.SuspendLayout();
            // 
            // betInput
            // 
            this.betInput.BackColor = System.Drawing.Color.PaleGreen;
            this.betInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betInput.Location = new System.Drawing.Point(351, 183);
            this.betInput.Name = "betInput";
            this.betInput.Size = new System.Drawing.Size(159, 33);
            this.betInput.TabIndex = 22;
            this.betInput.Visible = false;
            this.betInput.TextChanged += new System.EventHandler(this.stake_input_TextChanged);
            // 
            // playerCard5
            // 
            this.playerCard5.Location = new System.Drawing.Point(587, 232);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(60, 100);
            this.playerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard5.TabIndex = 32;
            this.playerCard5.TabStop = false;
            this.playerCard5.Visible = false;
            // 
            // playerCard4
            // 
            this.playerCard4.Location = new System.Drawing.Point(477, 232);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(60, 100);
            this.playerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard4.TabIndex = 31;
            this.playerCard4.TabStop = false;
            this.playerCard4.Visible = false;
            // 
            // playerCard1
            // 
            this.playerCard1.Location = new System.Drawing.Point(146, 232);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(60, 100);
            this.playerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard1.TabIndex = 30;
            this.playerCard1.TabStop = false;
            this.playerCard1.Visible = false;
            // 
            // playerCard3
            // 
            this.playerCard3.Location = new System.Drawing.Point(366, 232);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(60, 100);
            this.playerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard3.TabIndex = 29;
            this.playerCard3.TabStop = false;
            this.playerCard3.Visible = false;
            // 
            // playerCard2
            // 
            this.playerCard2.Location = new System.Drawing.Point(256, 232);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(60, 100);
            this.playerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard2.TabIndex = 28;
            this.playerCard2.TabStop = false;
            this.playerCard2.Visible = false;
            // 
            // dealerCard2
            // 
            this.dealerCard2.Location = new System.Drawing.Point(256, 75);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(60, 100);
            this.dealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard2.TabIndex = 23;
            this.dealerCard2.TabStop = false;
            this.dealerCard2.Visible = false;
            // 
            // dealerCard3
            // 
            this.dealerCard3.Location = new System.Drawing.Point(366, 75);
            this.dealerCard3.Name = "dealerCard3";
            this.dealerCard3.Size = new System.Drawing.Size(60, 100);
            this.dealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard3.TabIndex = 24;
            this.dealerCard3.TabStop = false;
            this.dealerCard3.Visible = false;
            // 
            // dealerCard1
            // 
            this.dealerCard1.Location = new System.Drawing.Point(146, 75);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(60, 100);
            this.dealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard1.TabIndex = 25;
            this.dealerCard1.TabStop = false;
            this.dealerCard1.Visible = false;
            // 
            // dealerCard4
            // 
            this.dealerCard4.Location = new System.Drawing.Point(477, 75);
            this.dealerCard4.Name = "dealerCard4";
            this.dealerCard4.Size = new System.Drawing.Size(60, 100);
            this.dealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard4.TabIndex = 26;
            this.dealerCard4.TabStop = false;
            this.dealerCard4.Visible = false;
            // 
            // dealerCard5
            // 
            this.dealerCard5.Location = new System.Drawing.Point(587, 75);
            this.dealerCard5.Name = "dealerCard5";
            this.dealerCard5.Size = new System.Drawing.Size(60, 100);
            this.dealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard5.TabIndex = 27;
            this.dealerCard5.TabStop = false;
            this.dealerCard5.Visible = false;
            // 
            // btn_stand
            // 
            this.btn_stand.BackColor = System.Drawing.Color.Silver;
            this.btn_stand.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_stand.FlatAppearance.BorderSize = 3;
            this.btn_stand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_stand.Location = new System.Drawing.Point(432, 458);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(147, 33);
            this.btn_stand.TabIndex = 33;
            this.btn_stand.Tag = "BetPhase";
            this.btn_stand.Text = "Stand";
            this.btn_stand.UseVisualStyleBackColor = false;
            this.btn_stand.Visible = false;
            this.btn_stand.Click += new System.EventHandler(this.btn_stand_Click);
            // 
            // hitBtn
            // 
            this.hitBtn.BackColor = System.Drawing.Color.Silver;
            this.hitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hitBtn.FlatAppearance.BorderSize = 3;
            this.hitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hitBtn.Location = new System.Drawing.Point(279, 458);
            this.hitBtn.Name = "hitBtn";
            this.hitBtn.Size = new System.Drawing.Size(147, 33);
            this.hitBtn.TabIndex = 34;
            this.hitBtn.Tag = "BetPhase";
            this.hitBtn.Text = "Hit";
            this.hitBtn.UseVisualStyleBackColor = false;
            this.hitBtn.Click += new System.EventHandler(this.hitBtn_click);
            // 
            // pb_bet
            // 
            this.pb_bet.BackColor = System.Drawing.Color.Transparent;
            this.pb_bet.Image = global::BlackJackDissertation.Properties.Resources.bjchips;
            this.pb_bet.Location = new System.Drawing.Point(620, 392);
            this.pb_bet.Name = "pb_bet";
            this.pb_bet.Size = new System.Drawing.Size(100, 50);
            this.pb_bet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_bet.TabIndex = 35;
            this.pb_bet.TabStop = false;
            this.pb_bet.Click += new System.EventHandler(this.pb_chip_stake_Click);
            // 
            // pb_bank
            // 
            this.pb_bank.BackColor = System.Drawing.Color.Transparent;
            this.pb_bank.Image = global::BlackJackDissertation.Properties.Resources.bjchips;
            this.pb_bank.Location = new System.Drawing.Point(620, 448);
            this.pb_bank.Name = "pb_bank";
            this.pb_bank.Size = new System.Drawing.Size(100, 50);
            this.pb_bank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_bank.TabIndex = 36;
            this.pb_bank.TabStop = false;
            this.pb_bank.Click += new System.EventHandler(this.pb_bank_Click);
            // 
            // lbl_dealer_score
            // 
            this.lbl_dealer_score.AutoSize = true;
            this.lbl_dealer_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dealer_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dealer_score.ForeColor = System.Drawing.Color.White;
            this.lbl_dealer_score.Location = new System.Drawing.Point(558, 2);
            this.lbl_dealer_score.Name = "lbl_dealer_score";
            this.lbl_dealer_score.Size = new System.Drawing.Size(102, 20);
            this.lbl_dealer_score.TabIndex = 37;
            this.lbl_dealer_score.Text = "Dealer Score";
            this.lbl_dealer_score.Visible = false;
            // 
            // lbl_player_score
            // 
            this.lbl_player_score.AutoSize = true;
            this.lbl_player_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_player_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player_score.ForeColor = System.Drawing.Color.White;
            this.lbl_player_score.Location = new System.Drawing.Point(4, 2);
            this.lbl_player_score.Name = "lbl_player_score";
            this.lbl_player_score.Size = new System.Drawing.Size(98, 20);
            this.lbl_player_score.TabIndex = 38;
            this.lbl_player_score.Text = "Player Score";
            this.lbl_player_score.Visible = false;
            this.lbl_player_score.Click += new System.EventHandler(this.lbl_player_score_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.DarkRed;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_close.FlatAppearance.BorderSize = 3;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_close.Location = new System.Drawing.Point(797, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(47, 35);
            this.btn_close.TabIndex = 39;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_bet_ammount
            // 
            this.lbl_bet_ammount.AutoSize = true;
            this.lbl_bet_ammount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bet_ammount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bet_ammount.ForeColor = System.Drawing.Color.White;
            this.lbl_bet_ammount.Location = new System.Drawing.Point(726, 410);
            this.lbl_bet_ammount.Name = "lbl_bet_ammount";
            this.lbl_bet_ammount.Size = new System.Drawing.Size(74, 20);
            this.lbl_bet_ammount.TabIndex = 40;
            this.lbl_bet_ammount.Text = "Bet - £50";
            this.lbl_bet_ammount.Click += new System.EventHandler(this.lbl_bet_ammount_Click);
            // 
            // lbl_bank_ammount
            // 
            this.lbl_bank_ammount.AutoSize = true;
            this.lbl_bank_ammount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bank_ammount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bank_ammount.ForeColor = System.Drawing.Color.White;
            this.lbl_bank_ammount.Location = new System.Drawing.Point(726, 474);
            this.lbl_bank_ammount.Name = "lbl_bank_ammount";
            this.lbl_bank_ammount.Size = new System.Drawing.Size(100, 20);
            this.lbl_bank_ammount.TabIndex = 41;
            this.lbl_bank_ammount.Text = "Bank- £1000";
            // 
            // lbl_bet_title
            // 
            this.lbl_bet_title.AutoSize = true;
            this.lbl_bet_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bet_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bet_title.ForeColor = System.Drawing.Color.White;
            this.lbl_bet_title.Location = new System.Drawing.Point(236, 193);
            this.lbl_bet_title.Name = "lbl_bet_title";
            this.lbl_bet_title.Size = new System.Drawing.Size(38, 20);
            this.lbl_bet_title.TabIndex = 42;
            this.lbl_bet_title.Text = "Bet ";
            this.lbl_bet_title.Click += new System.EventHandler(this.lbl_stake_input_Click);
            // 
            // btn_all_in
            // 
            this.btn_all_in.Location = new System.Drawing.Point(155, 475);
            this.btn_all_in.Name = "btn_all_in";
            this.btn_all_in.Size = new System.Drawing.Size(75, 23);
            this.btn_all_in.TabIndex = 43;
            this.btn_all_in.Text = "All In";
            this.btn_all_in.UseVisualStyleBackColor = true;
            this.btn_all_in.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_chip_500
            // 
            this.pb_chip_500.BackColor = System.Drawing.Color.Transparent;
            this.pb_chip_500.Image = ((System.Drawing.Image)(resources.GetObject("pb_chip_500.Image")));
            this.pb_chip_500.Location = new System.Drawing.Point(8, 428);
            this.pb_chip_500.Name = "pb_chip_500";
            this.pb_chip_500.Size = new System.Drawing.Size(72, 70);
            this.pb_chip_500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_chip_500.TabIndex = 44;
            this.pb_chip_500.TabStop = false;
            this.pb_chip_500.Click += new System.EventHandler(this.pb_chip_500_Click);
            // 
            // pb_chip_100
            // 
            this.pb_chip_100.BackColor = System.Drawing.Color.Transparent;
            this.pb_chip_100.Image = ((System.Drawing.Image)(resources.GetObject("pb_chip_100.Image")));
            this.pb_chip_100.Location = new System.Drawing.Point(86, 426);
            this.pb_chip_100.Name = "pb_chip_100";
            this.pb_chip_100.Size = new System.Drawing.Size(63, 72);
            this.pb_chip_100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_chip_100.TabIndex = 45;
            this.pb_chip_100.TabStop = false;
            this.pb_chip_100.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pb_chip_50
            // 
            this.pb_chip_50.BackColor = System.Drawing.Color.Transparent;
            this.pb_chip_50.Image = ((System.Drawing.Image)(resources.GetObject("pb_chip_50.Image")));
            this.pb_chip_50.Location = new System.Drawing.Point(48, 358);
            this.pb_chip_50.Name = "pb_chip_50";
            this.pb_chip_50.Size = new System.Drawing.Size(63, 72);
            this.pb_chip_50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_chip_50.TabIndex = 46;
            this.pb_chip_50.TabStop = false;
            this.pb_chip_50.Click += new System.EventHandler(this.pb_chip_50_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(155, 446);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 47;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_wins
            // 
            this.lbl_wins.AutoSize = true;
            this.lbl_wins.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wins.ForeColor = System.Drawing.Color.White;
            this.lbl_wins.Location = new System.Drawing.Point(275, 2);
            this.lbl_wins.Name = "lbl_wins";
            this.lbl_wins.Size = new System.Drawing.Size(44, 20);
            this.lbl_wins.TabIndex = 48;
            this.lbl_wins.Text = "Wins";
            this.lbl_wins.Visible = false;
            this.lbl_wins.Click += new System.EventHandler(this.lbl_wins_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 503);
            this.Controls.Add(this.lbl_wins);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pb_chip_50);
            this.Controls.Add(this.pb_chip_100);
            this.Controls.Add(this.pb_chip_500);
            this.Controls.Add(this.btn_all_in);
            this.Controls.Add(this.lbl_bet_title);
            this.Controls.Add(this.lbl_bank_ammount);
            this.Controls.Add(this.lbl_bet_ammount);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_player_score);
            this.Controls.Add(this.lbl_dealer_score);
            this.Controls.Add(this.pb_bank);
            this.Controls.Add(this.pb_bet);
            this.Controls.Add(this.hitBtn);
            this.Controls.Add(this.btn_stand);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.dealerCard5);
            this.Controls.Add(this.dealerCard4);
            this.Controls.Add(this.dealerCard1);
            this.Controls.Add(this.dealerCard3);
            this.Controls.Add(this.dealerCard2);
            this.Controls.Add(this.betInput);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chip_500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chip_100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chip_50)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox betInput;
        public System.Windows.Forms.PictureBox playerCard5;
        public System.Windows.Forms.PictureBox playerCard4;
        public System.Windows.Forms.PictureBox playerCard1;
        public System.Windows.Forms.PictureBox playerCard3;
        public System.Windows.Forms.PictureBox playerCard2;
        public System.Windows.Forms.PictureBox dealerCard2;
        public System.Windows.Forms.PictureBox dealerCard3;
        public System.Windows.Forms.PictureBox dealerCard1;
        public System.Windows.Forms.PictureBox dealerCard4;
        public System.Windows.Forms.PictureBox dealerCard5;
        public System.Windows.Forms.Button btn_stand;
        public System.Windows.Forms.Button hitBtn;
        private System.Windows.Forms.PictureBox pb_bet;
        private System.Windows.Forms.PictureBox pb_bank;
        public System.Windows.Forms.Label lbl_dealer_score;
        public System.Windows.Forms.Label lbl_player_score;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Label lbl_bet_ammount;
        public System.Windows.Forms.Label lbl_bank_ammount;
        public System.Windows.Forms.Label lbl_bet_title;
        private System.Windows.Forms.Button btn_all_in;
        private System.Windows.Forms.PictureBox pb_chip_500;
        private System.Windows.Forms.PictureBox pb_chip_100;
        private System.Windows.Forms.PictureBox pb_chip_50;
        private System.Windows.Forms.Button btn_reset;
        public System.Windows.Forms.Label lbl_wins;
    }
}

