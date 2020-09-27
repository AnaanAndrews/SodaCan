using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProjectile
{
    public class Shoot
    {
       
        Random rand= new Random();
   

        public Panel fireball = new Panel()
        {
            Size = new Size(25, 25),
            BackColor = Color.FromName("orange"),
            Location = new Point(Form1.playerLocation[0], Form1.playerLocation[1]),
            Visible = true,
            Name = "Fireball"
        };

        public void Kill()
        {

        }
    }
}

    
