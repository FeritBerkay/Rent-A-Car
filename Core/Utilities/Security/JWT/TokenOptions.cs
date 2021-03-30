public partial class JwtHelper
{
    public class TokenOptions
    {
        //Tokenın seceneklerini burada verdik. Yani apı de 
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}