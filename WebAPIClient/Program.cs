using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq.Expressions;

private static readonly HttpClient client = new HttpClient();

//namespace WebAPIClient;
class Program
{
    static async Task Main(string[] args)
    {
        await ProcessRepositories();
    }
    private static async Task ProcessRepositories()
    {
        while(true)
        {
            Console.WriteLine("Enter name of pokemon. Enter key for exit");

            var pokemonName = Console.ReadLine();

            if(string.IsNullOrEmpty(pokemonName))
            {
                break;
            }

            var result = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + pokemonName.ToLower());
            var resultRead = await result.Content.ReadAsStringAsync();

            //Console.WriteLine(resultRead);

        }
        catch(Exception)
        {
            Console.WriteLine("ERROR, enter a correct name");
        }

    }
}