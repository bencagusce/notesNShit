namespace Battleship
{
    class monoBehaviour
    {
        public float xPos = 0.5f;
        private float yPos = 0.5f;
        public float zPos { get; private set; }
        private int hp = 100;

        public void Move()
        {
            yPos++;
        }

        public bool ModifyHp(string input)
        {
            int result = 0;
            bool success = int.TryParse(input, out result);

            if (success)
            {
                if (result >= 0 && result <= 100)
                {
                    hp = result;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }

    class Program
    {
        
        
        monoBehaviour dave = new monoBehaviour();

        void Main()
        {
            dave.xPos = 5;
            dave.Move();

            dave.ModifyHp(Console.ReadLine());

            float oawh = dave.zPos;
            dave.zPos = 5;

        }
    }
}