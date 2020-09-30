using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;

namespace vsc_c_
{
    class Program
    {
        static void Main(string[] args)
        {

            Captura();


        }
        static void Captura()
        {
            string Text = "";
            Console.WriteLine("Inserete el codigo que desea traducir a morse");
            Text = Console.ReadLine();

            Traduccion(Text);

        }
        static void Traduccion(string Text)
        {
            System.Console.WriteLine(Text);
            char[] TextMorseChar;

            Text = Text.ToUpper();
            TextMorseChar = new char[Text.Length];
            TextMorseChar = Text.ToCharArray();

            Dictionary<char, string> Morsedic = new Dictionary<char, string>();

            Morsedic.Add('A', ".-");
            Morsedic.Add('B', "-...");
            Morsedic.Add('C', "-.-.");
            Morsedic.Add('D', "-..");
            Morsedic.Add('E', ".");
            Morsedic.Add('F', "..-.");
            Morsedic.Add('G', "--.");
            Morsedic.Add('H', "....");
            Morsedic.Add('I', "..");
            Morsedic.Add('J', ".---");
            Morsedic.Add('K', "-.-");
            Morsedic.Add('L', ".-..");
            Morsedic.Add('M', "--");
            Morsedic.Add('N', "-.");
            Morsedic.Add('O', "---");
            Morsedic.Add('P', ".--.");
            Morsedic.Add('Q', "--.-");
            Morsedic.Add('R', ".-.");
            Morsedic.Add('S', "...");
            Morsedic.Add('T', "-");
            Morsedic.Add('U', "..-");
            Morsedic.Add('V', "...-");
            Morsedic.Add('W', ".--");
            Morsedic.Add('X', "-..-");
            Morsedic.Add('Y', "-.--");
            Morsedic.Add('Z', "--..");
            Morsedic.Add('0', "-----");
            Morsedic.Add('1', ".----");
            Morsedic.Add('2', "..---");
            Morsedic.Add('3', "...--");
            Morsedic.Add('4', "....-");
            Morsedic.Add('5', ".....");
            Morsedic.Add('6', "-....");
            Morsedic.Add('7', "--...");
            Morsedic.Add('8', "---..");
            Morsedic.Add('9', "----.");

            string VMorse = "";
            const int punto = 275, guion = punto * 3;


            try
            {

                for (int i = 0; i < Text.Length; i++)
                {
                    VMorse = Morsedic[TextMorseChar[i]];
                    System.Console.Write(VMorse + "|");

                    char[] VMorseChar = new char[VMorse.Length];
                    VMorseChar = VMorse.ToCharArray();

                    for (int c = 0; c < VMorse.Length; c++)
                    {
                        if (VMorseChar[c] == '.')
                        {
                            Console.Beep(800, punto);
                        }
                        else
                        {
                            Console.Beep(800, guion);
                        }
                        System.Threading.Thread.Sleep(punto * 3);
                    }
                    System.Threading.Thread.Sleep(punto * 7);


                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }






        }
    }
}
