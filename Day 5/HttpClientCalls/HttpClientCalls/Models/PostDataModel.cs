namespace HttpClientCalls.Models
{
    public class PostDataModel
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        static List<PostDataModel> pList = new List<PostDataModel>();

        public List<PostDataModel> GetPostData()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear(); // clear the default type from the calling environment
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var makeCall = client.GetAsync(url).Result; //make a call 

            //check if call is getting successful, else throw exception
            if (makeCall.IsSuccessStatusCode)
            {
                var readData = makeCall.Content.ReadAsAsync<List<PostDataModel>>(); //this line  show error because we need to add a nuget package 
                readData.Wait();
                pList = readData.Result;              

            }
            else
            {
                throw new Exception("Call failed, please contact Admin");
            }


            return pList; 

        }
    }
}
