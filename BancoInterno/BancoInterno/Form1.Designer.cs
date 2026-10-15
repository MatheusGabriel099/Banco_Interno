namespace BancoInterno
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic_McChickenCombo = new System.Windows.Forms.PictureBox();
            this.pic_Gif = new System.Windows.Forms.PictureBox();
            this.lbl_DigitePedido = new System.Windows.Forms.Label();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.btn_MacPedido = new System.Windows.Forms.Button();
            this.pic_BigMacConbo = new System.Windows.Forms.PictureBox();
            this.pic_CheeseBurgerCombo = new System.Windows.Forms.PictureBox();
            this.pic_QuarterPounderCombo = new System.Windows.Forms.PictureBox();
            this.pic_McFishCombo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_McChickenCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BigMacConbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CheeseBurgerCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QuarterPounderCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_McFishCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_McChickenCombo
            // 
            this.pic_McChickenCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_McChickenCombo.Image = global::BancoInterno.Properties.Resources.combo_mc_chicken;
            this.pic_McChickenCombo.Location = new System.Drawing.Point(12, 25);
            this.pic_McChickenCombo.Name = "pic_McChickenCombo";
            this.pic_McChickenCombo.Size = new System.Drawing.Size(134, 93);
            this.pic_McChickenCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_McChickenCombo.TabIndex = 0;
            this.pic_McChickenCombo.TabStop = false;
            this.pic_McChickenCombo.Click += new System.EventHandler(this.pic_McChickenCombo_Click);
            // 
            // pic_Gif
            // 
            this.pic_Gif.BackColor = System.Drawing.Color.Transparent;
            this.pic_Gif.Image = global::BancoInterno.Properties.Resources.French_Fries_Food_GIF_by_McDonald_s_CZSK;
            this.pic_Gif.Location = new System.Drawing.Point(707, 363);
            this.pic_Gif.Name = "pic_Gif";
            this.pic_Gif.Size = new System.Drawing.Size(81, 75);
            this.pic_Gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Gif.TabIndex = 6;
            this.pic_Gif.TabStop = false;
            // 
            // lbl_DigitePedido
            // 
            this.lbl_DigitePedido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DigitePedido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DigitePedido.Location = new System.Drawing.Point(317, 25);
            this.lbl_DigitePedido.Name = "lbl_DigitePedido";
            this.lbl_DigitePedido.Size = new System.Drawing.Size(396, 39);
            this.lbl_DigitePedido.TabIndex = 7;
            this.lbl_DigitePedido.Text = "DIGITE O PEDIDO";
            this.lbl_DigitePedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Texto
            // 
            this.txt_Texto.BackColor = System.Drawing.Color.LightGray;
            this.txt_Texto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Texto.Location = new System.Drawing.Point(349, 67);
            this.txt_Texto.Multiline = true;
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.ReadOnly = true;
            this.txt_Texto.Size = new System.Drawing.Size(318, 135);
            this.txt_Texto.TabIndex = 8;
            this.txt_Texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_MacPedido
            // 
            this.btn_MacPedido.BackColor = System.Drawing.Color.Firebrick;
            this.btn_MacPedido.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_MacPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_MacPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_MacPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MacPedido.Location = new System.Drawing.Point(469, 208);
            this.btn_MacPedido.Name = "btn_MacPedido";
            this.btn_MacPedido.Size = new System.Drawing.Size(75, 23);
            this.btn_MacPedido.TabIndex = 9;
            this.btn_MacPedido.Text = "MacPedido";
            this.btn_MacPedido.UseVisualStyleBackColor = false;
            this.btn_MacPedido.Click += new System.EventHandler(this.btn_MacPedido_Click);
            // 
            // pic_BigMacConbo
            // 
            this.pic_BigMacConbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_BigMacConbo.Image = global::BancoInterno.Properties.Resources.combo_bigmac;
            this.pic_BigMacConbo.Location = new System.Drawing.Point(169, 25);
            this.pic_BigMacConbo.Name = "pic_BigMacConbo";
            this.pic_BigMacConbo.Size = new System.Drawing.Size(142, 93);
            this.pic_BigMacConbo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_BigMacConbo.TabIndex = 10;
            this.pic_BigMacConbo.TabStop = false;
            this.pic_BigMacConbo.Click += new System.EventHandler(this.pic_BigMacConbo_Click);
            // 
            // pic_CheeseBurgerCombo
            // 
            this.pic_CheeseBurgerCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_CheeseBurgerCombo.Image = global::BancoInterno.Properties.Resources.combo_cheeseburger;
            this.pic_CheeseBurgerCombo.Location = new System.Drawing.Point(12, 149);
            this.pic_CheeseBurgerCombo.Name = "pic_CheeseBurgerCombo";
            this.pic_CheeseBurgerCombo.Size = new System.Drawing.Size(134, 93);
            this.pic_CheeseBurgerCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CheeseBurgerCombo.TabIndex = 11;
            this.pic_CheeseBurgerCombo.TabStop = false;
            this.pic_CheeseBurgerCombo.Click += new System.EventHandler(this.pic_CheeseBurgerCombo_Click);
            // 
            // pic_QuarterPounderCombo
            // 
            this.pic_QuarterPounderCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_QuarterPounderCombo.Image = global::BancoInterno.Properties.Resources.combo_quarteirão;
            this.pic_QuarterPounderCombo.Location = new System.Drawing.Point(169, 149);
            this.pic_QuarterPounderCombo.Name = "pic_QuarterPounderCombo";
            this.pic_QuarterPounderCombo.Size = new System.Drawing.Size(142, 93);
            this.pic_QuarterPounderCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_QuarterPounderCombo.TabIndex = 12;
            this.pic_QuarterPounderCombo.TabStop = false;
            this.pic_QuarterPounderCombo.Click += new System.EventHandler(this.pic_QuarterPounderCombo_Click);
            // 
            // pic_McFishCombo
            // 
            this.pic_McFishCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_McFishCombo.Image = global::BancoInterno.Properties.Resources.combo3;
            this.pic_McFishCombo.Location = new System.Drawing.Point(12, 278);
            this.pic_McFishCombo.Name = "pic_McFishCombo";
            this.pic_McFishCombo.Size = new System.Drawing.Size(134, 93);
            this.pic_McFishCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_McFishCombo.TabIndex = 13;
            this.pic_McFishCombo.TabStop = false;
            this.pic_McFishCombo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BancoInterno.Properties.Resources.desconto2;
            this.pictureBox2.Location = new System.Drawing.Point(169, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::BancoInterno.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic_McFishCombo);
            this.Controls.Add(this.pic_QuarterPounderCombo);
            this.Controls.Add(this.pic_CheeseBurgerCombo);
            this.Controls.Add(this.pic_BigMacConbo);
            this.Controls.Add(this.btn_MacPedido);
            this.Controls.Add(this.txt_Texto);
            this.Controls.Add(this.lbl_DigitePedido);
            this.Controls.Add(this.pic_Gif);
            this.Controls.Add(this.pic_McChickenCombo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mc Donald\'s";
            ((System.ComponentModel.ISupportInitialize)(this.pic_McChickenCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BigMacConbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CheeseBurgerCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QuarterPounderCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_McFishCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_McChickenCombo;
        private System.Windows.Forms.PictureBox pic_Gif;
        private System.Windows.Forms.Label lbl_DigitePedido;
        private System.Windows.Forms.TextBox txt_Texto;
        private System.Windows.Forms.Button btn_MacPedido;
        private System.Windows.Forms.PictureBox pic_BigMacConbo;
        private System.Windows.Forms.PictureBox pic_CheeseBurgerCombo;
        private System.Windows.Forms.PictureBox pic_QuarterPounderCombo;
        private System.Windows.Forms.PictureBox pic_McFishCombo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

