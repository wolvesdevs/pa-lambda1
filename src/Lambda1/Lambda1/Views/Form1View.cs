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

        private void button4_Click(object sender, EventArgs e)
        {
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = CommonFunc.GetValues3(values, 2, CommonFunc.CheckLength3);

            Debug.WriteLine(string.Join(", ", result));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = CommonFunc.GetValues2(values,
                delegate (string value)
                {
                    return value.Length >= 3;
                });

            Debug.WriteLine(string.Join(", ", result));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = CommonFunc.GetValues4(values,
                delegate (string value)
                {
                    return value.Length >= 2;
                });

            Debug.WriteLine(string.Join(", ", result));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = CommonFunc.GetValues4(values, x => x.Length >= 2);

            Debug.WriteLine(string.Join(", ", result));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = CommonFunc.GetValues5(values, 2, (value, len) => value.Length >= len);

            Debug.WriteLine(string.Join(", ", result));
        }

        private void Func2Button_Click(object sender, EventArgs e)
        {
            var values = new string[] { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var result = CommonFunc.GetValues5(values, 2,
                (value, len) =>
                {
                    if (value[0] == 'E')
                    {
                        return value.Length > len;
                    }

                    return false;
                });

            Debug.WriteLine(string.Join(", ", result));
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            CommonFunc.GetData(value => Debug.WriteLine($"{value}%"));
        }

        private void Action2Button_Click(object sender, EventArgs e)
        {
            CommonFunc.GetData2(() => Debug.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")));
        }

        private void Test()
        {
            Debug.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
        }

        private void CollectionButton_Click(object sender, EventArgs e)
        {
            var values = new List<string> { "ABCDE", "AAAA", "BBBB", "CCCC", "DDD" };

            var result1 = values.Find(x => x.Contains("B"));
            Debug.WriteLine($"result1: {string.Join(", ", result1)}");
        }
    }
}
