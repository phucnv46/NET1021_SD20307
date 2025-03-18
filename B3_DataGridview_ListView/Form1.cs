using System.ComponentModel;
using System.Text.Json;

namespace B3_DataGridview_ListView
{
    public partial class Form1 : Form
    {
        BindingList<SinhVien> list = new BindingList<SinhVien>() {
          new SinhVien(){ MaSinhVien="PG123",Ten="Nguyễn Văn Phúc",Mon="C#2",Diem=10}
        };
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = list;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SinhVien sv =(SinhVien) dataGridView1.SelectedRows[0].DataBoundItem;
            MessageBox.Show(JsonSerializer.Serialize(sv));
        }
    }


}
