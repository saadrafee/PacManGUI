using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PacMan.GameGL
{
   public  class GamePacManPlayer : GameObject
    {
        public GamePacManPlayer(Image image,GameCell startCell):base (GameObjectType.PLAYER,image) {
            this.CurrentCell = startCell;
        }
       
        public void move(GameCell gameCell)
        {
            CurrentCell = gameCell;
        }
        
    }

    
}
