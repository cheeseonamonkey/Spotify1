using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify1
{
    class AccessToken
    {

        public string access_token { get; set; }
        public string token_type { get; set; }
        public long expires_in { get; set; }

        //list of scopes - https://developer.spotify.com/documentation/general/guides/scopes/
        public string scope { get; set; }
    }
}
