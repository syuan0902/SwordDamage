using System;

namespace SwordDamage
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            SwordDamageCount swordDamage = new SwordDamageCount(RollDice());
            while (true)
            {
                Console.Write("輸入 0 進行基礎攻擊, 輸入 1 附加魔法攻擊, 輸入 2 附加火焰攻擊, " +
                              "輸入 3 附加魔法和火焰攻擊, 輸入其他鍵離開測試  ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;
                swordDamage.Roll = RollDice();
                swordDamage.Magic = (key == '1' || key == '3');
                swordDamage.Flaming = (key == '2' || key == '3');
                Console.WriteLine($"\n擲出 {swordDamage.Roll} 點, 造成 {swordDamage.Damage} HP傷害\n");
            }
        }

        private static int RollDice()
        {
            return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        }
    }
}
