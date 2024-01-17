using Mission_2;

internal class Program
{
    private static void Main(string[] args)
    {   //initiate vrable rolls and and instance of the funcitn DiceRolls
        int rolls = 0;
        DiceRolls dr = new DiceRolls();
        string results = "";
        
        
        System.Console.WriteLine("Welcom to the dice throwing simulator!\n\nEnter the number of how many times you want to roll the dice:");
        // if a number was entered into the console then assign it as the value of rolls
        if (int.TryParse(System.Console.ReadLine(), out rolls))
        {
            //input rolls to the GetROlls funciton found in the DiceRolls file
            List<int> listRolls = dr.GetRolls(rolls);

            // with the list that is out put itterate thought each possibel value to see how many times it occurs
            //count how many times each instance of a number appears then divie that by rolls divie that by .01 and genrate that many *
            for (int i = 2; i < 13; i++)
            {   int count = 0;
                string stars = "";
              
                foreach (int roll in listRolls)
                {
                    if (i == roll) 
                    {
                        count++;
                    }
                   
                }
                //calculate the occurcance as a percentage and generate a * for every 1% that that number occurs
                float Percent = (float)count / rolls;
                int starcount = (int)Math.Round(Percent / .01);
                for (int s = 0; s < starcount; s++)
                {
                    stars = stars + "*";
                }
                //print the result to the console
                results += (i + ": " + stars + "\n");
                    
            }
            System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach '*' represetns 1% of the total number of rolls.\nTotal number of rolls = "+ rolls);
            System.Console.WriteLine(results);
            System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }

       
    }
}