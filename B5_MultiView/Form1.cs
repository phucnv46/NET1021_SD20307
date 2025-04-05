using B5_MultiView.Views;

namespace B5_MultiView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            LoadSachView();
           
        }
        
       private void LoadSachView()
        {
            sachView1 = new SachView();
            tabControl1.TabPages[0].Controls.Add(sachView1);
            sachView1.Dock = DockStyle.Fill;
            
        }
       
    
    }
}
