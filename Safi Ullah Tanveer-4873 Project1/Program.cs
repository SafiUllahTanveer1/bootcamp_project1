using System;

namespace Safi_Ullah_Tanveer_4873_Project1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the sentence:");
            string sentence = Console.ReadLine();
            Console.WriteLine(word_count(sentence));
            int length_of_str = word_count(sentence);
            // Console.WriteLine(word_array(sentence));
            string[] wordArray = word_array(sentence, length_of_str);
            Console.WriteLine(freq_count(wordArray, length_of_str));
            // Console.WriteLine(word_search( wordArray,length_of_str));
            Console.WriteLine(word_length(wordArray,length_of_str));
            Console.WriteLine(palindrome_check(wordArray,length_of_str));
        }

        static int word_count(string sentence)
        {
            char my_c = ' ';
            int space = 0;
            foreach (char c in sentence)
            {
                if (my_c==c)
                {
                    space++;
                }
            }

            int word_count = space + 1;
            return word_count;
        }

        static string[] word_array(string sentence, int length)
        {
            char letter = ' ';
            string word = "";
            int i= 0;
            string[] word_array = new string [length];
            // Console.WriteLine("length of sentence is : ");
            foreach (char c in sentence)
            {
                if (c == letter)
                {
                    word_array[i] = word;
                    Console.WriteLine("entering word in array index " + i);
                    Console.WriteLine(word);
                    word = "";
                    i++;
                    continue;
                }

                word += c;
                word_array[i] = word;
            }

            Console.WriteLine("outside the loop " + word);
            word_array[i] = word;
            Console.WriteLine("word array 3 index : "+word_array[0]);
            

            {
                
            }
            return word_array;
        }

        static int freq_count(string[] word_array, int length)
        {
            int i = 0;
            int j = 0;
            Console.WriteLine("length of word array is : " + word_array.Length);
            for (i = 0; i < length; i++)
            {
                int frequency = 0;
                if (word_array[i]!="")
                {
                    frequency = 1;
                }

                for (j = i+1; j < length; j++)
                {
                    if (word_array[j] == "")
                    {
                        continue;
                    }
                    if (word_array[i] == word_array[j])
                    {
                        frequency++;
                        word_array[j] = "" ;
                    }
                }
                if (frequency > 0)
                {
                    Console.WriteLine("frequency of word \"" + word_array[i] + "\" is : " + frequency);
                }
            }
            // Console.WriteLine("The freq of letter is "+frequency);
            Console.WriteLine(word_array);

            return 0;
        }

        static string word_search(string sentence)
        {
            Console.WriteLine("What word do you want to search:");
            string searchedword = Console.ReadLine();
            // string [] array=word_array(sentence);
            int i;
            for (i = 0; i < sentence.Length; i++)
            {
                // if (searchedword ==array[i])
                {
                    Console.WriteLine("The word is present");
                }
            }

            return null;
        }

        static string word_search(string[] word_array, int length)
        {
          Console.WriteLine("Give the word you want to search:");
          string search_word = Console.ReadLine();
          bool flag = false;
          foreach (string str in  word_array)
          {
              if (search_word == str)
              {
                  flag = true;
                  Console.WriteLine("The word is present");
                  break;
              }
              
          }
          if (flag==false)
          {
              Console.WriteLine("Word not present");
          }

          return search_word;
        }

        static int word_length(string[] word_array, int length)
        {
            string word_length = "";
            int i;
            int j;
            int spaces = 0;
            for (i = 0; i <= length - 1; i++)
            {
                for (j = i + 1; j <= length - 1; j++)
                {
                    {
                        if (word_array[i].Length > word_array[j].Length)
                        {
                            if (word_array[i] == "" || word_array[j] == "")
                            {
                                spaces++;
                            }

                            word_length = "";
                            word_length = word_array[i];
                            word_array[i] = word_array[j];
                            word_array[j] = word_length;
                            

                        }
                    }
                }

            }
            Console.WriteLine("length of spaces is : " + spaces);
            string[] final_str = new string[length - spaces];
            Console.WriteLine("Array after sorting is : ");
            int k = 0;
            foreach (string str in word_array)
            {
                if (str != "")
                {
                    final_str[k] = str;
                    Console.WriteLine(str);
                    k++;
                }
            }
            Console.WriteLine("The shortest length is "+ final_str[0].Length +" of word "+ final_str[0]);
            Console.WriteLine("The largest length is "+ word_array[length-1].Length +" of word "+ word_array[length-1]);
                
                
            

            return 0;
        }

        static string palindrome_check( string [] word_array, int length)
        {
            int i;
            string checker = "";
            bool flag = false;
            foreach (string str in word_array)
            {
                checker = "";
                for (i = str.Length - 1; i >= 0; i--)
                {
                    checker += str[i];

                }
                if (checker == str)
                {
                    flag = true;
                    Console.WriteLine(checker+"The word is palindrome");
                }

                else  
                {
                    Console.WriteLine(checker+ "The word is not Palindrome");
                }

            }

            return checker;
        }
    

    }
}