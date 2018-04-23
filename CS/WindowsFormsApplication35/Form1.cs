using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace WindowsFormsApplication35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            windowsUIView1.ContentContainerActions.Add(ContentContainerAction.Exit);
        }

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            GridControl grid = new GridControl();
            grid.DataSource = GetData();
            if (e.Document.Caption == "CardView")
                grid.MainView = new CardView(grid);
            e.Control = grid;
            
      
        }
        public List<Person> GetData()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { FirstName = "Alex", LastName = "Hunt", ID = 12321 });
            list.Add(new Person() { FirstName = "James", LastName = "Bond", ID = 87452 });
            list.Add(new Person() { FirstName = "Sam", LastName = "Winchester", ID = 43598 });
            list.Add(new Person() { FirstName = "Din", LastName = "Winchester", ID = 31561 });
            list.Add(new Person() { FirstName = "Derek", LastName = "Morgan", ID = 29873 });
            return list;
        }
    }
}
