using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_tetoris_t
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// 横幅
        /// </summary>
        private const int width = 10;
        /// <summary>
        /// 縦幅
        /// </summary>
        private const int height = 20;
        /// <summary>
        /// 画像の一辺の大きさ
        /// </summary>
        private const int length = 20;
        /// <summary>
        /// 色のバリエーション数
        /// </summary>
        private const int nColor = 8;

        /// <summary>
        /// 全画面のブロックの色を決める配列
        /// </summary>
        private int[,] screen = new int[width, height];

        private Image image;

        private Rectangle[] srcRect;

        private Rectangle[,] destRect;

        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 描画イメージの位置とサイズを設定
        /// </summary>
        private void CreateSrcRect()
        {
            srcRect = new Rectangle[nColor];
            for (int i = 0; i < nColor; i++)
            {
                srcRect[i] = new Rectangle(i * length, 0, length, length);
            }
        }

        /// <summary>
        ///描画する image オブジェクトの部分を設定
        /// </summary>
        private void CreateDestRect()
        {
            destRect = new Rectangle[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    destRect[i, j] = new Rectangle(i * length, j * length, length, length);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 画像読み込み
            image = Image.FromFile("Tetris.bmp");
            Bitmap img = new Bitmap(200, 100);

            CreateSrcRect();
            CreateDestRect();

            //Graphics dra = new Graphics();

            Graphics drawingImage = Graphics.FromImage(img);
            //drawingImage.DrawImage(image, 20, 20, 20, 20);
            drawingImage.DrawImage(img, destRect[1, 1], srcRect[3], GraphicsUnit.Pixel);
            drawingImage.Dispose();
            pictureBox1.Image = img;

            //pictureBox1..Image = drawingImage.DrawImage(image, destRect[1, 1], srcRect[3], GraphicsUnit.Pixel);

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //Graphics drawingImage = Graphics.FromImage(image);
            ////drawingImage.DrawImage(image, 20, 20, 20, 20);
            //drawingImage.DrawImage(image, destRect[1, 1], srcRect[3], GraphicsUnit.Pixel);

            ////e.Graphics.DrawImage(image, destRect[1, 1], srcRect[3], GraphicsUnit.Pixel);

        }
    }
}
