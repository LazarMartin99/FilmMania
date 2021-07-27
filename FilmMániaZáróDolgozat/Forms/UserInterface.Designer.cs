namespace FilmMániaZáróDolgozat
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonDirector = new System.Windows.Forms.Button();
            this.buttonActor = new System.Windows.Forms.Button();
            this.buttonMovie = new System.Windows.Forms.Button();
            this.asd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewFavourites = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBoxSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavourites)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(370, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üdvözlet a FilmMániába!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Válogasson a filmek listájából kedve szerint";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBoxSearch.Controls.Add(this.buttonDirector);
            this.groupBoxSearch.Controls.Add(this.buttonActor);
            this.groupBoxSearch.Controls.Add(this.buttonMovie);
            this.groupBoxSearch.Controls.Add(this.asd);
            this.groupBoxSearch.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxSearch.Location = new System.Drawing.Point(649, 112);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(275, 209);
            this.groupBoxSearch.TabIndex = 3;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Keresés Menü";
            // 
            // buttonDirector
            // 
            this.buttonDirector.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDirector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDirector.Image = global::FilmMániaZáróDolgozat.Properties.Resources.csapó;
            this.buttonDirector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDirector.Location = new System.Drawing.Point(77, 151);
            this.buttonDirector.Name = "buttonDirector";
            this.buttonDirector.Size = new System.Drawing.Size(103, 39);
            this.buttonDirector.TabIndex = 3;
            this.buttonDirector.Text = "Rendező";
            this.buttonDirector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDirector.UseVisualStyleBackColor = false;
            this.buttonDirector.Click += new System.EventHandler(this.buttonDirector_Click);
            // 
            // buttonActor
            // 
            this.buttonActor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonActor.Image = global::FilmMániaZáróDolgozat.Properties.Resources.csapó;
            this.buttonActor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActor.Location = new System.Drawing.Point(77, 109);
            this.buttonActor.Name = "buttonActor";
            this.buttonActor.Size = new System.Drawing.Size(103, 36);
            this.buttonActor.TabIndex = 2;
            this.buttonActor.Text = "Szinész";
            this.buttonActor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonActor.UseVisualStyleBackColor = false;
            this.buttonActor.Click += new System.EventHandler(this.buttonActor_Click);
            // 
            // buttonMovie
            // 
            this.buttonMovie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMovie.Image = global::FilmMániaZáróDolgozat.Properties.Resources.csapó;
            this.buttonMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMovie.Location = new System.Drawing.Point(77, 67);
            this.buttonMovie.Name = "buttonMovie";
            this.buttonMovie.Size = new System.Drawing.Size(103, 36);
            this.buttonMovie.TabIndex = 1;
            this.buttonMovie.Text = "Film";
            this.buttonMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMovie.UseVisualStyleBackColor = false;
            this.buttonMovie.Click += new System.EventHandler(this.buttonMovie_Click);
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.asd.Location = new System.Drawing.Point(6, 31);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(246, 15);
            this.asd.TabIndex = 0;
            this.asd.Text = "Keressen filmeket az alábbi menüpontok között";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.buttonLogout);
            this.groupBox1.Controls.Add(this.buttonProfile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(649, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiók";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogout.Image = global::FilmMániaZáróDolgozat.Properties.Resources.logout_log_out_512;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(77, 156);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(114, 36);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Kijelentkezés";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfile.Image")));
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(77, 100);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(114, 37);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "Adatlap";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProfile.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(34, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kezelje fiókját egyszerüen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bezárás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::FilmMániaZáróDolgozat.Properties.Resources.kedvencc;
            this.tabPage2.Controls.Add(this.dataGridViewFavourites);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kedvencek";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFavourites
            // 
            this.dataGridViewFavourites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFavourites.Location = new System.Drawing.Point(36, 34);
            this.dataGridViewFavourites.Name = "dataGridViewFavourites";
            this.dataGridViewFavourites.Size = new System.Drawing.Size(478, 384);
            this.dataGridViewFavourites.TabIndex = 0;
            this.dataGridViewFavourites.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFavourites_CellContentDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Összes Film";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(496, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(32, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 483);
            this.tabControl1.TabIndex = 6;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavourites)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonDirector;
        private System.Windows.Forms.Button buttonActor;
        private System.Windows.Forms.Button buttonMovie;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewFavourites;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}