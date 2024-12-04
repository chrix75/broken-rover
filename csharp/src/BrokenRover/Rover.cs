namespace BrokenRover
{
    public class Rover
    {
        private int x;
        private int y;
        private string direction;

        public void SetX(int i)
        {
            x = i;
        }

        public void SetY(int i)
        {
            y = i;
        }

        public void SetOrientation(string s)
        {
            direction = s;
        }

        public void process(string commands)
        {
            foreach (char c in commands.ToCharArray())
            {
                switch (c)
                {
                    case 'R':
                        switch (direction)
                        {
                            case "NORTH":
                                direction = "EAST";
                                break;
                            case "EAST":
                                direction = "SOUTH";
                                break;
                            case "SOUTH":
                                direction = "OUEST";
                                break;
                        }
                        break;
                    case 'L':
                        switch (direction)
                        {
                            case "NORTH":
                                direction = "WEST";
                                break;
                            case "WEST":
                                direction = "SOUTH";
                                break;
                            case "SOUTH":
                                direction = "EAST";
                                break;
                            case "EAST":
                                direction = "NORTH";
                                break;
                        }
                        break;
                    case 'F':
                        switch (direction)
                        {
                            case "NORTH":
                                y++;
                                break;
                            case "WEST":
                                x--;
                                break;
                            case "SOUTH":
                                y--;
                                break;
                            case "EAST":
                                x++;
                                break;
                        }
                        break;
                }
            }

            if (x == -1)
            {
                x = 0;
            }

            if (y == -1)
            {
                y = 0;
            }
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public string GetOrientation()
        {
            return direction;
        }
    }
}