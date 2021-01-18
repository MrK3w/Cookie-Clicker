using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Cookie_Clicker
{
    public partial class MyUnit : Form
    {
        private ShopForm _shopForm;
        public MyUnit(ShopForm _shop)
        {
            InitializeComponent();
            unitView.BackgroundColor = SystemColors.Control;
            _shopForm = _shop;
            PrepareView();
           
        }

        private void PrepareView()
        {
          
            unitView.DataSource = (from entry in _shopForm.UnitDictionary
                orderby entry.Key
                select new { entry.Key, entry.Value.countOfUnit, entry.Value.damageDealt, entry.Value.type, entry.Value.price }).ToList();
            unitView.Columns[0].HeaderText = "Unit name";
            unitView.Columns[1].HeaderText = "Count of unit";
            unitView.Columns[2].HeaderText = "damage of unit";
            unitView.Columns[3].HeaderText = "type of unit";
            unitView.Columns[4].HeaderText = "price of unit";
        }
    }
}
