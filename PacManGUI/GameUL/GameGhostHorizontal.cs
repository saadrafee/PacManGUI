using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace PacMan.GameUL
{
    class GameGhostHorizontal:GameGhost
    {
        GameDirection direction = GameDirection.Left;
        GameObject pervious = Game.getBlankGameObject();
        GameObject pallet = new GameObject(GameObjectType.REWARD,PacManGUI.Properties.Resources.pallet);
        public GameGhostHorizontal(Image ghostImage,GameCell start) : base( ghostImage)
        {
            this.CurrentCell = start;
        }
        public override void move(GameCell gameCell)
        {
            GameCell currentcell = this.CurrentCell;
            GameCell nextcell = gameCell;
            GameObject Next_Object = nextcell.CurrentGameObject;
          
            this.CurrentCell = nextcell;
            if (currentcell != nextcell && nextcell != null)
            {
                if (pervious.GameObjectType == GameObjectType.REWARD)
                {
                    currentcell.setGameObject(pallet);
                }
                else
                {
                    currentcell.setGameObject(Game.getBlankGameObject());
                }
                pervious = Next_Object;
            }
            else
            {
                ChangeDirection();
            }
       
        }
        public void ChangeDirection()
        {
            if(direction==GameDirection.Left)
            {
                direction = GameDirection.Right;
            }
            else
            {
                direction = GameDirection.Left;
            }
        }
        public override GameCell nextCell()
        {
            return this.CurrentCell.nextCell(direction);
        }
    }
   
}
