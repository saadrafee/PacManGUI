using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI.GameGL
{
    public abstract class GameBullet:GameObject
    {
        bool isActive = true;
        public GameBullet(Image ghostImage) : base(GameObjectType.BULLET, ghostImage)
        {
        }


        public abstract GameCell nextCell();
        public abstract void move(GameCell gameCell);
        public void makeBulletInActive()
        {
            isActive
                = false;
        }
        public bool checkActive()
        {
            return isActive;
        }
    }
}
