//week 14 - 12.2.24

//API stuff
using System.Text.Json;

string endpoint = @"https://api.api-ninjas.com/v1/goldprice";
string animalEndpoint = @"https://api.api-ninjas.com/v1/animals?name=cheetah";
string apiKey = "R2x138NKUkZWWpZCXHVsNQ==okp7CSARHvkyo2sJ";


HttpClient client = new HttpClient();//creates an object to query web request
client.BaseAddress = new Uri(animalEndpoint);//uri - universal resource identifier   //link the client object with the API endpoint
client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));//set header value to return JSON
client.DefaultRequestHeaders.Add("X-API-Key", apiKey);////set headers: provide API key
HttpResponseMessage response = await client.GetAsync("");


string data = await response.Content.ReadAsStringAsync();//Read the content as a string   //similar to a converttoint  
// //await makes you wait until moving on to the nect thing
// Console.WriteLine(data);
AnimalResponse[] animalData = JsonSerializer.Deserialize<AnimalResponse[]>(data);
Console.WriteLine(animalData[0].name);
// Console.WriteLine(animalData[0].locations[0]);
foreach(string place in animalData[0].locations)
    Console.WriteLine(place);
//mnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmnmn
//

// GoldPriceResponse goldData = JsonSerializer.Deserialize<GoldPriceResponse>(data);
// Console.WriteLine(goldData.price);
// Console.WriteLine(goldData.updated);

class GoldPriceResponse
{
    public double price {get; set;}
    public long updated {get; set;}
}//class GoldPriceResponse

class AnimalResponse
{
    public string name {get; set;}
    public string[] locations {get; set;}
}