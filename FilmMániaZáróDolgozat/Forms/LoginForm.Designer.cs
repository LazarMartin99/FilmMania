namespace FilmMániaZáróDolgozat
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonBejelentkezésAdmin = new System.Windows.Forms.Button();
            this.buttonBejelentkezes = new System.Windows.Forms.Button();
            this.buttonRegisztráció = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "FilmMánia Bejelentkezés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(159, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Felhasználónév: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(195, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jelszó:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(320, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 28);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(320, 183);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 28);
            this.textBox2.TabIndex = 4;
            // 
            // buttonBejelentkezésAdmin
            // 
            this.buttonBejelentkezésAdmin.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonBejelentkezésAdmin.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBejelentkezésAdmin.Image = global::FilmMániaZáróDolgozat.Properties.Resources.admin;
            this.buttonBejelentkezésAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBejelentkezésAdmin.Location = new System.Drawing.Point(184, 315);
            this.buttonBejelentkezésAdmin.Name = "buttonBejelentkezésAdmin";
            this.buttonBejelentkezésAdmin.Size = new System.Drawing.Size(131, 52);
            this.buttonBejelentkezésAdmin.TabIndex = 5;
            this.buttonBejelentkezésAdmin.Text = "Adminisztrátor";
            this.buttonBejelentkezésAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBejelentkezésAdmin.UseVisualStyleBackColor = false;
            this.buttonBejelentkezésAdmin.Click += new System.EventHandler(this.buttonBejelentkezésAdmin_Click);
            // 
            // buttonBejelentkezes
            // 
            this.buttonBejelentkezes.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonBejelentkezes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBejelentkezes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBejelentkezes.Image = global::FilmMániaZáróDolgozat.Properties.Resources.user;
            this.buttonBejelentkezes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBejelentkezes.Location = new System.Drawing.Point(338, 315);
            this.buttonBejelentkezes.Name = "buttonBejelentkezes";
            this.buttonBejelentkezes.Size = new System.Drawing.Size(131, 52);
            this.buttonBejelentkezes.TabIndex = 6;
            this.buttonBejelentkezes.Text = "Bejelentkezés";
            this.buttonBejelentkezes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBejelentkezes.UseVisualStyleBackColor = false;
            this.buttonBejelentkezes.Click += new System.EventHandler(this.buttonBejelentkezes_Click);
            // 
            // buttonRegisztráció
            // 
            this.buttonRegisztráció.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonRegisztráció.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegisztráció.Image = global::FilmMániaZáróDolgozat.Properties.Resources.register;
            this.buttonRegisztráció.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegisztráció.Location = new System.Drawing.Point(487, 315);
            this.buttonRegisztráció.Name = "buttonRegisztráció";
            this.buttonRegisztráció.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRegisztráció.Size = new System.Drawing.Size(131, 52);
            this.buttonRegisztráció.TabIndex = 7;
            this.buttonRegisztráció.Text = "Regisztráció";
            this.buttonRegisztráció.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegisztráció.UseVisualStyleBackColor = false;
            this.buttonRegisztráció.Click += new System.EventHandler(this.buttonRegisztráció_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(483, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nincs még fiókja?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FilmMániaZáróDolgozat.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(794, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRegisztráció);
            this.Controls.Add(this.buttonBejelentkezes);
            this.Controls.Add(this.buttonBejelentkezésAdmin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonBejelentkezésAdmin;
        private System.Windows.Forms.Button buttonBejelentkezes;
        private System.Windows.Forms.Button buttonRegisztráció;
        private System.Windows.Forms.Label label4;
    }
}