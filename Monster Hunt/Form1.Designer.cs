namespace Monster_Hunt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hp = new System.Windows.Forms.ProgressBar();
            this.gold = new System.Windows.Forms.Label();
            this.dmg = new System.Windows.Forms.Label();
            this.sw_cost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.catch_id2 = new System.Windows.Forms.Button();
            this.catch_id1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.upg_sword = new System.Windows.Forms.Button();
            this.monster = new System.Windows.Forms.Button();
            this.hp_label = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.sw_am = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hp
            // 
            this.hp.Location = new System.Drawing.Point(296, 264);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(264, 24);
            this.hp.TabIndex = 1;
            // 
            // gold
            // 
            this.gold.AutoSize = true;
            this.gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gold.Location = new System.Drawing.Point(8, 8);
            this.gold.Name = "gold";
            this.gold.Size = new System.Drawing.Size(60, 20);
            this.gold.TabIndex = 2;
            this.gold.Text = "Gold: 0";
            // 
            // dmg
            // 
            this.dmg.AutoSize = true;
            this.dmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmg.Location = new System.Drawing.Point(8, 48);
            this.dmg.Name = "dmg";
            this.dmg.Size = new System.Drawing.Size(60, 20);
            this.dmg.TabIndex = 3;
            this.dmg.Text = "Dmg: 1";
            // 
            // sw_cost
            // 
            this.sw_cost.AutoSize = true;
            this.sw_cost.Location = new System.Drawing.Point(64, 176);
            this.sw_cost.Name = "sw_cost";
            this.sw_cost.Size = new System.Drawing.Size(44, 13);
            this.sw_cost.TabIndex = 5;
            this.sw_cost.Text = "20 Gold";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.catch_id2);
            this.panel1.Controls.Add(this.catch_id1);
            this.panel1.Location = new System.Drawing.Point(1168, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 528);
            this.panel1.TabIndex = 6;
            // 
            // catch_id2
            // 
            this.catch_id2.BackColor = System.Drawing.Color.Transparent;
            this.catch_id2.BackgroundImage = global::Monster_Hunt.Properties.Resources.angrybirds;
            this.catch_id2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catch_id2.FlatAppearance.BorderSize = 0;
            this.catch_id2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.catch_id2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.catch_id2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catch_id2.ForeColor = System.Drawing.Color.Transparent;
            this.catch_id2.Location = new System.Drawing.Point(32, 0);
            this.catch_id2.Name = "catch_id2";
            this.catch_id2.Size = new System.Drawing.Size(32, 32);
            this.catch_id2.TabIndex = 9;
            this.catch_id2.UseVisualStyleBackColor = false;
            this.catch_id2.Visible = false;
            // 
            // catch_id1
            // 
            this.catch_id1.BackColor = System.Drawing.Color.Transparent;
            this.catch_id1.BackgroundImage = global::Monster_Hunt.Properties.Resources.pikachu;
            this.catch_id1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catch_id1.FlatAppearance.BorderSize = 0;
            this.catch_id1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.catch_id1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.catch_id1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catch_id1.ForeColor = System.Drawing.Color.Transparent;
            this.catch_id1.Location = new System.Drawing.Point(0, 0);
            this.catch_id1.Name = "catch_id1";
            this.catch_id1.Size = new System.Drawing.Size(32, 32);
            this.catch_id1.TabIndex = 8;
            this.catch_id1.UseVisualStyleBackColor = false;
            this.catch_id1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(296, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Catch Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // upg_sword
            // 
            this.upg_sword.BackColor = System.Drawing.Color.Transparent;
            this.upg_sword.BackgroundImage = global::Monster_Hunt.Properties.Resources.sword;
            this.upg_sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upg_sword.FlatAppearance.BorderSize = 0;
            this.upg_sword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.upg_sword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.upg_sword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upg_sword.ForeColor = System.Drawing.Color.Transparent;
            this.upg_sword.Location = new System.Drawing.Point(8, 88);
            this.upg_sword.Name = "upg_sword";
            this.upg_sword.Size = new System.Drawing.Size(56, 104);
            this.upg_sword.TabIndex = 4;
            this.upg_sword.UseVisualStyleBackColor = false;
            this.upg_sword.Click += new System.EventHandler(this.upg_sword_Click);
            // 
            // monster
            // 
            this.monster.BackColor = System.Drawing.Color.Transparent;
            this.monster.BackgroundImage = global::Monster_Hunt.Properties.Resources.pikachucc;
            this.monster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monster.FlatAppearance.BorderSize = 0;
            this.monster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.monster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.monster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monster.ForeColor = System.Drawing.Color.Transparent;
            this.monster.Location = new System.Drawing.Point(296, 8);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(264, 256);
            this.monster.TabIndex = 0;
            this.monster.UseVisualStyleBackColor = false;
            this.monster.Click += new System.EventHandler(this.monster_Click);
            // 
            // hp_label
            // 
            this.hp_label.AutoSize = true;
            this.hp_label.BackColor = System.Drawing.Color.Transparent;
            this.hp_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hp_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hp_label.Location = new System.Drawing.Point(424, 288);
            this.hp_label.Name = "hp_label";
            this.hp_label.Size = new System.Drawing.Size(47, 15);
            this.hp_label.TabIndex = 8;
            this.hp_label.Text = "20 / 20 ";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.Location = new System.Drawing.Point(288, 0);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(63, 20);
            this.level.TabIndex = 9;
            this.level.Text = "Level: 1";
            this.level.TextChanged += new System.EventHandler(this.level_TextChanged);
            // 
            // sw_am
            // 
            this.sw_am.AutoSize = true;
            this.sw_am.Location = new System.Drawing.Point(64, 88);
            this.sw_am.Name = "sw_am";
            this.sw_am.Size = new System.Drawing.Size(13, 13);
            this.sw_am.TabIndex = 10;
            this.sw_am.Text = "0";
            // 
            // save
            // 
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(8, 480);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(96, 24);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Location = new System.Drawing.Point(8, 504);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(96, 24);
            this.load.TabIndex = 12;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 533);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.sw_am);
            this.Controls.Add(this.level);
            this.Controls.Add(this.hp_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sw_cost);
            this.Controls.Add(this.upg_sword);
            this.Controls.Add(this.dmg);
            this.Controls.Add(this.gold);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.monster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Monster Hunt";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monster;
        private System.Windows.Forms.ProgressBar hp;
        private System.Windows.Forms.Label gold;
        private System.Windows.Forms.Label dmg;
        private System.Windows.Forms.Button upg_sword;
        private System.Windows.Forms.Label sw_cost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button catch_id1;
        private System.Windows.Forms.Button catch_id2;
        private System.Windows.Forms.Label hp_label;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label sw_am;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
    }
}

