using Lambda1.Domain.Helper;
using System.Diagnostics;

namespace Lambda1.UI
{
    public partial class Form1View : Form
    {
        public Form1View()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = CommonFunc.GetValues(values, 3);

            Debug.WriteLine(string.Join(", ", result));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = CommonFunc.GetValues2(values, CommonFunc.CheckLength1);

            Debug.WriteLine(string.Join(", ", result));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = CommonFunc.GetValues2(values, CommonFunc.CheckLength2);

            Debug.WriteLine(string.Join(", ", result));
        }
    }
}
