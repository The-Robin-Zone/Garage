using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    [Serializable]
    public class ValueOutOfRangeException : Exception
    {
        private const string k_Message = "Value is out of range, the range is {0} to {1}";
        private readonly float m_MaxValue;
        private readonly float m_MinValue;

        // 4 different type of constructor depnding of the cases.
        public ValueOutOfRangeException(float i_MaxValue, float i_MinValue) : base(string.Format(k_Message, i_MinValue, i_MaxValue))
        {
            this.m_MaxValue = i_MaxValue;
            this.m_MinValue = i_MinValue;
        }

        public ValueOutOfRangeException(float i_MaxValue, float i_MinValue, string i_Message) : base(string.Format(i_Message, i_MinValue, i_MaxValue))
        {
            this.m_MaxValue = i_MaxValue;
            this.m_MinValue = i_MinValue;
        }

        public float MaxValue
        {
            get
            {
                return this.m_MaxValue;
            }
        }

        public float MinValue
        {
            get
            {
                return this.m_MinValue;
            }
        }
    }
}
