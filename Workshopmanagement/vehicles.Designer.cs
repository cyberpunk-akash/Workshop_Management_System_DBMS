namespace Workshopmanagement
{
    partial class vehicles
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Vehicle_no_add = new System.Windows.Forms.TextBox();
            this.vehicle_name_add = new System.Windows.Forms.TextBox();
            this.capacity_add = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.vehicle_remove = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.Button();
            this.desired_capacity = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD VEHICLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Number:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicel Name :*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacity(in kgs):*";
            // 
            // Vehicle_no_add
            // 
            this.Vehicle_no_add.Location = new System.Drawing.Point(139, 71);
            this.Vehicle_no_add.Name = "Vehicle_no_add";
            this.Vehicle_no_add.Size = new System.Drawing.Size(100, 20);
            this.Vehicle_no_add.TabIndex = 4;
            this.Vehicle_no_add.TextChanged += new System.EventHandler(this.Vehicle_no_add_TextChanged);
            // 
            // vehicle_name_add
            // 
            this.vehicle_name_add.Location = new System.Drawing.Point(139, 103);
            this.vehicle_name_add.Name = "vehicle_name_add";
            this.vehicle_name_add.Size = new System.Drawing.Size(100, 20);
            this.vehicle_name_add.TabIndex = 5;
            // 
            // capacity_add
            // 
            this.capacity_add.Location = new System.Drawing.Point(139, 140);
            this.capacity_add.Name = "capacity_add";
            this.capacity_add.Size = new System.Drawing.Size(100, 20);
            this.capacity_add.TabIndex = 6;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(91, 186);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(91, 308);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 15;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // vehicle_remove
            // 
            this.vehicle_remove.Location = new System.Drawing.Point(128, 272);
            this.vehicle_remove.Name = "vehicle_remove";
            this.vehicle_remove.Size = new System.Drawing.Size(100, 20);
            this.vehicle_remove.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Vehicle Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "REMOVE VEHICLE";
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(570, 22);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 23;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "VIEW ALL VEHICLES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "GET VEHICLES THAT CAN HOLD DESIRED CAPACITY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Enter desired capacity:";
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(679, 94);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 26;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.button4_Click);
            // 
            // desired_capacity
            // 
            this.desired_capacity.Location = new System.Drawing.Point(573, 96);
            this.desired_capacity.Name = "desired_capacity";
            this.desired_capacity.Size = new System.Drawing.Size(100, 20);
            this.desired_capacity.TabIndex = 27;
            this.desired_capacity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(436, 140);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(335, 218);
            this.dataGridView2.TabIndex = 29;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "BACK TO HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.desired_capacity);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.View);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.vehicle_remove);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.capacity_add);
            this.Controls.Add(this.vehicle_name_add);
            this.Controls.Add(this.Vehicle_no_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "vehicles";
            this.Text = "Manage Vehicles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Vehicle_no_add;
        private System.Windows.Forms.TextBox vehicle_name_add;
        private System.Windows.Forms.TextBox capacity_add;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox vehicle_remove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox desired_capacity;
        private System.Windows.Forms.DataGridView dataGridView2;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /*private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "vehicles";
            this.Text = "vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            this.ResumeLayout(false);

        }
        */

        #endregion

        private System.Windows.Forms.Button button1;
    }
}