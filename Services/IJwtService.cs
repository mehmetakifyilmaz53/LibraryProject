using LibraryProject.Models;

namespace LibraryProject.Services
{
    public interface IJwtService
    {
        string GenerateJwtToken(User user);
    }
}
