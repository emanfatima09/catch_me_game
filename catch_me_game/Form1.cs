using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catch_me_game
{
    public partial class catch_me : Form
    {
        bool move_to_left;
        bool move_to_right;
        int speed = 3;
        int score = 0;
        
        Random random_top = new Random();
        Random random_left = new Random();
        
        
        public catch_me()
        {
            InitializeComponent();
            
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                move_to_left = true;
            }
            if (e.KeyCode == Keys.Right)
            {

                move_to_right = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                move_to_left = false;
            }
            if (e.KeyCode == Keys.Right)
            {

                move_to_right = false;
            }
        }

        private void catch_Timer(object sender, EventArgs e)
        {
            catch_bone.Text = "Bones Caught: " + score;


            if (move_to_left == true && dog.Left > 0)
            {
               
                dog.Left -= 10;
                
                dog.Image = Properties.Resources.dog_left;
            }
          
            if (move_to_right == true && dog.Left + dog.Width < this.ClientSize.Width)
            {
                
                dog.Left += 10;
              
                dog.Image = Properties.Resources.dog_right;
            }


           
            foreach (Control bone in this.Controls)
            {
                if (bone is PictureBox && bone.Tag== "eat_bone")

                {

                    bone.Top += speed;

                    if (bone.Top + bone.Height > this.ClientSize.Height)
                    {

                        bone.Top = random_top.Next(80, 300) * -1;
                        bone.Left = random_left.Next(5, this.ClientSize.Width - bone.Width);
                        catch_timer.Stop(); 
                        if(MessageBox.Show("You score is : " + score,"Game Over")== DialogResult.OK)
                        {
                            this.Close();
                        }
                        

                    }

                    if (bone.Bounds.IntersectsWith(dog.Bounds))
                    {
                        bone.Top = random_top.Next(80, 320) * -1;
                        bone.Left = random_left.Next(5, this.ClientSize.Width - bone.Width);
                        
                        score++; 
                    }


                    if (score >= 5)
                    {
                        speed =5 ;
                    }

                }
            }

        }

        private void eat_bone_Click(object sender, EventArgs e)
        {
           
        }

        private void dog_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
