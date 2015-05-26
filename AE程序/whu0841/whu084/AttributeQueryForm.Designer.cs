namespace whu084
{
    partial class AttributeQueryForm
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
            this.cboLayer = new System.Windows.Forms.ComboBox();
            this.listBoxField = new System.Windows.Forms.ListBox();
            this.listBoxValue = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnempty = new System.Windows.Forms.Button();
            this.btnspace = new System.Windows.Forms.Button();
            this.btnbetween = new System.Windows.Forms.Button();
            this.btncharacter = new System.Windows.Forms.Button();
            this.btnpercent = new System.Windows.Forms.Button();
            this.btnunderline = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnand = new System.Windows.Forms.Button();
            this.btnnot = new System.Windows.Forms.Button();
            this.btnnull = new System.Windows.Forms.Button();
            this.btnor = new System.Windows.Forms.Button();
            this.btnloe = new System.Windows.Forms.Button();
            this.btnmoe = new System.Windows.Forms.Button();
            this.btnless = new System.Windows.Forms.Button();
            this.btnmore = new System.Windows.Forms.Button();
            this.btnlike = new System.Windows.Forms.Button();
            this.btnis = new System.Windows.Forms.Button();
            this.btnunequal = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboLayer
            // 
            this.cboLayer.FormattingEnabled = true;
            this.cboLayer.Location = new System.Drawing.Point(60, 12);
            this.cboLayer.Name = "cboLayer";
            this.cboLayer.Size = new System.Drawing.Size(358, 20);
            this.cboLayer.TabIndex = 0;
            this.cboLayer.SelectedIndexChanged += new System.EventHandler(this.cboLayer_SelectedIndexChanged);
            // 
            // listBoxField
            // 
            this.listBoxField.FormattingEnabled = true;
            this.listBoxField.ItemHeight = 12;
            this.listBoxField.Location = new System.Drawing.Point(15, 51);
            this.listBoxField.Name = "listBoxField";
            this.listBoxField.Size = new System.Drawing.Size(186, 64);
            this.listBoxField.TabIndex = 1;
            this.listBoxField.SelectedIndexChanged += new System.EventHandler(this.listBoxField_SelectedIndexChanged);
            this.listBoxField.DoubleClick += new System.EventHandler(this.listBoxField_DoubleClick);
            // 
            // listBoxValue
            // 
            this.listBoxValue.FormattingEnabled = true;
            this.listBoxValue.ItemHeight = 12;
            this.listBoxValue.Location = new System.Drawing.Point(232, 51);
            this.listBoxValue.Name = "listBoxValue";
            this.listBoxValue.Size = new System.Drawing.Size(186, 64);
            this.listBoxValue.TabIndex = 2;
            this.listBoxValue.DoubleClick += new System.EventHandler(this.listBoxValue_DoubleClick);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.btnempty);
            this.groupBox.Controls.Add(this.btnspace);
            this.groupBox.Controls.Add(this.btnbetween);
            this.groupBox.Controls.Add(this.btncharacter);
            this.groupBox.Controls.Add(this.btnpercent);
            this.groupBox.Controls.Add(this.btnunderline);
            this.groupBox.Controls.Add(this.btnin);
            this.groupBox.Controls.Add(this.btnand);
            this.groupBox.Controls.Add(this.btnnot);
            this.groupBox.Controls.Add(this.btnnull);
            this.groupBox.Controls.Add(this.btnor);
            this.groupBox.Controls.Add(this.btnloe);
            this.groupBox.Controls.Add(this.btnmoe);
            this.groupBox.Controls.Add(this.btnless);
            this.groupBox.Controls.Add(this.btnmore);
            this.groupBox.Controls.Add(this.btnlike);
            this.groupBox.Controls.Add(this.btnis);
            this.groupBox.Controls.Add(this.btnunequal);
            this.groupBox.Controls.Add(this.btnequal);
            this.groupBox.Location = new System.Drawing.Point(12, 120);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(406, 139);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "表达式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // btnempty
            // 
            this.btnempty.Location = new System.Drawing.Point(300, 104);
            this.btnempty.Name = "btnempty";
            this.btnempty.Size = new System.Drawing.Size(102, 23);
            this.btnempty.TabIndex = 17;
            this.btnempty.Text = "清空";
            this.btnempty.UseVisualStyleBackColor = true;
            this.btnempty.Click += new System.EventHandler(this.btnempty_Click);
            // 
            // btnspace
            // 
            this.btnspace.Location = new System.Drawing.Point(190, 104);
            this.btnspace.Name = "btnspace";
            this.btnspace.Size = new System.Drawing.Size(100, 23);
            this.btnspace.TabIndex = 16;
            this.btnspace.Text = "空格";
            this.btnspace.UseVisualStyleBackColor = true;
            this.btnspace.Click += new System.EventHandler(this.btnspace_Click);
            // 
            // btnbetween
            // 
            this.btnbetween.Location = new System.Drawing.Point(84, 104);
            this.btnbetween.Name = "btnbetween";
            this.btnbetween.Size = new System.Drawing.Size(100, 23);
            this.btnbetween.TabIndex = 15;
            this.btnbetween.Text = "Between";
            this.btnbetween.UseVisualStyleBackColor = true;
            this.btnbetween.Click += new System.EventHandler(this.btnbetween_Click);
            // 
            // btncharacter
            // 
            this.btncharacter.Location = new System.Drawing.Point(3, 104);
            this.btncharacter.Name = "btncharacter";
            this.btncharacter.Size = new System.Drawing.Size(75, 23);
            this.btncharacter.TabIndex = 14;
            this.btncharacter.Text = "\' \'";
            this.btncharacter.UseVisualStyleBackColor = true;
            this.btncharacter.Click += new System.EventHandler(this.btncharacter_Click);
            // 
            // btnpercent
            // 
            this.btnpercent.Location = new System.Drawing.Point(327, 75);
            this.btnpercent.Name = "btnpercent";
            this.btnpercent.Size = new System.Drawing.Size(75, 23);
            this.btnpercent.TabIndex = 13;
            this.btnpercent.Text = "%";
            this.btnpercent.UseVisualStyleBackColor = true;
            this.btnpercent.Click += new System.EventHandler(this.btnpercent_Click);
            // 
            // btnunderline
            // 
            this.btnunderline.Location = new System.Drawing.Point(246, 75);
            this.btnunderline.Name = "btnunderline";
            this.btnunderline.Size = new System.Drawing.Size(75, 23);
            this.btnunderline.TabIndex = 12;
            this.btnunderline.Text = "_";
            this.btnunderline.UseVisualStyleBackColor = true;
            this.btnunderline.Click += new System.EventHandler(this.btnunderline_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(165, 75);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 11;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnand
            // 
            this.btnand.Location = new System.Drawing.Point(84, 75);
            this.btnand.Name = "btnand";
            this.btnand.Size = new System.Drawing.Size(75, 23);
            this.btnand.TabIndex = 10;
            this.btnand.Text = "And";
            this.btnand.UseVisualStyleBackColor = true;
            this.btnand.Click += new System.EventHandler(this.btnand_Click);
            // 
            // btnnot
            // 
            this.btnnot.Location = new System.Drawing.Point(3, 75);
            this.btnnot.Name = "btnnot";
            this.btnnot.Size = new System.Drawing.Size(75, 23);
            this.btnnot.TabIndex = 9;
            this.btnnot.Text = "Not";
            this.btnnot.UseVisualStyleBackColor = true;
            this.btnnot.Click += new System.EventHandler(this.btnnot_Click);
            // 
            // btnnull
            // 
            this.btnnull.Location = new System.Drawing.Point(327, 46);
            this.btnnull.Name = "btnnull";
            this.btnnull.Size = new System.Drawing.Size(75, 23);
            this.btnnull.TabIndex = 8;
            this.btnnull.Text = "Null";
            this.btnnull.UseVisualStyleBackColor = true;
            this.btnnull.Click += new System.EventHandler(this.btnnull_Click);
            // 
            // btnor
            // 
            this.btnor.Location = new System.Drawing.Point(246, 46);
            this.btnor.Name = "btnor";
            this.btnor.Size = new System.Drawing.Size(75, 23);
            this.btnor.TabIndex = 7;
            this.btnor.Text = "Or";
            this.btnor.UseVisualStyleBackColor = true;
            this.btnor.Click += new System.EventHandler(this.btnor_Click);
            // 
            // btnloe
            // 
            this.btnloe.Location = new System.Drawing.Point(165, 46);
            this.btnloe.Name = "btnloe";
            this.btnloe.Size = new System.Drawing.Size(75, 23);
            this.btnloe.TabIndex = 6;
            this.btnloe.Text = "<=";
            this.btnloe.UseVisualStyleBackColor = true;
            this.btnloe.Click += new System.EventHandler(this.btnloe_Click);
            // 
            // btnmoe
            // 
            this.btnmoe.Location = new System.Drawing.Point(84, 46);
            this.btnmoe.Name = "btnmoe";
            this.btnmoe.Size = new System.Drawing.Size(75, 23);
            this.btnmoe.TabIndex = 5;
            this.btnmoe.Text = ">=";
            this.btnmoe.UseVisualStyleBackColor = true;
            this.btnmoe.Click += new System.EventHandler(this.btnmoe_Click);
            // 
            // btnless
            // 
            this.btnless.Location = new System.Drawing.Point(3, 46);
            this.btnless.Name = "btnless";
            this.btnless.Size = new System.Drawing.Size(75, 23);
            this.btnless.TabIndex = 4;
            this.btnless.Text = "<";
            this.btnless.UseVisualStyleBackColor = true;
            this.btnless.Click += new System.EventHandler(this.btnless_Click);
            // 
            // btnmore
            // 
            this.btnmore.Location = new System.Drawing.Point(327, 17);
            this.btnmore.Name = "btnmore";
            this.btnmore.Size = new System.Drawing.Size(75, 23);
            this.btnmore.TabIndex = 4;
            this.btnmore.Text = ">";
            this.btnmore.UseVisualStyleBackColor = true;
            this.btnmore.Click += new System.EventHandler(this.btnmore_Click);
            // 
            // btnlike
            // 
            this.btnlike.Location = new System.Drawing.Point(246, 17);
            this.btnlike.Name = "btnlike";
            this.btnlike.Size = new System.Drawing.Size(75, 23);
            this.btnlike.TabIndex = 3;
            this.btnlike.Text = "like";
            this.btnlike.UseVisualStyleBackColor = true;
            this.btnlike.Click += new System.EventHandler(this.btnlike_Click);
            // 
            // btnis
            // 
            this.btnis.Location = new System.Drawing.Point(165, 17);
            this.btnis.Name = "btnis";
            this.btnis.Size = new System.Drawing.Size(75, 23);
            this.btnis.TabIndex = 2;
            this.btnis.Text = "is";
            this.btnis.UseVisualStyleBackColor = true;
            this.btnis.Click += new System.EventHandler(this.btnis_Click);
            // 
            // btnunequal
            // 
            this.btnunequal.Location = new System.Drawing.Point(84, 17);
            this.btnunequal.Name = "btnunequal";
            this.btnunequal.Size = new System.Drawing.Size(75, 23);
            this.btnunequal.TabIndex = 1;
            this.btnunequal.Text = "!=";
            this.btnunequal.UseVisualStyleBackColor = true;
            this.btnunequal.Click += new System.EventHandler(this.btnunequal_Click);
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(3, 17);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(75, 23);
            this.btnequal.TabIndex = 0;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // textBoxSql
            // 
            this.textBoxSql.Location = new System.Drawing.Point(15, 278);
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.Size = new System.Drawing.Size(406, 21);
            this.textBoxSql.TabIndex = 0;
            //this.textBoxSql.TextChanged += new System.EventHandler(this.textBoxSql_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 320);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "查找";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "图层：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "字段：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "取值：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "Select * From Table Where";
            // 
            // AttributeQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxSql);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.listBoxValue);
            this.Controls.Add(this.listBoxField);
            this.Controls.Add(this.cboLayer);
            this.Name = "AttributeQueryForm";
            this.Text = "属性查询";
            this.Load += new System.EventHandler(this.AttributeQueryForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLayer;
        private System.Windows.Forms.ListBox listBoxField;
        private System.Windows.Forms.ListBox listBoxValue;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnempty;
        private System.Windows.Forms.Button btnspace;
        private System.Windows.Forms.Button btnbetween;
        private System.Windows.Forms.Button btncharacter;
        private System.Windows.Forms.Button btnpercent;
        private System.Windows.Forms.Button btnunderline;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnand;
        private System.Windows.Forms.Button btnnot;
        private System.Windows.Forms.Button btnnull;
        private System.Windows.Forms.Button btnor;
        private System.Windows.Forms.Button btnloe;
        private System.Windows.Forms.Button btnmoe;
        private System.Windows.Forms.Button btnless;
        private System.Windows.Forms.Button btnmore;
        private System.Windows.Forms.Button btnlike;
        private System.Windows.Forms.Button btnis;
        private System.Windows.Forms.Button btnunequal;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}