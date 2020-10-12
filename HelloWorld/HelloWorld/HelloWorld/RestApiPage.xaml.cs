using HelloWorld.Models.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestApiPage : ContentPage
    {
        private const string apiUrl = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient client = new HttpClient();
        private ObservableCollection<Post> posts;

        public RestApiPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await client.GetStringAsync(apiUrl);
            this.posts = new ObservableCollection<Post>(JsonConvert.DeserializeObject<List<Post>>(content));
            postsListView.ItemsSource = this.posts;

            base.OnAppearing();
        }

        // bad practice
        async void AddPost(object sender, EventArgs e)
        {
            var post = new Post
            {
                Title = "New " + DateTime.Now.ToLongTimeString(),
                Body = "hey"
            };

            var contentToSend = JsonConvert.SerializeObject(post);
            await this.client.PostAsync(apiUrl, new StringContent(contentToSend));

            this.posts.Insert(0, post);
        }

        async void UpdatePost(object sender, EventArgs e)
        {
            var post = this.posts[0];
            post.Title += " Updated by me";

            var contentToSend = JsonConvert.SerializeObject(post);
            await this.client.PostAsync(apiUrl + "/" + post.Id, new StringContent(contentToSend));
        }

        async void DeletePost(object sender, EventArgs e)
        {
            var post = this.posts[0];

            await this.client.DeleteAsync(apiUrl + "/" + post.Id);

            this.posts.Remove(post);
        }
    }
}