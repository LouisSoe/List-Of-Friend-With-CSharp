namespace List_Of_Friend
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_add5 = new System.Windows.Forms.Button();
            this.btn_atoz = new System.Windows.Forms.Button();
            this.btn_ztoa = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_countFriend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 251);
            this.listBox1.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(240, 24);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(148, 27);
            this.txt_name.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(240, 72);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_add5
            // 
            this.btn_add5.Location = new System.Drawing.Point(240, 109);
            this.btn_add5.Name = "btn_add5";
            this.btn_add5.Size = new System.Drawing.Size(75, 23);
            this.btn_add5.TabIndex = 3;
            this.btn_add5.Text = "Add 5";
            this.btn_add5.UseVisualStyleBackColor = true;
            this.btn_add5.Click += new System.EventHandler(this.btn_add5_Click);
            // 
            // btn_atoz
            // 
            this.btn_atoz.Location = new System.Drawing.Point(240, 201);
            this.btn_atoz.Name = "btn_atoz";
            this.btn_atoz.Size = new System.Drawing.Size(75, 23);
            this.btn_atoz.TabIndex = 4;
            this.btn_atoz.Text = "A -> Z";
            this.btn_atoz.UseVisualStyleBackColor = true;
            this.btn_atoz.Click += new System.EventHandler(this.btn_atoz_Click);
            // 
            // btn_ztoa
            // 
            this.btn_ztoa.Location = new System.Drawing.Point(332, 201);
            this.btn_ztoa.Name = "btn_ztoa";
            this.btn_ztoa.Size = new System.Drawing.Size(75, 23);
            this.btn_ztoa.TabIndex = 5;
            this.btn_ztoa.Text = "Z -> A";
            this.btn_ztoa.UseVisualStyleBackColor = true;
            this.btn_ztoa.Click += new System.EventHandler(this.btn_ztoa_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(421, 201);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_countFriend
            // 
            this.txt_countFriend.AutoSize = true;
            this.txt_countFriend.Location = new System.Drawing.Point(362, 81);
            this.txt_countFriend.Name = "txt_countFriend";
            this.txt_countFriend.Size = new System.Drawing.Size(35, 13);
            this.txt_countFriend.TabIndex = 7;
            this.txt_countFriend.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_countFriend);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_ztoa);
            this.Controls.Add(this.btn_atoz);
            this.Controls.Add(this.btn_add5);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_add5;
        private System.Windows.Forms.Button btn_atoz;
        private System.Windows.Forms.Button btn_ztoa;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label txt_countFriend;
    }
}

