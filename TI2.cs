using System;
using System.Windows.Forms;

namespace TI
{
    public partial class Lab2 : Form
    {
        Key keys = new Key();
        private ulong[] _cipher;
        public Lab2()
        {
            InitializeComponent();
        }

        static ulong[] MainFunc(ulong[] source, long[] key)
        {
            ulong[] result = new ulong[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                result[i] = Power(source[i], (ulong)key[0], (ulong)key[1]);
            }

            return result;
        }
        
        private void GenerateKey(object sender, EventArgs e)
        {
            keys.CreateKey();
            publicKey_field.Text = keys.PublicKey[0].ToString() + @", " + keys.PublicKey[1].ToString();
            privateKey_field.Text = keys.PrivateKey[0].ToString() + @", " + keys.PrivateKey[1].ToString();
        }

        //шифрование
        private void encrypt_Text(object sender, EventArgs e)
        {
            string inptext = inText_field.Text;
            ulong[] source = new ulong[inptext.Length];

            for (int i = 0; i < inptext.Length; i++)
            {
                source[i] = inptext[i];
            }

            _cipher = MainFunc(source, keys.PublicKey);

            encryptText_field.Text = "";

            for (int i = 0; i < inptext.Length; i++)
            {
                encryptText_field.Text += _cipher[i] + @" ";
            }
        }

        //дешифрование
        private void decrypt_Text(object sender, EventArgs e)
        {
            ulong[] text;

            text = MainFunc(_cipher, keys.PrivateKey);

            decryptText_field.Text = "";

            for (int i = 0; i < text.Length; i++)
            {
                decryptText_field.Text += (char)text[i];
            }
        }
        static ulong Power(ulong number, ulong pow, ulong mod)
        {
            ulong result = 1;
            ulong bit = number % mod;

            while (pow > 0)
            {
                if ((pow & 1) == 1)
                {
                    result *= bit;
                    result %= mod;
                }
                bit *= bit;
                bit %= mod;
                pow >>= 1;
            }
            return result;
        }
    }
}
