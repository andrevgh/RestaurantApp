namespace Restaurant
{
    partial class Restaurant
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
            this.cbxPizza = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cblPizzaAdds = new System.Windows.Forms.CheckedListBox();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.numPizza = new System.Windows.Forms.NumericUpDown();
            this.cbxPizzaAdds = new System.Windows.Forms.CheckBox();
            this.cmbPizza = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cblDishAdds = new System.Windows.Forms.CheckedListBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.numDish = new System.Windows.Forms.NumericUpDown();
            this.cbxDishAdds = new System.Windows.Forms.CheckBox();
            this.cmbDish = new System.Windows.Forms.ComboBox();
            this.cbxDish = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddSoup = new System.Windows.Forms.Button();
            this.numSoup = new System.Windows.Forms.NumericUpDown();
            this.cmbSoup = new System.Windows.Forms.ComboBox();
            this.cbxSoup = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.numDrink = new System.Windows.Forms.NumericUpDown();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.cbxDrink = new System.Windows.Forms.CheckBox();
            this.dgvPizza = new System.Windows.Forms.DataGridView();
            this.PizzaDeleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvDish = new System.Windows.Forms.DataGridView();
            this.DishDeleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvSoup = new System.Windows.Forms.DataGridView();
            this.SoupDeleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvDrink = new System.Windows.Forms.DataGridView();
            this.DrinkDeleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmailFrom = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.cmbEmailTo = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSelectTable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPizza)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDish)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoup)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxPizza
            // 
            this.cbxPizza.AutoSize = true;
            this.cbxPizza.Location = new System.Drawing.Point(3, 3);
            this.cbxPizza.Name = "cbxPizza";
            this.cbxPizza.Size = new System.Drawing.Size(51, 17);
            this.cbxPizza.TabIndex = 0;
            this.cbxPizza.Text = "Pizza";
            this.cbxPizza.UseVisualStyleBackColor = true;
            this.cbxPizza.CheckedChanged += new System.EventHandler(this.cbxPizza_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cblPizzaAdds);
            this.panel1.Controls.Add(this.btnAddPizza);
            this.panel1.Controls.Add(this.numPizza);
            this.panel1.Controls.Add(this.cbxPizzaAdds);
            this.panel1.Controls.Add(this.cmbPizza);
            this.panel1.Controls.Add(this.cbxPizza);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 173);
            this.panel1.TabIndex = 1;
            // 
            // cblPizzaAdds
            // 
            this.cblPizzaAdds.FormattingEnabled = true;
            this.cblPizzaAdds.Location = new System.Drawing.Point(23, 78);
            this.cblPizzaAdds.Name = "cblPizzaAdds";
            this.cblPizzaAdds.Size = new System.Drawing.Size(234, 79);
            this.cblPizzaAdds.TabIndex = 7;
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPizza.Location = new System.Drawing.Point(290, 49);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(75, 23);
            this.btnAddPizza.TabIndex = 6;
            this.btnAddPizza.Text = "Dodaj";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // numPizza
            // 
            this.numPizza.Location = new System.Drawing.Point(249, 26);
            this.numPizza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPizza.Name = "numPizza";
            this.numPizza.Size = new System.Drawing.Size(32, 20);
            this.numPizza.TabIndex = 4;
            this.numPizza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxPizzaAdds
            // 
            this.cbxPizzaAdds.AutoSize = true;
            this.cbxPizzaAdds.Location = new System.Drawing.Point(3, 53);
            this.cbxPizzaAdds.Name = "cbxPizzaAdds";
            this.cbxPizzaAdds.Size = new System.Drawing.Size(104, 17);
            this.cbxPizzaAdds.TabIndex = 2;
            this.cbxPizzaAdds.Text = "Dodatki do pizzy";
            this.cbxPizzaAdds.UseVisualStyleBackColor = true;
            this.cbxPizzaAdds.CheckedChanged += new System.EventHandler(this.cbxPizzaAdds_CheckedChanged);
            // 
            // cmbPizza
            // 
            this.cmbPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizza.FormattingEnabled = true;
            this.cmbPizza.Location = new System.Drawing.Point(23, 26);
            this.cmbPizza.Name = "cmbPizza";
            this.cmbPizza.Size = new System.Drawing.Size(218, 21);
            this.cmbPizza.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cblDishAdds);
            this.panel2.Controls.Add(this.btnAddDish);
            this.panel2.Controls.Add(this.numDish);
            this.panel2.Controls.Add(this.cbxDishAdds);
            this.panel2.Controls.Add(this.cmbDish);
            this.panel2.Controls.Add(this.cbxDish);
            this.panel2.Location = new System.Drawing.Point(404, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 173);
            this.panel2.TabIndex = 4;
            // 
            // cblDishAdds
            // 
            this.cblDishAdds.FormattingEnabled = true;
            this.cblDishAdds.Location = new System.Drawing.Point(20, 78);
            this.cblDishAdds.Name = "cblDishAdds";
            this.cblDishAdds.Size = new System.Drawing.Size(221, 79);
            this.cblDishAdds.TabIndex = 8;
            // 
            // btnAddDish
            // 
            this.btnAddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDish.Location = new System.Drawing.Point(285, 49);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(75, 23);
            this.btnAddDish.TabIndex = 7;
            this.btnAddDish.Text = "Dodaj";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // numDish
            // 
            this.numDish.Location = new System.Drawing.Point(247, 25);
            this.numDish.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDish.Name = "numDish";
            this.numDish.Size = new System.Drawing.Size(32, 20);
            this.numDish.TabIndex = 5;
            this.numDish.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxDishAdds
            // 
            this.cbxDishAdds.AutoSize = true;
            this.cbxDishAdds.Location = new System.Drawing.Point(3, 53);
            this.cbxDishAdds.Name = "cbxDishAdds";
            this.cbxDishAdds.Size = new System.Drawing.Size(168, 17);
            this.cbxDishAdds.TabIndex = 2;
            this.cbxDishAdds.Text = "Dodatki do dania obiadowego";
            this.cbxDishAdds.UseVisualStyleBackColor = true;
            this.cbxDishAdds.CheckedChanged += new System.EventHandler(this.cbxDishAdds_CheckedChanged);
            // 
            // cmbDish
            // 
            this.cmbDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDish.FormattingEnabled = true;
            this.cmbDish.Location = new System.Drawing.Point(20, 25);
            this.cmbDish.Name = "cmbDish";
            this.cmbDish.Size = new System.Drawing.Size(218, 21);
            this.cmbDish.TabIndex = 1;
            // 
            // cbxDish
            // 
            this.cbxDish.AutoSize = true;
            this.cbxDish.Location = new System.Drawing.Point(3, 3);
            this.cbxDish.Name = "cbxDish";
            this.cbxDish.Size = new System.Drawing.Size(103, 17);
            this.cbxDish.TabIndex = 0;
            this.cbxDish.Text = "Danie obiadowe";
            this.cbxDish.UseVisualStyleBackColor = true;
            this.cbxDish.CheckedChanged += new System.EventHandler(this.cbxDish_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAddSoup);
            this.panel3.Controls.Add(this.numSoup);
            this.panel3.Controls.Add(this.cmbSoup);
            this.panel3.Controls.Add(this.cbxSoup);
            this.panel3.Location = new System.Drawing.Point(12, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 78);
            this.panel3.TabIndex = 5;
            // 
            // btnAddSoup
            // 
            this.btnAddSoup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSoup.Location = new System.Drawing.Point(288, 24);
            this.btnAddSoup.Name = "btnAddSoup";
            this.btnAddSoup.Size = new System.Drawing.Size(75, 23);
            this.btnAddSoup.TabIndex = 7;
            this.btnAddSoup.Text = "Dodaj";
            this.btnAddSoup.UseVisualStyleBackColor = true;
            this.btnAddSoup.Click += new System.EventHandler(this.btnAddSoup_Click);
            // 
            // numSoup
            // 
            this.numSoup.Location = new System.Drawing.Point(249, 27);
            this.numSoup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoup.Name = "numSoup";
            this.numSoup.Size = new System.Drawing.Size(32, 20);
            this.numSoup.TabIndex = 7;
            this.numSoup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbSoup
            // 
            this.cmbSoup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoup.FormattingEnabled = true;
            this.cmbSoup.Location = new System.Drawing.Point(23, 26);
            this.cmbSoup.Name = "cmbSoup";
            this.cmbSoup.Size = new System.Drawing.Size(218, 21);
            this.cmbSoup.TabIndex = 1;
            // 
            // cbxSoup
            // 
            this.cbxSoup.AutoSize = true;
            this.cbxSoup.Location = new System.Drawing.Point(3, 3);
            this.cbxSoup.Name = "cbxSoup";
            this.cbxSoup.Size = new System.Drawing.Size(51, 17);
            this.cbxSoup.TabIndex = 0;
            this.cbxSoup.Text = "Zupa";
            this.cbxSoup.UseVisualStyleBackColor = true;
            this.cbxSoup.CheckedChanged += new System.EventHandler(this.cbxSoup_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnAddDrink);
            this.panel4.Controls.Add(this.numDrink);
            this.panel4.Controls.Add(this.cmbDrink);
            this.panel4.Controls.Add(this.cbxDrink);
            this.panel4.Location = new System.Drawing.Point(404, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 78);
            this.panel4.TabIndex = 6;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrink.Location = new System.Drawing.Point(285, 24);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(75, 23);
            this.btnAddDrink.TabIndex = 8;
            this.btnAddDrink.Text = "Dodaj";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // numDrink
            // 
            this.numDrink.Location = new System.Drawing.Point(247, 27);
            this.numDrink.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDrink.Name = "numDrink";
            this.numDrink.Size = new System.Drawing.Size(32, 20);
            this.numDrink.TabIndex = 8;
            this.numDrink.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbDrink
            // 
            this.cmbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location = new System.Drawing.Point(23, 26);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(218, 21);
            this.cmbDrink.TabIndex = 1;
            // 
            // cbxDrink
            // 
            this.cbxDrink.AutoSize = true;
            this.cbxDrink.Location = new System.Drawing.Point(3, 3);
            this.cbxDrink.Name = "cbxDrink";
            this.cbxDrink.Size = new System.Drawing.Size(54, 17);
            this.cbxDrink.TabIndex = 0;
            this.cbxDrink.Text = "Napój";
            this.cbxDrink.UseVisualStyleBackColor = true;
            this.cbxDrink.CheckedChanged += new System.EventHandler(this.cbxDrink_CheckedChanged);
            // 
            // dgvPizza
            // 
            this.dgvPizza.AllowUserToAddRows = false;
            this.dgvPizza.AllowUserToDeleteRows = false;
            this.dgvPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PizzaDeleteRow});
            this.dgvPizza.Location = new System.Drawing.Point(12, 191);
            this.dgvPizza.Name = "dgvPizza";
            this.dgvPizza.ReadOnly = true;
            this.dgvPizza.Size = new System.Drawing.Size(386, 156);
            this.dgvPizza.TabIndex = 7;
            this.dgvPizza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPizza_CellContentClick);
            // 
            // PizzaDeleteRow
            // 
            this.PizzaDeleteRow.HeaderText = "Usuń";
            this.PizzaDeleteRow.Name = "PizzaDeleteRow";
            this.PizzaDeleteRow.ReadOnly = true;
            this.PizzaDeleteRow.Text = "Usuń";
            this.PizzaDeleteRow.UseColumnTextForButtonValue = true;
            // 
            // dgvDish
            // 
            this.dgvDish.AllowUserToAddRows = false;
            this.dgvDish.AllowUserToDeleteRows = false;
            this.dgvDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DishDeleteRow});
            this.dgvDish.Location = new System.Drawing.Point(404, 191);
            this.dgvDish.Name = "dgvDish";
            this.dgvDish.ReadOnly = true;
            this.dgvDish.Size = new System.Drawing.Size(386, 156);
            this.dgvDish.TabIndex = 9;
            this.dgvDish.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDish_CellContentClick);
            // 
            // DishDeleteRow
            // 
            this.DishDeleteRow.HeaderText = "Usuń";
            this.DishDeleteRow.Name = "DishDeleteRow";
            this.DishDeleteRow.ReadOnly = true;
            this.DishDeleteRow.Text = "Usuń";
            this.DishDeleteRow.UseColumnTextForButtonValue = true;
            // 
            // dgvSoup
            // 
            this.dgvSoup.AllowUserToAddRows = false;
            this.dgvSoup.AllowUserToDeleteRows = false;
            this.dgvSoup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoupDeleteRow});
            this.dgvSoup.Location = new System.Drawing.Point(12, 437);
            this.dgvSoup.Name = "dgvSoup";
            this.dgvSoup.ReadOnly = true;
            this.dgvSoup.Size = new System.Drawing.Size(386, 188);
            this.dgvSoup.TabIndex = 10;
            this.dgvSoup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoup_CellContentClick);
            // 
            // SoupDeleteRow
            // 
            this.SoupDeleteRow.HeaderText = "Usuń";
            this.SoupDeleteRow.Name = "SoupDeleteRow";
            this.SoupDeleteRow.ReadOnly = true;
            this.SoupDeleteRow.Text = "Usuń";
            this.SoupDeleteRow.UseColumnTextForButtonValue = true;
            // 
            // dgvDrink
            // 
            this.dgvDrink.AllowUserToAddRows = false;
            this.dgvDrink.AllowUserToDeleteRows = false;
            this.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrinkDeleteRow});
            this.dgvDrink.Location = new System.Drawing.Point(404, 437);
            this.dgvDrink.Name = "dgvDrink";
            this.dgvDrink.ReadOnly = true;
            this.dgvDrink.Size = new System.Drawing.Size(386, 188);
            this.dgvDrink.TabIndex = 11;
            this.dgvDrink.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrink_CellContentClick);
            // 
            // DrinkDeleteRow
            // 
            this.DrinkDeleteRow.HeaderText = "Usuń";
            this.DrinkDeleteRow.Name = "DrinkDeleteRow";
            this.DrinkDeleteRow.ReadOnly = true;
            this.DrinkDeleteRow.Text = "Usuń";
            this.DrinkDeleteRow.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(803, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTotalPrice.Location = new System.Drawing.Point(849, 596);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 13;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Location = new System.Drawing.Point(801, 12);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(194, 23);
            this.btnNewOrder.TabIndex = 14;
            this.btnNewOrder.Text = "Nowe zamówienie";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(955, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "zł.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email do:";
            // 
            // cmbEmailFrom
            // 
            this.cmbEmailFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmailFrom.FormattingEnabled = true;
            this.cmbEmailFrom.Location = new System.Drawing.Point(6, 24);
            this.cmbEmailFrom.Name = "cmbEmailFrom";
            this.cmbEmailFrom.Size = new System.Drawing.Size(183, 21);
            this.cmbEmailFrom.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSendOrder);
            this.panel5.Controls.Add(this.cmbEmailTo);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cmbEmailFrom);
            this.panel5.Location = new System.Drawing.Point(799, 459);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 127);
            this.panel5.TabIndex = 19;
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOrder.Location = new System.Drawing.Point(42, 91);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(110, 23);
            this.btnSendOrder.TabIndex = 21;
            this.btnSendOrder.Text = "Wyślij zamówienie";
            this.btnSendOrder.UseVisualStyleBackColor = true;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // cmbEmailTo
            // 
            this.cmbEmailTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmailTo.FormattingEnabled = true;
            this.cmbEmailTo.Location = new System.Drawing.Point(6, 64);
            this.cmbEmailTo.Name = "cmbEmailTo";
            this.cmbEmailTo.Size = new System.Drawing.Size(183, 21);
            this.cmbEmailTo.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtDescription);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.cmbSelectTable);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(799, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 375);
            this.panel6.TabIndex = 20;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 65);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(183, 303);
            this.txtDescription.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dodatkowe informacje:";
            // 
            // cmbSelectTable
            // 
            this.cmbSelectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectTable.FormattingEnabled = true;
            this.cmbSelectTable.Location = new System.Drawing.Point(6, 25);
            this.cmbSelectTable.Name = "cmbSelectTable";
            this.cmbSelectTable.Size = new System.Drawing.Size(183, 21);
            this.cmbSelectTable.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Wybierz stolik:";
            // 
            // btnHistory
            // 
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Location = new System.Drawing.Point(801, 41);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(194, 23);
            this.btnHistory.TabIndex = 21;
            this.btnHistory.Text = "Historia zamówień";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 634);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDrink);
            this.Controls.Add(this.dgvSoup);
            this.Controls.Add(this.dgvDish);
            this.Controls.Add(this.dgvPizza);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Restaurant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamówienia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPizza)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDish)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoup)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxPizza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxPizzaAdds;
        private System.Windows.Forms.ComboBox cmbPizza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbxDishAdds;
        private System.Windows.Forms.ComboBox cmbDish;
        private System.Windows.Forms.CheckBox cbxDish;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbSoup;
        private System.Windows.Forms.CheckBox cbxSoup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.CheckBox cbxDrink;
        private System.Windows.Forms.DataGridView dgvPizza;
        private System.Windows.Forms.NumericUpDown numPizza;
        private System.Windows.Forms.NumericUpDown numDish;
        private System.Windows.Forms.NumericUpDown numSoup;
        private System.Windows.Forms.NumericUpDown numDrink;
        private System.Windows.Forms.DataGridView dgvDish;
        private System.Windows.Forms.DataGridView dgvSoup;
        private System.Windows.Forms.DataGridView dgvDrink;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Button btnAddSoup;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmailFrom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.ComboBox cmbEmailTo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmbSelectTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewButtonColumn PizzaDeleteRow;
        private System.Windows.Forms.DataGridViewButtonColumn DishDeleteRow;
        private System.Windows.Forms.DataGridViewButtonColumn SoupDeleteRow;
        private System.Windows.Forms.DataGridViewButtonColumn DrinkDeleteRow;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.CheckedListBox cblPizzaAdds;
        private System.Windows.Forms.CheckedListBox cblDishAdds;
    }
}

