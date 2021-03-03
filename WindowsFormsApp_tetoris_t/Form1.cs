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
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ペイント　イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // 画像読み込み
            Image image = Image.FromFile(@"D:\01_sorce\test\WindowsFormsApp_tetoris_t\WindowsFormsApp_tetoris_t\Tetris.bmp");

            // 切り取り
            const int length = 20;
            const int nColor = 8;
            //1 :::var srcRect = new Rectangle(3 * length, 0, length, length);
            var srcRect = new Rectangle(3 * length, 0, length, length);
            var destRect = new Rectangle(length, length, length, length);
            e.Graphics.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);



            //var srcRect = new Rectangle[nColor];
            //for (int i = 0; i > nColor; i++)
            //{
            //    srcRect[i] = new Rectangle(i * length, 0, length, length);
            //}

            //// 切り取った絵を表示する位置と大きさを決める領域
            //const int width = 10;
            //const int height = 20;
            //var destRect = new Rectangle[width, height];
            //for (int i = 0; i < width; i++)
            //{
            //    for (int j = 0; j < height; j++)
            //    {
            //        destRect[i, j] = new Rectangle(i * length, j * length, length, length);
            //    }
            //}

            //// 描画
            //e.Graphics.DrawImage(image, destRect[1,1], srcRect[4], GraphicsUnit.Pixel);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 画像読み込み
            Image image = Image.FromFile(@"D:\01_sorce\test\WindowsFormsApp_tetoris_t\WindowsFormsApp_tetoris_t\Tetris.bmp");

            // 切り取り
            const int length = 20;
            const int nColor = 8;
            //1 :::var srcRect = new Rectangle(3 * length, 0, length, length);
            var srcRect = new Rectangle(3 * length, 0, length, length);
            var destRect = new Rectangle[10, 20];
            e.Graphics.DrawImage(image, destRect[1, 1], srcRect, GraphicsUnit.Pixel);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // 画像読み込み
            Image image = Image.FromFile("Tetris.bmp");

            // 切り取り
            const int length = 20;
            const int nColor = 8;
            //1 :::var srcRect = new Rectangle(3 * length, 0, length, length);
            var srcRect = new Rectangle(4 * length, 0, length, length);
            var destRect = new Rectangle(length, length, length, length);
            e.Graphics.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);

        }
    }
}
