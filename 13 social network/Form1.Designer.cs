namespace _13_social_network
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.auth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usern = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.passw = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // auth
            // 
            this.auth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auth.Location = new System.Drawing.Point(323, 492);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(139, 57);
            this.auth.TabIndex = 0;
            this.auth.Text = "Войти";
            this.auth.UseVisualStyleBackColor = true;
            this.auth.Click += new System.EventHandler(this.auth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // usern
            // 
            this.usern.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usern.Location = new System.Drawing.Point(302, 224);
            this.usern.Name = "usern";
            this.usern.Size = new System.Drawing.Size(176, 26);
            this.usern.TabIndex = 2;
            this.usern.TextChanged += new System.EventHandler(this.usern_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(298, 198);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(170, 23);
            this.username.TabIndex = 3;
            this.username.Text = "Имя пользователя";
            // 
            // passw
            // 
            this.passw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passw.Location = new System.Drawing.Point(302, 321);
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(176, 26);
            this.passw.TabIndex = 4;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.password.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(298, 295);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(75, 23);
            this.password.TabIndex = 5;
            this.password.Text = "Пароль";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.username);
            this.Controls.Add(this.usern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.auth);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Authorization";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button auth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usern;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.Label password;
    }
}

