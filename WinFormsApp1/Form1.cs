using System.Reflection;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // 載入要打開的 .exe 檔
            Assembly assembly = Assembly.LoadFrom("WinFormsApp2.dll");

            // 取得該 .dll 檔中所有的類別
            Type[] types = assembly.GetTypes();

            // 選擇要載入的類別（假設選擇第一個Form類別）
            var selectedType = (from c in types where c.BaseType.Name == "Form" select c).FirstOrDefault();

            // 建立該類別的實例
            Form mdiChild = (Form)Activator.CreateInstance(selectedType);

            // 設定 MDI Parent 為當前視窗
            mdiChild.MdiParent = this;

            // 將 MDI Child 放在 SplitContainer 的右邊
            //this.splitContainer1.Panel2.Controls.Add(mdiChild);

            // 顯示該 MDI Child 視窗
            mdiChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}