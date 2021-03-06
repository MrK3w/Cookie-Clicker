﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdleClickerEngine;
using Newtonsoft.Json;

namespace Cookie_Clicker
{
    public partial class TableOfMyUnits : Form
    {

        private readonly MyUnits _units = MyUnits.GetInstance();


        public TableOfMyUnits()
        {
            InitializeComponent();
            unitView.BackgroundColor = SystemColors.Control;
            ShowTableOfAllUnits();
           
        }

        /// <summary>
        /// Datagrid for all units
        /// </summary>
        private void ShowTableOfAllUnits()
        {
          
            unitView.DataSource = (from entry in _units.UnitDictionary
                orderby entry.Value.Price
                select new { entry.Key, countOfUnit = entry.Value.CountOfUnit, damageDealt = entry.Value.DamageDealt, type = entry.Value.Type, price = entry.Value.Price }).ToList();
            unitView.Columns[0].HeaderText = "Unit name";
            unitView.Columns[1].HeaderText = "Count of unit";
            unitView.Columns[2].HeaderText = "damage of unit";
            unitView.Columns[3].HeaderText = "type of unit";
            unitView.Columns[4].HeaderText = "price of unit";
        }
    }
}
