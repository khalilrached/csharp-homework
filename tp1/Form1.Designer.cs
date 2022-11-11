namespace TpMaisonExercice1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.element = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSwipeR = new System.Windows.Forms.Button();
            this.btnSwipeL = new System.Windows.Forms.Button();
            this.btnDel2 = new System.Windows.Forms.Button();
            this.btnDel1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(73, 75);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(110, 173);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(357, 75);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(110, 173);
            this.listBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.element.Location = new System.Drawing.Point(137, 27);
            this.element.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.element.Name = "textBox1";
            this.element.Size = new System.Drawing.Size(162, 20);
            this.element.TabIndex = 2;
            this.element.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btADD
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(322, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btADD";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btRIGHT
            // 
            this.btnSwipeR.Enabled = false;
            this.btnSwipeR.Location = new System.Drawing.Point(242, 113);
            this.btnSwipeR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSwipeR.Name = "btRIGHT";
            this.btnSwipeR.Size = new System.Drawing.Size(56, 19);
            this.btnSwipeR.TabIndex = 4;
            this.btnSwipeR.Text = "Swipe ->";
            this.btnSwipeR.UseVisualStyleBackColor = true;
            this.btnSwipeR.Click += new System.EventHandler(this.btnSwipeR_Click);
            // 
            // btSWIPEL
            // 
            this.btnSwipeL.Enabled = false;
            this.btnSwipeL.Location = new System.Drawing.Point(242, 167);
            this.btnSwipeL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSwipeL.Name = "btSWIPEL";
            this.btnSwipeL.Size = new System.Drawing.Size(56, 19);
            this.btnSwipeL.TabIndex = 5;
            this.btnSwipeL.Text = "<-Swipe";
            this.btnSwipeL.UseVisualStyleBackColor = true;
            this.btnSwipeL.Click += new System.EventHandler(this.btSwipeL_Click);
            // 
            // btDELETE2
            // 
            this.btnDel2.Enabled = false;
            this.btnDel2.Location = new System.Drawing.Point(382, 275);
            this.btnDel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel2.Name = "btDELETE2";
            this.btnDel2.Size = new System.Drawing.Size(56, 19);
            this.btnDel2.TabIndex = 6;
            this.btnDel2.Text = "Delete";
            this.btnDel2.UseVisualStyleBackColor = true;
            this.btnDel2.Click += new System.EventHandler(this.btnDel2_Click);
            // 
            // btDELETE1
            // 
            this.btnDel1.Enabled = false;
            this.btnDel1.Location = new System.Drawing.Point(101, 275);
            this.btnDel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel1.Name = "btDELETE1";
            this.btnDel1.Size = new System.Drawing.Size(56, 19);
            this.btnDel1.TabIndex = 7;
            this.btnDel1.Text = "Delete";
            this.btnDel1.UseVisualStyleBackColor = true;
            this.btnDel1.Click += new System.EventHandler(this.btnDel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "tapez un text pour l\'inclure dans la liste 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "List 1 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "List  2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDel1);
            this.Controls.Add(this.btnDel2);
            this.Controls.Add(this.btnSwipeL);
            this.Controls.Add(this.btnSwipeR);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.element);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox element;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSwipeR;
        private System.Windows.Forms.Button btnSwipeL;
        private System.Windows.Forms.Button btnDel2;
        private System.Windows.Forms.Button btnDel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

