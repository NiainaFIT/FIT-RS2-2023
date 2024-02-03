using AutoMapper;
using eProdaja.Infrastructure.Database;
using Db = eProdaja.Infrastructure.Entities;
using eProdaja.Model.Requests;
using eProdaja.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace eProdaja.Services.Services
{
    public class KorisniciService : IKorisniciService
    {
        EProdajaContext _context;
        public IMapper _mapper { get; set; }
        public KorisniciService(EProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Model.Korisnici>> Get()
        {
            var korisnici = await _context.Korisnici.ToListAsync();
            return _mapper.Map<List<Model.Korisnici>>(korisnici);
        }

        public async Task<Model.Korisnici> Insert(KorisniciInsertRequest request)
        {
            var korisnik = new Db.Korisnici();
            _mapper.Map(request, korisnik);

            byte[] salt = GenerateSalt();
            string saltString = BitConverter.ToString(salt).Replace("-", "");

            // Generate the hashed password
            string hashedPassword = GeneratePasswordHash(request.Password, salt);
            korisnik.LozinkaSalt = saltString;
            korisnik.LozinkaHash = hashedPassword;

            await _context.AddAsync(korisnik);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Korisnici>(korisnik);
        }

        static byte[] GenerateSalt()
        {
            byte[] salt = new byte[16]; // 16 bytes salt (128 bits)
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        static string GeneratePasswordHash(string password, byte[] salt)
        {
            byte[] saltedPassword = new byte[salt.Length + Encoding.UTF8.GetByteCount(password)];
            Buffer.BlockCopy(salt, 0, saltedPassword, 0, salt.Length);
            Buffer.BlockCopy(Encoding.UTF8.GetBytes(password), 0, saltedPassword, salt.Length, Encoding.UTF8.GetByteCount(password));

            using (var sha512 = new SHA512Managed())
            {
                byte[] hashedPassword = sha512.ComputeHash(saltedPassword);
                return BitConverter.ToString(hashedPassword).Replace("-", "").ToLower();
            }
        }

        public async Task<Model.Korisnici> Update(int id, KorisniciUpdateRequest request)
        {
            var entity = await _context.Korisnici.FindAsync(id);

            _mapper.Map(request, entity);

            await _context.SaveChangesAsync();
            return _mapper.Map<Model.Korisnici>(entity);
        }
    }
}
