using BusinessLogic.Dtos;
using BusinessLogic.Interface;
using BusinessLogic.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;
        private List<UserDto> userViewCurrent;
        private int? selectedUserId;


        public Form1(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
            AddColumnsToDataGridView();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                MessageBox.Show("Ctrl + S Pressed!");
                return true; // Ngăn không cho phím này thực hiện hành động mặc định
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var user = new UserDto
            {
                UserName = txtUserName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                FullName = txtFullName.Text,
            };
            _userService.AddUser(user);
            LoadUsers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userViewCurrent = new List<UserDto>(_userService.GetUsers());
            LoadUsers();
        }

        private void LoadUsers()
        {
            userViewCurrent = _userService.GetUsers();
            viewUser.DataSource = userViewCurrent;
        }

        private void AddColumnsToDataGridView()
        {
            viewUser.AllowUserToOrderColumns = true;
            viewUser.AutoGenerateColumns = false;

            viewUser.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });

            viewUser.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UserName",
                HeaderText = "Username",
                DataPropertyName = "UserName",
                SortMode = DataGridViewColumnSortMode.Programmatic
            });

            viewUser.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Full Name",
                DataPropertyName = "FullName",
                SortMode = DataGridViewColumnSortMode.Programmatic
            });

            viewUser.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email",
                SortMode = DataGridViewColumnSortMode.Programmatic
            });

            viewUser.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Password",
                HeaderText = "Password",
                DataPropertyName = "Password",
                SortMode = DataGridViewColumnSortMode.Programmatic
            });
        }

        private void viewUser_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(viewUser.RowHeadersDefaultCellStyle.ForeColor))
            {
                string stt = (e.RowIndex + 1).ToString(); // Tính số thứ tự
                e.Graphics.DrawString(
                    stt,
                    viewUser.DefaultCellStyle.Font,
                    brush,
                    e.RowBounds.Location.X + 10, // Vị trí X của số thứ tự
                    e.RowBounds.Location.Y + 4  // Vị trí Y của số thứ tự
                );
            }
        }

        private void viewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = viewUser.Rows[e.RowIndex];
                var userName = selectedRow.Cells["UserName"].Value?.ToString();
                var fullName = selectedRow.Cells["FullName"].Value?.ToString();
                var email = selectedRow.Cells["Email"].Value?.ToString();
                var passWord = selectedRow.Cells["Password"].Value?.ToString();
                var userId = selectedRow.Cells["Id"].Value;
                selectedUserId = userId != null ? Convert.ToInt32(userId) : (int?)null;

                txtEmail.Text = email;
                txtFullName.Text = fullName;
                txtPassword.Text = passWord;
                txtUserName.Text = userName;
            }
        }

        private void viewUser_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = viewUser.Columns[e.ColumnIndex];
                var currentOrder = column.HeaderCell.SortGlyphDirection;
                if (currentOrder == SortOrder.Ascending)
                {
                    currentOrder = SortOrder.Descending;
                }
                else if (currentOrder == SortOrder.Descending)
                {
                    currentOrder = SortOrder.None;
                }
                else
                {
                    currentOrder = SortOrder.Ascending;
                }
                var data = Order(userViewCurrent, column.Name, currentOrder);
                viewUser.DataSource = data;
                column.HeaderCell.SortGlyphDirection = currentOrder;
            }

        }
        public List<UserDto> Order(List<UserDto> data, string propertyName, SortOrder direction = 0)
        {
            var query = data.AsQueryable();
            if (direction == SortOrder.Ascending)
            {
                query = query.OrderBy(x => typeof(UserDto).GetProperty(propertyName).GetValue(x, null));
            }
            else if (direction == SortOrder.Descending)
            {
                query = query.OrderByDescending(x => typeof(UserDto).GetProperty(propertyName).GetValue(x, null));
            }
            else
            {
                return userViewCurrent;
            }
            return query.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var user = new UserDto
            {
                Id = selectedUserId.Value,
                UserName = txtUserName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                FullName = txtFullName.Text,
            };
            _userService.EditUser(user);
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _userService.DeleteUser(selectedUserId.Value);
            selectedUserId = null;

            txtEmail.Text = "";
            txtFullName.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            LoadUsers();
        }
    }
}
