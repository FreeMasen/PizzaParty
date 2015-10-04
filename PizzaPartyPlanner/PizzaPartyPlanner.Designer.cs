namespace PizzaPartyPlanner
{
    partial class frmPizzaParty
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
            this.cboPizzaSize = new System.Windows.Forms.ComboBox();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.cboPizzaType = new System.Windows.Forms.ComboBox();
            this.lblPizzaType = new System.Windows.Forms.Label();
            this.brnAdd = new System.Windows.Forms.Button();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.ckbArtichoke = new System.Windows.Forms.CheckBox();
            this.ckbOlives = new System.Windows.Forms.CheckBox();
            this.ckbOions = new System.Windows.Forms.CheckBox();
            this.ckbPeppers = new System.Windows.Forms.CheckBox();
            this.ckbMushrooms = new System.Windows.Forms.CheckBox();
            this.ckbBeef = new System.Windows.Forms.CheckBox();
            this.ckbBacon = new System.Windows.Forms.CheckBox();
            this.ckbHam = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbPep = new System.Windows.Forms.CheckBox();
            this.cboSlices = new System.Windows.Forms.ComboBox();
            this.lblSlices = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPizzaCost = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lstPizzaType = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDisplayNotes = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpToppings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPizzaSize
            // 
            this.cboPizzaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPizzaSize.FormattingEnabled = true;
            this.cboPizzaSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cboPizzaSize.Location = new System.Drawing.Point(97, 17);
            this.cboPizzaSize.Name = "cboPizzaSize";
            this.cboPizzaSize.Size = new System.Drawing.Size(121, 21);
            this.cboPizzaSize.TabIndex = 0;
            this.cboPizzaSize.SelectedIndexChanged += new System.EventHandler(this.changeCost);
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Location = new System.Drawing.Point(6, 25);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(27, 13);
            this.lblPizzaSize.TabIndex = 4;
            this.lblPizzaSize.Text = "Size";
            // 
            // cboPizzaType
            // 
            this.cboPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPizzaType.FormattingEnabled = true;
            this.cboPizzaType.Items.AddRange(new object[] {
            "Build Your Own",
            "Surpreme",
            "BBQ Chicken",
            "Hawaiian",
            "Meat Lovers",
            "Veggy",
            "Greek",
            "Cheeseburger"});
            this.cboPizzaType.Location = new System.Drawing.Point(97, 44);
            this.cboPizzaType.Name = "cboPizzaType";
            this.cboPizzaType.Size = new System.Drawing.Size(121, 21);
            this.cboPizzaType.TabIndex = 5;
            this.cboPizzaType.SelectedIndexChanged += new System.EventHandler(this.changeCost);
            // 
            // lblPizzaType
            // 
            this.lblPizzaType.AutoSize = true;
            this.lblPizzaType.Location = new System.Drawing.Point(6, 52);
            this.lblPizzaType.Name = "lblPizzaType";
            this.lblPizzaType.Size = new System.Drawing.Size(59, 13);
            this.lblPizzaType.TabIndex = 6;
            this.lblPizzaType.Text = "Pizza Type";
            // 
            // brnAdd
            // 
            this.brnAdd.Location = new System.Drawing.Point(423, 175);
            this.brnAdd.Name = "brnAdd";
            this.brnAdd.Size = new System.Drawing.Size(75, 23);
            this.brnAdd.TabIndex = 7;
            this.brnAdd.Text = "Add Pizza";
            this.brnAdd.UseVisualStyleBackColor = true;
            this.brnAdd.Click += new System.EventHandler(this.brnAdd_Click);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.ckbArtichoke);
            this.grpToppings.Controls.Add(this.ckbOlives);
            this.grpToppings.Controls.Add(this.ckbOions);
            this.grpToppings.Controls.Add(this.ckbPeppers);
            this.grpToppings.Controls.Add(this.ckbMushrooms);
            this.grpToppings.Controls.Add(this.ckbBeef);
            this.grpToppings.Controls.Add(this.ckbBacon);
            this.grpToppings.Controls.Add(this.ckbHam);
            this.grpToppings.Controls.Add(this.ckbSausage);
            this.grpToppings.Controls.Add(this.ckbPep);
            this.grpToppings.Location = new System.Drawing.Point(277, 20);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(221, 149);
            this.grpToppings.TabIndex = 3;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings sm-$0.25, md-$0.50 lg-$0.75";
            // 
            // ckbArtichoke
            // 
            this.ckbArtichoke.AutoSize = true;
            this.ckbArtichoke.Location = new System.Drawing.Point(106, 110);
            this.ckbArtichoke.Name = "ckbArtichoke";
            this.ckbArtichoke.Size = new System.Drawing.Size(71, 17);
            this.ckbArtichoke.TabIndex = 9;
            this.ckbArtichoke.Text = "Artichoke";
            this.ckbArtichoke.UseVisualStyleBackColor = true;
            this.ckbArtichoke.CheckedChanged += new System.EventHandler(this.changeCost);
            // 
            // ckbOlives
            // 
            this.ckbOlives.AutoSize = true;
            this.ckbOlives.Location = new System.Drawing.Point(106, 87);
            this.ckbOlives.Name = "ckbOlives";
            this.ckbOlives.Size = new System.Drawing.Size(55, 17);
            this.ckbOlives.TabIndex = 8;
            this.ckbOlives.Text = "Olives";
            this.ckbOlives.UseVisualStyleBackColor = true;
            this.ckbOlives.CheckedChanged += new System.EventHandler(this.changeCost);
            // 
            // ckbOions
            // 
            this.ckbOions.AutoSize = true;
            this.ckbOions.Location = new System.Drawing.Point(106, 64);
            this.ckbOions.Name = "ckbOions";
            this.ckbOions.Size = new System.Drawing.Size(59, 17);
            this.ckbOions.TabIndex = 7;
            this.ckbOions.Text = "Onions";
            this.ckbOions.UseVisualStyleBackColor = true;
            this.ckbOions.CheckedChanged += new System.EventHandler(this.changeCost);
            // 
            // ckbPeppers
            // 
            this.ckbPeppers.AutoSize = true;
            this.ckbPeppers.Location = new System.Drawing.Point(106, 38);
            this.ckbPeppers.Name = "ckbPeppers";
            this.ckbPeppers.Size = new System.Drawing.Size(65, 17);
            this.ckbPeppers.TabIndex = 6;
            this.ckbPeppers.Text = "Peppers";
            this.ckbPeppers.UseVisualStyleBackColor = true;
            this.ckbPeppers.CheckedChanged += new System.EventHandler(this.changeCost);
            // 
            // ckbMushrooms
            // 
            this.ckbMushrooms.AutoSize = true;
            this.ckbMushrooms.Location = new System.Drawing.Point(106, 15);
            this.ckbMushrooms.Name = "ckbMushrooms";
            this.ckbMushrooms.Size = new System.Drawing.Size(80, 17);
            this.ckbMushrooms.TabIndex = 5;
            this.ckbMushrooms.Text = "Mushrooms";
            this.ckbMushrooms.UseVisualStyleBackColor = true;
            this.ckbMushrooms.CheckedChanged += new System.EventHandler(this.changeCost);
            // 
            // ckbBeef
            // 
            this.ckbBeef.AutoSize = true;
            this.ckbBeef.Location = new System.Drawing.Point(3, 106);
            this.ckbBeef.Name = "ckbBeef";
            this.ckbBeef.Size = new System.Drawing.Size(48, 17);
            this.ckbBeef.TabIndex = 4;
            this.ckbBeef.Text = "Beef";
            this.ckbBeef.UseVisualStyleBackColor = true;
            this.ckbBeef.CheckedChanged += new System.EventHandler(this.changeCost);
            // 
            // ckbBacon
            // 
            this.ckbBacon.AutoSize = true;
            this.ckbBacon.Location = new System.Drawing.Point(3, 83);
            this.ckbBacon.Name = "ckbBacon";
            this.ckbBacon.Size = new System.Drawing.Size(57, 17);
            this.ckbBacon.TabIndex = 3;
            this.ckbBacon.Text = "Bacon";
            this.ckbBacon.UseVisualStyleBackColor = true;
            this.ckbBacon.CheckedChanged += new System.EventHandler(this.changeCost);
            // 
            // ckbHam
            // 
            this.ckbHam.AutoSize = true;
            this.ckbHam.Location = new System.Drawing.Point(3, 62);
            this.ckbHam.Name = "ckbHam";
            this.ckbHam.Size = new System.Drawing.Size(48, 17);
            this.ckbHam.TabIndex = 2;
            this.ckbHam.Text = "Ham";
            this.ckbHam.UseVisualStyleBackColor = true;
            this.ckbHam.CheckedChanged += new System.EventHandler(this.changeCost);
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Location = new System.Drawing.Point(3, 39);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(68, 17);
            this.ckbSausage.TabIndex = 1;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            this.ckbSausage.CheckedChanged += new System.EventHandler(this.changeCost);
            // 
            // ckbPep
            // 
            this.ckbPep.AutoSize = true;
            this.ckbPep.Location = new System.Drawing.Point(3, 16);
            this.ckbPep.Name = "ckbPep";
            this.ckbPep.Size = new System.Drawing.Size(62, 17);
            this.ckbPep.TabIndex = 0;
            this.ckbPep.Text = "Peproni";
            this.ckbPep.UseVisualStyleBackColor = true;
            this.ckbPep.CheckedChanged += new System.EventHandler(this.changeCost);
            // 
            // cboSlices
            // 
            this.cboSlices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSlices.FormattingEnabled = true;
            this.cboSlices.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10"});
            this.cboSlices.Location = new System.Drawing.Point(97, 71);
            this.cboSlices.Name = "cboSlices";
            this.cboSlices.Size = new System.Drawing.Size(121, 21);
            this.cboSlices.TabIndex = 8;
            // 
            // lblSlices
            // 
            this.lblSlices.AutoSize = true;
            this.lblSlices.Location = new System.Drawing.Point(6, 79);
            this.lblSlices.Name = "lblSlices";
            this.lblSlices.Size = new System.Drawing.Size(85, 13);
            this.lblSlices.TabIndex = 9;
            this.lblSlices.Text = "Number of slices";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(97, 100);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(121, 52);
            this.txtNotes.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cost of this Pizza:";
            // 
            // lblPizzaCost
            // 
            this.lblPizzaCost.AutoSize = true;
            this.lblPizzaCost.Location = new System.Drawing.Point(380, 181);
            this.lblPizzaCost.Name = "lblPizzaCost";
            this.lblPizzaCost.Size = new System.Drawing.Size(34, 13);
            this.lblPizzaCost.TabIndex = 13;
            this.lblPizzaCost.Text = "$0.00";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(239, 401);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(98, 44);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Create Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 401);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 44);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(492, 401);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "$0.00";
            // 
            // lstPizzaType
            // 
            this.lstPizzaType.FormattingEnabled = true;
            this.lstPizzaType.Location = new System.Drawing.Point(12, 209);
            this.lstPizzaType.Name = "lstPizzaType";
            this.lstPizzaType.Size = new System.Drawing.Size(200, 186);
            this.lstPizzaType.TabIndex = 19;
            this.lstPizzaType.SelectedIndexChanged += new System.EventHandler(this.lstPizzaType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pizza";
            // 
            // txtDisplayNotes
            // 
            this.txtDisplayNotes.Location = new System.Drawing.Point(239, 209);
            this.txtDisplayNotes.Multiline = true;
            this.txtDisplayNotes.Name = "txtDisplayNotes";
            this.txtDisplayNotes.Size = new System.Drawing.Size(287, 186);
            this.txtDisplayNotes.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(137, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 44);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Remove All";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPizzaSize);
            this.groupBox1.Controls.Add(this.cboPizzaSize);
            this.groupBox1.Controls.Add(this.cboPizzaType);
            this.groupBox1.Controls.Add(this.lblPizzaType);
            this.groupBox1.Controls.Add(this.cboSlices);
            this.groupBox1.Controls.Add(this.lblSlices);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 178);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Selector";
            // 
            // frmPizzaParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDisplayNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPizzaType);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblPizzaCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.brnAdd);
            this.Name = "frmPizzaParty";
            this.Text = "Pizza Party Planner";
            this.Load += new System.EventHandler(this.frmPizzaParty_Load);
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPizzaSize;
        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.ComboBox cboPizzaType;
        private System.Windows.Forms.Label lblPizzaType;
        private System.Windows.Forms.Button brnAdd;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox ckbPep;
        private System.Windows.Forms.ComboBox cboSlices;
        private System.Windows.Forms.Label lblSlices;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbArtichoke;
        private System.Windows.Forms.CheckBox ckbOlives;
        private System.Windows.Forms.CheckBox ckbOions;
        private System.Windows.Forms.CheckBox ckbPeppers;
        private System.Windows.Forms.CheckBox ckbMushrooms;
        private System.Windows.Forms.CheckBox ckbBeef;
        private System.Windows.Forms.CheckBox ckbBacon;
        private System.Windows.Forms.CheckBox ckbHam;
        private System.Windows.Forms.CheckBox ckbSausage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPizzaCost;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lstPizzaType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDisplayNotes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

