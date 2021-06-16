using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RandomProjectile
{
    public partial class Form1 : Form
    {
        public Random ranum = new Random();
        public static int[] playerLocation = new int[2];


        public List<Shoot> Fireballs = new List<Shoot>();
        public int fireCount = -1;

        public List<int> dirX = new List<int>();
        public List<int> dirY = new List<int>();

        private Boolean L;
        private Boolean R;
        private Boolean U;
        private Boolean D;

        private int WHYGOD = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void tmFire_Tick(object sender, EventArgs e)
        {
            FireAdd();
            FireDirectionX();
            FireDirectionY();
            tmMove.Enabled = true;

        }
        private void tmMove_Tick(object sender, EventArgs e)
        {
            FireMove();
            Collision();
        }
        private void tmPlayerMove_Tick(object sender, EventArgs e)
        {
            PlayerMove();
        }
        public void FireAdd()
        {
            
                    playerLocation[0] = lblYou.Location.X;
                    playerLocation[1] = lblYou.Location.Y;

                    fireCount += 1;
                    Fireballs.Add(new Shoot());
                    Controls.Add(Fireballs[fireCount].fireball);
                   WHYGOD = 0;
                

               
        }

        public void FireDirectionX()
        {
            dirX.Add(Ran(-8, 8));
        }

        public void FireDirectionY()
        {
            dirY.Add(Ran(-8, 8));
        }

        public void FireMove()
        {
            for (var x = 0; x < Fireballs.Count; x++)
            {
                
                    Fireballs[x].fireball.Left += dirX[x];
                    Fireballs[x].fireball.Top += dirY[x];
            }
        }
        public void Collision()
        {
            for (var i = 0; i < Fireballs.Count; i++)
            {
                if (!(Fireballs[i].fireball.Location.Y < 1010 && Fireballs[i].fireball.Location.X < 1200 && Fireballs[i].fireball.Location.Y >0 && Fireballs[i].fireball.Location.X > 0))
                {
                    fireCount -=1 ;
                    Controls.Remove(Fireballs[i].fireball); 
                    Fireballs.Remove(Fireballs[i]);
                    
                    dirX.Remove(dirX[i]);
                    dirY.Remove(dirY[i]);
                    
                }
            }
        }
        public void PlayerMove()
        {
            if (U)
            {
                lblYou.Top -= 2;
            }
            if (D)
            {
                lblYou.Top += 2;
            }
            if (L) {
                lblYou.Left -= 2;
            }
            if (R){
                lblYou.Left += 2;
            }
        }
        public int Ran(int min, int max)
        {
            var y = ranum.Next(min, max);
            return y;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                U = true;
            }
            if (e.KeyCode == Keys.A)
            {
                L = true;
            }
            if (e.KeyCode == Keys.S)
            {
                D = true;

            }
            if (e.KeyCode == Keys.D)
            {
                R = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {

                U = false;
            }
            if (e.KeyCode == Keys.A)
            {
                L = false;
            }
            if (e.KeyCode == Keys.S)
            {
                D = false;

            }
            if (e.KeyCode == Keys.D)
            {
                R = false;
            }
            
        }

      
    }
}