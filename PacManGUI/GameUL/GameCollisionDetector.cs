using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;
using PacManGUI.GameGL;

namespace PacMan.GameUL
{
    class GameCollisionDetector

    {
        public bool isGhostCollideWithPacMan(GameGhost ghost) {
            bool flag = false;
            //Write your Code Here
            GameCell up = ghost.nextCell();
            
            if(up.CurrentGameObject.GameObjectType==GameObjectType.PLAYER)
            {
                return true;
            }
            return flag;
        }
        public bool isPacManCollideWithPallet(GameCell potentialCell) {
            bool flag = false;
            //Write your Code Here
            if(potentialCell.CurrentGameObject.GameObjectType==GameObjectType.REWARD)
            {
                return true;
            }
            return flag;

        }
        public bool isBulletCollideWithEnemy(GameBullet bullet)
        {
            bool flag = false;
            //Write your Code Here
            if (bullet.checkActive()) { 
            GameCell up = bullet.nextCell();

            if (up.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                return true;
            } }
            return flag;
        }
    }
}
