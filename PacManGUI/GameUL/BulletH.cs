using PacMan.GameGL;
using PacManGUI.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI.GameUL
{
     class BulletH:GameBullet
    {

        GameDirection direction = GameDirection.Right;
        GameObject pervious = Game.getBlankGameObject();
        GameObject pallet = new GameObject(GameObjectType.REWARD, PacManGUI.Properties.Resources.pallet);
        public BulletH(Image fire, GameCell start) : base(fire)
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
                currentcell.setGameObject(Game.getBlankGameObject());
                base.makeBulletInActive();
            }
         

        }
       
        public override GameCell nextCell()
        {
            return this.CurrentCell.nextCell(direction);
        }
    }
}
