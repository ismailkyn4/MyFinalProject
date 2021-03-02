using Core.Entities.Concrete;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims); //ilgili kullanıcı için, ilgili kullanıcının claimlerini içerecek bir token üretecek
    }
}
