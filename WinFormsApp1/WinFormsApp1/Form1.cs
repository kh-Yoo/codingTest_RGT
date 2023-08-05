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
            textBox9.Text = "RGB 테스트 매장";
            textBox8.Text = "테스트";
            textBox6.Text = "주문일";
            textBox4.Text = "주문자";
            textBox2.Text = "테이블 번호";
            textBox1.Text = "주문번호";
            label1.Text = "주문번호 검색";
            textBox11.Text = "0001";
            string url = "http://211.44.24.167:9002/codingTest/getData.php?order_id=" + WebUtility.UrlEncode("'0001'");

            // HttpClient 생성
            using (var httpClient = new HttpClient())
            {
                try
                {
                    // JSON 데이터를 비동기적으로 가져옴
                    string jsonString = await httpClient.GetStringAsync(url);

                    // JSON 데이터를 JArray로 파싱
                    JArray jsonArray = JArray.Parse(jsonString);

                    // JArray의 요소들을 반복하여 "order_id" 값을 찾음
                    foreach (JObject obj in jsonArray)
                    {
                        // "order_id" 속성의 값을 가져옴
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
                    // 에러 처리
                    Console.WriteLine($"오류 발생: {ex.Message}");
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
