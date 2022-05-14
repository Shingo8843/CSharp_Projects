
namespace fast_food_restaurant
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
            this.Cheese = new System.Windows.Forms.CheckBox();
            this.lettuce = new System.Windows.Forms.CheckBox();
            this.Tomatoes = new System.Windows.Forms.CheckBox();
            this.PepperJack = new System.Windows.Forms.CheckBox();
            this.Jalapenos = new System.Windows.Forms.CheckBox();
            this.BurgerOptions = new System.Windows.Forms.ListBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.ExtraMeat = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cheese
            // 
            this.Cheese.AutoSize = true;
            this.Cheese.Location = new System.Drawing.Point(521, 38);
            this.Cheese.Name = "Cheese";
            this.Cheese.Size = new System.Drawing.Size(62, 17);
            this.Cheese.TabIndex = 1;
            this.Cheese.Text = "Cheese";
            this.Cheese.UseVisualStyleBackColor = true;
            this.Cheese.CheckedChanged += new System.EventHandler(this.Cheese_CheckedChanged);
            // 
            // lettuce
            // 
            this.lettuce.AutoSize = true;
            this.lettuce.Location = new System.Drawing.Point(521, 73);
            this.lettuce.Name = "lettuce";
            this.lettuce.Size = new System.Drawing.Size(62, 17);
            this.lettuce.TabIndex = 2;
            this.lettuce.Text = "Lettuce";
            this.lettuce.UseVisualStyleBackColor = true;
            this.lettuce.CheckedChanged += new System.EventHandler(this.lettuce_CheckedChanged);
            // 
            // Tomatoes
            // 
            this.Tomatoes.AutoSize = true;
            this.Tomatoes.Location = new System.Drawing.Point(521, 117);
            this.Tomatoes.Name = "Tomatoes";
            this.Tomatoes.Size = new System.Drawing.Size(73, 17);
            this.Tomatoes.TabIndex = 3;
            this.Tomatoes.Text = "Tomatoes";
            this.Tomatoes.UseVisualStyleBackColor = true;
            this.Tomatoes.CheckedChanged += new System.EventHandler(this.Tomatoes_CheckedChanged);
            // 
            // PepperJack
            // 
            this.PepperJack.AutoSize = true;
            this.PepperJack.Location = new System.Drawing.Point(521, 156);
            this.PepperJack.Name = "PepperJack";
            this.PepperJack.Size = new System.Drawing.Size(86, 17);
            this.PepperJack.TabIndex = 4;
            this.PepperJack.Text = "Pepper-Jack";
            this.PepperJack.UseVisualStyleBackColor = true;
            this.PepperJack.CheckedChanged += new System.EventHandler(this.PepperJack_CheckedChanged);
            // 
            // Jalapenos
            // 
            this.Jalapenos.AutoSize = true;
            this.Jalapenos.Location = new System.Drawing.Point(521, 193);
            this.Jalapenos.Name = "Jalapenos";
            this.Jalapenos.Size = new System.Drawing.Size(100, 17);
            this.Jalapenos.TabIndex = 5;
            this.Jalapenos.Text = "fresh jalapeños.";
            this.Jalapenos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Jalapenos.UseVisualStyleBackColor = true;
            this.Jalapenos.CheckedChanged += new System.EventHandler(this.Jalapenos_CheckedChanged);
            // 
            // BurgerOptions
            // 
            this.BurgerOptions.FormattingEnabled = true;
            this.BurgerOptions.Items.AddRange(new object[] {
            "Smoked Bacon Buger",
            "Turkey Buger",
            "Cheese Buger"});
            this.BurgerOptions.Location = new System.Drawing.Point(136, 38);
            this.BurgerOptions.Name = "BurgerOptions";
            this.BurgerOptions.Size = new System.Drawing.Size(120, 95);
            this.BurgerOptions.TabIndex = 6;
            this.BurgerOptions.SelectedIndexChanged += new System.EventHandler(this.BurgerOptions_SelectedIndexChanged);
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(319, 343);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 31);
            this.Price.TabIndex = 7;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // ExtraMeat
            // 
            this.ExtraMeat.AutoSize = true;
            this.ExtraMeat.Location = new System.Drawing.Point(521, 230);
            this.ExtraMeat.Name = "ExtraMeat";
            this.ExtraMeat.Size = new System.Drawing.Size(71, 17);
            this.ExtraMeat.TabIndex = 8;
            this.ExtraMeat.Text = "ExraMeat";
            this.ExtraMeat.UseVisualStyleBackColor = true;
            this.ExtraMeat.CheckedChanged += new System.EventHandler(this.ExtraMeat_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Price: $";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtraMeat);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.BurgerOptions);
            this.Controls.Add(this.Jalapenos);
            this.Controls.Add(this.PepperJack);
            this.Controls.Add(this.Tomatoes);
            this.Controls.Add(this.lettuce);
            this.Controls.Add(this.Cheese);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Cheese;
        private System.Windows.Forms.CheckBox lettuce;
        private System.Windows.Forms.CheckBox Tomatoes;
        private System.Windows.Forms.CheckBox PepperJack;
        private System.Windows.Forms.CheckBox Jalapenos;
        private System.Windows.Forms.ListBox BurgerOptions;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.CheckBox ExtraMeat;
        private System.Windows.Forms.Label label1;
    }
}

