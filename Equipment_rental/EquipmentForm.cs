using MySql.Data.MySqlClient;
using System.Data;

namespace Equipment_rental
{
    public partial class EquipmentForm : Form
    {
        private int? _selectedEquipmentId;

        public EquipmentForm()
        {
            InitializeComponent();
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            if (!UserSession.IsAuthenticated)
            {
                MessageBox.Show("Необходимо войти в систему.");
                OpenLoginForm();
                return;
            }

            labelRole.Text = $"Роль: {UserRoleHelper.ToDisplayName(UserSession.Role)} ({UserSession.UserName})";
            ApplyRolePermissions();
            LoadEquipment();
        }

        private void ApplyRolePermissions()
        {
            bool canCreate = UserRoleHelper.CanCreate(UserSession.Role);
            bool canUpdate = UserRoleHelper.CanUpdate(UserSession.Role);
            bool canDelete = UserRoleHelper.CanDelete(UserSession.Role);
            bool canSearch = UserRoleHelper.CanSearch(UserSession.Role);

            btnAdd.Enabled = canCreate;
            btnUpdate.Enabled = canUpdate;
            btnDelete.Enabled = canDelete;
            btnSearch.Enabled = canSearch;
            textBoxSearch.Enabled = canSearch;

            bool readOnlyFields = !canCreate && !canUpdate;
            textBoxName.ReadOnly = readOnlyFields;
            textBoxCategory.ReadOnly = readOnlyFields;
            textBoxDescription.ReadOnly = readOnlyFields;
            numericUpDownPrice.Enabled = !readOnlyFields;
            numericUpDownQuantity.Enabled = !readOnlyFields;

            groupBoxEdit.Text = UserSession.Role switch
            {
                UserRole.Administrator => "Данные (полный доступ)",
                UserRole.Operator => "Данные (создание и изменение)",
                _ => "Данные (только просмотр)"
            };
        }

        /// <summary>READ — загрузка списка оборудования.</summary>
        private void LoadEquipment(string? searchText = null)
        {
            DB db = new DB();
            DataTable table = new DataTable();

            string sql = @"SELECT id, name, category, price_per_day, quantity, description
                           FROM equipment";

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                sql += @" WHERE name LIKE @search
                          OR category LIKE @search
                          OR description LIKE @search";
            }

            sql += " ORDER BY name";

            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            if (!string.IsNullOrWhiteSpace(searchText))
                command.Parameters.Add("@search", MySqlDbType.VarChar).Value = $"%{searchText.Trim()}%";

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();

            dataGridViewEquipment.DataSource = table;

            if (dataGridViewEquipment.Columns.Contains("id"))
                dataGridViewEquipment.Columns["id"]!.Visible = false;

            if (dataGridViewEquipment.Columns.Contains("price_per_day"))
                dataGridViewEquipment.Columns["price_per_day"]!.HeaderText = "Цена/сутки";

            _selectedEquipmentId = null;
        }

        private void dataGridViewEquipment_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEquipment.CurrentRow?.DataBoundItem is not DataRowView rowView)
                return;

            DataRow row = rowView.Row;
            _selectedEquipmentId = Convert.ToInt32(row["id"]);
            textBoxName.Text = row["name"].ToString();
            textBoxCategory.Text = row["category"].ToString();
            numericUpDownPrice.Value = Convert.ToDecimal(row["price_per_day"]);
            numericUpDownQuantity.Value = Convert.ToDecimal(row["quantity"]);
            textBoxDescription.Text = row["description"] == DBNull.Value ? "" : row["description"].ToString();
        }

        /// <summary>CREATE — добавление оборудования.</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!UserRoleHelper.CanCreate(UserSession.Role))
            {
                MessageBox.Show("Недостаточно прав. Добавление доступно администратору и оператору.");
                return;
            }

            if (!ValidateInput(out string name, out string category, out decimal price, out int quantity, out string description))
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(
                @"INSERT INTO equipment (name, category, price_per_day, quantity, description)
                  VALUES (@name, @category, @price, @quantity, @description)",
                db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = category;
            command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
            command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("@description", MySqlDbType.Text).Value = description;

            db.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Оборудование добавлено.");
                    ClearInputFields();
                    LoadEquipment(textBoxSearch.Text);
                }
                else
                    MessageBox.Show("Не удалось добавить запись.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}");
            }
            finally
            {
                db.closeConnection();
            }
        }

        /// <summary>UPDATE — изменение выбранного оборудования.</summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!UserRoleHelper.CanUpdate(UserSession.Role))
            {
                MessageBox.Show("Недостаточно прав. Изменение доступно администратору и оператору.");
                return;
            }

            if (_selectedEquipmentId == null)
            {
                MessageBox.Show("Выберите запись в таблице.");
                return;
            }

            if (!ValidateInput(out string name, out string category, out decimal price, out int quantity, out string description))
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(
                @"UPDATE equipment
                  SET name = @name, category = @category, price_per_day = @price,
                      quantity = @quantity, description = @description
                  WHERE id = @id",
                db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _selectedEquipmentId.Value;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = category;
            command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
            command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = quantity;
            command.Parameters.Add("@description", MySqlDbType.Text).Value = description;

            db.openConnection();
            try
            {
                if (command.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Данные обновлены.");
                    LoadEquipment(textBoxSearch.Text);
                }
                else
                    MessageBox.Show("Запись не найдена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении: {ex.Message}");
            }
            finally
            {
                db.closeConnection();
            }
        }

        /// <summary>DELETE — удаление выбранного оборудования.</summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!UserRoleHelper.CanDelete(UserSession.Role))
            {
                MessageBox.Show("Недостаточно прав. Удаление доступно только администратору.");
                return;
            }

            if (_selectedEquipmentId == null)
            {
                MessageBox.Show("Выберите запись в таблице.");
                return;
            }

            if (MessageBox.Show("Удалить выбранное оборудование?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(
                "DELETE FROM equipment WHERE id = @id",
                db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = _selectedEquipmentId.Value;

            db.openConnection();
            try
            {
                if (command.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Запись удалена.");
                    ClearInputFields();
                    LoadEquipment(textBoxSearch.Text);
                }
                else
                    MessageBox.Show("Запись не найдена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
            finally
            {
                db.closeConnection();
            }
        }

        /// <summary>SEARCH — поиск по кнопке.</summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!UserRoleHelper.CanSearch(UserSession.Role))
                return;

            LoadEquipment(textBoxSearch.Text);
        }

        /// <summary>SEARCH — поиск при изменении текста.</summary>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!UserRoleHelper.CanSearch(UserSession.Role))
                return;

            LoadEquipment(textBoxSearch.Text);
        }

        private bool ValidateInput(out string name, out string category, out decimal price, out int quantity, out string description)
        {
            name = textBoxName.Text.Trim();
            category = textBoxCategory.Text.Trim();
            description = textBoxDescription.Text.Trim();
            price = numericUpDownPrice.Value;
            quantity = (int)numericUpDownQuantity.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите наименование оборудования.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Введите категорию.");
                return false;
            }

            if (price <= 0)
            {
                MessageBox.Show("Цена должна быть больше нуля.");
                return false;
            }

            if (quantity < 0)
            {
                MessageBox.Show("Количество не может быть отрицательным.");
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxDescription.Clear();
            numericUpDownPrice.Value = 0;
            numericUpDownQuantity.Value = 0;
            _selectedEquipmentId = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.Logout();
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (_, _) => Close();
            loginForm.Show();
        }
    }
}
