
namespace Pong
{
    partial class Game
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Teto = new System.Windows.Forms.PictureBox();
            this.Chao = new System.Windows.Forms.PictureBox();
            this.Tempo = new System.Windows.Forms.Timer(this.components);
            this.RightLimit = new System.Windows.Forms.PictureBox();
            this.LeftLimit = new System.Windows.Forms.PictureBox();
            this.textP2Points = new System.Windows.Forms.Label();
            this.textP1Points = new System.Windows.Forms.Label();
            this.Bola = new System.Windows.Forms.PictureBox();
            this.Jogador2 = new System.Windows.Forms.PictureBox();
            this.Jogador1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Teto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jogador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jogador1)).BeginInit();
            this.SuspendLayout();
            // 
            // Teto
            // 
            this.Teto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Teto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Teto.Location = new System.Drawing.Point(-101, -2);
            this.Teto.Name = "Teto";
            this.Teto.Size = new System.Drawing.Size(1033, 34);
            this.Teto.TabIndex = 1;
            this.Teto.TabStop = false;
            this.Teto.Tag = "BloqueioVertical";
            // 
            // Chao
            // 
            this.Chao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Chao.Location = new System.Drawing.Point(-101, 414);
            this.Chao.Name = "Chao";
            this.Chao.Size = new System.Drawing.Size(1055, 38);
            this.Chao.TabIndex = 2;
            this.Chao.TabStop = false;
            this.Chao.Tag = "BloqueioVertical";
            // 
            // Tempo
            // 
            this.Tempo.Enabled = true;
            this.Tempo.Interval = 1;
            this.Tempo.Tick += new System.EventHandler(this.TimeAction);
            // 
            // RightLimit
            // 
            this.RightLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RightLimit.Location = new System.Drawing.Point(787, -91);
            this.RightLimit.Name = "RightLimit";
            this.RightLimit.Size = new System.Drawing.Size(22, 622);
            this.RightLimit.TabIndex = 5;
            this.RightLimit.TabStop = false;
            // 
            // LeftLimit
            // 
            this.LeftLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LeftLimit.Location = new System.Drawing.Point(0, -27);
            this.LeftLimit.Name = "LeftLimit";
            this.LeftLimit.Size = new System.Drawing.Size(13, 508);
            this.LeftLimit.TabIndex = 7;
            this.LeftLimit.TabStop = false;
            // 
            // textP2Points
            // 
            this.textP2Points.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textP2Points.AutoSize = true;
            this.textP2Points.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textP2Points.Location = new System.Drawing.Point(214, 95);
            this.textP2Points.Name = "textP2Points";
            this.textP2Points.Size = new System.Drawing.Size(50, 56);
            this.textP2Points.TabIndex = 8;
            this.textP2Points.Text = "0";
            // 
            // textP1Points
            // 
            this.textP1Points.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textP1Points.AutoSize = true;
            this.textP1Points.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textP1Points.Location = new System.Drawing.Point(569, 95);
            this.textP1Points.Name = "textP1Points";
            this.textP1Points.Size = new System.Drawing.Size(50, 56);
            this.textP1Points.TabIndex = 9;
            this.textP1Points.Text = "0";
            // 
            // Bola
            // 
            this.Bola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bola.Location = new System.Drawing.Point(389, 215);
            this.Bola.Name = "Bola";
            this.Bola.Size = new System.Drawing.Size(23, 21);
            this.Bola.TabIndex = 10;
            this.Bola.TabStop = false;
            // 
            // Jogador2
            // 
            this.Jogador2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Jogador2.Location = new System.Drawing.Point(57, 182);
            this.Jogador2.Name = "Jogador2";
            this.Jogador2.Size = new System.Drawing.Size(16, 109);
            this.Jogador2.TabIndex = 11;
            this.Jogador2.TabStop = false;
            // 
            // Jogador1
            // 
            this.Jogador1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Jogador1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Jogador1.Location = new System.Drawing.Point(718, 182);
            this.Jogador1.Name = "Jogador1";
            this.Jogador1.Size = new System.Drawing.Size(14, 109);
            this.Jogador1.TabIndex = 12;
            this.Jogador1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Jogador1);
            this.Controls.Add(this.Jogador2);
            this.Controls.Add(this.Bola);
            this.Controls.Add(this.textP1Points);
            this.Controls.Add(this.textP2Points);
            this.Controls.Add(this.LeftLimit);
            this.Controls.Add(this.RightLimit);
            this.Controls.Add(this.Chao);
            this.Controls.Add(this.Teto);
            this.Name = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.SizeChanged += new System.EventHandler(this.Game_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TestBall_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Teto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jogador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jogador1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Teto;
        private System.Windows.Forms.PictureBox Chao;
        private System.Windows.Forms.Timer Tempo;
        private System.Windows.Forms.PictureBox RightLimit;
        private System.Windows.Forms.PictureBox LeftLimit;
        private System.Windows.Forms.Label textP2Points;
        private System.Windows.Forms.Label textP1Points;
        private System.Windows.Forms.PictureBox Bola;
        private System.Windows.Forms.PictureBox Jogador2;
        private System.Windows.Forms.PictureBox Jogador1;
    }
}

