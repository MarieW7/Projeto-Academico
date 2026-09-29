namespace CrudWinPlanoSaude
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtCodeID = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.WhiteSmoke;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(340, 183);
            button4.Name = "button4";
            button4.Size = new Size(35, 29);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(251, 108);
            label1.Name = "label1";
            label1.Size = new Size(196, 18);
            label1.TabIndex = 4;
            label1.Text = "Nome do Plano de Saúde";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(251, 33);
            label2.Name = "label2";
            label2.Size = new Size(167, 18);
            label2.TabIndex = 5;
            label2.Text = "ID do Plano de Saúde";
            label2.Click += label2_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(251, 131);
            txtName.Name = "txtName";
            txtName.ScrollBars = ScrollBars.Vertical;
            txtName.Size = new Size(268, 27);
            txtName.TabIndex = 6;
            // 
            // txtCodeID
            // 
            txtCodeID.BorderStyle = BorderStyle.FixedSingle;
            txtCodeID.Location = new Point(251, 56);
            txtCodeID.Name = "txtCodeID";
            txtCodeID.Size = new Size(268, 27);
            txtCodeID.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(142, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(501, 242);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(289, 183);
            button1.Name = "button1";
            button1.Size = new Size(35, 29);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.WhiteSmoke;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(394, 183);
            button2.Name = "button2";
            button2.Size = new Size(35, 29);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_2;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.WhiteSmoke;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(447, 183);
            button3.Name = "button3";
            button3.Size = new Size(35, 29);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(797, 482);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtCodeID);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Plano de Saúde";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtCodeID;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
