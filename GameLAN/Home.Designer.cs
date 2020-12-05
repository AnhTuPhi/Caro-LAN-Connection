namespace GameLAN
{
    partial class Home
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
            this.pnl_ChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctbAvatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Lan = new System.Windows.Forms.Button();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.pctb_Mark = new System.Windows.Forms.PictureBox();
            this.prcb_CoolDown = new System.Windows.Forms.ProgressBar();
            this.txt_PlayerName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_Mark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_ChessBoard
            // 
            this.pnl_ChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_ChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnl_ChessBoard.Name = "pnl_ChessBoard";
            this.pnl_ChessBoard.Size = new System.Drawing.Size(594, 611);
            this.pnl_ChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pctbAvatar);
            this.panel2.Location = new System.Drawing.Point(617, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 266);
            this.panel2.TabIndex = 1;
            // 
            // pctbAvatar
            // 
            this.pctbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbAvatar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pctbAvatar.Location = new System.Drawing.Point(0, 0);
            this.pctbAvatar.Name = "pctbAvatar";
            this.pctbAvatar.Size = new System.Drawing.Size(294, 266);
            this.pctbAvatar.TabIndex = 0;
            this.pctbAvatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_Lan);
            this.panel3.Controls.Add(this.txt_IP);
            this.panel3.Controls.Add(this.pctb_Mark);
            this.panel3.Controls.Add(this.prcb_CoolDown);
            this.panel3.Controls.Add(this.txt_PlayerName);
            this.panel3.Location = new System.Drawing.Point(617, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 183);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Lan
            // 
            this.btn_Lan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lan.Location = new System.Drawing.Point(3, 84);
            this.btn_Lan.Name = "btn_Lan";
            this.btn_Lan.Size = new System.Drawing.Size(146, 32);
            this.btn_Lan.TabIndex = 4;
            this.btn_Lan.Text = "LAN";
            this.btn_Lan.UseVisualStyleBackColor = true;
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(3, 58);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(146, 20);
            this.txt_IP.TabIndex = 3;
            this.txt_IP.Text = "127.0.0.1";
            // 
            // pctb_Mark
            // 
            this.pctb_Mark.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pctb_Mark.Location = new System.Drawing.Point(155, 3);
            this.pctb_Mark.Name = "pctb_Mark";
            this.pctb_Mark.Size = new System.Drawing.Size(139, 113);
            this.pctb_Mark.TabIndex = 2;
            this.pctb_Mark.TabStop = false;
            // 
            // prcb_CoolDown
            // 
            this.prcb_CoolDown.Location = new System.Drawing.Point(3, 29);
            this.prcb_CoolDown.Name = "prcb_CoolDown";
            this.prcb_CoolDown.Size = new System.Drawing.Size(146, 23);
            this.prcb_CoolDown.TabIndex = 1;
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Location = new System.Drawing.Point(3, 3);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.ReadOnly = true;
            this.txt_PlayerName.Size = new System.Drawing.Size(146, 20);
            this.txt_PlayerName.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 635);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_ChessBoard);
            this.Name = "Home";
            this.Text = "Home";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_Mark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pctbAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Lan;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.PictureBox pctb_Mark;
        private System.Windows.Forms.ProgressBar prcb_CoolDown;
        private System.Windows.Forms.TextBox txt_PlayerName;
    }
}