using Core.Entities;
using System.Collections.Generic;
using System.Text;
//JWT jason web token
namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //Kullanıcı adı ve parola girip girince bu method calısıcak.
        //Bu kullanıcın bilgilerini ve rollerini bulucak ve orada token uretecek. Ve onları vericek.
        //Biz user core verdik cunku burada kullanıyoruz. Ve bu her core projesinde kullanılır.
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
