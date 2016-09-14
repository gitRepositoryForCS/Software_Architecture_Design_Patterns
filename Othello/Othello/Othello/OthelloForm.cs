using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    // Provides a form with an Othello board as 8x8 PictureBoxes
    public partial class OthelloForm : Form
    {
        // stores 8x8 tiles of PictureBoxes for othello board for easy control access
        private readonly PictureBox[,] tileYX;

        // stores an empty tile image (green background with black border)
        private readonly Image tileImage;

        // stores an tile image with a white piece
        private readonly Image whiteTileImage;

        // stores an tile image with a black piece
        private readonly Image blackTileImage;

        private bool status = false;

        //delegate numberOfWhites
        //numberOfBlack
        //tiles[8,8]
        //delegate hasAnyvalidMove()
        //delegate IsValidMove
        //delegate MakeMove()


        public OthelloForm()
        {
            InitializeComponent();

            tileYX = new PictureBox[,] {
                { tile00, tile01, tile02, tile03, tile04, tile05, tile06, tile07 },
                { tile10, tile11, tile12, tile13, tile14, tile15, tile16, tile17 },
                { tile20, tile21, tile22, tile23, tile24, tile25, tile26, tile27 },
                { tile30, tile31, tile32, tile33, tile34, tile35, tile36, tile37 },
                { tile40, tile41, tile42, tile43, tile44, tile45, tile46, tile47 },
                { tile50, tile51, tile52, tile53, tile54, tile55, tile56, tile57 },
                { tile60, tile61, tile62, tile63, tile64, tile65, tile66, tile67 },
                { tile70, tile71, tile72, tile73, tile74, tile75, tile76, tile77 }
            };

            // get tile images from Properties' Resources
            tileImage = global::Othello.Properties.Resources.tile;
            whiteTileImage = global::Othello.Properties.Resources.tile_white;
            blackTileImage = global::Othello.Properties.Resources.tile_black;

            Init();
        }

        // Additional initializations
        private void Init()
        {
            // Example for changing a PictureBox's image to setup a new game
            // tileYX[3, 3].Image = whiteTileImage;
            // tileYX[4, 4].Image = whiteTileImage;
            // tileYX[3, 4].Image = blackTileImage;
            // tileYX[4, 3].Image = blackTileImage;

            // TODO
        }

        private void tile33_Click(object sender, EventArgs e)
        {

        }

        private void tile00_Click(object sender, EventArgs e)
        {
            MessageBox.Show("00");
        }
    }
}
