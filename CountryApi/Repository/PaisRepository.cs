using CountryApi.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace CountryApi.Repository
{
    public class PaisRepository
    {
        public string URL = "https://restcountries.com/v2/";

        public List<PaisModel> FindAll()
        {
            var rest = new RestClient(URL);
            var request = new RestRequest("all", Method.GET);
            var response = rest.Execute(request);
            List<PaisModel> paisModel = JsonConvert.DeserializeObject<List<PaisModel>>(response.Content);
            return paisModel;
        }
    }
}
