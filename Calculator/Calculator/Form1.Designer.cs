namespace Calculator
{
    partial class Basic_Calculator
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
            this.Title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_screen = new System.Windows.Forms.TextBox();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_comma = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_cross = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_converter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Title.Location = new System.Drawing.Point(13, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(95, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "Calculator";
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_close.Location = new System.Drawing.Point(313, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 29);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_screen
            // 
            this.txt_screen.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_screen.Location = new System.Drawing.Point(13, 51);
            this.txt_screen.MaxLength = 18;
            this.txt_screen.Name = "txt_screen";
            this.txt_screen.Size = new System.Drawing.Size(319, 40);
            this.txt_screen.TabIndex = 2;
            this.txt_screen.Text = "0";
            this.txt_screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_one
            // 
            this.btn_one.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_one.Location = new System.Drawing.Point(13, 98);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(50, 43);
            this.btn_one.TabIndex = 3;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_two
            // 
            this.btn_two.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_two.Location = new System.Drawing.Point(69, 98);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(50, 43);
            this.btn_two.TabIndex = 4;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_three
            // 
            this.btn_three.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_three.Location = new System.Drawing.Point(125, 98);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(50, 43);
            this.btn_three.TabIndex = 5;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            // 
            // btn_four
            // 
            this.btn_four.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_four.Location = new System.Drawing.Point(12, 147);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(50, 43);
            this.btn_four.TabIndex = 6;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.btn_four_Click);
            // 
            // btn_five
            // 
            this.btn_five.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_five.Location = new System.Drawing.Point(69, 147);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(50, 43);
            this.btn_five.TabIndex = 7;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            // 
            // btn_six
            // 
            this.btn_six.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_six.Location = new System.Drawing.Point(125, 147);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(50, 43);
            this.btn_six.TabIndex = 8;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.btn_six_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_seven.Location = new System.Drawing.Point(12, 196);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(50, 43);
            this.btn_seven.TabIndex = 9;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.btn_seven_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_eight.Location = new System.Drawing.Point(69, 196);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(50, 43);
            this.btn_eight.TabIndex = 10;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.btn_eight_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_nine.Location = new System.Drawing.Point(125, 196);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(50, 43);
            this.btn_nine.TabIndex = 11;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.btn_nine_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_zero.Location = new System.Drawing.Point(69, 245);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(50, 43);
            this.btn_zero.TabIndex = 12;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_comma
            // 
            this.btn_comma.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_comma.Location = new System.Drawing.Point(13, 245);
            this.btn_comma.Name = "btn_comma";
            this.btn_comma.Size = new System.Drawing.Size(50, 43);
            this.btn_comma.TabIndex = 13;
            this.btn_comma.Text = ",";
            this.btn_comma.UseVisualStyleBackColor = true;
            this.btn_comma.Click += new System.EventHandler(this.btn_comma_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(125, 245);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(50, 43);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_plus.Location = new System.Drawing.Point(181, 98);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(109, 43);
            this.btn_plus.TabIndex = 15;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.AutoSizeChanged += new System.EventHandler(this.btn_sign_click);
            this.btn_plus.Click += new System.EventHandler(this.btn_sign_click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_minus.Location = new System.Drawing.Point(181, 147);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(109, 43);
            this.btn_minus.TabIndex = 16;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.AutoSizeChanged += new System.EventHandler(this.btn_sign_click);
            this.btn_minus.Click += new System.EventHandler(this.btn_sign_click);
            // 
            // btn_cross
            // 
            this.btn_cross.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cross.Location = new System.Drawing.Point(181, 196);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(109, 43);
            this.btn_cross.TabIndex = 17;
            this.btn_cross.Text = "*";
            this.btn_cross.UseVisualStyleBackColor = true;
            this.btn_cross.AutoSizeChanged += new System.EventHandler(this.btn_sign_click);
            this.btn_cross.Click += new System.EventHandler(this.btn_sign_click);
            // 
            // btn_division
            // 
            this.btn_division.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_division.Location = new System.Drawing.Point(181, 245);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(109, 43);
            this.btn_division.TabIndex = 18;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.AutoSizeChanged += new System.EventHandler(this.btn_sign_click);
            this.btn_division.Click += new System.EventHandler(this.btn_sign_click);
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_equal.Location = new System.Drawing.Point(17, 294);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(273, 43);
            this.btn_equal.TabIndex = 19;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_del.Location = new System.Drawing.Point(294, 98);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(50, 92);
            this.btn_del.TabIndex = 20;
            this.btn_del.Text = "<";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_converter
            // 
            this.btn_converter.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_converter.Location = new System.Drawing.Point(294, 196);
            this.btn_converter.Name = "btn_converter";
            this.btn_converter.Size = new System.Drawing.Size(50, 139);
            this.btn_converter.TabIndex = 21;
            this.btn_converter.Text = "+-";
            this.btn_converter.UseVisualStyleBackColor = true;
            this.btn_converter.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // Basic_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 347);
            this.Controls.Add(this.btn_converter);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_cross);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_comma);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.txt_screen);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Basic_Calculator";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_screen;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_comma;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_cross;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_converter;
    }
}

