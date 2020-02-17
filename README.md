# AxesSharp
One api to simplify the consuming of rest services in C#  .Net Framework Core 3.1. 

Exemple Get:

Console Main.cs:
```
using System;
using AxesSharp;

namespace AxesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiClient api = new ApiClient();
            var x =  api.Get<UserGitHub>(" https://api.github.com/users/aaluiz").Result;
            Console.WriteLine(x.Name);
            Console.ReadLine();
        }
    }
}

```
UserGitHub.cs
```
using System;
using System.Collections.Generic;
using System.Text;

namespace AxesConsole
{
    public class UserGitHub
    {
        public string Login { get; set; }
        public string Id { get; set; }
        public string Node_id { get; set; }
        public string Avatar_url { get; set; }
        public string Gravatar_id { get; set; }
        public string Url { get; set; }
        public string Html_url { get; set; }
        public string Followers_url { get; set; }
        public string Following_url { get; set; }
        public string Gists_url { get; set; }
        public string Starred_url { get; set; }
        public string Subscriptions_url { get; set; }
        public string Organizations_url { get; set; }
        public string Repos_url { get; set; }
        public string Events_url { get; set; }
        public string Received_events_url { get; set; }
        public string Type { get; set; }
        public bool Site_admin { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Blog { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Hireable { get; set; }
        public string Bio { get; set; }
        public long Public_repos { get; set; }
        public long Public_gists { get; set; }
        public long Followers { get; set; }
        public long Following { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
```
