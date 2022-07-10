
namespace RockPaperScisors
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.paperbtn = new System.Windows.Forms.Button();
            this.rockbtn = new System.Windows.Forms.Button();
            this.scissorsbtn = new System.Windows.Forms.Button();
            this.plaScore = new System.Windows.Forms.Label();
            this.compScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.timGame = new System.Windows.Forms.Timer(this.components);
            this.startbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player.Location = new System.Drawing.Point(134, 366);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(160, 55);
            this.player.TabIndex = 5;
            this.player.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(632, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Computer";
            // 
            // picBox2
            // 
            this.picBox2.Image = global::RockPaperScisors.Properties.Resources.x;
            this.picBox2.Location = new System.Drawing.Point(642, 440);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(225, 225);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 8;
            this.picBox2.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.Image = global::RockPaperScisors.Properties.Resources.x;
            this.picBox1.Location = new System.Drawing.Point(104, 440);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(225, 225);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 7;
            this.picBox1.TabStop = false;
            // 
            // paperbtn
            // 
            this.paperbtn.Image = global::RockPaperScisors.Properties.Resources._1Paper;
            this.paperbtn.Location = new System.Drawing.Point(642, 12);
            this.paperbtn.Name = "paperbtn";
            this.paperbtn.Size = new System.Drawing.Size(282, 283);
            this.paperbtn.TabIndex = 4;
            this.paperbtn.UseVisualStyleBackColor = true;
            this.paperbtn.Click += new System.EventHandler(this.paperbtn_Click);
            // 
            // rockbtn
            // 
            this.rockbtn.Image = global::RockPaperScisors.Properties.Resources._2Rock;
            this.rockbtn.Location = new System.Drawing.Point(12, 12);
            this.rockbtn.Name = "rockbtn";
            this.rockbtn.Size = new System.Drawing.Size(282, 283);
            this.rockbtn.TabIndex = 3;
            this.rockbtn.UseVisualStyleBackColor = true;
            this.rockbtn.Click += new System.EventHandler(this.rockbtn_Click);
            // 
            // scissorsbtn
            // 
            this.scissorsbtn.Image = global::RockPaperScisors.Properties.Resources.Scissors;
            this.scissorsbtn.Location = new System.Drawing.Point(327, 12);
            this.scissorsbtn.Name = "scissorsbtn";
            this.scissorsbtn.Size = new System.Drawing.Size(282, 283);
            this.scissorsbtn.TabIndex = 1;
            this.scissorsbtn.UseVisualStyleBackColor = true;
            this.scissorsbtn.Click += new System.EventHandler(this.scissorsbtn_Click);
            // 
            // plaScore
            // 
            this.plaScore.AutoSize = true;
            this.plaScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plaScore.Location = new System.Drawing.Point(385, 512);
            this.plaScore.Name = "plaScore";
            this.plaScore.Size = new System.Drawing.Size(51, 55);
            this.plaScore.TabIndex = 9;
            this.plaScore.Text = "0";
            // 
            // compScore
            // 
            this.compScore.AutoSize = true;
            this.compScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.compScore.Location = new System.Drawing.Point(539, 512);
            this.compScore.Name = "compScore";
            this.compScore.Size = new System.Drawing.Size(51, 55);
            this.compScore.TabIndex = 10;
            this.compScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(469, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = ":";
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetBtn.Location = new System.Drawing.Point(615, 746);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(282, 64);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset ";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // timGame
            // 
            this.timGame.Tick += new System.EventHandler(this.timGame_Tick);
            // 
            // startbtn
            // 
            this.startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startbtn.Location = new System.Drawing.Point(39, 746);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(282, 64);
            this.startbtn.TabIndex = 13;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopbtn.Location = new System.Drawing.Point(327, 746);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(282, 64);
            this.stopbtn.TabIndex = 14;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.Location = new System.Drawing.Point(539, 366);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 55);
            this.lblTime.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(373, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 55);
            this.label3.TabIndex = 16;
            this.label3.Text = "Time :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 873);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compScore);
            this.Controls.Add(this.plaScore);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.paperbtn);
            this.Controls.Add(this.rockbtn);
            this.Controls.Add(this.scissorsbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scissorsbtn;
        private System.Windows.Forms.Button rockbtn;
        private System.Windows.Forms.Button paperbtn;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Label plaScore;
        private System.Windows.Forms.Label compScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Timer timGame;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
    }
}

