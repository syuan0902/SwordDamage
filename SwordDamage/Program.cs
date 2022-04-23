using System;

namespace SwordDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamageCount m_swordDamageCount = new SwordDamageCount();
            Random m_random = new Random();

            while (true)
            {
                Console.Write("普通攻擊請輸入0, 魔法攻擊請按1, 火焰劍攻擊請按2, 火焰劍附加魔法攻擊請按3, 離開測試請輸入其他按鍵: ");

                char m_Input = Console.ReadKey().KeyChar;

                if (m_Input != '0' && m_Input != '1' && m_Input != '2' && m_Input != '3') return;

                int m_3Roll = m_random.Next(1, 7) + m_random.Next(1, 7) + m_random.Next(1, 7);

                m_swordDamageCount.m_roll = m_3Roll;

                m_swordDamageCount.SetMagic(m_Input == '1' || m_Input == '3');

                m_swordDamageCount.SetFlameSword(m_Input == '2' || m_Input == '3');

                Console.WriteLine("\n3顆骰子擲出了 " + m_3Roll + "總傷害為 " + m_swordDamageCount.m_totalDamage + "HP\n");
            }
        }
    }
}
