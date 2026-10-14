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
            this.pic_MacFishCombo = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_McChickenCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BigMacConbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CheeseBurgerCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QuarterPounderCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MacFishCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_McChickenCombo
            // 
            this.pic_McChickenCombo.Image = global::BancoInterno.Properties.Resources.combo_mc_chicken;
            this.pic_McChickenCombo.Location = new System.Drawing.Point(12, 25);
            this.pic_McChickenCombo.Name = "pic_McChickenCombo";
            this.pic_McChickenCombo.Size = new System.Drawing.Size(134, 93);
            this.pic_McChickenCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_McChickenCombo.TabIndex = 0;
            this.pic_McChickenCombo.TabStop = false;
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
            this.lbl_DigitePedido.Location = new System.Drawing.Point(299, 25);
            this.lbl_DigitePedido.Name = "lbl_DigitePedido";
            this.lbl_DigitePedido.Size = new System.Drawing.Size(414, 39);
            this.lbl_DigitePedido.TabIndex = 7;
            this.lbl_DigitePedido.Text = "DIGITE O PEDIDO";
            this.lbl_DigitePedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Texto
            // 
            this.txt_Texto.BackColor = System.Drawing.Color.LightGray;
            this.txt_Texto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Texto.Location = new System.Drawing.Point(349, 67);
            this.txt_Texto.Multiline = true;
            this.txt_Texto.Name = "txt_Texto";
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
            // 
            // pic_BigMacConbo
            // 
            this.pic_BigMacConbo.Image = global::BancoInterno.Properties.Resources.combo_bigmac;
            this.pic_BigMacConbo.Location = new System.Drawing.Point(169, 25);
            this.pic_BigMacConbo.Name = "pic_BigMacConbo";
            this.pic_BigMacConbo.Size = new System.Drawing.Size(142, 93);
            this.pic_BigMacConbo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_BigMacConbo.TabIndex = 10;
            this.pic_BigMacConbo.TabStop = false;
            // 
            // pic_CheeseBurgerCombo
            // 
            this.pic_CheeseBurgerCombo.Image = global::BancoInterno.Properties.Resources.combo_cheeseburger;
            this.pic_CheeseBurgerCombo.Location = new System.Drawing.Point(12, 149);
            this.pic_CheeseBurgerCombo.Name = "pic_CheeseBurgerCombo";
            this.pic_CheeseBurgerCombo.Size = new System.Drawing.Size(134, 93);
            this.pic_CheeseBurgerCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CheeseBurgerCombo.TabIndex = 11;
            this.pic_CheeseBurgerCombo.TabStop = false;
            // 
            // pic_QuarterPounderCombo
            // 
            this.pic_QuarterPounderCombo.Image = global::BancoInterno.Properties.Resources.combo_quarteirão;
            this.pic_QuarterPounderCombo.Location = new System.Drawing.Point(169, 149);
            this.pic_QuarterPounderCombo.Name = "pic_QuarterPounderCombo";
            this.pic_QuarterPounderCombo.Size = new System.Drawing.Size(142, 93);
            this.pic_QuarterPounderCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_QuarterPounderCombo.TabIndex = 12;
            this.pic_QuarterPounderCombo.TabStop = false;
            // 
            // pic_MacFishCombo
            // 
            this.pic_MacFishCombo.Image = global::BancoInterno.Properties.Resources.mc_fish_combo;
            this.pic_MacFishCombo.Location = new System.Drawing.Point(12, 269);
            this.pic_MacFishCombo.Name = "pic_MacFishCombo";
            this.pic_MacFishCombo.Size = new System.Drawing.Size(134, 93);
            this.pic_MacFishCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MacFishCombo.TabIndex = 13;
            this.pic_MacFishCombo.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BancoInterno.Properties.Resources.desconto;
            this.pictureBox6.Location = new System.Drawing.Point(169, 269);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(267, 93);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::BancoInterno.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pic_MacFishCombo);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_MacFishCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.PictureBox pic_MacFishCombo;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

