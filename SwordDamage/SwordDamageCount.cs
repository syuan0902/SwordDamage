using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamage
{
    class SwordDamageCount
    {

        public const int m_baseDamage = 3;
        public const int m_flameSwordDamage = 2;

        public int m_roll;
        public decimal m_magicMultiplier = 1m;
        public int m_flameDamage = 0;
        public int m_totalDamage;

        public void CalculateDamage()
        {
            m_totalDamage = (int)(m_roll * m_magicMultiplier) + m_baseDamage + m_flameDamage;
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                m_magicMultiplier = 1.75m;
            }

            else
            {
                m_magicMultiplier = 1m;
            }

            CalculateDamage();
        }

        public void SetFlameSword(bool isFlameSword)
        {
            CalculateDamage();

            if (isFlameSword)
            {
                m_totalDamage += m_flameSwordDamage;
            }
        }
    }
}
