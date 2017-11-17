using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace BBS
{
    public static class CryptoStore
    {
        private static string cryptoKey = "";

        public static bool SaveObject(Object o, string name)
        {
            bool success = true;

            CryptoStream crStream = null;
            FileStream fs = null;
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                if (cryptoKey == "")
                {
                    throw new InvalidOperationException("Encryptie / decryptie key niet beschikbaar in code -> vul er een in.");
                }

                fs = File.Open(name + ".crypt", FileMode.Create);

                DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
                cryptic.Key = ASCIIEncoding.ASCII.GetBytes(cryptoKey);
                cryptic.IV = ASCIIEncoding.ASCII.GetBytes(cryptoKey);

                crStream = new CryptoStream(fs, cryptic.CreateEncryptor(), CryptoStreamMode.Write);

                bf.Serialize(crStream, o);

                crStream.FlushFinalBlock();
            }
            catch (Exception e)
            {
                MessageBoxCreator.RaiseError("Saven is mislukt!! Paniek!",e);
                success = false;
            }
            finally
            {
                if (crStream != null)
                    crStream.Close();
            }
            return success;
        }

        public static Object LoadObject(string name)
        {
            Logger.Log("Loading...");

            FileStream fs = null;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = null;
            CryptoStream crStream = null;
            bf.Binder = new AssemblyRedirectBinder();

            try
            {
                if (cryptoKey == "")
                {
                    throw new InvalidOperationException("Encryptie / decryptie key niet beschikbaar in code -> vul er een in.");
                }

                fs = File.Open(name + ".crypt", FileMode.Open);

                DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
                cryptic.Padding = PaddingMode.None;
                cryptic.Key = ASCIIEncoding.ASCII.GetBytes(cryptoKey);
                cryptic.IV = ASCIIEncoding.ASCII.GetBytes(cryptoKey);

                crStream = new CryptoStream(fs, cryptic.CreateDecryptor(), CryptoStreamMode.Read);                            

                obj = bf.Deserialize(crStream);
                
            }
            catch (Exception e)
            {
                MessageBoxCreator.RaiseError("Data laden mislukt", e);
            }
            finally
            {
                try
                {
                    if (crStream != null)
                        crStream.Close();
                }
                catch (Exception e)
                {
                    Logger.Log(e.ToString());
                }
            }

            return obj;
        }
    }

    public class AssemblyRedirectBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            //assembly redirect: from BBS to BBS.Core
            var oldBBSAssembly = "BBS, Version";
            var newBBSAssembly = "BBS.Core, Version";

            if (assemblyName.StartsWith(oldBBSAssembly))
            {
                return this.GetType().Assembly.GetType(typeName, true);
            }
            else if (typeName.Contains(oldBBSAssembly))
            {
                typeName = typeName.Replace(oldBBSAssembly, newBBSAssembly);
            }
            return Type.GetType(String.Format("{0}, {1}", typeName, assemblyName));
        }
    }
}
