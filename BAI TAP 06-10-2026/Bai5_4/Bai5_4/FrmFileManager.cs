
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai5_4
{
    public partial class FrmFileManager : Form
    {
        private readonly Dictionary<string, List<Employee>> employees = new()
        {
            ["Phòng Kỹ thuật"] = new List<Employee>
            {
                new Employee { Id = "NV001", FullName = "Nguyễn Văn An", Position = "Lập trình viên", StartDate = new DateTime(2024, 1, 15) },
                new Employee { Id = "NV002", FullName = "Trần Minh Bình", Position = "Kỹ sư hệ thống", StartDate = new DateTime(2023, 8, 1) }
            },
            ["Phòng Kinh doanh"] = new List<Employee>
            {
                new Employee { Id = "NV003", FullName = "Lê Thu Hà", Position = "Nhân viên kinh doanh", StartDate = new DateTime(2024, 3, 20) }
            },
            ["Phòng Nhân sự"] = new List<Employee>
            {
                new Employee { Id = "NV004", FullName = "Phạm Quốc Huy", Position = "Chuyên viên nhân sự", StartDate = new DateTime(2022, 11, 10) }
            }
        };

        public FrmFileManager()
        {
            InitializeComponent();

            BuildTree();

            cboViewMode.Items.AddRange(new object[]
            {
                "Details",
                "SmallIcon",
                "LargeIcon",
                "Tile"
            });

            cboViewMode.SelectedIndex = 0;
        }

        private void BuildTree()
        {
            tvDepartments.Nodes.Clear();

            TreeNode company = new TreeNode("Công ty");

            foreach (string dept in employees.Keys)
            {
                TreeNode departmentNode = new TreeNode(dept);
                departmentNode.Nodes.Add(new TreeNode("Nhóm 1"));
                departmentNode.Nodes.Add(new TreeNode("Nhóm 2"));
                company.Nodes.Add(departmentNode);
            }

            tvDepartments.Nodes.Add(company);
            company.Expand();
        }

        private void tvDepartments_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            string? dept = null;

            if (employees.ContainsKey(e.Node.Text))
            {
                dept = e.Node.Text;
            }
            else if (e.Node.Parent != null && employees.ContainsKey(e.Node.Parent.Text))
            {
                dept = e.Node.Parent.Text;
            }

            if (dept == null)
            {
                lvEmployees.Items.Clear();
                return;
            }

            LoadEmployees(employees[dept]);
        }

        private void LoadEmployees(List<Employee> list)
        {
            lvEmployees.Items.Clear();

            foreach (Employee emp in list)
            {
                ListViewItem item = new ListViewItem(emp.ToRow());
                lvEmployees.Items.Add(item);
            }
        }

        private void cboViewMode_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lvEmployees.View = cboViewMode.SelectedItem?.ToString() switch
            {
                "SmallIcon" => View.SmallIcon,
                "LargeIcon" => View.LargeIcon,
                "Tile" => View.Tile,
                _ => View.Details
            };
        }
    }
}
