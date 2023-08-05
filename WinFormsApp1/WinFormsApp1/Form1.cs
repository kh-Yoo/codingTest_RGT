using Newtonsoft.Json.Linq;
using System.Net;
using Newtonsoft.Json;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox9.Text = "RGB �׽�Ʈ ����";
            textBox8.Text = "�׽�Ʈ";
            textBox6.Text = "�ֹ���";
            textBox4.Text = "�ֹ���";
            textBox2.Text = "���̺� ��ȣ";
            textBox1.Text = "�ֹ���ȣ";
            label1.Text = "�ֹ���ȣ �˻�";
            textBox11.Text = "0001";
            string url = "http://211.44.24.167:9002/codingTest/getData.php?order_id=" + WebUtility.UrlEncode("'0001'");

            // HttpClient ����
            using (var httpClient = new HttpClient())
            {
                try
                {
                    // JSON �����͸� �񵿱������� ������
                    string jsonString = await httpClient.GetStringAsync(url);

                    // JSON �����͸� JArray�� �Ľ�
                    JArray jsonArray = JArray.Parse(jsonString);

                    // JArray�� ��ҵ��� �ݺ��Ͽ� "order_id" ���� ã��
                    foreach (JObject obj in jsonArray)
                    {
                        // "order_id" �Ӽ��� ���� ������
                        if (obj.TryGetValue("order_id", out JToken orderIdToken))
                        {
                            string orderId = orderIdToken.ToString();
                            textBox10.Text = orderId;
                            Console.WriteLine($"order_id: {orderId}");
                        }
                        if (obj.TryGetValue("date_time", out JToken dateTimeToken))
                        {
                            string dateTime = dateTimeToken.ToString();
                            textBox7.Text = dateTime;
                            Console.WriteLine($"date_time: {dateTime}");
                        }
                        if (obj.TryGetValue("orderer_name", out JToken orderNameToken))
                        {
                            string orderName = orderNameToken.ToString();
                            textBox5.Text = orderName;
                            Console.WriteLine($"order_name: {orderName}");
                        }
                        if (obj.TryGetValue("table_no", out JToken tableNoToken))
                        {
                            string tableNo = tableNoToken.ToString();
                            textBox3.Text = tableNo;
                            Console.WriteLine($"table_no: {tableNo}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // ���� ó��
                    Console.WriteLine($"���� �߻�: {ex.Message}");
                }

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
