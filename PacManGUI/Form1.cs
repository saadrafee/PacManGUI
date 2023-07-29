using System;
using System.Windows.Forms;
using PacMan.GameGL;
using PacMan.GameUL;
using EZInput;
using gamePacOop.GameGL;
using PacManGUI.GameUL;
using PacManGUI.GameGL;
/*using Microsoft.VisualBasic.Devices;*/

namespace PacManGUI
{
    public partial class Form1 : Form
    {
        Game game;
        GameCollisionDetector collider;
        public Form1()
        {
            InitializeComponent();
            game = new Game(this);
            collider = new GameCollisionDetector();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GameGhostVertical gv1 = new GameGhostVertical(game.getBlueGhostImage(), game.getCell(3, 6));
            GameGhostVertical gv2 = new GameGhostVertical(game.getOrangeGhostImage(), game.getCell(3, 22));
            GameGhostHorizontal HGhost = new GameGhostHorizontal(game.getPinkGhostImage(), game.getCell(13, 23));
            GameGhostChaser CGhost = new GameGhostChaser(game.getRedGhostImage(), game.getCell(15, 26));
           
            game.addGhost(gv1);
            game.addGhost(gv2);
            game.addGhost(HGhost);
            game.addGhost(CGhost);
        }
        private void gameLoop_Tick(object sender, EventArgs e)
        {
            movePacMan();
            moveGhosts();
            moveBullet();
            showScore();

        }
        public void moveGhosts()
        {
            foreach (GameGhost g in game.ghosts)
            {
                if (collider.isGhostCollideWithPacMan(g))
                {
                    game.addScorePoints(-1);
                }
                g.move(g.nextCell());


            }
        }
        public void moveBullet()
        {
            if (game.bullets.Count > 0)
            {
                foreach (GameBullet g in game.bullets)
                {
                    if (collider.isBulletCollideWithEnemy(g))
                    {
                        game.addScorePoints(+5);
                    }
                    g.move(g.nextCell());


                }
            }
        }
        private void showScore()
        {

            lblScoreValue.Text = game.getScore().ToString();
        }
        private void movePacMan()
        {
            GamePacManPlayer pacman = game.getPacManPlayer();
            GameCell potentialNewCell = pacman.CurrentCell;
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                potentialNewCell = pacman.CurrentCell.nextCell(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                potentialNewCell = pacman.CurrentCell.nextCell(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                potentialNewCell = pacman.CurrentCell.nextCell(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                potentialNewCell = pacman.CurrentCell.nextCell(GameDirection.Down);
            }
            if(Keyboard.IsKeyPressed(Key.Space))
            {
                gerateBullet(pacman);
            }
            GameCell currentCell = pacman.CurrentCell;
            currentCell.setGameObject(Game.getBlankGameObject());
            if (collider.isPacManCollideWithPallet(potentialNewCell))
            {
                game.addScorePoints(1);
            }
            pacman.move(potentialNewCell);


        }
        public void gerateBullet(GamePacManPlayer pacman)
        {
            BulletH b = new BulletH(game.getBlueFire(), pacman.CurrentCell.nextCell(GameDirection.Right));
            game.addBullet(b);
        }
    }
}
