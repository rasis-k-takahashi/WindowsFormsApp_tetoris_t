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
    public partial class Form1 : Form
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

        /// <summary>
        /// 画像
        /// </summary>
        private Image image;

        private Rectangle[] srcRect;

        private Rectangle[,] destRect;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
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

        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 画像読み込み
            image = Image.FromFile("Tetris.bmp");

            CreateSrcRect();
            CreateDestRect();

            Graphics drawingImage = Graphics.FromImage(image);
            drawingImage.DrawImage(image, 20, 20, 20, 20);
        }

        /// <summary>
        /// パネルのペイントイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // 画像読み込み
            Image image = Image.FromFile(@"D:\01_sorce\test\WindowsFormsApp_tetoris_t\WindowsFormsApp_tetoris_t\Tetris.bmp");

            // 切り取り
            //1 :::var srcRect = new Rectangle(3 * length, 0, length, length);
            var srcRect = new Rectangle(3 * length, 0, length, length);
            var destRect = new Rectangle(length, length, length, length);
            e.Graphics.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);

            //// 描画
            //e.Graphics.DrawImage(image, destRect[1,1], srcRect[4], GraphicsUnit.Pixel);
        }

        /// <summary>
        /// pictureBox1のペイントイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // 切り取った絵を表示する位置と大きさを決める領域


            Paint1(e);


        }

        private void Paint1(PaintEventArgs e)
        {
            // 描画　赤色ブロックを左上から4,3の位置に描画
            e.Graphics.DrawImage(image, destRect[4, 3], srcRect[4], GraphicsUnit.Pixel);
        }

        private void Paint2(PaintEventArgs e)
        {
            // 全画面青色ブロックを描画
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    e.Graphics.DrawImage(image, destRect[i, j], srcRect[3], GraphicsUnit.Pixel);
                }
            }
        }

    }
}
