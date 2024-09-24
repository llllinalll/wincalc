namespace wincalc
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
            textBox1 = new TextBox();
            btnc = new Button();
            btnerase = new Button();
            btndenial = new Button();
            btnplus = new Button();
            btnSeven = new Button();
            btneigth = new Button();
            btnnine = new Button();
            bthminus = new Button();
            bthfour = new Button();
            bthfive = new Button();
            bthsix = new Button();
            bthmiltiply = new Button();
            bthone = new Button();
            bthtwo = new Button();
            bththree = new Button();
            bthdivision = new Button();
            bthzero = new Button();
            bthpoint = new Button();
            bthequation = new Button();
            label1 = new Label();
            bthsinus = new Button();
            bthcos = new Button();
            bthtan = new Button();
            bthlog = new Button();
            bthe = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(502, 65);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnc
            // 
            btnc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnc.Location = new Point(12, 83);
            btnc.Name = "btnc";
            btnc.Size = new Size(75, 39);
            btnc.TabIndex = 1;
            btnc.Text = "C";
            btnc.UseVisualStyleBackColor = true;
            btnc.Click += btnc_Click;
            // 
            // btnerase
            // 
            btnerase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnerase.Location = new Point(111, 83);
            btnerase.Name = "btnerase";
            btnerase.Size = new Size(75, 39);
            btnerase.TabIndex = 2;
            btnerase.Text = "<-";
            btnerase.UseVisualStyleBackColor = true;
            // 
            // btndenial
            // 
            btndenial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btndenial.Location = new Point(223, 83);
            btndenial.Name = "btndenial";
            btndenial.Size = new Size(75, 39);
            btndenial.TabIndex = 3;
            btndenial.Text = "+/-";
            btndenial.UseVisualStyleBackColor = true;
            btndenial.Click += btndenial_Click;
            // 
            // btnplus
            // 
            btnplus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnplus.Location = new Point(331, 83);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(75, 39);
            btnplus.TabIndex = 4;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSeven.Location = new Point(12, 144);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(75, 39);
            btnSeven.TabIndex = 5;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btneigth
            // 
            btneigth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btneigth.Location = new Point(111, 144);
            btneigth.Name = "btneigth";
            btneigth.Size = new Size(75, 39);
            btneigth.TabIndex = 6;
            btneigth.Text = "8";
            btneigth.UseVisualStyleBackColor = true;
            btneigth.Click += btneigth_Click;
            // 
            // btnnine
            // 
            btnnine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnnine.Location = new Point(223, 144);
            btnnine.Name = "btnnine";
            btnnine.Size = new Size(75, 39);
            btnnine.TabIndex = 7;
            btnnine.Text = "9";
            btnnine.UseVisualStyleBackColor = true;
            btnnine.Click += btnnine_Click;
            // 
            // bthminus
            // 
            bthminus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthminus.Location = new Point(331, 144);
            bthminus.Name = "bthminus";
            bthminus.Size = new Size(75, 39);
            bthminus.TabIndex = 8;
            bthminus.Text = "-";
            bthminus.UseVisualStyleBackColor = true;
            bthminus.Click += bthminus_Click;
            // 
            // bthfour
            // 
            bthfour.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthfour.Location = new Point(12, 205);
            bthfour.Name = "bthfour";
            bthfour.Size = new Size(75, 36);
            bthfour.TabIndex = 9;
            bthfour.Text = "4";
            bthfour.UseVisualStyleBackColor = true;
            bthfour.Click += bthfour_Click;
            // 
            // bthfive
            // 
            bthfive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthfive.Location = new Point(111, 205);
            bthfive.Name = "bthfive";
            bthfive.Size = new Size(75, 36);
            bthfive.TabIndex = 10;
            bthfive.Text = "5";
            bthfive.UseVisualStyleBackColor = true;
            bthfive.Click += bthfive_Click;
            // 
            // bthsix
            // 
            bthsix.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthsix.Location = new Point(223, 205);
            bthsix.Name = "bthsix";
            bthsix.Size = new Size(75, 36);
            bthsix.TabIndex = 11;
            bthsix.Text = "6";
            bthsix.UseVisualStyleBackColor = true;
            bthsix.Click += bthsix_Click;
            // 
            // bthmiltiply
            // 
            bthmiltiply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthmiltiply.Location = new Point(331, 205);
            bthmiltiply.Name = "bthmiltiply";
            bthmiltiply.Size = new Size(75, 36);
            bthmiltiply.TabIndex = 12;
            bthmiltiply.Text = "*";
            bthmiltiply.UseVisualStyleBackColor = true;
            bthmiltiply.Click += bthmiltiply_Click;
            // 
            // bthone
            // 
            bthone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthone.Location = new Point(12, 263);
            bthone.Name = "bthone";
            bthone.Size = new Size(75, 30);
            bthone.TabIndex = 13;
            bthone.Text = "1";
            bthone.UseVisualStyleBackColor = true;
            bthone.Click += bthone_Click;
            // 
            // bthtwo
            // 
            bthtwo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthtwo.Location = new Point(111, 263);
            bthtwo.Name = "bthtwo";
            bthtwo.Size = new Size(75, 30);
            bthtwo.TabIndex = 14;
            bthtwo.Text = "2";
            bthtwo.UseVisualStyleBackColor = true;
            bthtwo.Click += bthtwo_Click;
            // 
            // bththree
            // 
            bththree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bththree.Location = new Point(223, 263);
            bththree.Name = "bththree";
            bththree.Size = new Size(75, 30);
            bththree.TabIndex = 15;
            bththree.Text = "3";
            bththree.UseVisualStyleBackColor = true;
            bththree.Click += bththree_Click;
            // 
            // bthdivision
            // 
            bthdivision.Location = new Point(331, 263);
            bthdivision.Name = "bthdivision";
            bthdivision.Size = new Size(75, 30);
            bthdivision.TabIndex = 16;
            bthdivision.Text = "/";
            bthdivision.UseVisualStyleBackColor = true;
            bthdivision.Click += bthdivision_Click;
            // 
            // bthzero
            // 
            bthzero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthzero.Location = new Point(111, 312);
            bthzero.Name = "bthzero";
            bthzero.Size = new Size(75, 38);
            bthzero.TabIndex = 17;
            bthzero.Text = "0";
            bthzero.UseVisualStyleBackColor = true;
            bthzero.Click += bthzero_Click;
            // 
            // bthpoint
            // 
            bthpoint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthpoint.Location = new Point(223, 312);
            bthpoint.Name = "bthpoint";
            bthpoint.Size = new Size(75, 38);
            bthpoint.TabIndex = 18;
            bthpoint.Text = ".";
            bthpoint.UseVisualStyleBackColor = true;
            bthpoint.Click += bthpoint_Click;
            // 
            // bthequation
            // 
            bthequation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthequation.Location = new Point(331, 312);
            bthequation.Name = "bthequation";
            bthequation.Size = new Size(183, 35);
            bthequation.TabIndex = 19;
            bthequation.Text = "=";
            bthequation.UseVisualStyleBackColor = true;
            bthequation.Click += bthequation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 20;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bthsinus
            // 
            bthsinus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthsinus.Location = new Point(439, 83);
            bthsinus.Name = "bthsinus";
            bthsinus.Size = new Size(75, 39);
            bthsinus.TabIndex = 21;
            bthsinus.Text = "sin";
            bthsinus.UseVisualStyleBackColor = true;
            bthsinus.Click += bthsinus_Click;
            // 
            // bthcos
            // 
            bthcos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthcos.Location = new Point(439, 144);
            bthcos.Name = "bthcos";
            bthcos.Size = new Size(75, 39);
            bthcos.TabIndex = 22;
            bthcos.Text = "cos";
            bthcos.UseVisualStyleBackColor = true;
            bthcos.Click += cos_Click;
            // 
            // bthtan
            // 
            bthtan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthtan.Location = new Point(439, 205);
            bthtan.Name = "bthtan";
            bthtan.Size = new Size(75, 36);
            bthtan.TabIndex = 23;
            bthtan.Text = "tan";
            bthtan.UseVisualStyleBackColor = true;
            bthtan.Click += tan_Click;
            // 
            // bthlog
            // 
            bthlog.Location = new Point(439, 263);
            bthlog.Name = "bthlog";
            bthlog.Size = new Size(75, 30);
            bthlog.TabIndex = 24;
            bthlog.Text = "log";
            bthlog.UseVisualStyleBackColor = true;
            bthlog.Click += log_Click;
            // 
            // bthe
            // 
            bthe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bthe.Location = new Point(12, 315);
            bthe.Name = "bthe";
            bthe.Size = new Size(75, 35);
            bthe.TabIndex = 26;
            bthe.Text = "e";
            bthe.UseVisualStyleBackColor = true;
            bthe.Click += e_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bthe);
            Controls.Add(bthlog);
            Controls.Add(bthtan);
            Controls.Add(bthcos);
            Controls.Add(bthsinus);
            Controls.Add(label1);
            Controls.Add(bthequation);
            Controls.Add(bthpoint);
            Controls.Add(bthzero);
            Controls.Add(bthdivision);
            Controls.Add(bththree);
            Controls.Add(bthtwo);
            Controls.Add(bthone);
            Controls.Add(bthmiltiply);
            Controls.Add(bthsix);
            Controls.Add(bthfive);
            Controls.Add(bthfour);
            Controls.Add(bthminus);
            Controls.Add(btnnine);
            Controls.Add(btneigth);
            Controls.Add(btnSeven);
            Controls.Add(btnplus);
            Controls.Add(btndenial);
            Controls.Add(btnerase);
            Controls.Add(btnc);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "калькулятор";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnc;
        private Button btnerase;
        private Button btndenial;
        private Button btnplus;
        private Button btnSeven;
        private Button btneigth;
        private Button btnnine;
        private Button bthminus;
        private Button bthfour;
        private Button bthfive;
        private Button bthsix;
        private Button bthmiltiply;
        private Button bthone;
        private Button bthtwo;
        private Button bththree;
        private Button bthdivision;
        private Button bthzero;
        private Button bthpoint;
        private Button bthequation;
        private Label label1;
        private Button button1;
        private Button bthsinus;
        private Button bthcos;
        private Button bthtan;
        private Button bthlog;
        private Button bthe;
    }
}
