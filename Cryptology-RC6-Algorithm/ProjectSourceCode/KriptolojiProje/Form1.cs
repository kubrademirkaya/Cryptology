using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptolojiProje
{
    public partial class Form1 : Form
    {
        internal static int w = 32, r = 20;
        internal static int[] S;
        internal static int Pw = unchecked((int)0xb7e15163), Qw = unchecked((int)0x9e3779b9);
        string tempString;
        string text_data;
        string key_value;
        string plaintext;
        string ciphertext;


        // DIGIT

        public static int Digit(char deger, int radix)
        {
            if ((radix <= 0) || (radix > 36))
                return -1;

            if (radix <= 10)
                if (deger >= '0' && deger < '0' + radix)
                    return deger - '0';
                else
                    return -1;
            else if (deger >= '0' && deger <= '9')
                return deger - '0';
            else if (deger >= 'a' && deger <= 'z' && deger < 'a' + radix - 10)
                return deger - 'a' + 10;
            else if (deger >= 'A' && deger <= 'Z' && deger < 'A' + radix - 10)
                return deger - 'A' + 10;
            else if (deger >= '\uFF41' && deger <= '\uFF5A' && deger < '\uFF41' + radix - 10)
                return deger - '\uFF41' + 10;
            else if (deger >= '\uFF21' && deger <= '\uFF3A' && deger < '\uFF21' + radix - 10)
                return deger - '\uFF21' + 10;

            return -1;
        }

        //HEX FORMAT TO BYTE ARRAY

        public static byte[] HexStringToByteArray(string s)
        {
            int stringLength = s.Length;

            byte[] data = new byte[stringLength / 2];

            for (int i = 0; i < stringLength; i += 2)
            {
                data[i / 2] = (byte)((Digit(s[i], 16) << 4) + Digit(s[i + 1], 16));
            }

            return data;
        }

        //BYTE ARRAY TO HEX FORMAT

        public static string ByteArrayToHex(byte[] a)
        {
            StringBuilder sb = new StringBuilder(a.Length * 2);

            foreach (byte b in a)
            {
                sb.Append(string.Format("{0:x2}", b & 0xff));
            }

            return sb.ToString();
        }

        // KEY OLUŞTURMA ALGORİTMASI

        public virtual int[] KeySchedule(byte[] key)
        {

            int[] S = new int[2 * r + 4];
            S[0] = Pw;
            int c = key.Length / (w / 8);
            int[] L = BytestoWords(key, c);

            for (int k = 1; k < (2 * r + 4); k++)
            {
                S[k] = S[k - 1] + Qw;
            }

            int A, B, i, j;
            A = B = i = j = 0;
            int v = 3 * Math.Max(c, (2 * r + 4));
            for (int s = 0; s < v; s++)
            {
                A = S[i] = RotateLeft((S[i] + A + B), 3);
                B = L[j] = RotateLeft((L[j] + A + B), A + B);
                i = (i + 1) % (2 * r + 4);
                j = (j + 1) % c;
            }

            return S;

        }

        // ENCRYPTION 

        public virtual byte[] Encryption(byte[] keySchArray)
        {
            int temp, t, u;
            int[] temp_data = new int[keySchArray.Length / 4];
            for (int i = 0; i < temp_data.Length; i++)
            {
                temp_data[i] = 0;
            }

            temp_data = ConvertBytetoInt(keySchArray, temp_data.Length);

            int A, B, C, D;
            A = B = C = D = 0;

            A = temp_data[0];
            B = temp_data[1];
            C = temp_data[2];
            D = temp_data[3];

            B = B + S[0];
            D = D + S[1];

            int lgw = 5;
            byte[] outputArr = new byte[keySchArray.Length];

            for (int i = 1; i <= r; i++)
            {
                t = RotateLeft(B * (2 * B + 1), lgw);
                u = RotateLeft(D * (2 * D + 1), lgw);
                A = RotateLeft(A ^ t, u) + S[2 * i];
                C = RotateLeft(C ^ u, t) + S[2 * i + 1];

                temp = A;
                A = B;
                B = C;
                C = D;
                D = temp;
            }

            A = A + S[2 * r + 2];
            C = C + S[2 * r + 3];

            temp_data[0] = A;
            temp_data[1] = B;
            temp_data[2] = C;
            temp_data[3] = D;
            outputArr = ConvertIntToByte(temp_data, keySchArray.Length);

            return outputArr;
        }

        //DECRYPTION 

        public virtual byte[] Decryption(byte[] keySchArray)
        {
            int temp, t, u;
            int A, B, C, D;
            A = B = C = D = 0;
            int[] temp_data_decryption = new int[keySchArray.Length / 4];

            for (int i = 0; i < temp_data_decryption.Length; i++)
            {
                temp_data_decryption[i] = 0;
            }

            temp_data_decryption = ConvertBytetoInt(keySchArray, temp_data_decryption.Length);

            A = temp_data_decryption[0];
            B = temp_data_decryption[1];
            C = temp_data_decryption[2];
            D = temp_data_decryption[3];

            C = C - S[2 * r + 3];
            A = A - S[2 * r + 2];

            int lgw = 5;
            byte[] outputArr = new byte[keySchArray.Length];

            for (int i = r; i >= 1; i--)
            {
                temp = D;
                D = C;
                C = B;
                B = A;
                A = temp;

                u = RotateLeft(D * (2 * D + 1), lgw);
                t = RotateLeft(B * (2 * B + 1), lgw);
                C = RotateRight(C - S[2 * i + 1], t) ^ u;
                A = RotateRight(A - S[2 * i], u) ^ t;
            }

            D = D - S[1];
            B = B - S[0];

            temp_data_decryption[0] = A;
            temp_data_decryption[1] = B;
            temp_data_decryption[2] = C;
            temp_data_decryption[3] = D;

            outputArr = ConvertIntToByte(temp_data_decryption, keySchArray.Length);

            return outputArr;
        }

        //INT TO BYTE FORM

        public static byte[] ConvertIntToByte(int[] integerArray, int length)
        {
            byte[] int_to_byte = new byte[length];

            for (int i = 0; i < length; i++)
            {
                int_to_byte[i] = unchecked((byte)(((int)((uint)integerArray[i / 4] >> (i % 4) * 8)) & 0xff));
            }

            return int_to_byte;
        }

        // BYTE TO INT FORM

        private static int[] ConvertBytetoInt(byte[] arr, int length)
        {
            int[] byte_to_int = new int[length];

            for (int j = 0; j < byte_to_int.Length; j++)
            {
                byte_to_int[j] = 0;
            }

            int counter = 0;

            for (int i = 0; i < byte_to_int.Length; i++)
            {
                byte_to_int[i] = ((arr[counter++] & 0xff)) | ((arr[counter++] & 0xff) << 8) | ((arr[counter++] & 0xff) << 16) | ((arr[counter++] & 0xff) << 24);
            }

            return byte_to_int;
        }

        //BYTE TO WORDS

        private static int[] BytestoWords(byte[] userkey, int c)
        {
            int[] bytes_to_words = new int[c];

            for (int i = 0; i < bytes_to_words.Length; i++)
            {
                bytes_to_words[i] = 0;
            }

            for (int i = 0, off = 0; i < c; i++)
            {
                bytes_to_words[i] = ((userkey[off++] & 0xFF)) | ((userkey[off++] & 0xFF) << 8) | ((userkey[off++] & 0xFF) << 16) | ((userkey[off++] & 0xFF) << 24);
            }

            return bytes_to_words;
        }

        // ROTATE LEFT 

        private static int RotateLeft(int val, int pas)
        {
            return (val << pas) | ((int)((uint)val >> (32 - pas)));
        }

        //ROTATE RIGHT 

        private static int RotateRight(int val, int pas)
        {
            return ((int)((uint)val >> pas)) | (val << (32 - pas));
        }



        private void textboxEKey_TextChanged(object sender, EventArgs e)
        {
            key_value = textboxEKey.Text;
        }

        private void textboxEPlainText_TextChanged(object sender, EventArgs e)
        {
            plaintext = textboxEPlainText.Text;
            buttonEncryption.Enabled = true;
        }
        
        private void buttonEncryption_Click(object sender, EventArgs e)
        {
            if (textboxEPlainText.TextLength % 32 != 0 || textboxEKey.TextLength % 32 != 0 || textboxEKey.Text == "")
            {
                MessageBox.Show("Plaintext ve key alanı 32 karakter ve katları sayıda olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textboxEPlainText.Enabled = false;
                textboxEKey.Enabled = false;

                text_data = plaintext;
                tempString = key_value;
                
                byte[] key = HexStringToByteArray(tempString);
                byte[] W = HexStringToByteArray(text_data);
                S = (new Form1()).KeySchedule(key);
                byte[] encrypt = (new Form1()).Encryption(W);
                string encrypted_text = ByteArrayToHex(encrypt);
                encrypted_text = encrypted_text.Replace("..", "$0 ");

                textboxECipherText.Text = encrypted_text;
            }
        }

        private void textboxDCipherText_TextChanged(object sender, EventArgs e)
        {
            ciphertext = textboxDCipherText.Text;
            buttonDecryption.Enabled = true;
        }

        private void buttonDecryption_Click(object sender, EventArgs e)
        {
            if (textboxDCipherText.TextLength % 32 != 0 || textboxEKey.TextLength % 32 != 0 || textboxEKey.Text == "")
            {
                MessageBox.Show("Ciphertext ve key alanı 32 karakter ve katları sayıda olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textboxDCipherText.Enabled = false;
                textboxEKey.Enabled = false;

                text_data = ciphertext;
                tempString = key_value;

                byte[] key2 = HexStringToByteArray(tempString);
                byte[] X = HexStringToByteArray(text_data);
                S = (new Form1()).KeySchedule(key2);
                byte[] decrypt = (new Form1()).Decryption(X);
                string decrypted_text = ByteArrayToHex(decrypt);
                decrypted_text = decrypted_text.Replace("..", "$0 ");

                textboxDPlainText.Text = decrypted_text;
            }
        }

        private void buttonClearKey_Click(object sender, EventArgs e)
        {
            textboxEKey.Clear();
            textboxEKey.Enabled = true;
        }

        private void buttonClearEncryption_Click(object sender, EventArgs e)
        {
            textboxEPlainText.Clear();
            textboxECipherText.Clear();
            textboxEPlainText.Enabled = true;
            buttonEncryption.Enabled = false;
        }

        private void buttonClearDecryption_Click(object sender, EventArgs e)
        {
            textboxDPlainText.Clear();
            textboxDCipherText.Clear();
            textboxDCipherText.Enabled = true;
            buttonDecryption.Enabled = false;
        }

        private void textboxEKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ;
        }

        private void textboxEPlainText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ;
        }

        private void textboxDCipherText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
