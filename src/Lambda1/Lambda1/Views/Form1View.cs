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
            // #03 ƒ‰ƒ€ƒ_‚È‚µ‚ÅŽÀ‘•
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = CommonFunc.GetValues(values, 3);

            Debug.WriteLine(string.Join(", ", result));
        }
    }
}
