using System;
using System.Security.Cryptography;
using System.Configuration;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.UI.WebControls;
using System.Collections;


namespace Services
{
	/// <summary>
	/// Summary description for Utility.
	/// </summary>
	public class Utility
	{
		private PDSAEncryptionType mbytEncryptionType;
		private string mstrOriginalString;
		private string mstrEncryptedString;
		private SymmetricAlgorithm mCSP;

		public enum PDSAEncryptionType : byte
		{
			DES,
			RC2,
			Rijndael,
			TripleDES
		}
        public void CargarCombo(DropDownList combo, IList Lista, string Value, string Text, string InsertaFila)
        {
            combo.DataSource = Lista;
            combo.DataTextField = Text;
            combo.DataValueField = Value;
            combo.DataBind();
            if (InsertaFila != "")
                combo.Items.Insert(0, new ListItem(InsertaFila, "0"));
        }

        public bool IsDecimal( string dato)
        {
            bool band=false;
            try
            {
               Convert.ToDecimal(dato);
               band = true;
             }
            catch
            {
            band= false;
            }
            return band;
        }

		#region " Constructores "

		public Utility()
		{
			mbytEncryptionType = PDSAEncryptionType.DES;

			this.SetEncryptor();
		}

		public Utility(PDSAEncryptionType EncryptionType)
		{
			mbytEncryptionType = EncryptionType;

			this.SetEncryptor();
		}

		public Utility(PDSAEncryptionType EncryptionType, string OriginalString)
		{
			mbytEncryptionType = EncryptionType;
			mstrOriginalString = OriginalString;

			this.SetEncryptor();
		}

		#endregion

		#region " Metodos Anteriores "
        
		public static string EncryptAnterior(string strPass)
		{
			long lngChr;
			string strBuff="";
			string strInput = ConfigurationSettings.AppSettings["encKey"];
			strPass = strPass.ToUpper();

			if(strPass.Length != 0) 
			{
				for(int intCnt=0;intCnt<strInput.Length;intCnt++)
				{
					int intStart = intCnt % strPass.Length; lngChr = Convert.ToInt64(strInput.Substring(intCnt,1)[0]); // [0] for to avoid "" from the input, e.g., "S" ==> 'S'
					// To avoid index is not found exception
					if(intStart == (strPass.Length -1))
						lngChr = lngChr + Convert.ToInt64(strPass.Substring(intStart,1)[0]); // [0] for to avoid "" from the input, e.g., "S" ==> 'S'
					else
						lngChr = lngChr + Convert.ToInt64(strPass.Substring(intStart+1,1)[0]); // [0] for to avoid "" from the input, e.g., "S" ==> 'S' 

					strBuff = strBuff + (char)(lngChr & Convert.ToInt64("0xFF", 16));// AND wif 0xFF
				}
			}
			else
				strBuff = strInput;

			return strBuff;
		}

		public static string DecryptAnterior(string strPass) 
		{
			string strBuff="";
			string strInput = ConfigurationSettings.AppSettings["encKey"];
			long lngChr; strPass = strPass.ToUpper();
			if(strPass.Length != 0)
			{
				for(int intCnt=0;intCnt<strInput.Length;intCnt++)
				{ 
					int intStart = intCnt % strPass.Length;

					lngChr = Convert.ToInt64(strInput.Substring(intCnt,1)[0]);// [0] for to avoid "" from the input, e.g., "S" ==> 'S'

					// To avoid index is not found exception
					if(intStart == (strPass.Length -1))
						lngChr = lngChr - Convert.ToInt64(strPass.Substring(intStart,1)[0]);// [0] for to avoid "" from the input, e.g., "S" ==> 'S'
					else
						lngChr = lngChr - Convert.ToInt64(strPass.Substring(intStart+1,1)[0]); // [0] for to avoid "" from the input, e.g., "S" ==> 'S' 

					strBuff = strBuff + (char)(lngChr & Convert.ToInt64("0xFF", 16));// AND wif 0xFF

				}

			}
			else

				strBuff = strInput;

			return strBuff; 
		}


		#endregion

		#region " Propiedades Publicas "

		public PDSAEncryptionType EncryptionType
		{
			get {return mbytEncryptionType;}
			set
			{
				if (mbytEncryptionType != value) 
				{
					mbytEncryptionType = value;
					mstrOriginalString = String.Empty;
					mstrEncryptedString = String.Empty;

					this.SetEncryptor();
				}
			}
		}

		public SymmetricAlgorithm CryptoProvider
		{
			get {return mCSP;}
			set {mCSP = value;}
		}

		public string OriginalString
		{
			get {return mstrOriginalString;}
			set {mstrOriginalString = value;}
		}

