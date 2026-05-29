namespace Equipment_rental
{
    partial class EquipmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelRole = new Label();
            labelTitle = new Label();
            btnLogout = new Button();
            dataGridViewEquipment = new DataGridView();
            groupBoxEdit = new GroupBox();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelQuantity = new Label();
            numericUpDownQuantity = new NumericUpDown();
            labelPrice = new Label();
            numericUpDownPrice = new NumericUpDown();
            labelCategory = new Label();
            textBoxCategory = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            panelActions = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panelSearch = new Panel();
            btnSearch = new Button();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipment).BeginInit();
            groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            panelActions.SuspendLayout();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkGoldenrod;
            panelHeader.Controls.Add(labelRole);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(984, 56);
            panelHeader.TabIndex = 0;
            // 
            // labelRole
            // 
            labelRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(520, 16);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(300, 24);
            labelRole.TabIndex = 2;
            labelRole.Text = "Роль:";
            labelRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(12, 14);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(248, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Прокат оборудования";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.Black;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(832, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 32);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridViewEquipment
            // 
            dataGridViewEquipment.AllowUserToAddRows = false;
            dataGridViewEquipment.AllowUserToDeleteRows = false;
            dataGridViewEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEquipment.BackgroundColor = Color.White;
            dataGridViewEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEquipment.Dock = DockStyle.Fill;
            dataGridViewEquipment.Location = new Point(0, 106);
            dataGridViewEquipment.MultiSelect = false;
            dataGridViewEquipment.Name = "dataGridViewEquipment";
            dataGridViewEquipment.ReadOnly = true;
            dataGridViewEquipment.RowHeadersVisible = false;
            dataGridViewEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEquipment.Size = new Size(684, 455);
            dataGridViewEquipment.TabIndex = 2;
            dataGridViewEquipment.SelectionChanged += dataGridViewEquipment_SelectionChanged;
            // 
            // groupBoxEdit
            // 
            groupBoxEdit.Controls.Add(labelDescription);
            groupBoxEdit.Controls.Add(textBoxDescription);
            groupBoxEdit.Controls.Add(labelQuantity);
            groupBoxEdit.Controls.Add(numericUpDownQuantity);
            groupBoxEdit.Controls.Add(labelPrice);
            groupBoxEdit.Controls.Add(numericUpDownPrice);
            groupBoxEdit.Controls.Add(labelCategory);
            groupBoxEdit.Controls.Add(textBoxCategory);
            groupBoxEdit.Controls.Add(labelName);
            groupBoxEdit.Controls.Add(textBoxName);
            groupBoxEdit.Controls.Add(panelActions);
            groupBoxEdit.Dock = DockStyle.Right;
            groupBoxEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxEdit.Location = new Point(684, 106);
            groupBoxEdit.Name = "groupBoxEdit";
            groupBoxEdit.Padding = new Padding(10);
            groupBoxEdit.Size = new Size(300, 455);
            groupBoxEdit.TabIndex = 3;
            groupBoxEdit.TabStop = false;
            groupBoxEdit.Text = "Данные оборудования";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 9F);
            labelDescription.Location = new Point(13, 228);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(65, 15);
            labelDescription.TabIndex = 8;
            labelDescription.Text = "Описание:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 9F);
            textBoxDescription.Location = new Point(13, 246);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(268, 80);
            textBoxDescription.TabIndex = 9;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Segoe UI", 9F);
            labelQuantity.Location = new Point(13, 178);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(78, 15);
            labelQuantity.TabIndex = 6;
            labelQuantity.Text = "Количество:";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Font = new Font("Segoe UI", 9F);
            numericUpDownQuantity.Location = new Point(13, 196);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(268, 23);
            numericUpDownQuantity.TabIndex = 7;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 9F);
            labelPrice.Location = new Point(13, 128);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(108, 15);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Цена за сутки (₽):";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Font = new Font("Segoe UI", 9F);
            numericUpDownPrice.Location = new Point(13, 146);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(268, 23);
            numericUpDownPrice.TabIndex = 5;
            numericUpDownPrice.ThousandsSeparator = true;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 9F);
            labelCategory.Location = new Point(13, 78);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(69, 15);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "Категория:";
            // 
            // textBoxCategory
            // 
            textBoxCategory.Font = new Font("Segoe UI", 9F);
            textBoxCategory.Location = new Point(13, 96);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(268, 23);
            textBoxCategory.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F);
            labelName.Location = new Point(13, 28);
            labelName.Name = "labelName";
            labelName.Size = new Size(96, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Наименование:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 9F);
            textBoxName.Location = new Point(13, 46);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(268, 23);
            textBoxName.TabIndex = 1;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnDelete);
            panelActions.Controls.Add(btnUpdate);
            panelActions.Controls.Add(btnAdd);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(10, 342);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(280, 103);
            panelActions.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Dock = DockStyle.Top;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(0, 68);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(280, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить (DELETE)";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkGoldenrod;
            btnUpdate.Dock = DockStyle.Top;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(0, 34);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(280, 34);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Изменить (UPDATE)";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.Dock = DockStyle.Top;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить (CREATE)";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.PeachPuff;
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Controls.Add(labelSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 56);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(12, 8, 12, 8);
            panelSearch.Size = new Size(984, 50);
            panelSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.DarkGoldenrod;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(832, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 28);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Найти (SEARCH)";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(120, 10);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Поиск по названию, категории, описанию...";
            textBoxSearch.Size = new Size(700, 25);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSearch.Location = new Point(12, 12);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(52, 19);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Поиск:";
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(dataGridViewEquipment);
            Controls.Add(groupBoxEdit);
            Controls.Add(panelSearch);
            Controls.Add(panelHeader);
            MinimumSize = new Size(900, 500);
            Name = "EquipmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление оборудованием";
            Load += EquipmentForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipment).EndInit();
            groupBoxEdit.ResumeLayout(false);
            groupBoxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            panelActions.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelHeader;
        private Label labelTitle;
        private Label labelRole;
        private Button btnLogout;
        private Panel panelSearch;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Button btnSearch;
        private DataGridView dataGridViewEquipment;
        private GroupBox groupBoxEdit;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelCategory;
        private TextBox textBoxCategory;
        private Label labelPrice;
        private NumericUpDown numericUpDownPrice;
        private Label labelQuantity;
        private NumericUpDown numericUpDownQuantity;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Panel panelActions;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
