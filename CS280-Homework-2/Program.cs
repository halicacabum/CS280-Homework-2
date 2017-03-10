using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();

            Console.Write("請輸入Pokemon的編號：");
            try
            {
                pokemon.Number = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("編號輸入錯誤！");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            Console.Write("請輸入Pokemon的名稱：");
            try
            {
                pokemon.Name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("名稱輸入錯誤！");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            Console.Write("請輸入Pokemon的高度：");
            try
            {
                pokemon.Height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("高度輸入錯誤！");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            Console.Write("請輸入Pokemon的重量：");
            try
            {
                pokemon.Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("重量輸入錯誤！");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            Console.Write("請輸入Pokemon的能力別：");
            try
            {
                pokemon.Abilities = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("能力輸入錯誤！");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            Console.Write("請輸入Pokemon的類別：");
            try
            {
                pokemon.Category = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("類別輸入錯誤！");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }

            Console.Write("請輸入Pokemon的性別：");
            try
            {
                pokemon.Gender = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("性別輸入錯誤！");
                Console.WriteLine("錯誤訊息：\n" + e.ToString());
                return;
            }
            Console.WriteLine("以下為輸入的Pokemon資訊：\n編號：{0}\n名稱：{1}\n高度：{2}公分\n重量：{3}磅\n能力：{4}\n分類：{5}\n性別：{6}", pokemon.Number, pokemon.Name, pokemon.Height, pokemon.Weight, pokemon.Abilities, pokemon.Category, pokemon.Gender);
        }
    }
}