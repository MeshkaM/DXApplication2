using DataGridBindingExampleCore;
using DevExpress.Xpf.Grid;
using System;
using System.Linq;
using System.Windows;

namespace DXApplication2
{

    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridControl_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ProvinceID" && viewModel != null)
            {
                int provinceID = Convert.ToInt32(e.Value);
                var province = viewModel.Provinces.FirstOrDefault(p => p.ProvinceID == provinceID);
                if (province != null)
                {
                    e.DisplayText = province.ProvinceName;
                }
            }
            else if (e.Column.FieldName == "DistrictID" && viewModel != null)
            {
                int districtID = Convert.ToInt32(e.Value);
                var district = viewModel.Districts.FirstOrDefault(d => d.DistrictID == districtID);
                if (district != null)
                {
                    e.DisplayText = district.DistrictName;
                }
            }
        }
    }
}
