
namespace game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.player = new System.Windows.Forms.Label();
            this.bat = new System.Windows.Forms.Label();
            this.ghost = new System.Windows.Forms.Label();
            this.ghoul = new System.Windows.Forms.Label();
            this.lblBat = new System.Windows.Forms.Label();
            this.lblGamer = new System.Windows.Forms.Label();
            this.lblGhoul = new System.Windows.Forms.Label();
            this.lblGhost = new System.Windows.Forms.Label();
            this.picGhost = new System.Windows.Forms.PictureBox();
            this.picGhoul = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picSword = new System.Windows.Forms.PictureBox();
            this.picBat = new System.Windows.Forms.PictureBox();
            this.picBow = new System.Windows.Forms.PictureBox();
            this.picMace = new System.Windows.Forms.PictureBox();
            this.picPotionRed = new System.Windows.Forms.PictureBox();
            this.picPotionBlue = new System.Windows.Forms.PictureBox();
            this.picSwordInventory = new System.Windows.Forms.PictureBox();
            this.picPotionRedInventory = new System.Windows.Forms.PictureBox();
            this.picPotionBlueInventory = new System.Windows.Forms.PictureBox();
            this.picBowInventory = new System.Windows.Forms.PictureBox();
            this.picMaceInventory = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.Attack = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwordInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionRedInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionBlueInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBowInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaceInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.player, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghost, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoul, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGamer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGhoul, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGhost, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(611, 302);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(177, 111);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Location = new System.Drawing.Point(3, 0);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(36, 13);
            this.player.TabIndex = 16;
            this.player.Text = "Player";
            // 
            // bat
            // 
            this.bat.AutoSize = true;
            this.bat.Location = new System.Drawing.Point(3, 30);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(23, 13);
            this.bat.TabIndex = 17;
            this.bat.Text = "Bat";
            // 
            // ghost
            // 
            this.ghost.AutoSize = true;
            this.ghost.Location = new System.Drawing.Point(3, 60);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(35, 13);
            this.ghost.TabIndex = 18;
            this.ghost.Text = "Ghost";
            // 
            // ghoul
            // 
            this.ghoul.AutoSize = true;
            this.ghoul.Location = new System.Drawing.Point(3, 85);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(35, 13);
            this.ghoul.TabIndex = 19;
            this.ghoul.Text = "Ghoul";
            // 
            // lblBat
            // 
            this.lblBat.AutoSize = true;
            this.lblBat.Location = new System.Drawing.Point(91, 30);
            this.lblBat.Name = "lblBat";
            this.lblBat.Size = new System.Drawing.Size(0, 13);
            this.lblBat.TabIndex = 20;
            // 
            // lblGamer
            // 
            this.lblGamer.AutoSize = true;
            this.lblGamer.Location = new System.Drawing.Point(91, 0);
            this.lblGamer.Name = "lblGamer";
            this.lblGamer.Size = new System.Drawing.Size(0, 13);
            this.lblGamer.TabIndex = 21;
            // 
            // lblGhoul
            // 
            this.lblGhoul.AutoSize = true;
            this.lblGhoul.Location = new System.Drawing.Point(91, 85);
            this.lblGhoul.Name = "lblGhoul";
            this.lblGhoul.Size = new System.Drawing.Size(35, 13);
            this.lblGhoul.TabIndex = 22;
            this.lblGhoul.Text = "label1";
            // 
            // lblGhost
            // 
            this.lblGhost.AutoSize = true;
            this.lblGhost.Location = new System.Drawing.Point(91, 60);
            this.lblGhost.Name = "lblGhost";
            this.lblGhost.Size = new System.Drawing.Size(35, 13);
            this.lblGhost.TabIndex = 23;
            this.lblGhost.Text = "label1";
            // 
            // picGhost
            // 
            this.picGhost.Image = global::game.Properties.Resources.ghost;
            this.picGhost.Location = new System.Drawing.Point(161, 158);
            this.picGhost.Name = "picGhost";
            this.picGhost.Size = new System.Drawing.Size(38, 36);
            this.picGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhost.TabIndex = 15;
            this.picGhost.TabStop = false;
            // 
            // picGhoul
            // 
            this.picGhoul.Image = global::game.Properties.Resources.ghoul;
            this.picGhoul.Location = new System.Drawing.Point(98, 158);
            this.picGhoul.Name = "picGhoul";
            this.picGhoul.Size = new System.Drawing.Size(38, 36);
            this.picGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhoul.TabIndex = 14;
            this.picGhoul.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::game.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Image = global::game.Properties.Resources.player;
            this.picPlayer.Location = new System.Drawing.Point(247, 178);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(38, 36);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 13;
            this.picPlayer.TabStop = false;
            this.picPlayer.Visible = false;
            this.picPlayer.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // picSword
            // 
            this.picSword.BackColor = System.Drawing.Color.Transparent;
            this.picSword.Image = global::game.Properties.Resources.sword;
            this.picSword.Location = new System.Drawing.Point(391, 102);
            this.picSword.Name = "picSword";
            this.picSword.Size = new System.Drawing.Size(37, 39);
            this.picSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSword.TabIndex = 12;
            this.picSword.TabStop = false;
            // 
            // picBat
            // 
            this.picBat.Image = global::game.Properties.Resources.bat;
            this.picBat.Location = new System.Drawing.Point(325, 91);
            this.picBat.Name = "picBat";
            this.picBat.Size = new System.Drawing.Size(38, 36);
            this.picBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBat.TabIndex = 11;
            this.picBat.TabStop = false;
            // 
            // picBow
            // 
            this.picBow.Image = global::game.Properties.Resources.bow;
            this.picBow.Location = new System.Drawing.Point(271, 102);
            this.picBow.Name = "picBow";
            this.picBow.Size = new System.Drawing.Size(38, 36);
            this.picBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBow.TabIndex = 10;
            this.picBow.TabStop = false;
            // 
            // picMace
            // 
            this.picMace.Image = global::game.Properties.Resources.mace;
            this.picMace.Location = new System.Drawing.Point(213, 91);
            this.picMace.Name = "picMace";
            this.picMace.Size = new System.Drawing.Size(38, 36);
            this.picMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMace.TabIndex = 9;
            this.picMace.TabStop = false;
            // 
            // picPotionRed
            // 
            this.picPotionRed.Image = global::game.Properties.Resources.potion_blue;
            this.picPotionRed.Location = new System.Drawing.Point(161, 91);
            this.picPotionRed.Name = "picPotionRed";
            this.picPotionRed.Size = new System.Drawing.Size(38, 36);
            this.picPotionRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPotionRed.TabIndex = 8;
            this.picPotionRed.TabStop = false;
            // 
            // picPotionBlue
            // 
            this.picPotionBlue.BackColor = System.Drawing.Color.Transparent;
            this.picPotionBlue.Image = global::game.Properties.Resources.potion_blue;
            this.picPotionBlue.Location = new System.Drawing.Point(98, 91);
            this.picPotionBlue.Name = "picPotionBlue";
            this.picPotionBlue.Size = new System.Drawing.Size(38, 36);
            this.picPotionBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPotionBlue.TabIndex = 7;
            this.picPotionBlue.TabStop = false;
            // 
            // picSwordInventory
            // 
            this.picSwordInventory.BackColor = System.Drawing.Color.Transparent;
            this.picSwordInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSwordInventory.BackgroundImage")));
            this.picSwordInventory.Location = new System.Drawing.Point(303, 321);
            this.picSwordInventory.Name = "picSwordInventory";
            this.picSwordInventory.Size = new System.Drawing.Size(53, 50);
            this.picSwordInventory.TabIndex = 6;
            this.picSwordInventory.TabStop = false;
            this.picSwordInventory.Click += new System.EventHandler(this.picSwordInventory_Click);
            // 
            // picPotionRedInventory
            // 
            this.picPotionRedInventory.BackColor = System.Drawing.Color.Transparent;
            this.picPotionRedInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPotionRedInventory.BackgroundImage")));
            this.picPotionRedInventory.Location = new System.Drawing.Point(247, 321);
            this.picPotionRedInventory.Name = "picPotionRedInventory";
            this.picPotionRedInventory.Size = new System.Drawing.Size(50, 50);
            this.picPotionRedInventory.TabIndex = 5;
            this.picPotionRedInventory.TabStop = false;
            this.picPotionRedInventory.Click += new System.EventHandler(this.picPotionRedInventory_Click);
            // 
            // picPotionBlueInventory
            // 
            this.picPotionBlueInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPotionBlueInventory.BackgroundImage")));
            this.picPotionBlueInventory.Location = new System.Drawing.Point(191, 321);
            this.picPotionBlueInventory.Name = "picPotionBlueInventory";
            this.picPotionBlueInventory.Size = new System.Drawing.Size(50, 50);
            this.picPotionBlueInventory.TabIndex = 4;
            this.picPotionBlueInventory.TabStop = false;
            this.picPotionBlueInventory.Click += new System.EventHandler(this.picPotionBlueInventory_Click);
            // 
            // picBowInventory
            // 
            this.picBowInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBowInventory.BackgroundImage")));
            this.picBowInventory.Location = new System.Drawing.Point(131, 321);
            this.picBowInventory.Name = "picBowInventory";
            this.picBowInventory.Size = new System.Drawing.Size(54, 50);
            this.picBowInventory.TabIndex = 2;
            this.picBowInventory.TabStop = false;
            this.picBowInventory.Click += new System.EventHandler(this.picBowInventory_Click);
            // 
            // picMaceInventory
            // 
            this.picMaceInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMaceInventory.BackgroundImage")));
            this.picMaceInventory.Location = new System.Drawing.Point(73, 321);
            this.picMaceInventory.Name = "picMaceInventory";
            this.picMaceInventory.Size = new System.Drawing.Size(52, 50);
            this.picMaceInventory.TabIndex = 1;
            this.picMaceInventory.TabStop = false;
            this.picMaceInventory.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 401);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(662, 60);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 16;
            this.btnMoveUp.Text = "Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(713, 90);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 17;
            this.btnMoveRight.Text = "Right";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(611, 89);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 18;
            this.btnMoveLeft.Text = "Left";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(662, 118);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 19;
            this.btnMoveDown.Text = "Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttackUp.Location = new System.Drawing.Point(662, 192);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(71, 22);
            this.btnAttackUp.TabIndex = 21;
            this.btnAttackUp.Text = "\t↑";
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttackRight.Location = new System.Drawing.Point(713, 220);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(61, 24);
            this.btnAttackRight.TabIndex = 22;
            this.btnAttackRight.Text = "\t→";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            this.btnAttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttackLeft.Location = new System.Drawing.Point(625, 220);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(61, 24);
            this.btnAttackLeft.TabIndex = 23;
            this.btnAttackLeft.Text = "\t←";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            this.btnAttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttackDown.Location = new System.Drawing.Point(662, 250);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(71, 24);
            this.btnAttackDown.TabIndex = 24;
            this.btnAttackDown.Text = "↓";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            this.btnAttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
            // 
            // Attack
            // 
            this.Attack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Attack.AutoSize = true;
            this.Attack.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attack.Location = new System.Drawing.Point(608, 158);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(56, 17);
            this.Attack.TabIndex = 25;
            this.Attack.Text = "Attack";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.btnAttackDown);
            this.Controls.Add(this.btnAttackLeft);
            this.Controls.Add(this.btnAttackRight);
            this.Controls.Add(this.btnAttackUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picGhost);
            this.Controls.Add(this.picGhoul);
            this.Controls.Add(this.picSword);
            this.Controls.Add(this.picBat);
            this.Controls.Add(this.picBow);
            this.Controls.Add(this.picMace);
            this.Controls.Add(this.picPotionRed);
            this.Controls.Add(this.picPotionBlue);
            this.Controls.Add(this.picSwordInventory);
            this.Controls.Add(this.picPotionRedInventory);
            this.Controls.Add(this.picPotionBlueInventory);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.picBowInventory);
            this.Controls.Add(this.picMaceInventory);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwordInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionRedInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionBlueInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBowInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaceInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picMaceInventory;
        private System.Windows.Forms.PictureBox picBowInventory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picPotionBlueInventory;
        private System.Windows.Forms.PictureBox picPotionRedInventory;
        private System.Windows.Forms.PictureBox picSwordInventory;
        private System.Windows.Forms.PictureBox picPotionBlue;
        private System.Windows.Forms.PictureBox picPotionRed;
        private System.Windows.Forms.PictureBox picMace;
        private System.Windows.Forms.PictureBox picBow;
        private System.Windows.Forms.PictureBox picBat;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picGhoul;
        private System.Windows.Forms.PictureBox picGhost;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label bat;
        private System.Windows.Forms.Label ghost;
        private System.Windows.Forms.Label ghoul;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveDown;
       // private System.Windows.Forms.Label Move;
        private System.Windows.Forms.Button btnAttackUp;
        private System.Windows.Forms.Button btnAttackRight;
        private System.Windows.Forms.Button btnAttackLeft;
        private System.Windows.Forms.Button btnAttackDown;
        private System.Windows.Forms.Label Attack;
        private System.Windows.Forms.Label lblBat;
        private System.Windows.Forms.Label lblGamer;
        private System.Windows.Forms.Label lblGhoul;
        private System.Windows.Forms.Label lblGhost;
        private System.Windows.Forms.PictureBox picSword;
    }
}

