using IdealKarkas.Context;
using IdealKarkas.Context.Models;
using IdealKarkas.WinForms.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.UserControls
{
    public partial class ViewInfo : UserControl
    {
        public Order order { get; set; }
        public int ClientId;
        public ViewInfo(Order order)
        {
            this.order = order;
            InitializeComponent();
            InitOrder(order);
        }
        public Order Order => order;
        public void InitOrder(Order order)
        {
            labelNumber.Text = order.NumberProject;
            labelAddress.Text = order.Address;
            labelPrice.Text = $"Стоимость заказа: {order.AllPrice:C2}";
            txtDesc.Text = order.Description;
            ClientId = order.ClientId;
            using (var db = new IKContext())
            {
                var list = db.ObjectOrders.Where(x => x.OrderId == order.Id).ToList(); 
                foreach (var item in list)
                {
                    listBox1.Items.Add($"{item.ObjectMod.Title} x{item.CountObject}");
                }
            }
        }

        private void labelClient_DoubleClick(object sender, EventArgs e)
        {
            using (var db = new IKContext())
            {
                var item1 = db.Clients.FirstOrDefault(x => x.Id == ClientId);
                var form = new FormClientModel(item1);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                }
            }
        }
    }
}
