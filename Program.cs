using Newtonsoft.Json.Linq;

HttpClient client = new HttpClient();
string url = "https://apilist.tronscanapi.com/api/transaction-info?hash=853793d552635f533aa982b92b35b00e63a1c1add062c099da2450a15119bcb2";

HttpResponseMessage request = await client.GetAsync(url);
string response = await request.Content.ReadAsStringAsync();
JObject transactData = JObject.Parse(response);
string riskLevel = transactData["noteLevel"]?.ToString() ?? "Риск неизвестен";

Console.WriteLine(riskLevel);