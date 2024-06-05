using IdealKarkas.Context;
using IdealKarkas.Context.Models;
using IdealKarkas.WinForms.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormNewOrder : Form
    {
        public Dictionary<ObjectMod, int> ObjectMods = new Dictionary<ObjectMod, int>();
        decimal TotalPrice = 0;
        public FormNewOrder()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
        }

        public void Print()
        {
            using (var db = new IKContext())
            {
                var services = db.ObjectMods.Where(x => x.IsActual == null).ToList();
                foreach (var service in services)
                {
                    var viewService = new ViewObject(service);
                    viewService.AddToOrder += VisibleList;
                    viewService.Parent = flowLayoutPanel1;
                }
            }
        }
        private void VisibleList(ObjectMod service)
        {
            if (ObjectMods.TryGetValue(service, out var count))
                ObjectMods[service] = ++count;
            else
                ObjectMods.Add(service, 1);
            PrintOrder();
        }
        private void PrintOrder()
        {
            listBox1.Items.Clear();
            TotalPrice = 0;
            foreach (var item in ObjectMods.Keys)
            {
                listBox1.Items.Add($"{item.Title} x{ObjectMods[item]}");
                TotalPrice += item.Price * ObjectMods[item];
            }
            EnableButton();
            label7.Text = $"Итоговая стоимость заказа {TotalPrice:C2}";
        }
        private void EnableButton()
        {
            if (listBox1.Items.Count != 0 && WorkToClient.Client.Id != -1 && !string.IsNullOrWhiteSpace( txtAddress.Text) && !string.IsNullOrWhiteSpace(txtDesc.Text))
                btnEnter.Enabled = true;
        }

        private void FormNewOrder_Load(object sender, EventArgs e)
        {
            Print();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var form = new FormClient();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                label1.Text = $"Клиент {WorkToClient.Client} добавлен";
            }
            EnableButton();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                ClientId = WorkToClient.Client.Id,
                StaffId = WorkToUser.Staff.Id,
                DateAdd = DateTimeOffset.Now,
                DateEnd = dateTimePicker1.Value,
                Address = txtAddress.Text,
                Description = txtDesc.Text,
                AllPrice = TotalPrice,
                NumberProject = DateTime.UtcNow.ToShortDateString() + "/" + WorkToClient.Client.LastName
            };
            using (var db = new IKContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
                int id = order.Id;
                List <ObjectOrder> objectOrders = new List<ObjectOrder>();
                foreach (var o in ObjectMods)
                {
                    objectOrders.Add(new ObjectOrder
                    {
                        ObjectModId = o.Key.Id,
                        OrderId = id,
                        CountObject = o.Value
                    });
                }
                db.ObjectOrders.AddRange(objectOrders);
                db.SaveChanges();
                MessageBox.Show($"Заказ открыт!\nНомер проекта:  {order.NumberProject}", "IdealKarkas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
