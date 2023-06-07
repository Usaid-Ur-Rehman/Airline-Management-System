namespace Airline_Management_System
{
    partial class Flight
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
            this.fare = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.no_of_stop = new System.Windows.Forms.NumericUpDown();
            this.destiantion = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.origin = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.airline_name = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_stop)).BeginInit();
            this.SuspendLayout();
            // 
            // fare
            // 
            this.fare.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fare.Location = new System.Drawing.Point(424, 383);
            this.fare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fare.Name = "fare";
            this.fare.Size = new System.Drawing.Size(248, 27);
            this.fare.TabIndex = 152;
            this.fare.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(128, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 28);
            this.label11.TabIndex = 151;
            this.label11.Text = "Airline Name";
            // 
            // no_of_stop
            // 
            this.no_of_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_stop.Location = new System.Drawing.Point(424, 341);
            this.no_of_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.no_of_stop.Name = "no_of_stop";
            this.no_of_stop.Size = new System.Drawing.Size(248, 27);
            this.no_of_stop.TabIndex = 149;
            this.no_of_stop.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // destiantion
            // 
            this.destiantion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destiantion.Location = new System.Drawing.Point(424, 193);
            this.destiantion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destiantion.Name = "destiantion";
            this.destiantion.Size = new System.Drawing.Size(248, 27);
            this.destiantion.TabIndex = 147;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(424, 283);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker2.TabIndex = 146;
            // 
            // origin
            // 
            this.origin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origin.Location = new System.Drawing.Point(424, 150);
            this.origin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(248, 27);
            this.origin.TabIndex = 145;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(424, 241);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 144;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(128, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 28);
            this.label10.TabIndex = 143;
            this.label10.Text = "Fare";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(128, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 28);
            this.label9.TabIndex = 142;
            this.label9.Text = "No. of Stops";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(124, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 28);
            this.label5.TabIndex = 139;
            this.label5.Text = "Arrival Date Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(128, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 28);
            this.label4.TabIndex = 138;
            this.label4.Text = "Departure Date Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(128, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 137;
            this.label3.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(128, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 136;
            this.label2.Text = "Origin ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // airline_name
            // 
            this.airline_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airline_name.Location = new System.Drawing.Point(424, 112);
            this.airline_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.airline_name.Name = "airline_name";
            this.airline_name.Size = new System.Drawing.Size(248, 27);
            this.airline_name.TabIndex = 135;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(261, 459);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(322, 69);
            this.button5.TabIndex = 153;
            this.button5.Text = "ADD FLIGHT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(261, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 50);
            this.label1.TabIndex = 154;
            this.label1.Text = "ADD  FLIGHT";
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.fare);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.no_of_stop);
            this.Controls.Add(this.destiantion);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.origin);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.airline_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Flight";
            this.Text = "Flight";
            this.Load += new System.EventHandler(this.Flight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.no_of_stop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fare;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown no_of_stop;
        private System.Windows.Forms.TextBox destiantion;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox origin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox airline_name;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}