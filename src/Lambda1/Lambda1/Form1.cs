using System.Diagnostics;

namespace Lambda1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // #03 ƒ‰ƒ€ƒ_‚È‚µ‚ÅŽÀ‘•
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = new List<string>();

            foreach (var value in values)
            {
                if (value.Length >= 3)
                {
                    result.Add(value);
                }
            }

            Debug.WriteLine(string.Join(", ", result));
        }
    }
}
