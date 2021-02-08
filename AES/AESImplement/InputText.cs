using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.AESImplement.MatrixOperation;

namespace AES.AESImplement
{
    public class InputText
    {
        public List<Matrix> matrixList { get; set; }
        private string inputText;

        public InputText(string inputText)
        {
            this.inputText = inputText;
            divideToBlock(inputText);
        }

        /// <summary>
        /// Dzielnie tesktu na zestaw macierzy 4x4 bajty 
        /// </summary>
        /// <param name="inputText"></param>
        private void divideToBlock(string inputText)
        {
            if (string.IsNullOrEmpty(inputText)) return;

            matrixList = new List<Matrix>();
            
            byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(inputText);
            
            int blockSize = 16;
            bool isRest = false;

            for (int i = 0; i < textBytes.Length; i +=16)
            {
                byte[] buff = new byte[16];
                int diff = textBytes.Length - i;

                // jeśli długość tekstu w bajtach nie jest podzielna przez 16
                if(diff>0 && diff<16)
                {
                    blockSize = diff;
                    isRest = true;
                }


                int j = 0;
                for (; j < blockSize; ++j)
                {
                    buff[j] = textBytes[i + j];
                }

                if (isRest)
                {
                    // to dopisuje zera do ostaniego bloku
                    for (; j < 16 - blockSize - 1; ++j)
                    {
                        buff[j] = 0x00;
                        ++i;
                    }
                }
    

                Matrix m = new Matrix(buff);
                matrixList.Add(m);
            }

            SBox s = new SBox();
            int bn = s.SubBytes(10);

        }
    }
}
