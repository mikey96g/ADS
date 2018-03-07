using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FourmClient
{
    class FourmClient
    {
        //static async Task GetAllPostsAsync()
        //{
        //    try
        //    {
        //        using (HttpClient client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri("http://localhost:62173");
        //            //accept header
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //            HttpResponseMessage response = await client.GetAsync("forum/all");
        //            if (response.IsSuccessStatusCode)
        //            {
        //                fourm[] post = response.Content.ReadAsAsync<fourm[]>().Result;
        //                Console.WriteLine("\nList of posts:\n");
        //                foreach (var p in post)
        //                {
        //                    Console.WriteLine("{0}\n {1}\n {2}\n {3},\n", p.ID, p.Subject, p.Message, p.Timestamp);
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine(response.StatusCode + " " + response.ReasonPhrase);
        //            }

        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //}

        //static async Task GetLastPostsAsync(int numberPosts)
        //{
        //    try
        //    {
        //        using (HttpClient client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri("http://localhost:62173");

        //            //accept header
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //            HttpResponseMessage response = await client.GetAsync("forum/last/" + numberPosts);

        //            if (response.IsSuccessStatusCode)
        //            {
        //                //parse result
        //                fourm[] posts = response.Content.ReadAsAsync<fourm[]>().Result;
        //                Console.WriteLine("\nLast " + numberPosts + " posts:\n");
        //                foreach (var p in posts)
        //                {
        //                    Console.WriteLine("{0}\n {1}\n {2}\n {3},\n", p.ID, p.Subject, p.Message, p.Timestamp);
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine(response.StatusCode + " " + response.ReasonPhrase);
        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //}

        //static async Task AddPostAsync(String subject, String message)
        //{
        //    try
        //    {
        //        using (HttpClient client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri("http://localhost:62173");

        //            //accept header
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //            fourm newPost = new fourm() { Subject = subject, Message = message };
        //            HttpResponseMessage response = await client.PostAsJsonAsync("forum", newPost);
        //            if (response.IsSuccessStatusCode)
        //            {
        //                Uri newPostUri = response.Headers.Location;
        //                var post = await response.Content.ReadAsAsync<fourm>();
        //                Console.WriteLine("URI for new resource: " + newPostUri.ToString());
        //                Console.WriteLine("resource " + post.ID + " " + post.Subject);
        //            }
        //            else
        //            {
        //                Console.WriteLine(response.StatusCode + " " + response.ReasonPhrase);
        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //}
        //static async Task UpdatePostAsync(int id, String subject, String message)
        //{
        //    try
        //    {
        //        using (HttpClient client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri("http://localhost:62173");


        //            fourm newPost = new fourm() { ID = id, Subject = subject, Message = message };
        //            HttpResponseMessage response = await client.PutAsJsonAsync("forum", newPost);
        //            if (response.IsSuccessStatusCode)
        //            {
        //                Console.WriteLine("\nUpdated post " + id + "\n");
        //            }
        //            else
        //            {
        //                Console.WriteLine(response.StatusCode + " " + response.ReasonPhrase);
        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //}


    }

}
