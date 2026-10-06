
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class FrmDichVu : Form
    {
        private readonly Dictionary<string, List<ServiceItem>> data = new()
        {
            ["Khám bệnh"] = new List<ServiceItem>
            {
                new("Khám tổng quát", 150000),
                new("Khám chuyên khoa", 250000),
                new("Tư vấn bác sĩ", 100000)
            },
            ["Xét nghiệm"] = new List<ServiceItem>
            {
                new("Xét nghiệm máu", 120000),
                new("Xét nghiệm nước tiểu", 80000),
                new("Xét nghiệm đường huyết", 70000)
            },
            ["Chụp X-Quang"] = new List<ServiceItem>
            {
                new("X-Quang ngực", 200000),
                new("X-Quang xương", 220000)
            },
            ["Vắc-xin"] = new List<ServiceItem>
            {
                new("Vắc-xin cúm", 300000),
                new("Vắc-xin viêm gan B", 350000),
                new("Vắc-xin HPV", 1500000)
            }
        };

        public FrmDichVu()
        {
            InitializeComponent();
            cboCategory.Items.AddRange(data.Keys.ToArray());
            cboCategory.SelectedIndex = 0;
            Recalculate();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            if (cboCategory.SelectedItem is string key && data.TryGetValue(key, out var items))
            {
                foreach (var item in items)
                    lstAvailableServices.Items.Add(item);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) => AddSelectedService();

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e) => AddSelectedService();

        private void AddSelectedService()
        {
            if (lstAvailableServices.SelectedItem is ServiceItem item &&
                !lstSelectedServices.Items.Contains(item))
            {
                lstSelectedServices.Items.Add(item);
                Recalculate();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem);
                Recalculate();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            Recalculate();
        }

        private void Recalculate()
        {
            decimal total = 0;
            foreach (var obj in lstSelectedServices.Items)
                if (obj is ServiceItem item) total += item.Price;

            // Đề không nêu công thức chiết khấu cụ thể, nên dùng mức mẫu để minh họa.
            decimal discountRate = total >= 2000000 ? 10 :
                                   total >= 1000000 ? 5 : 0;
            decimal finalTotal = total * (1 - discountRate / 100m);

            lblSubtotalValue.Text = total.ToString("#,##0") + " VND";
            lblDiscountValue.Text = discountRate.ToString("0") + "%";
            lblFinalValue.Text = finalTotal.ToString("#,##0") + " VND";
        }
    }

    public class ServiceItem
    {
        public string Name { get; }
        public decimal Price { get; }

        public ServiceItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() => $"{Name} - {Price:#,##0} VND";
    }
}
