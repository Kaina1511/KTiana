namespace KTiana
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonAgents = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonContracts = new System.Windows.Forms.Button();
            this.buttonAddedClients = new System.Windows.Forms.Button();
            this.buttonSalary = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgents
            // 
            this.buttonAgents.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgents.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAgents.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonAgents.Location = new System.Drawing.Point(27, 66);
            this.buttonAgents.Name = "buttonAgents";
            this.buttonAgents.Size = new System.Drawing.Size(114, 47);
            this.buttonAgents.TabIndex = 0;
            this.buttonAgents.Text = "Сотрудники";
            this.buttonAgents.UseVisualStyleBackColor = false;
            this.buttonAgents.Click += new System.EventHandler(this.buttonAgents_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonClients.Location = new System.Drawing.Point(27, 120);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(114, 47);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServices.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonServices.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonServices.Location = new System.Drawing.Point(27, 169);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(114, 47);
            this.buttonServices.TabIndex = 2;
            this.buttonServices.Text = "Услуги";
            this.buttonServices.UseVisualStyleBackColor = false;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // buttonContracts
            // 
            this.buttonContracts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContracts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContracts.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonContracts.Location = new System.Drawing.Point(27, 223);
            this.buttonContracts.Name = "buttonContracts";
            this.buttonContracts.Size = new System.Drawing.Size(114, 47);
            this.buttonContracts.TabIndex = 3;
            this.buttonContracts.Text = "Договоры";
            this.buttonContracts.UseVisualStyleBackColor = false;
            this.buttonContracts.Click += new System.EventHandler(this.buttonContracts_Click);
            // 
            // buttonAddedClients
            // 
            this.buttonAddedClients.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddedClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddedClients.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddedClients.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonAddedClients.Location = new System.Drawing.Point(27, 12);
            this.buttonAddedClients.Name = "buttonAddedClients";
            this.buttonAddedClients.Size = new System.Drawing.Size(139, 46);
            this.buttonAddedClients.TabIndex = 4;
            this.buttonAddedClients.Text = "Эффективность работы сотрудников";
            this.buttonAddedClients.UseVisualStyleBackColor = false;
            this.buttonAddedClients.Click += new System.EventHandler(this.buttonAddedClients_Click);
            // 
            // buttonSalary
            // 
            this.buttonSalary.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalary.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSalary.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonSalary.Location = new System.Drawing.Point(164, 120);
            this.buttonSalary.Name = "buttonSalary";
            this.buttonSalary.Size = new System.Drawing.Size(118, 47);
            this.buttonSalary.TabIndex = 5;
            this.buttonSalary.Text = "Зарплата";
            this.buttonSalary.UseVisualStyleBackColor = false;
            this.buttonSalary.Click += new System.EventHandler(this.buttonSalary_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddUser.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonAddUser.Location = new System.Drawing.Point(180, 11);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(281, 49);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "Добавление пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(513, 298);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonSalary);
            this.Controls.Add(this.buttonAddedClients);
            this.Controls.Add(this.buttonContracts);
            this.Controls.Add(this.buttonServices);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonAgents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAgents;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.Button buttonContracts;
        private System.Windows.Forms.Button buttonAddedClients;
        private System.Windows.Forms.Button buttonSalary;
        private System.Windows.Forms.Button buttonAddUser;
    }
}

