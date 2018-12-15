using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace LIST.Classes.Encryption
{
    public static class UNIALGO1
    {

        public static string Encrypt<T>(string input, string key, string salt) where T : SymmetricAlgorithm, new()
        {

            DeriveBytes rgb = new Rfc2898DeriveBytes(key, Encoding.Unicode.GetBytes(salt));
            var algorithm = new T();

            byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
            byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);
            ICryptoTransform transform = algorithm.CreateEncryptor(rgbKey, rgbIV);

            using (MemoryStream buffer = new MemoryStream())
            {
                using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
                    {
                        writer.Write(input);
                    }
                }
                return Convert.ToBase64String(buffer.ToArray());

            }

        }
        public static string Decrypt<T>(string input, string key, string salt) where T : SymmetricAlgorithm, new()
        {
            DeriveBytes rgb = new Rfc2898DeriveBytes(key, Encoding.Unicode.GetBytes(salt));
            var algorithm = new T();

            byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
            byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);
            ICryptoTransform transform = algorithm.CreateEncryptor(rgbKey, rgbIV);

            using (MemoryStream buffer = new MemoryStream(Convert.FromBase64String(input)))
            {
                using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Read))
                {
                    using (StreamReader reader = new StreamReader(stream, Encoding.Unicode))
                    {
                        return reader.ReadToEnd();
                    }
                }

            }
        }
        public static string EncryptIV<T>(string input, string password, string salt) where T : SymmetricAlgorithm, new()
        {
            var algoritm = new T();
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
            byte[] bkey = key.GetBytes(algoritm.KeySize);
            byte[] binput = Encoding.Unicode.GetBytes(input);
            using (algoritm)
            {
                algoritm.Key = bkey;
                algoritm.GenerateIV();
                using (var encryptor = algoritm.CreateEncryptor(algoritm.Key, algoritm.IV))
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(algoritm.IV, 0, algoritm.IV.Length);
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(binput, 0, binput.Length);
                            cs.FlushFinalBlock();
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        public static string DecryptIV<T>(string input, string password, string salt) where T : SymmetricAlgorithm, new()
        {
            var algoritm = new T();
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
            byte[] bkey = key.GetBytes(algoritm.KeySize);

            byte[] binput = Convert.FromBase64String(input);
            using (algoritm)
            {
                algoritm.Key = bkey;
                using (var ms = new MemoryStream(binput))
                {
                    byte[] iv = new byte[algoritm.IV.Length];
                    ms.Read(iv, 0, algoritm.IV.Length);
                    algoritm.IV = iv;

                    using (var decryptor = algoritm.CreateDecryptor(algoritm.Key, algoritm.IV))
                    {
                        using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            byte[] decrypted = new byte[binput.Length];
                            var byteCount = cs.Read(decrypted, 0, binput.Length);
                            return Encoding.Unicode.GetString(decrypted, 0, byteCount);
                        }
                    }
                }
            }
        }

    }







    public static class AES
    {

        public static bool EncryptFile(string inputfile, string outputfile, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(32);

                using (FileStream fsC = new FileStream(outputfile, FileMode.Create))
                {
                    using (var algoritm = Aes.Create())
                    {
                        algoritm.Key = bkey;
                        algoritm.GenerateIV();
                        fsC.Write(algoritm.IV, 0, algoritm.IV.Length);
                        using (CryptoStream cs = new CryptoStream(fsC, algoritm.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (FileStream fsIn = new FileStream(inputfile, FileMode.Open))
                            {
                                byte[] buffer = new byte[1048576];
                                int read;

                                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    cs.Write(buffer, 0, read);
                                }
                                return true;
                            }
                        }

                    }

                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DecryptFile(string inputfile, string outputfile, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(32);

                using (FileStream fsC = new FileStream(inputfile, FileMode.Open))
                {
                    using (var algoritm = Aes.Create())
                    {
                        byte[] bsalt = new byte[algoritm.IV.Length];

                        fsC.Read(bsalt, 0, bsalt.Length);
                        algoritm.Key = bkey;
                        algoritm.IV = bsalt;

                        using (CryptoStream cs = new CryptoStream(fsC, algoritm.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (FileStream fsOut = new FileStream(outputfile, FileMode.Create))
                            {
                                int read;
                                byte[] buffer = new byte[1048576];

                                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    fsOut.Write(buffer, 0, read);

                                }
                                return true;
                            }
                        }

                    }

                }
            }
            catch
            {
                return false;
            }
        }




        public static string Encrypt(string input, string password, string salt)
        {
            try
            {
                var algoritm = Aes.Create();
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(algoritm.BlockSize >> 3);
                byte[] rgbIV = key.GetBytes(algoritm.BlockSize >> 3);

                byte[] binput = Encoding.Unicode.GetBytes(input);
                using (algoritm)
                {
                    algoritm.Key = bkey;
                    algoritm.IV = rgbIV;
                    using (var encryptor = algoritm.CreateEncryptor(algoritm.Key, algoritm.IV))
                    {
                        using (var ms = new MemoryStream())
                        {
                            ms.Write(algoritm.IV, 0, algoritm.IV.Length);
                            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                cs.Write(binput, 0, binput.Length);
                                cs.FlushFinalBlock();
                            }
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }
            catch
            {
                return "Encryption failed.";
            }

        }
        public static string Decrypt(string input, string password, string salt)
        {
            try
            {
                var algoritm = Aes.Create();
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(algoritm.BlockSize >> 3);
                byte[] rgbIV = key.GetBytes(algoritm.BlockSize >> 3);
                byte[] binput = Convert.FromBase64String(input);
                using (algoritm)
                {
                    algoritm.Key = bkey;
                    using (var ms = new MemoryStream(binput))
                    {
                        byte[] iv = new byte[algoritm.IV.Length];
                        ms.Read(iv, 0, algoritm.IV.Length);
                        algoritm.IV = iv;

                        using (var decryptor = algoritm.CreateDecryptor(algoritm.Key, algoritm.IV))
                        {
                            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] decrypted = new byte[binput.Length];
                                var byteCount = cs.Read(decrypted, 0, binput.Length);
                                return Encoding.Unicode.GetString(decrypted, 0, byteCount);
                            }
                        }
                    }
                }
            }
            catch
            {
                return "Decryption failed.";
            }

        }

        public static string EncryptIV(string input, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(32);
                byte[] binput = Encoding.Unicode.GetBytes(input);
                using (var algoritm = System.Security.Cryptography.Aes.Create())
                {
                    algoritm.Key = bkey;
                    algoritm.GenerateIV();
                    using (var encryptor = algoritm.CreateEncryptor(algoritm.Key, algoritm.IV))
                    {
                        using (var ms = new MemoryStream())
                        {
                            ms.Write(algoritm.IV, 0, algoritm.IV.Length);
                            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                cs.Write(binput, 0, binput.Length);
                                cs.FlushFinalBlock();
                            }
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }
            catch
            {
                return "Encryption failed.";
            }
        }
        public static string DecryptIV(string input, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(32);

                byte[] binput = Convert.FromBase64String(input);
                using (var algoritm = System.Security.Cryptography.Aes.Create())
                {
                    algoritm.Key = bkey;
                    using (var ms = new MemoryStream(binput))
                    {
                        byte[] iv = new byte[algoritm.IV.Length];
                        ms.Read(iv, 0, algoritm.IV.Length);
                        algoritm.IV = iv;

                        using (var decryptor = algoritm.CreateDecryptor(algoritm.Key, algoritm.IV))
                        {
                            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] decrypted = new byte[binput.Length];
                                var byteCount = cs.Read(decrypted, 0, binput.Length);
                                return Encoding.Unicode.GetString(decrypted, 0, byteCount);
                            }
                        }
                    }
                }
            }
            catch
            {
                return "Decryption failed.";
            }
        }
    }


    public static class DES
    {
        public static bool EncryptFile(string inputfile, string outputfile, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(8);

                using (FileStream fsC = new FileStream(outputfile, FileMode.Create))
                {
                    using (var algoritm = new DESCryptoServiceProvider())
                    {
                        algoritm.Key = bkey;
                        algoritm.GenerateIV();
                        fsC.Write(algoritm.IV, 0, algoritm.IV.Length);
                        using (CryptoStream cs = new CryptoStream(fsC, algoritm.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (FileStream fsIn = new FileStream(inputfile, FileMode.Open))
                            {
                                byte[] buffer = new byte[1048576];
                                int read;

                                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    cs.Write(buffer, 0, read);
                                }
                                return true;
                            }
                        }

                    }

                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DecryptFile(string inputfile, string outputfile, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(8);

                using (FileStream fsC = new FileStream(inputfile, FileMode.Open))
                {
                    using (var algoritm = new DESCryptoServiceProvider())
                    {
                        byte[] bsalt = new byte[algoritm.IV.Length];
                        fsC.Read(bsalt, 0, bsalt.Length);
                        algoritm.Key = bkey;
                        algoritm.IV = bsalt;

                        using (CryptoStream cs = new CryptoStream(fsC, algoritm.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (FileStream fsOut = new FileStream(outputfile, FileMode.Create))
                            {
                                int read;
                                byte[] buffer = new byte[1048576];

                                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    fsOut.Write(buffer, 0, read);

                                }
                                return true;
                            }
                        }

                    }

                }
            }
            catch
            {
                return false;
            }
        }

        public static string Encrypt(string input, string password, string salt)
        {
            try
            {
                var algoritm = new DESCryptoServiceProvider();
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(algoritm.BlockSize >> 3);
                byte[] rgbIV = key.GetBytes(algoritm.BlockSize >> 3);

                byte[] binput = Encoding.Unicode.GetBytes(input);
                using (algoritm)
                {
                    algoritm.Key = bkey;
                    algoritm.IV = rgbIV;
                    using (var encryptor = algoritm.CreateEncryptor(algoritm.Key, algoritm.IV))
                    {
                        using (var ms = new MemoryStream())
                        {
                            ms.Write(algoritm.IV, 0, algoritm.IV.Length);
                            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                cs.Write(binput, 0, binput.Length);
                                cs.FlushFinalBlock();
                            }
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }
            catch
            {
                return "Encryption failed.";
            }

        }
        public static string Decrypt(string input, string password, string salt)
        {
            try
            {
                var algoritm = new DESCryptoServiceProvider();
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(algoritm.BlockSize >> 3);
                byte[] rgbIV = key.GetBytes(algoritm.BlockSize >> 3);
                byte[] binput = Convert.FromBase64String(input);
                using (algoritm)
                {
                    algoritm.Key = bkey;
                    using (var ms = new MemoryStream(binput))
                    {
                        byte[] iv = new byte[algoritm.IV.Length];
                        ms.Read(iv, 0, algoritm.IV.Length);
                        algoritm.IV = iv;

                        using (var decryptor = algoritm.CreateDecryptor(algoritm.Key, algoritm.IV))
                        {
                            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] decrypted = new byte[binput.Length];
                                var byteCount = cs.Read(decrypted, 0, binput.Length);
                                return Encoding.Unicode.GetString(decrypted, 0, byteCount);
                            }
                        }
                    }
                }
            }
            catch
            {
                return "Decryption failed.";
            }

        }
        public static string EncryptIV(string input, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(8);
                byte[] binput = Encoding.Unicode.GetBytes(input);
                using (var algoritm = new DESCryptoServiceProvider())
                {
                    algoritm.Key = bkey;
                    algoritm.GenerateIV();
                    using (var encryptor = algoritm.CreateEncryptor(algoritm.Key, algoritm.IV))
                    {
                        using (var ms = new MemoryStream())
                        {
                            ms.Write(algoritm.IV, 0, algoritm.IV.Length);
                            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                cs.Write(binput, 0, binput.Length);
                                cs.FlushFinalBlock();
                            }
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }
            catch
            {
                return "Encryption failed.";
            }
        }
        public static string DecryptIV(string input, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(8);

                byte[] binput = Convert.FromBase64String(input);
                using (var algoritm = new DESCryptoServiceProvider())
                {
                    algoritm.Key = bkey;
                    using (var ms = new MemoryStream(binput))
                    {
                        byte[] iv = new byte[algoritm.IV.Length];
                        ms.Read(iv, 0, algoritm.IV.Length);
                        algoritm.IV = iv;

                        using (var decryptor = algoritm.CreateDecryptor(algoritm.Key, algoritm.IV))
                        {
                            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] decrypted = new byte[binput.Length];
                                var byteCount = cs.Read(decrypted, 0, binput.Length);
                                return Encoding.Unicode.GetString(decrypted, 0, byteCount);
                            }
                        }
                    }
                }
            }
            catch
            {
                return "Decryption failed.";
            }
        }
    }


    public static class TRIPLEDES
    {


        public static bool EncryptFile(string inputfile, string outputfile, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(24);

                using (FileStream fsC = new FileStream(outputfile, FileMode.Create))
                {
                    using (var algoritm = new TripleDESCryptoServiceProvider())
                    {
                        algoritm.Key = bkey;
                        algoritm.GenerateIV();
                        fsC.Write(algoritm.IV, 0, algoritm.IV.Length);
                        using (CryptoStream cs = new CryptoStream(fsC, algoritm.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (FileStream fsIn = new FileStream(inputfile, FileMode.Open))
                            {
                                byte[] buffer = new byte[1048576];
                                int read;

                                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    cs.Write(buffer, 0, read);
                                }
                                return true;
                            }
                        }

                    }

                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DecryptFile(string inputfile, string outputfile, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(24);

                using (FileStream fsC = new FileStream(inputfile, FileMode.Open))
                {
                    using (var algoritm = new TripleDESCryptoServiceProvider())
                    {
                        byte[] bsalt = new byte[algoritm.IV.Length];
                        fsC.Read(bsalt, 0, bsalt.Length);
                        algoritm.Key = bkey;
                        algoritm.IV = bsalt;

                        using (CryptoStream cs = new CryptoStream(fsC, algoritm.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (FileStream fsOut = new FileStream(outputfile, FileMode.Create))
                            {
                                int read;
                                byte[] buffer = new byte[1048576];

                                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    fsOut.Write(buffer, 0, read);

                                }
                                return true;
                            }
                        }

                    }

                }
            }
            catch
            {
                return false;
            }
        }

        public static string Encrypt(string input, string password, string salt)
        {
            try
            {
                var algoritm = new TripleDESCryptoServiceProvider();
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(24);
                byte[] rgbIV = key.GetBytes(algoritm.BlockSize >> 3);

                byte[] binput = Encoding.Unicode.GetBytes(input);
                using (algoritm)
                {
                    algoritm.Key = bkey;
                    algoritm.IV = rgbIV;
                    using (var encryptor = algoritm.CreateEncryptor(algoritm.Key, algoritm.IV))
                    {
                        using (var ms = new MemoryStream())
                        {
                            ms.Write(algoritm.IV, 0, algoritm.IV.Length);
                            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                cs.Write(binput, 0, binput.Length);
                                cs.FlushFinalBlock();
                            }
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }
            catch
            {
                return "Encryption failed. ";
            }

        }
        public static string Decrypt(string input, string password, string salt)
        {
            try
            {
                var algoritm = new TripleDESCryptoServiceProvider();
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(24);
                byte[] rgbIV = key.GetBytes(algoritm.BlockSize >> 3);
                byte[] binput = Convert.FromBase64String(input);
                using (algoritm)
                {
                    algoritm.Key = bkey;
                    using (var ms = new MemoryStream(binput))
                    {
                        byte[] iv = new byte[algoritm.IV.Length];
                        ms.Read(iv, 0, algoritm.IV.Length);
                        algoritm.IV = iv;

                        using (var decryptor = algoritm.CreateDecryptor(algoritm.Key, algoritm.IV))
                        {
                            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] decrypted = new byte[binput.Length];
                                var byteCount = cs.Read(decrypted, 0, binput.Length);
                                return Encoding.Unicode.GetString(decrypted, 0, byteCount);
                            }
                        }
                    }
                }
            }
            catch
            {
                return "Decryption failed.";
            }

        }

        public static string EncryptIV(string input, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(24);
                byte[] binput = Encoding.Unicode.GetBytes(input);
                using (var algoritm = new TripleDESCryptoServiceProvider())
                {
                    algoritm.Key = bkey;
                    algoritm.GenerateIV();
                    using (var encryptor = algoritm.CreateEncryptor(algoritm.Key, algoritm.IV))
                    {
                        using (var ms = new MemoryStream())
                        {
                            ms.Write(algoritm.IV, 0, algoritm.IV.Length);
                            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                cs.Write(binput, 0, binput.Length);
                                cs.FlushFinalBlock();
                            }
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }
            catch
            {
                return "Encryption failed.";
            }
        }
        public static string DecryptIV(string input, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(24);

                byte[] binput = Convert.FromBase64String(input);
                using (var algoritm = new TripleDESCryptoServiceProvider())
                {
                    algoritm.Key = bkey;
                    using (var ms = new MemoryStream(binput))
                    {
                        byte[] iv = new byte[algoritm.IV.Length];
                        ms.Read(iv, 0, algoritm.IV.Length);
                        algoritm.IV = iv;

                        using (var decryptor = algoritm.CreateDecryptor(algoritm.Key, algoritm.IV))
                        {
                            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] decrypted = new byte[binput.Length];
                                var byteCount = cs.Read(decrypted, 0, binput.Length);
                                return Encoding.Unicode.GetString(decrypted, 0, byteCount);
                            }
                        }
                    }
                }
            }
            catch
            {
                return "Decryption failed.";
            }
        }
    }


    public static class RC2
    {

        public static bool EncryptFile(string inputfile, string outputfile, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(16);

                using (FileStream fsC = new FileStream(outputfile, FileMode.Create))
                {
                    using (var algoritm = System.Security.Cryptography.RC2.Create())
                    {
                        algoritm.Key = bkey;
                        algoritm.GenerateIV();
                        fsC.Write(algoritm.IV, 0, algoritm.IV.Length);
                        using (CryptoStream cs = new CryptoStream(fsC, algoritm.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (FileStream fsIn = new FileStream(inputfile, FileMode.Open))
                            {
                                byte[] buffer = new byte[1048576];
                                int read;

                                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    cs.Write(buffer, 0, read);
                                }
                                return true;
                            }
                        }

                    }

                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DecryptFile(string inputfile, string outputfile, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(16);

                using (FileStream fsC = new FileStream(inputfile, FileMode.Open))
                {
                    using (var algoritm = System.Security.Cryptography.RC2.Create())
                    {
                        byte[] bsalt = new byte[algoritm.IV.Length];
                        fsC.Read(bsalt, 0, bsalt.Length);
                        algoritm.Key = bkey;
                        algoritm.IV = bsalt;

                        using (CryptoStream cs = new CryptoStream(fsC, algoritm.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (FileStream fsOut = new FileStream(outputfile, FileMode.Create))
                            {
                                int read;
                                byte[] buffer = new byte[1048576];

                                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    fsOut.Write(buffer, 0, read);

                                }
                                return true;
                            }
                        }

                    }

                }
            }
            catch
            {
                return false;
            }
        }
        public static string Encrypt(string input, string password, string salt)
        {
            try
            {
                var algoritm = System.Security.Cryptography.RC2.Create();
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(algoritm.BlockSize >> 3);
                byte[] rgbIV = key.GetBytes(algoritm.BlockSize >> 3);

                byte[] binput = Encoding.Unicode.GetBytes(input);
                using (algoritm)
                {
                    algoritm.Key = bkey;
                    algoritm.IV = rgbIV;
                    using (var encryptor = algoritm.CreateEncryptor(algoritm.Key, algoritm.IV))
                    {
                        using (var ms = new MemoryStream())
                        {
                            ms.Write(algoritm.IV, 0, algoritm.IV.Length);
                            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                cs.Write(binput, 0, binput.Length);
                                cs.FlushFinalBlock();
                            }
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }
            catch
            {
                return "Encryption failed.";
            }

        }
        public static string Decrypt(string input, string password, string salt)
        {
            try
            {
                var algoritm = System.Security.Cryptography.RC2.Create();
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(algoritm.BlockSize >> 3);
                byte[] rgbIV = key.GetBytes(algoritm.BlockSize >> 3);
                byte[] binput = Convert.FromBase64String(input);
                using (algoritm)
                {
                    algoritm.Key = bkey;
                    using (var ms = new MemoryStream(binput))
                    {
                        byte[] iv = new byte[algoritm.IV.Length];
                        ms.Read(iv, 0, algoritm.IV.Length);
                        algoritm.IV = iv;

                        using (var decryptor = algoritm.CreateDecryptor(algoritm.Key, algoritm.IV))
                        {
                            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] decrypted = new byte[binput.Length];
                                var byteCount = cs.Read(decrypted, 0, binput.Length);
                                return Encoding.Unicode.GetString(decrypted, 0, byteCount);
                            }
                        }
                    }
                }
            }
            catch
            {
                return "Decryption failed.";
            }

        }

        public static string EncryptIV(string input, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(16);
                byte[] binput = Encoding.Unicode.GetBytes(input);
                using (var algoritm = System.Security.Cryptography.RC2.Create())
                {
                    algoritm.Key = bkey;
                    algoritm.GenerateIV();
                    using (var encryptor = algoritm.CreateEncryptor(algoritm.Key, algoritm.IV))
                    {
                        using (var ms = new MemoryStream())
                        {
                            ms.Write(algoritm.IV, 0, algoritm.IV.Length);
                            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                cs.Write(binput, 0, binput.Length);
                                cs.FlushFinalBlock();
                            }
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }
            catch
            {
                return "Encryption failed.";
            }
        }
        public static string DecryptIV(string input, string password, string salt)
        {
            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
                byte[] bkey = key.GetBytes(16);

                byte[] binput = Convert.FromBase64String(input);
                using (var algoritm = System.Security.Cryptography.RC2.Create())
                {
                    algoritm.Key = bkey;
                    using (var ms = new MemoryStream(binput))
                    {
                        byte[] iv = new byte[algoritm.IV.Length];
                        ms.Read(iv, 0, algoritm.IV.Length);
                        algoritm.IV = iv;

                        using (var decryptor = algoritm.CreateDecryptor(algoritm.Key, algoritm.IV))
                        {
                            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] decrypted = new byte[binput.Length];
                                var byteCount = cs.Read(decrypted, 0, binput.Length);
                                return Encoding.Unicode.GetString(decrypted, 0, byteCount);
                            }
                        }
                    }
                }
            }
            catch
            {
                return "Decryption failed.";
            }
        }
    }






    public static class HASH
    {
        public static string hashSHA512(string input)
        {
            using (var algoritm = SHA512.Create())
            {
                byte[] binput = algoritm.ComputeHash(Encoding.Unicode.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < binput.Length; i++)
                {
                    builder.Append(binput[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool checkSHA512(string input, string hash)
        {
            string inputhash = hashSHA512(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(inputhash, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string hashSHA384(string input)
        {
            using (var algoritm = SHA384.Create())
            {
                byte[] binput = algoritm.ComputeHash(Encoding.Unicode.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < binput.Length; i++)
                {
                    builder.Append(binput[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool checkSHA384(string input, string hash)
        {
            string inputhash = hashSHA384(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(inputhash, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string hashSHA256(string input)
        {
            using (var algoritm = SHA256.Create())
            {
                byte[] binput = algoritm.ComputeHash(Encoding.Unicode.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < binput.Length; i++)
                {
                    builder.Append(binput[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool checkSHA256(string input, string hash)
        {
            string inputhash = hashSHA256(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(inputhash, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string hashSHA1(string input)
        {
            using (var algoritm = SHA1.Create())
            {
                byte[] binput = algoritm.ComputeHash(Encoding.Unicode.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < binput.Length; i++)
                {
                    builder.Append(binput[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool checkSHA1(string input, string hash)
        {
            string inputhash = hashSHA1(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(inputhash, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string hashMD5(string input)
        {
            using (var algoritm = MD5.Create())
            {
                byte[] binput = algoritm.ComputeHash(Encoding.Unicode.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < binput.Length; i++)
                {
                    builder.Append(binput[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool checkMD5(string input, string hash)
        {
            string inputhash = hashMD5(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(inputhash, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string hashPBKDF2(string password, int iterations = 10000)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(20);
            var hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return Convert.ToBase64String(hashBytes);
        }

        public static bool checkPBKDF2(string password, string hashedPassword)
        {
            //Engine.WriteError("CP: " + password + ":" + hashedPassword +":"+hashPBKDF2(password),"#");
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }

    public static class SPECIAL
    {
        public static string RandomString(int maxSize, bool usecaps = true, bool usenrs = true, bool usesp = true, bool usenc = true)
        {
            string characters = "";
            if (usecaps == true) { characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (usenc == true) { characters += "abcdefghijklmnopqrstuvwxyz"; }
            if (usesp == true) { characters += "!@#$%^&*()!@#$%^&*()!@"; }
            if (usenrs == true) { characters += "01234567890123456789"; }

            char[] chars = new char[62];
            chars = characters.ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        public static string EncryptCeasar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shift);
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        public static string DecryptCeasar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter - shift);
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        public static string EncryptBinary(string input)
        {
            var binaryString = ToBinary(ConvertToByteArray(input, Encoding.ASCII));
            return binaryString;

        }

        public static string DecryptBinary(string input)
        {

            string bin = input.Replace(" ", "");
            var data = GetBytesFromBinaryString(bin);
            var text = Encoding.ASCII.GetString(data);
            return text;


        }

        public static Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }
            return list.ToArray();
        }

        public static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }

        public static String ToBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }
    }
}