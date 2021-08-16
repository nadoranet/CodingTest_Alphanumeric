using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter the Sentence and Hit Enter ");
                string str = Console.ReadLine();
                Console.WriteLine(ConvertStrToAlphanumeric(str));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw new Exception("Something wrong with Logic" + ex.Message);
            }
        }

        public static string ConvertStrToAlphanumeric(string str)
        {
            try
            {
                string[] strArr = str.Split(' ');
                List<string> listSentence = new List<string>();
                StringBuilder builder = new StringBuilder();

                foreach (string word in strArr)
                {
                    listSentence.Add(word);
                    string outPutWord = null;
                    if (word.Length > 2)
                    {
                        int distinctCount = 0;
                        int wordLength = word.Length;
                        Dictionary<string, int> objDic = new Dictionary<string, int>();
                        for (int i = 1; i < wordLength - 1; i++)
                        {
                            if (!objDic.ContainsKey(word.ElementAt(i).ToString()))
                            {
                                objDic[word.ElementAt(i).ToString()] = 1;
                            }
                        }
                        distinctCount = objDic.Count();
                        char firstChar = word[0];
                        char lastChar = word[word.Length - 1];
                        outPutWord = String.Concat(firstChar, distinctCount.ToString(), lastChar);
                        builder.Append(outPutWord + " ");

                    }


                }
                return builder.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Something wrong with Logic" + ex.Message);
            }

        }
    }
}
