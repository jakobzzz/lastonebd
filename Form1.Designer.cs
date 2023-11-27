namespace lastonebd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            listView1 = new ListView();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(155, 106);
            button1.Name = "button1";
            button1.Size = new Size(161, 43);
            button1.TabIndex = 0;
            button1.Text = "Присоединить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(121, 32);
            label1.Name = "label1";
            label1.Size = new Size(361, 27);
            label1.TabIndex = 1;
            label1.Text = "Присоединить к отделению";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Location = new Point(240, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Thistle;
            listView1.Location = new Point(489, 62);
            listView1.Name = "listView1";
            listView1.Size = new Size(225, 352);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(313, 106);
            button2.Name = "button2";
            button2.Size = new Size(141, 43);
            button2.TabIndex = 4;
            button2.Text = "Выгрузить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(12, 155);
            button3.Name = "button3";
            button3.Size = new Size(168, 66);
            button3.TabIndex = 5;
            button3.Text = "Добавить рабочего";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private ListView listView1;
        private Button button2;
        private Button button3;
    }
}