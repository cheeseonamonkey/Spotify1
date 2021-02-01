using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify1
{
    public partial class Form2 : Form
    {
        Requester requester;
        dynamic playlistsObject;
        dynamic playlistSongsObject;
        dynamic trackDetails;

        public Form2()
        {
            InitializeComponent();
        }

        async Task<AccessToken> GetTokenAsync()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "NjZlMWNjNmY2MjE1NDM0MDk2NjU4MTAzM2NiZTg0ZTg6MTE0MjE4OWI4YzUwNGMwN2ExZGRmYzA4OGVlYjM2MWI");

            List<KeyValuePair<string, string>> requestData = new List<KeyValuePair<string, string>>();
            requestData.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            requestData.Add(new KeyValuePair<string, string>("code", Program.GlobalAuthCode));
            requestData.Add(new KeyValuePair<string, string>("redirect_uri", "http://localhost/"));

            FormUrlEncodedContent requestBody = new FormUrlEncodedContent(requestData);

            HttpResponseMessage response = await client.PostAsync("https://accounts.spotify.com/api/token", requestBody);

            string responseData = await response.Content.ReadAsStringAsync();

            client.Dispose();

            return JsonConvert.DeserializeObject<AccessToken>(responseData);

        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            Program.GlobalAccessToken = await GetTokenAsync();

            requester = new Requester();

            string currentUserJson = await requester.MakeRequestAsync("https://api.spotify.com/v1/me");

         //   System.Console.WriteLine(currentUserJson);

            dynamic currentUserObject = JsonConvert.DeserializeObject(currentUserJson);

            lblUserName.Text = currentUserObject.display_name;
            string userUrl = currentUserObject.href;

            string playlistsJson = await requester.MakeRequestAsync(userUrl + "/playlists?limit=50");

         //   System.Console.WriteLine(playlistsJson);

            playlistsObject = JsonConvert.DeserializeObject(playlistsJson);

            lstPlaylists.Items.Clear();

            foreach(var playlist in playlistsObject.items)
            {
                lstPlaylists.Items.Add(playlist.name);
            }


        }

        private async void lstPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstViewPlaylist.Items.Clear();

            int selectedIndex = lstPlaylists.SelectedIndex;

            var playlist = (playlistsObject.items[selectedIndex]);

            lblPlaylistName.Text = playlist.name;

            string playlistSongsJson = await requester.MakeRequestAsync($"https://api.spotify.com/v1/playlists/{playlist.id}/tracks");

            playlistSongsObject = JsonConvert.DeserializeObject(playlistSongsJson);

            
            for(int i=0; i<(int)playlist.tracks.total; i++)
            {
                lstViewPlaylist.Items.Add(playlistSongsObject.items[i].track.name);
            }

            


        }

        private async void lstViewPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstViewPlaylist.SelectedIndex;

            string trackName = (string)playlistSongsObject.items[selectedIndex].track.name;

            // System.Console.WriteLine((string)track.name);

            lblSongName.Text = (string)trackName;

            string trackDetailsJson = await requester.MakeRequestAsync($"https://api.spotify.com/v1/audio-features/{playlistSongsObject.items[selectedIndex].track.id}");

            FillTrackDetails(trackDetailsJson);
        }



        public async void FillTrackDetails(string trackDetailsJson)
        {
            trackDetails = JsonConvert.DeserializeObject(trackDetailsJson);

            lblEnergy.Text = trackDetails.energy;
            lblLiveness.Text = trackDetails.liveness;
            lblSpeechiness.Text = trackDetails.speechiness;
            lblDanceability.Text = trackDetails.danceability;
            lblInstrumentalness.Text = trackDetails.instrumentalness;
            lblValence.Text = trackDetails.valence;
            lblAcousticness.Text = trackDetails.acousticness;

            lblTempo.Text = trackDetails.tempo;
            lblTimeSignature.Text = trackDetails.time_signature;
            lblLoudness.Text = trackDetails.loudness;
        }

        private async void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchResultsJson = await requester.MakeRequestAsync($"https://api.spotify.com/v1/search?q={txtSearch.Text}&type=track&limit=1");
                dynamic searchResults = JsonConvert.DeserializeObject(searchResultsJson);


                string id = (string) searchResults.tracks.items[0].id;
                string trackName = (string)searchResults.tracks.items[0].name;

                lblSongName.Text = (string)trackName;

                string trackDetailsJson = await requester.MakeRequestAsync($"https://api.spotify.com/v1/audio-features/{id}");

                Console.WriteLine(trackDetailsJson);

                FillTrackDetails(trackDetailsJson);



            }
        }

        private async void btnGetSimilar_Click(object sender, EventArgs e)
        {
            string newSongJson = await requester.MakeRequestAsync($"https://api.spotify.com/v1/recommendations?limit=1&seed_tracks={trackDetails.id}");
            dynamic newSong = JsonConvert.DeserializeObject(newSongJson);

            //you are here =============================

            string trackDetailsJson = await requester.MakeRequestAsync($"https://api.spotify.com/v1/audio-features/{newSong.id}");
            FillTrackDetails(trackDetailsJson);

            Console.WriteLine(newSongJson);

        }
    }
}
