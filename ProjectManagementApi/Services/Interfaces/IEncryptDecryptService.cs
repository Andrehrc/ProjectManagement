using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography;
using System.Text;

namespace ProjectManagementApi.Services.Interfaces
{
    public interface IEncryptDecryptService
    {
        string Encrypt(string simpletext);
        string Decrypt(string entryText);
    }
}
