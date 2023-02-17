using System.Windows.Forms;

namespace Linije_73_2019
{
    public class StartForm : Form
    {
        private Button button1;
        private Button button3;
        private Button button2;

        public StartForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Нова игра";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Настави игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(397, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Резултати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StartForm
            // 
            this.ClientSize = new System.Drawing.Size(926, 518);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "StartForm";
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void button3_Click(object sender, System.EventArgs e)
        {

        }
    }
}