		public string EncryptedString
		{
			get {return mstrEncryptedString;}
			set {mstrEncryptedString = value;}
		}

		public byte[] key
		{
			get {return mCSP.Key;}
			set {mCSP.Key = value;}
		}

		public string KeyString
		{
			get {return Convert.ToBase64String(mCSP.Key);}
			set {mCSP.Key = Encoding.UTF8.GetBytes(value);}
		}

		public byte[] IV
		{
			get {return mCSP.IV;}
			set {mCSP.IV = value;}
		}

		public string IVString
		{
			get {return Convert.ToBase64String(mCSP.IV);}
			set {mCSP.IV = Encoding.UTF8.GetBytes(value);}
		}

		#endregion

		#region " Metodos de Encriptacion "

		public string Encrypt()
		{
			ICryptoTransform ct;
			MemoryStream ms;
			CryptoStream cs;
			byte[] byt;

			ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV);

			byt = Encoding.UTF8.GetBytes(mstrOriginalString);

			ms = new MemoryStream();
			cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
			cs.Write(byt, 0, byt.Length);
			cs.FlushFinalBlock();
			cs.Close();

			mstrEncryptedString = Convert.ToBase64String(ms.ToArray());

			return mstrEncryptedString;
		}

		public string Encrypt(string OriginalString)
		{
			mstrOriginalString = OriginalString;
      
			return this.Encrypt();
		}

		public string Encrypt(string OriginalString, PDSAEncryptionType EncryptionType)
		{
			mstrOriginalString = OriginalString;
			mbytEncryptionType = EncryptionType;

			return this.Encrypt();
		}

		#endregion

		#region " Metodos de Desencriptacion "

		public string Decrypt()
		{
			ICryptoTransform ct;
			MemoryStream ms;
			CryptoStream cs;
			byte[] byt;

			ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV);

			byt = Convert.FromBase64String(mstrEncryptedString);

			ms = new MemoryStream();
			cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
			cs.Write(byt, 0, byt.Length);
			cs.FlushFinalBlock();
			cs.Close();

			mstrOriginalString = Encoding.UTF8.GetString(ms.ToArray());

			return mstrOriginalString;
		}

		public string Decrypt(string EncryptedString)
		{
			mstrEncryptedString = EncryptedString;
            //return mstrEncryptedString;
		    return this.Decrypt();
		}

		public string Decrypt(string EncryptedString, PDSAEncryptionType EncryptionType)
		{
			mstrEncryptedString = EncryptedString;
			mbytEncryptionType = EncryptionType;

			return this.Decrypt();
		}

		#endregion

		#region " Metodo SetEncryptor() "

		private void SetEncryptor()
		{
			switch(mbytEncryptionType)
			{
				case PDSAEncryptionType.DES:
					mCSP = new DESCryptoServiceProvider();
					break;
				case PDSAEncryptionType.RC2:
					mCSP = new RC2CryptoServiceProvider();
					break;
				case PDSAEncryptionType.Rijndael:
					mCSP = new RijndaelManaged();
					break;
				case PDSAEncryptionType.TripleDES:
					mCSP = new TripleDESCryptoServiceProvider();
					break;
			}
      
			// Generate Key
			this.GenerateKey();

			// Generate IV
			this.GenerateIV();
		}
		#endregion

		#region " Metodos Publicos Varios "

		public byte[] GenerateKey()
		{
			try
			{
				int x = 0;
				char[] chars = ConfigurationSettings.AppSettings["encKey"].ToCharArray();
				byte[] bits = new byte[chars.Length];
				foreach (char c in chars)
				{
					bits[x] = Convert.ToByte(c);
					x += 1;
				}
										  
				mCSP.Key = bits;

				return mCSP.Key;
			}
			catch (Exception ex)
			{
				if (ex.GetType().Name.Equals("ArgumentException"))
					throw new Exception("La clave encKey debe tener 8 digitos"); 
				else
					throw new Exception("Clave encKey en Archivo de Configuracion no implementada"); 
			}
		}

		public byte[] GenerateIV()
		{
			try
			{
				int x = 0;
				char[] chars = ConfigurationSettings.AppSettings["encKey"].ToCharArray();
				byte[] bits = new byte[chars.Length];
				foreach (char c in chars)
				{
					bits[x] = Convert.ToByte(c);
					x += 1;
				}
										  
				mCSP.IV = bits;

				return mCSP.IV;
			}
			catch (Exception ex)
			{
				if (ex.GetType().Name.Equals("ArgumentException"))
					throw new Exception("La clave encKey debe tener 8 digitos"); 
				else
					throw new Exception("Clave encKey en Archivo de Configuracion no implementada"); 
			}
		}

		#endregion
	}
}
