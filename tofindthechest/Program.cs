//player data

int Powerstat = 2;
int Healthstat = 3;

//game data

string[] availabletxt1 = { "1", "2", "3", "4","fight", "open" };
string[] availabletxt2 = { "1", "2", "3", "4","fight", "open" };
int area = 0;
bool game = false;
int moves = 0;
bool key = false;

//monster stats

bool Monsterattack = false;
Random rand = new Random();
int Monstershowup = rand.Next(1,3);
int Monsterpower = rand.Next(1, 4);
int Monsterhealth = rand.Next(1, 4);

//game intro 
while (game == false)
{
//ending demand
Console.WriteLine("Before anything");
Console.WriteLine("please put some info in");
Console.WriteLine("Give me a name, any name");
string?nameplayer = Console.ReadLine()?.ToLower().Trim();
Console.WriteLine($"cool name {nameplayer}");
Console.WriteLine("pick a number, any number");
string?numberbumber = Console.ReadLine()?.ToLower().Trim();
Console.WriteLine("alright thanks");
Console.WriteLine("Now");
Console.WriteLine("Welcome to T.F.T.C.");
Console.WriteLine("You need to find the chest in 7 moves");
Console.WriteLine($"your power is: {Powerstat}");
Console.WriteLine($"your health is: {Healthstat}");
Console.WriteLine("Where would you like to go?");
Console.WriteLine("Type: 1 [forest] or 2 [river]");

string?firstmove = Console.ReadLine()?.ToLower().Trim();
while (!availabletxt1.Contains(firstmove))
		{
			 moves += 1;
			Console.WriteLine("what, try again");
			firstmove = Console.ReadLine()?.ToLower().Trim();
		}
Console.WriteLine("you are traveling");


//move 1
//FOREST

if (firstmove == "1")
{
  moves += 1;
    area = 1;
}
//RIVER
if (firstmove == "2")
{
  moves += 1;
    area = 2;
}


//area switch 1 

switch (area) 
      {
        case 1:
        
        Console.WriteLine("You see a long path going throut a sea of threes");
        Console.WriteLine("You can interact with: 3 [the path] or go back to 2 [the river]");
        if (Monstershowup == 2)
        {
          Console.WriteLine("A MONSTER SHOWED UP");
          Monsterattack = true;
          Console.WriteLine("The monster's power is:");
          Console.WriteLine(Monsterpower);
          Console.WriteLine("The monster's health is:");
          Console.WriteLine(Monsterhealth);
          Console.WriteLine("type fight to continue");
          }
          break ;

        case 2:

        Console.WriteLine("You see a nice flowing river");
        Console.WriteLine("You can 4 [talk to a Frog] or go back to the 1 [forest]");
          break;


      }    
 
 string?secondmove = Console.ReadLine()?.ToLower().Trim();
while (!availabletxt2.Contains(secondmove))
		{
			 moves += 1;
			Console.WriteLine("what, try again");
			secondmove = Console.ReadLine()?.ToLower().Trim();
		}

//move2
//FOREST
if (secondmove == "1")
{
  moves += 1;
    area = 1;
}
//RIVER
if (secondmove == "2")
{
  moves += 1;
    area = 2;
}
if (secondmove == "3")
{
  moves += 1;
    area = 3;
}
if (secondmove == "4")
{
  moves += 1;
    area = 4;
}
//FIGHT
if (secondmove == "fight")
{
while(Monsterattack == true)
{
  if((Powerstat > Monsterpower))

    {
      Console.WriteLine("You kill the monster!");
      break;
    }
    else
    {
        Console.WriteLine("You are weaker then the monster...");
    if (Healthstat > Monsterpower)
    {
    Console.WriteLine("The monster hurt you");
    Healthstat -= Monsterpower;
		Console.WriteLine("You're health is");
		Console.WriteLine(Healthstat);
    break;
    }
    else 
    {
    Console.WriteLine("The monster killed you");
    Healthstat -= Monsterpower;
    break; 
    }
    }
	}
  if (Healthstat != 0)
  {
    Console.WriteLine("You can interact with: 3 [the path] or go back to 2 [the river]");
	 string?fmove1 = Console.ReadLine()?.ToLower().Trim();
  //FOREST
if (fmove1 == "1")
{
  moves += 1;
    area = 1;
}
//PATH
if (fmove1 == "3")
{
  moves += 1;
    area = 3;
}
  }
	if (Healthstat == 0)
	{
	Console.WriteLine("YOU ARE DEAD");
  break;
}
}
//Open chest
if ((secondmove == "Open")  && (key = true))
{
  Console.WriteLine("You open the chest! Inside there is nothing");
  Console.WriteLine("Rewarding the player if the friends we made along the way");
  break;
}

//switch 2
switch (area) 
      {
        case 1:
        
        Console.WriteLine("You see a long path going throut a sea of threes");
        Console.WriteLine("You can interact with: 3 [the path] or go back to 2 [the river]");
        if (Monstershowup == 2)
        {
          Console.WriteLine("A MONSTER SHOWED UP");
          Monsterattack = true;
          Console.WriteLine("The monster's power is:");
          Console.WriteLine(Monsterpower);
          Console.WriteLine("The monster's health is:");
          Console.WriteLine(Monsterhealth);
          Console.WriteLine("type fight to continue");
        }
	


          break ;

        case 2:

        Console.WriteLine("You see a nice flowing river");
        Console.WriteLine("You can 4 [talk to a Frog] or go back to the 1 [forest]");
         


          break;

        case 3:

        Console.WriteLine("You go on the path");
        Console.WriteLine("You see a chest! it's the one you are looking for!");
        Console.WriteLine("Now to open it!");
        if (key == false)
        {
            Console.WriteLine("You don't have the key to open it =[ go back to the 1 [forest] and find it");
        }
        else
        {
            Console.WriteLine("Type OPEN to open it");
        }

          break;

        case 4:

        Console.WriteLine("ribit ribit says the Frog");
        Console.WriteLine("the frog vomits out a key in a really gross fashion...");
         Console.WriteLine("you take the key");
         key = true;
        Console.WriteLine("You can go back to the 1 [forest]");
         


          break;

      }    


string?threemove = Console.ReadLine()?.ToLower().Trim();
while (!availabletxt2.Contains(threemove))
		{
			 moves += 1;
			Console.WriteLine("what, try again");
			threemove = Console.ReadLine()?.ToLower().Trim();
		}

//FOREST
if (threemove == "1")
{
  moves += 1;
    area = 1;
}
//RIVER
if (threemove == "2")
{
  moves += 1;
    area = 2;
}
if (threemove == "3")
{
  moves += 1;
    area = 3;
}
if (threemove == "4")
{
  moves += 1;
    area = 4;
}
//FIGHT
if (threemove == "fight")
{
  moves += 1;
while(Monsterattack == true)
{
  if((Powerstat > Monsterpower))

    {
      Console.WriteLine("You kill the monster!");
      break;
    }
    else
    {
        Console.WriteLine("You are weaker then the monster...");
    if (Healthstat > Monsterpower)
    {
    Console.WriteLine("The monster hurt you");
    Healthstat -= Monsterpower;
		Console.WriteLine("You're health is");
		Console.WriteLine(Healthstat);
    break;
    }
    else 
    {
    Console.WriteLine("The monster killed you");
    Healthstat -= Monsterpower;
    break; 
    }
    }
	}
  if (Healthstat != 0)
  {
    Console.WriteLine("You can interact with: 3 [the path] or go back to 2 [the river]");
	 string?fmove2 = Console.ReadLine()?.ToLower().Trim();
  //FOREST
if (fmove2 == "1")
{
  moves += 1;
    area = 1;
}
//PATH
if (fmove2 == "3")
{
  moves += 1;
    area = 3;
}
  }
	if (Healthstat == 0)
	{
	Console.WriteLine("YOU ARE DEAD");
  break;
}
}
//Open chest
if ((threemove == "Open") && (key = true))
{
  Console.WriteLine("You open the chest! Inside there is nothing");
  Console.WriteLine("Rewarding the player if the friends we made along the way");
  break;
}

//Switch 3

switch (area) 
      {
        case 1:
        
        Console.WriteLine("You see a long path going throut a sea of threes");
        Console.WriteLine("You can interact with: 3 [the path] or go back to 2 [the river]");
        if (Monstershowup == 2)
        {
          Console.WriteLine("A MONSTER SHOWED UP");
          Monsterattack = true;
          Console.WriteLine("The monster's power is:");
          Console.WriteLine(Monsterpower);
          Console.WriteLine("The monster's health is:");
          Console.WriteLine(Monsterhealth);
          Console.WriteLine("type fight to continue");
        }
	


          break ;

        case 2:

        Console.WriteLine("You see a nice flowing river");
        Console.WriteLine("You can 4 [talk to a Frog] or go back to the 1 [forest]");
         


          break;

        case 3:

        Console.WriteLine("You go on the path");
        Console.WriteLine("You see a chest! it's the one you are looking for!");
        Console.WriteLine("Now to open it!");
        if (key == false)
        {
            Console.WriteLine("You don't have the key to open it =[ go back to the 1 [forest] and find it");
        }
        else
        {
            Console.WriteLine("Type OPEN to open it");
        }

          break;

        case 4:

        Console.WriteLine("ribit ribit says the Frog");
        Console.WriteLine("the frog vomits out a key in a really gross fashion...");
         Console.WriteLine("you take the key");
         key = true;
        Console.WriteLine("You can go back to the 1 [forest]");
         


          break;

      }    


string?fourmove = Console.ReadLine()?.ToLower().Trim();
while (!availabletxt2.Contains(fourmove))
		{
			 moves += 1;
			Console.WriteLine("what, try again");
			fourmove = Console.ReadLine()?.ToLower().Trim();
		}

//FOREST
if (fourmove == "1")
{
  moves += 1;
    area = 1;
}
//RIVER
if (fourmove == "2")
{
  moves += 1;
    area = 2;
}
if (fourmove == "3")
{
  moves += 1;
    area = 3;
}
if (fourmove == "4")
{
  moves += 1;
    area = 4;
}
//FIGHT
if (fourmove == "fight")
{
  moves += 1;
while(Monsterattack == true)
{
  if((Powerstat > Monsterpower))

    {
      Console.WriteLine("You kill the monster!");
      break;
    }
    else
    {
        Console.WriteLine("You are weaker then the monster...");
    if (Healthstat > Monsterpower)
    {
    Console.WriteLine("The monster hurt you");
    Healthstat -= Monsterpower;
		Console.WriteLine("You're health is");
		Console.WriteLine(Healthstat);
    break;
    }
    else 
    {
    Console.WriteLine("The monster killed you");
    Healthstat -= Monsterpower;
    break; 
    }
    }
	}
  if (Healthstat != 0)
  {
    Console.WriteLine("You can interact with: 3 [the path] or go back to 2 [the river]");
	 string?fmove3 = Console.ReadLine()?.ToLower().Trim();
  //FOREST
if (fmove3 == "1")
{
  moves += 1;
    area = 1;
}
//PATH
if (fmove3 == "3")
{
  moves += 1;
    area = 3;
}
  }
	if (Healthstat == 0)
	{
	Console.WriteLine("YOU ARE DEAD");
  break;
}
}
//Open chest
if ((fourmove == "Open") && (key = true))
{
  Console.WriteLine("You open the chest! Inside there is nothing");
  Console.WriteLine("Rewarding the player if the friends we made along the way");
  break;
}

//Switch 4
switch (area) 
      {
        case 1:
        
        Console.WriteLine("You see a long path going throut a sea of threes");
        Console.WriteLine("You can interact with: 3 [the path] or go back to 2 [the river]");
        if (Monstershowup == 2)
        {
          Console.WriteLine("A MONSTER SHOWED UP");
          Monsterattack = true;
          Console.WriteLine("The monster's power is:");
          Console.WriteLine(Monsterpower);
          Console.WriteLine("The monster's health is:");
          Console.WriteLine(Monsterhealth);
          Console.WriteLine("type fight to continue");
        }
	


          break ;

        case 2:

        Console.WriteLine("You see a nice flowing river");
        Console.WriteLine("You can 4 [talk to a Frog] or go back to the 1 [forest]");
         


          break;

        case 3:

        Console.WriteLine("You go on the path");
        Console.WriteLine("You see a chest! it's the one you are looking for!");
        Console.WriteLine("Now to open it!");
        if (key == false)
        {
            Console.WriteLine("You don't have the key to open it =[ go back to the 1 [forest] and find it");
        }
        else
        {
            Console.WriteLine("Type OPEN to open it");
        }

          break;

        case 4:

        Console.WriteLine("ribit ribit says the Frog");
        Console.WriteLine("the frog vomits out a key in a really gross fashion...");
         Console.WriteLine("you take the key");
         key = true;
        Console.WriteLine("You can go back to the 1 [forest]");
         


          break;

      }    


string?fivemove = Console.ReadLine()?.ToLower().Trim();
while (!availabletxt2.Contains(fivemove))
		{
			 moves += 1;
			Console.WriteLine("what, try again");
			fivemove = Console.ReadLine()?.ToLower().Trim();
		}

//FOREST
if (fivemove == "1")
{
  moves += 1;
    area = 1;
}
//RIVER
if (fivemove == "2")
{
  moves += 1;
    area = 2;
}
if (fivemove == "3")
{
  moves += 1;
    area = 3;
}
if (fivemove == "4")
{
  moves += 1;
    area = 4;
}
//FIGHT
if (fivemove == "fight")
{
  moves += 1;
while(Monsterattack == true)
{
  if((Powerstat > Monsterpower))

    {
      Console.WriteLine("You kill the monster!");
      break;
    }
    else
    {
        Console.WriteLine("You are weaker then the monster...");
    if (Healthstat > Monsterpower)
    {
    Console.WriteLine("The monster hurt you");
    Healthstat -= Monsterpower;
		Console.WriteLine("You're health is");
		Console.WriteLine(Healthstat);
    break;
    }
    else 
    {
    Console.WriteLine("The monster killed you");
    Healthstat -= Monsterpower;
    break; 
    }
    }
	}
  if (Healthstat != 0)
  {
    Console.WriteLine("You can interact with: 3 [the path] or go back to 2 [the river]");
	 string?fmove4 = Console.ReadLine()?.ToLower().Trim();
  //FOREST
if (fmove4 == "1")
{
  moves += 1;
    area = 1;
}
//PATH
if (fmove4 == "3")
{
  moves += 1;
    area = 3;
}
  }
	if (Healthstat == 0)
	{
	Console.WriteLine("YOU ARE DEAD");
  break;
}
}
//Open chest
if ((fivemove == "Open") && (key = true))
{
  Console.WriteLine("You open the chest! Inside there is nothing");
  Console.WriteLine("Rewarding the player if the friends we made along the way");
  break;
}
//Switch 5
switch (area) 
      {
        case 1:
        
        Console.WriteLine("You see a long path going throut a sea of threes");
        Console.WriteLine("You can interact with: 3 [the path] or go back to 2 [the river]");
        if (Monstershowup == 2)
        {
          Console.WriteLine("A MONSTER SHOWED UP");
          Monsterattack = true;
          Console.WriteLine("The monster's power is:");
          Console.WriteLine(Monsterpower);
          Console.WriteLine("The monster's health is:");
          Console.WriteLine(Monsterhealth);
          Console.WriteLine("type fight to continue");
        }
	


          break ;

        case 2:

        Console.WriteLine("You see a nice flowing river");
        Console.WriteLine("You can 4 [talk to a Frog] or go back to the 1 [forest]");
         


          break;

        case 3:

        Console.WriteLine("You go on the path");
        Console.WriteLine("You see a chest! it's the one you are looking for!");
        Console.WriteLine("Now to open it!");
        if (key == false)
        {
            Console.WriteLine("You don't have the key to open it =[ go back to the 1 [forest] and find it");
        }
        else
        {
            Console.WriteLine("Type OPEN to open it");
        }

          break;

        case 4:

        Console.WriteLine("ribit ribit says the Frog");
        Console.WriteLine("the frog vomits out a key in a really gross fashion...");
         Console.WriteLine("you take the key");
         key = true;
        Console.WriteLine("You can go back to the 1 [forest]");
         


          break;

      }    


string?sixmove = Console.ReadLine()?.ToLower().Trim();
while (!availabletxt2.Contains(sixmove))
		{
			 moves += 1;
			Console.WriteLine("what, try again");
			sixmove = Console.ReadLine()?.ToLower().Trim();
		}

//FOREST
if (sixmove == "1")
{
  moves += 1;
    area = 1;
}
//RIVER
if (sixmove == "2")
{
  moves += 1;
    area = 2;
}
if (sixmove == "3")
{
  moves += 1;
    area = 3;
}
if (sixmove == "4")
{
  moves += 1;
    area = 4;
}
//FIGHT
if (sixmove == "fight")
{
  moves += 1;
while(Monsterattack == true)
{
  if((Powerstat > Monsterpower))

    {
      Console.WriteLine("You kill the monster!");
      break;
    }
    else
    {
        Console.WriteLine("You are weaker then the monster...");
    if (Healthstat > Monsterpower)
    {
    Console.WriteLine("The monster hurt you");
    Healthstat -= Monsterpower;
		Console.WriteLine("You're health is");
		Console.WriteLine(Healthstat);
    break;
    }
    else 
    {
    Console.WriteLine("The monster killed you");
    Healthstat -= Monsterpower;
    break; 
    }
    }
	}
  if (Healthstat != 0)
  {
    Console.WriteLine("You can interact with: 3 [the path] or go back to 2 [the river]");
	 string?fmove5 = Console.ReadLine()?.ToLower().Trim();
  //FOREST
if (fmove5 == "1")
{
    moves += 1;
    area = 1;
}
//PATH
if (fmove5 == "3")
{
    moves += 1;
    area = 3;
}
  }
	if (Healthstat == 0)
	{
	Console.WriteLine("YOU ARE DEAD");
  break;
}
}
//Open chest
if ((sixmove == "Open") && (key = true))
{
  Console.WriteLine("You open the chest! Inside there is nothing");
  Console.WriteLine("Rewarding the player if the friends we made along the way");
  break;
}
//Switch 6
if(moves == 7)
{
  	Console.WriteLine("YOU RAN OUT OF MOVES");
    break;
}


}