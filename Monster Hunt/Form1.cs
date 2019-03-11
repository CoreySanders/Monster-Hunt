using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster_Hunt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hp.Maximum = 20;
            hp.Value = 20;
            MessageBox.Show("Welcome to Monster Hunt!" + "\n" + "\n" + "Your income will increase every 20 levels", "Welcome!");
        }

        //Basic stuff
        int lvl = 1; //Level
        int x; //Balance
        int y = 1; //Income

        //HP
        int hpbar = 20; //How much HP is left
        int hpbarmax = 20; //The current max HP the level has set
        double hpbarmultiply = 1.2; //How much the hpbarmax is getting multiplied with
        int dmgval = 1; //Your damage

        //Upgrades
        int sword_amount;
        int sword_cost = 20;
        int sword_income = 1;
        int sword_dmg = 1;

        int catch_cost = 100;
        //Monsters:
        bool id1 = false; //Pikachu
        bool id2 = false; //Angry Bird

        private void monster_Click(object sender, EventArgs e)
        {
            x = x + y;
            gold.Text = "Gold: " + x;

            hpbar = hpbar - dmgval;
            if (hpbar <= 0)
            {
                monster.BackgroundImage = Properties.Resources.materialangry;
                hpbarmax = (int)(hpbarmax * hpbarmultiply);
                hpbar = hpbarmax;
                lvl = lvl + 1;
                level.Text = "Level: " + lvl;
                
            }
            if (lvl >= 20)
            {
                hpbarmultiply = 1.1;

            }

            hp.Maximum = hpbarmax;
            hp.Value = hpbar;
            hp_label.Text = hpbar + " / " + hpbarmax + " ";





        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (id1 == true && id2 == true)
            {
                MessageBox.Show("You have already obtained every monster!", "Sorry");
            }
            else
            {
                if (x >= catch_cost)
                {
                    x = x - catch_cost; 
                    gold.Text = "Gold: " + x;

                    Random slumpGenerator = new Random();
                    int catchchance = slumpGenerator.Next(1, 100);

                    if (catchchance >= 70)
                    {

                        while (!id1 || !id2)
                        {
                            int catchid = slumpGenerator.Next(1, 3);

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
                else
                {
                    MessageBox.Show("You need " + catch_cost + " gold to purchase this item!", "Purchase failed");
                }
            }   
        }

        private void upg_sword_Click(object sender, EventArgs e)
        {
            if (x >= sword_cost)
            {
                x = x - sword_cost;
                sword_amount = sword_amount + 1;
                dmgval = dmgval +  sword_dmg;



                dmg.Text = "Dmg: " + dmgval;
                gold.Text = "Gold: " + x; 
                sword_cost = (int)(sword_cost * 1.3);
                sw_cost.Text = sword_cost + " Gold";
                sw_am.Text = sword_amount.ToString();
            }
            else
            {
                MessageBox.Show("You need " + sword_cost + " gold to purchase this item!", "Purchase failed");
            }
        }

        private void level_TextChanged(object sender, EventArgs e)
        {
            if (lvl % 20 == 0)
            {
                y = y + 1;
                MessageBox.Show("Congratulations for reaching level 20!" + "\n" + "\n" + "Your gold income has been increased by +1", "We hope you enjoy your stay");

            }
        }

        private void save_Click(object sender, EventArgs e)
        {

            TextWriter tw = new StreamWriter("settings.txt");
            tw.WriteLine("//Values you are allowed to change");
            tw.WriteLine("//Basic stuff");
            tw.WriteLine("x=" + x + " //Balance");
            tw.WriteLine("y=" + y + " //Income per click(gpc)");
            tw.WriteLine("");
            tw.WriteLine("//HP");
            tw.WriteLine("dmgval=" + dmgval + " //Damage");
            tw.WriteLine("");
            tw.WriteLine("//Upgrades");
            tw.WriteLine("sword_dmg=" + sword_dmg + " //Damage dealt by sword upgrades");
            tw.WriteLine("");
            tw.WriteLine("");
            tw.WriteLine("//Values you aren't allowed to change. (Warning! This might crash your game!)");
            tw.WriteLine("//Basic stuff");
            tw.WriteLine("lvl=" + lvl + " //Level");
            tw.WriteLine("");
            tw.WriteLine("//HP");
            tw.WriteLine("hpbar=" + hpbar);
            tw.WriteLine("hpbarmax=" + hpbarmax);
            tw.WriteLine("hpbarmultiply=" + hpbarmultiply);
            tw.WriteLine("");
            tw.WriteLine("//Upgrades");
            tw.WriteLine("sword_amount=" + sword_amount);
            tw.WriteLine("sword_cost=" + sword_cost);
            tw.WriteLine("sword_income=" + sword_income);
            tw.WriteLine("");
            tw.WriteLine("catch_cost=" + catch_cost);
            tw.WriteLine("//Monsters");
            tw.WriteLine("id1=" + id1);
            tw.WriteLine("");
            tw.WriteLine("id2=" + id2);


            tw.Close();
            MessageBox.Show("Game saved!", "Saved");
            
        }

        private void load_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex (@"(\d+[,\.]?)");
            TextReader tr = new StreamReader("settings.txt");
            tr.ReadLine();
            tr.ReadLine();
            string input1 = tr.ReadLine();
            string input2 = tr.ReadLine();
            tr.ReadLine();
            tr.ReadLine();
            string input3 = tr.ReadLine();
            tr.ReadLine();
            tr.ReadLine();
            string input4 = tr.ReadLine();
            tr.ReadLine();
            tr.ReadLine();
            tr.ReadLine();
            tr.ReadLine();
            string input5 = tr.ReadLine();
            tr.ReadLine();
            tr.ReadLine();
            string input6 = tr.ReadLine();
            string input7 = tr.ReadLine();
            string input8 = tr.ReadLine();
            tr.ReadLine();
            tr.ReadLine();
            string input9 = tr.ReadLine();
            string input10 = tr.ReadLine();
            string input11 = tr.ReadLine();
            tr.ReadLine();
            string input12 = tr.ReadLine();
            tr.ReadLine();
            string input13 = tr.ReadLine();
            tr.ReadLine();
            string input14 = tr.ReadLine();





            Match match1 = regex.Match(input1);
            Match match2 = regex.Match(input2);

            Match match3 = regex.Match(input3);

            Match match4 = regex.Match(input4);

            Match match5 = regex.Match(input5);

            Match match6 = regex.Match(input6);
            Match match7 = regex.Match(input7);
            Match match8 = regex.Match(input8);

            Match match9 = regex.Match(input9);
            Match match10 = regex.Match(input10);
            Match match11 = regex.Match(input11);

            Match match12 = regex.Match(input12);

            Match match13 = regex.Match(input13);
            Match match14 = regex.Match(input14);

            if (match1.Success)
            {
                string mg1 = match1.Groups[1].Value;
                x = Convert.ToInt32(mg1);
            }
            if (match2.Success)
            {
                string mg2 = match2.Groups[1].Value;
                y = Convert.ToInt32(mg2);
            }


            if (match3.Success)
            {
                string mg3 = match3.Groups[1].Value;
                dmgval = Convert.ToInt32(mg3);
            }


            if (match4.Success)
            {
                string mg4 = match4.Groups[1].Value;
                sword_dmg = Convert.ToInt32(mg4);
            }


            if (match5.Success)
            {
                string mg5 = match5.Groups[1].Value;
                lvl = Convert.ToInt32(mg5);
            }


            if (match6.Success)
            {
                string mg6 = match6.Groups[1].Value;
                hpbar = Convert.ToInt32(mg6);
            }
            if (match7.Success)
            {
                string mg7 = match7.Groups[1].Value;
                hpbarmax = Convert.ToInt32(mg7);
            }
            if (match8.Success)
            {
                string mg8 = match8.Groups[1].Value;
                hpbarmultiply = Convert.ToDouble(mg8);
            }


            if (match9.Success)
            {
                string mg9 = match9.Groups[1].Value;
                sword_amount = Convert.ToInt32(mg9);
            }
            if (match10.Success)
            {
                string mg10 = match10.Groups[1].Value;
                sword_cost = Convert.ToInt32(mg10);
            }
            if (match11.Success)
            {
                string mg11 = match11.Groups[1].Value;
                sword_income = Convert.ToInt32(mg11);
            }


            if (match12.Success)
            {
                string mg12 = match12.Groups[1].Value;
                catch_cost = Convert.ToInt32(mg12);
            }


            /*
            if (match13.Success)
            {
                string mg13 = match13.Groups[1].Value;
            }
            if (match14.Success)
            {
                string mg14 = match14.Groups[1].Value;
            }
            */
            













            tr.Close();
            MessageBox.Show("Game loaded!", "Loaded");
            dmg.Text = "Dmg: " + dmgval;
            gold.Text = "Gold: " + x;
            sw_cost.Text = sword_cost + " Gold";
            sw_am.Text = sword_amount.ToString();
            level.Text = "Level: " + lvl;
            hp.Maximum = hpbarmax;
            hp.Value = hpbar;
            hp_label.Text = hpbar + " / " + hpbarmax + " ";



        }
    }
}
