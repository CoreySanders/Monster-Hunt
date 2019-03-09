using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster_Hunt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x; //Balance
        int y = 1; //Income

        //Monsters:
        bool id1 = false; //Pikachu
        bool id2 = false; //Angry Bird

        private void monster_Click(object sender, EventArgs e)
        {
            x = x + y;
            gold.Text = "Gold: " + x;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id1 == true && id2 == true)
            {
                MessageBox.Show("You have already obtained every monster!", "Sorry");
            }
            else
            {
                Random slumpGenerator = new Random();
                int catchchance = slumpGenerator.Next(1, 100);

                if (catchchance >= 70)
                {

                    while (!id1 || !id2)
                    {
                        Random pokeGenerator = new Random();
                        int catchid = pokeGenerator.Next(1, 3);

                        if (catchid == 1)
                        {
                        
                            if (!id1)
                            {
                                id1 = true;
                                catch_id1.Visible = true;
                                break;
                            }
                        }
                        else
                        {
                            if (catchid == 2)
                            {

                                if (!id2)
                                {
                                    id2 = true;
                                    catch_id2.Visible = true;
                                    break;
                                }


                            }

                        }
                 

                    }

                    MessageBox.Show("Congratulations!", "Achievement");

                }

                else
                {
                    MessageBox.Show("Better luck next time!", "You failed");
                }

            }
        }
    }
}
