namespace Battleship
{
    class monoBehaviour
    {
        // Public kan läsas och ändras utanför klassen
        public float xPos = 0.5f;
        // Private kan bara läsas eller ändras i klassen
        private float yPos = 0.5f;
        // public, private set kan läsas utanför klassen men bara ändras i klassen
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

    // Om programmet använder klasser måste all annan kod ligga i program klassen
    class Program
    {
        
        
        monoBehaviour dave = new monoBehaviour();

        // Om programmet använder klasser måste all logik (funktionsanrop och variabeländringar) ligga i funktioner. Main() körs när man kör programmet
        // void är en return type, precis som int.TryParse() returnar en bool för om den lyckades returnar Main() inget (void)
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
