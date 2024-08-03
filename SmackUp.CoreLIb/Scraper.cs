using System.Diagnostics;
using HtmlAgilityPack;

namespace SmackUp.CoreLIb;
public class Scraper
{
    private string BaseUrl => "https://watchwrestlingup.org/";
    public async void ShowList(string Query, int Page)
    {
        string url = ParseQuery(Query);
        using (var http = new HttpClient())
        {
            string response = await http.GetStringAsync(url);
            HtmlDocument htmlDoc = new();
            htmlDoc.LoadHtml(response);

            var thumbs = htmlDoc.DocumentNode.SelectNodes("//div[@class='thumb']");
            foreach (var thumb in thumbs)
            {
                Debug.WriteLine(thumb.InnerHtml);
            }
        }
    }
    
    private string ParseQuery(string Query)
    {
        switch (Query)
        {
            case "main-shows":
                //https://watchwrestlingup.org/category/_wrestling_main/
                return BaseUrl + "/category/_wrestling_main/";
                break;
        }

        return BaseUrl;
    }
}