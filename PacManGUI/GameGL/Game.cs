using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using PacManGUI.GameGL;

namespace PacMan.GameGL
{
    public class Game
    {
        GamePacManPlayer pacman;
        GameGrid grid;
        public List<GameGhost> ghosts;
        public List<GameBullet> bullets=new List<GameBullet>();
        int score = 0;
        Form gameGUI;
        public Game(Form gameGUI)
        {
            this.gameGUI = gameGUI;
            grid = new GameGrid("maze.txt", 20, 70);
            Image pacManImage = Game.getGameObjectImage('P');
            ghosts = new List<GameGhost>();
            GameCell startCell = grid.getCell(8, 10);
            pacman = new GamePacManPlayer(pacManImage, startCell);
            printMaze(grid);

        }
        public GameCell getCell(int x, int y) {
            return grid.getCell(x, y);
        }
        public void addGhost(GameGhost ghost) {
            ghosts.Add(ghost);
        }
        public void addBullet(GameBullet b)
        {
            bullets.Add(b);
        }
        public GamePacManPlayer getPacManPlayer() {
            return pacman;
        }
        public void addScorePoints(int points) {
            this.score = score + points;
        }
        public int getScore() {
            return score;
        }
        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    gameGUI.Controls.Add(cell.PictureBox);
                    //        printCell(cell);
                }

            }
        }

        public static GameObject getBlankGameObject() {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, PacManGUI.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public Image getBlueGhostImage() {
                return PacManGUI.Properties.Resources.ghost_blue;
        }
        public Image getBlueFire()
        {
            return PacManGUI.Properties.Resources.fire;
        }
        public Image getRedGhostImage()
        {
            return PacManGUI.Properties.Resources.ghost_red;
        }

        public Image getPinkGhostImage()
        {
            return PacManGUI.Properties.Resources.ghost_pink;
        }
        public Image getOrangeGhostImage()
        {
            return PacManGUI.Properties.Resources.ghost_orange;
        }

        public static Image getGameObjectImage(char displayCharacter)
        {
            
            Image img = PacManGUI.Properties.Resources.simplebox;
          

            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = PacManGUI.Properties.Resources.vertical;
            }

            if (displayCharacter == '#')
            {
                img = PacManGUI.Properties.Resources.horizontal;
            }

            if (displayCharacter == '.')
            {
                img = PacManGUI.Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p') {
                img = PacManGUI.Properties.Resources.pacman_open;
            }

            return img;
        }
    }
}
