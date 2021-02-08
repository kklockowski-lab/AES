using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.AESImplement.MatrixOperation
{
    public class Matrix : ICloneable
    {
        private byte[,] matrix = new byte[4, 4];

        public Matrix()
        {

        }
        public Matrix(byte[] bytes)
        {
            // TODO: gdy bytes inne niż 16 bajów
            matrix[0, 0] = bytes[0];
            matrix[0, 1] = bytes[1];
            matrix[0, 2] = bytes[2];
            matrix[0, 3] = bytes[3];
            matrix[1, 0] = bytes[4];
            matrix[1, 1] = bytes[5];
            matrix[1, 2] = bytes[6];
            matrix[1, 3] = bytes[7];
            matrix[2, 0] = bytes[8];
            matrix[2, 1] = bytes[9];
            matrix[2, 2] = bytes[10];
            matrix[3, 3] = bytes[11];
            matrix[3, 0] = bytes[12];
            matrix[3, 1] = bytes[13];
            matrix[3, 2] = bytes[14];
            matrix[3, 3] = bytes[15];
        }

        public byte this[int i, int j]
        {
            get => matrix[i, j];
            set => matrix[i, j] = value;
        }


        public void SwitchRows()
        {
            byte buff = 0x00;
            for (int i = 1; i < 4; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    buff = matrix[i, 0];
                    matrix[i, 0] = matrix[i, 1];
                    matrix[i, 1] = matrix[i, 2];
                    matrix[i, 2] = matrix[i, 3];
                    matrix[i, 3] = buff;
                    //matrix[i, 3 - j] = matrix[i, j];
                    //matrix[i, j] = buff;
                }
            }
        }

        public void MixColumns()
        {
            for (int j = 0; j < 4; ++j)
            {
                byte a = gmul(2, matrix[0, j]);
                byte b = gmul(3, matrix[1, j]);
                byte c = matrix[2, j];
                byte d = matrix[3, j];

                matrix[0, j] = (byte)(gmul(2, matrix[0, j]) ^ gmul(3, matrix[1, j]) ^ matrix[2, j] ^ matrix[3, j]);
                matrix[1, j] = (byte)((matrix[0, j]) ^ gmul(2, matrix[1, j]) ^ gmul(3,matrix[2, j]) ^ matrix[3, j]);
                matrix[2, j] = (byte)( matrix[0, j] ^ matrix[1, j] ^ gmul(2, matrix[2, j]) ^ gmul(3,  matrix[3, j])); 
                matrix[3, j] = (byte)(gmul(3, matrix[0, j]) ^  matrix[1, j] ^ matrix[2, j] ^ gmul(2, matrix[3, j]));
            }
        }

        public void SubBytes(SBox sbox)
        {
            for(int i=0;i<4;++i)
            {
                for(int j=0;j<4;++j)
                {
                    matrix[i, j] = sbox.SubBytes(matrix[i, j]);
                }
            }
           


        }

        public object Clone()
        {
            Matrix cloneMatrix = new Matrix();
            cloneMatrix.matrix = (byte[,])this.matrix.Clone();
            return cloneMatrix;
        }


        // TODO: Sprawdzić to dokladnie, bo czasem daje inne wyniki niż spodziewane.
        // Na podstawie: https://en.wikipedia.org/wiki/Finite_field_arithmetic
        private byte gmul(byte a, byte b)
        {
            byte p = 0; /* the product of the multiplication */
            while (a * b != 0)
            {
                if (b %2 == 1) /* if b is odd, then add the corresponding a to p (final product = sum of all a's corresponding to odd b's) */
                    p ^= a; /* since we're in GF(2^m), addition is an XOR */

                if (a > 0x80) /* GF modulo: if a >= 128, then it will overflow when shifted left, so reduce */
                    a = (byte)((a << 1) ^ 0x11B); /* XOR with the primitive polynomial x^8 + x^4 + x^3 + x + 1 (0b1_0001_1011) – you can change it but it must be irreducible */
                else
                    a <<= 1; /* equivalent to a*2 */
                b >>= 1; /* equivalent to b // 2 */
            }
            return p;
        }
    }
}
