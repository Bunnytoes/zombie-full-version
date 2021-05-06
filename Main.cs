using System;
using System.Threading;


class MainClass {
 public static void Main (string[] args) {
 float health = 100;
 
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Enter 1 for the aftermath and 2 for the zombies");
string dazombies = Console.ReadLine();
if (dazombies == "1")
{
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Enter 1 for random score and 2 for normal");
 string blueberry = Console.ReadLine();
 if (blueberry == "1") 
 {

 
Random random = new Random();
 
float points = 0;
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Welcome to zombie: How long can you survive?, based off \nrhinorunner's but made in c#! Random version");
Thread.Sleep(3000);
Console.Clear();
Console.WriteLine ("please choose the option you think is best");
 Thread.Sleep(3000);
 Console.WriteLine("People are starting to reconstruct everything, what do you do? ");
 Console.WriteLine("1. Help rebuilding");
 Console.WriteLine("2. Don't work at all because of fear of tools killing you");
 Console.WriteLine("3. Do a little work");
 Console.WriteLine("4. Destroy it");
 int zomb = Convert.ToInt32(Console.ReadLine());
 
 if (zomb == 1)
 {
 points = points + random.Next(4,8);
 health = health + 5;
 }
 if (zomb == 2)
 {
 points = points + random.Next(1,3);
 health = health - 8;
 }
 if (zomb == 3)
 {
 points = points + random.Next(5,6);
 
 }

 if (zomb == 4)
{
 points = points + random.Next(-2,2);
health = health - 25;
}
 Console.Clear();
 Console.WriteLine("You are going raiding, what do you bring?");
 Thread.Sleep(3000);
 Console.WriteLine("1. Lasso and whip");
 Console.WriteLine("2. A Grenade");
 Console.WriteLine("3. Your (somehow alive) 7 years old little sister");
 Console.WriteLine("4. A smoke bomb (and gogles)");
 int zomb1 = Convert.ToInt32(Console.ReadLine());
 if (zomb1 == 1)
 {
 points = points + random.Next(5,9);
 health = health + 5;
 }
 if (zomb1 == 2)
 {
 points = points + random.Next(2,4);
 }
 if (zomb1 == 3)
 {
 points = random.Next(-2,2) + points;
health = health - 25;
 }
 if (zomb1 == 4)
 {
 points = points + random.Next(4,6);
 }
 Console.Clear();
 Console.WriteLine("What weapon would you like?");
 Thread.Sleep(3000);
 Console.WriteLine("1.Crossbow");
 Console.WriteLine("2. Sniper rifle");
 Console.WriteLine("3. U.S. military high tech anti-grav gun");
 Console.WriteLine("4.Machine pistol");

int zomb2 = Convert.ToInt32(Console.ReadLine()); 
if (zomb2 == 1)
{
 points = points + random.Next(2,6);
}
if (zomb2 == 2)
{
 points = points + random.Next(3,6);
}
if (zomb2 == 3)
{
 points = points + random.Next(4,7);
health = health + 5;
}
 if (zomb2 == 4)
{
 points = points + random.Next(3,5);
health = health - 15;
}
 Console.Clear();
 Console.WriteLine("You see a group of raiders and it's super cold,making a fire may alert them, what do you do?");
 Thread.Sleep(3000);
 Console.WriteLine("1.Light a huge fire");
Console.WriteLine("2.Light a normal fire");
 Console.WriteLine("3.Light a small fire");
 Console.WriteLine("4.Walk around and try to warm up");
 int zomb3 = Convert.ToInt32(Console.ReadLine());
 
 if (zomb3 == 1)
 {
 points = points + random.Next(2,4);
 health = health - 25;
 }
 
 if (zomb3 == 2)
 {
 points = points + random.Next(2,4);
 health = health - 14;
 }
if (zomb3 == 3)
 {
 points = points + random.Next(3,4);
 }
 if (zomb3 == 4)
 {
 points = points + random.Next(4,7);
 health = health + 5;
 }
Console.Clear();
Console.WriteLine("Where do you set up camp?");
Thread.Sleep(3000);
Console.WriteLine("1. by the beach");
 Console.WriteLine("2. in the mountains");
 Console.WriteLine("3. by a lake");
 Console.WriteLine("4. underground");
int zomb4 = Convert.ToInt32(Console.ReadLine());

if (zomb4 == 1)
{
 points = points + random.Next(3,5);
}
if (zomb4 == 2)
{
 points = points + random.Next(3,5);
health = health - 15;
if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
}

}

if (zomb4 == 3)
{
 points = points + random.Next(2,4);
}

if (zomb4 == 4)
{
 points = points + random.Next(5,8);
health = health + 5;
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("A group of people confronts you and tells you to get in a box, what do you do?");
Thread.Sleep(3000);
Console.WriteLine("1. Ask to join their group");
Console.WriteLine("2. Get in the box");
Console.WriteLine("3. Run away");
Console.WriteLine("4. Pretend to die");
int zomb5 = Convert.ToInt32(Console.ReadLine());
if (zomb5 == 1)
{
 points = points + random.Next(3,5);
}

if (zomb5 == 2)
{
 points = points + random.Next(4,7);
}
 if (zomb5 == 3)
{
 points = points + random.Next(4,6);
}
if (zomb5 == 4)
{
 points = points + random.Next(3,5);
health = health - 20;
if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
return;
}

}
 Console.Clear();
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("You find a drug store that has poisons and medicine what do you choose?");
 Thread.Sleep(3000);
 Console.WriteLine("1. pills to get you to fall asleep");
Console.WriteLine("2. Look for a tools store");
Console.WriteLine("3. Vitamins and boosters");
Console.WriteLine("4. Cigarettes and Alcohol");
int zomb6 = Convert.ToInt32(Console.ReadLine());
 if (zomb6 == 1)
 {
 points = points + random.Next(4,7);
 health = health + 5;
 }
 if (zomb6 == 2)
 {
 points = points + random.Next(5,8);
 }
 if (zomb6 == 3)
 {
 points = points + random.Next(4,6);
 }
 if (zomb6 == 4)
 {
 points = points + random.Next(-5,2);
 health = health - 80;
 if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
return;
}
 
 }
 
 
 
 
 if (zomb < 1 ||zomb > 4 || zomb1 < 1 ||zomb1 > 4 || zomb2 < 1 ||zomb2 > 4 || zomb3 < 1 ||zomb3 > 4 || zomb4 < 1 ||zomb4 > 4 || zomb5 < 1 ||zomb5 > 4 || zomb6 < 1 ||zomb6 > 4 ) 
 {
 Console.WriteLine("Invalid input");
 return;
 }
 
 Console.ForegroundColor = ConsoleColor.Cyan;
 Thread.Sleep(3000);
 Console.WriteLine("Final points:" + points);
 
 if (points >= 50)
 {
 Console.WriteLine("You were one of the people who survived the zombies and the aftermath! Great job!");
 }
 if (points > 45 && points < 50)
 {
 Console.WriteLine("You survived, but it was a little hard");
 }
 if (points > 30 && points < 45)
 {
 
 Console.WriteLine("You would survive years until the people raid your bunker");

 }
 if (points > 20 && points < 30 )
 {
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("You would survive a year until a steel beam fell on your head");
 
 }
 if (points < 20 && points > 10)
 {
 Console.ForegroundColor = ConsoleColor.DarkRed;
 Console.WriteLine("You would survive a couple months until you try to loot a store and get killed");
 
 }
if (points < 10)
 {
 Console.WriteLine("You would survive a week until you still deadly poison and acid on yourself");
 
 }
Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Press any key to close");
 Console.ReadKey();
 }
 
 
 
 
 
 
 
 
 
 if (blueberry == "2")
 {
float points = 0;
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Welcome to zombie: How long can you survive?, based off \nrhinorunner's but made in c#!");
Thread.Sleep(3000);
Console.Clear();
Console.WriteLine ("please choose the option you think is best");
 Thread.Sleep(3000);
 Console.WriteLine("People are starting to reconstruct everything, what do you do? ");
 Thread.Sleep(3000);
 Console.WriteLine("1. Help rebuilding");
 Console.WriteLine("2. Don't work at all because of fear of tools killing you");
 Console.WriteLine("3. Do a little work");
 Console.WriteLine("4. Destroy it");
 int zomb = Convert.ToInt32(Console.ReadLine());
 
 if (zomb == 1)
 {
 points = points + 7;
 health = health + 5;
 
 }
 if (zomb == 2)
 {
 points = points + 2;
 health = health - 8;
 }
 if (zomb == 3)
 {
 points = points + 4;
 
 }

 if (zomb == 4)
{
 points = points + 0;
health = health - 25;
}
 Console.Clear();
 Console.WriteLine("You are going raiding, what do you bring?");
 Thread.Sleep(3000);
 Console.WriteLine("1. Lasso and whip");
 Console.WriteLine("2. A Grenade");
 Console.WriteLine("3. Your (somehow alive) 7 years old little sister");
 Console.WriteLine("4. A smoke bomb (and gogles)");
 int zomb1 = Convert.ToInt32(Console.ReadLine());
 if (zomb1 == 1)
 {
 points = points + 7;
 health = health + 5;
 }
 if (zomb1 == 2)
 {
 points = points + 1;
 }
 if (zomb1 == 3)
 {
 points = -2 + points;
 health = health - 20;
 }
 if (zomb1 == 4)
 {
 points = points + 5;
 }
 Console.Clear();
 Console.WriteLine("What weapon would you like?");
 Thread.Sleep(3000);
 Console.WriteLine("1.Crossbow");
 Console.WriteLine("2. Sniper rifle");
 Console.WriteLine("3. U.S. military high tech anti-grav gun");
 Console.WriteLine("4.Machine pistol");

int zomb2 = Convert.ToInt32(Console.ReadLine()); 
if (zomb2 == 1)
{
 points = points + 5;
}
if (zomb2 == 2)
{
 points = points + 6;
}
if (zomb2 == 3)
{
 points = points + 4;
}
 if (zomb2 == 4)
{
 points = points + 3;
health = health - 15;
}
 Console.Clear();
 Console.WriteLine("You see a group of raiders and it's super cold,making a fire may alert them, what do you do?");
 Thread.Sleep(3000);
 Console.WriteLine("1.Light a huge fire");
Console.WriteLine("2.Light a normal fire");
 Console.WriteLine("3.Light a small fire");
 Console.WriteLine("4.Walk around and try to warm up");
 int zomb3 = Convert.ToInt32(Console.ReadLine());
 
 if (zomb3 == 1)
 {
 points = points + 3;
 health = health - 15;
 }
 
 if (zomb3 == 2)
 {
 points = points + 4;
 }
if (zomb3 == 3)
 {
 points = points + 4;
 }
 if (zomb3 == 4)
 {
 points = points + 6;
 health = health + 5;
 }
Console.Clear();
Console.WriteLine("Where do you set up camp?");
Thread.Sleep(3000);
Console.WriteLine("1. by the beach");
 Console.WriteLine("2. in the mountains");
 Console.WriteLine("3. by a lake");
 Console.WriteLine("4. underground");
int zomb4 = Convert.ToInt32(Console.ReadLine());

if (zomb4 == 1)
{
 points = points + 5;
}
if (zomb4 == 2)
{
 points = points + 4;
health = health - 15;
}

if (zomb4 == 3)
{
 points = points + 5;
}

if (zomb4 == 4)
{
 points = points + 8;

health = health + 5;
}
Console.Clear();
Console.WriteLine("A group of people confronts you and tells you to get in a box, what do you do?");
Thread.Sleep(3000);
Console.WriteLine("1. Ask to join their group");
Console.WriteLine("2. Get in the box");
Console.WriteLine("3. Run away");
Console.WriteLine("4. Pretend to be dead");
int zomb5 = Convert.ToInt32(Console.ReadLine());
if (zomb5 == 1)
{
 points = points + 6;
}

if (zomb5 == 2)
{
 points = points + 4;
}
 if (zomb5 == 3)
{
 points = points + 3;
}
if (zomb5 == 4)
{
 points = points + 3;
health = health - 20;
 
 if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
return;
}
}
 Console.Clear();
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("You find a drug store that has poisons and medicine what do you choose?");
 Thread.Sleep(3000);
 Console.WriteLine("1. pills to get you to fall asleep");
Console.WriteLine("2. Look for a tools store");
Console.WriteLine("3. Vitamins and boosters");
Console.WriteLine("4. Cigarettes and Alcohol");
int zomb6 = Convert.ToInt32(Console.ReadLine());
 if (zomb6 == 1)
 {
 points = points + 7;
 health = health + 5;
 }
 if (zomb6 == 2)
 {
 points = points + 6;
 }
 if (zomb6 == 3)
 {
 points = points + 5;
 }
 if (zomb6 == 4)
 {
 points = -10 + points;
 health = health - 80;
  if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
return;
}
 
 }
 
 
 
 
 if (zomb < 1 ||zomb > 4 || zomb1 < 1 ||zomb1 > 4 || zomb2 < 1 ||zomb2 > 4 || zomb3 < 1 ||zomb3 > 4 || zomb4 < 1 ||zomb4 > 4 || zomb5 < 1 ||zomb5 > 4 || zomb6 < 1 ||zomb6 > 4 ) 
 {
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Invalid input");
 return;
 }
 
 Console.ForegroundColor = ConsoleColor.Cyan;
 Thread.Sleep(3000);
 Console.WriteLine("Final points:" + points);
 
 if (points >= 50)
 {
 Console.WriteLine("You survive the aftermath and the zombies!!! Great job!");
 }
 if (points > 45 && points < 50)
 {
 Console.WriteLine("You survived, but it was hard");
 }
 if (points > 30 && points < 45)
 {
 
 Console.WriteLine("You would survive until raiders found a way into your bunker");

 }
 if (points > 20 && points < 30 )
 {
 Console.ForegroundColor = ConsoleColor.DarkRed;
 Console.WriteLine("You would survive a year until you got pushed into a lake and drowned");
 
 }
 if (points < 20 && points > 10)
 {
 Console.ForegroundColor = ConsoleColor.DarkRed;
 Console.WriteLine("You would survive a couple months until you try to loot a store and get killed");
 
 }
if (points < 10)
 {
 Console.WriteLine("You would survive a week until a steel beam fell on you");
 
 }
Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Press any key to close");
 Console.ReadKey();
 }
 else 
 {
 Console.WriteLine("Invalid input");
 }
 }


if (dazombies == "2")
{
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Enter 1 for random score and 2 for normal");
 string blueberry = Console.ReadLine();
 if (blueberry == "1") 
 {

 
Random random = new Random();
 
float points = 0;
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Welcome to zombie: How long can you survive?, based off \nrhinorunner's but made in c#! Random version");
Thread.Sleep(3000);
Console.Clear();
Console.WriteLine ("please choose the option you think is best");
 Thread.Sleep(3000);
 Console.WriteLine("You see a store what do you do?");
 Console.WriteLine("1. steal everything");
 Console.WriteLine("2. Don't go in because of fear of zombies");
 Console.WriteLine("3. Go in and steal some stuff");
 Console.WriteLine("4. Run away");
 int zomb = Convert.ToInt32(Console.ReadLine());
 
 if (zomb == 1)
 {
 points = points + random.Next(4,8);
 health = health + 5;
 }
 if (zomb == 2)
 {
 points = points + random.Next(2,5);
 
 }
 if (zomb == 3)
 {
 points = points + random.Next(3,4);
 
 }

 if (zomb == 4)
{
 points = points + random.Next(-2,4);
health = health - 20;
}
 Console.Clear();
 Console.WriteLine("You can only put one more thing in your backpack(or bring one more thing), what will it be?");
 Thread.Sleep(3000);
 Console.WriteLine("1. Police dog");
 Console.WriteLine("2. A bag of trail mix");
 Console.WriteLine("3. Your (somehow alive) 7 years old little sister");
 Console.WriteLine("4. A smoke bomb (and gogles)");
 int zomb1 = Convert.ToInt32(Console.ReadLine());
 if (zomb1 == 1)
 {
 points = points + random.Next(5,9);
 health = health + 5;
 }
 if (zomb1 == 2)
 {
 points = points + random.Next(3,6);
 }
 if (zomb1 == 3)
 {
 points = random.Next(-2,3) + points;
 health = health - 25;
 }
 if (zomb1 == 4)
 {
 points = points + random.Next(4,6);
 }
 Console.Clear();
 Console.WriteLine("What weapon would you like?");
 Thread.Sleep(3000);
 Console.WriteLine("1.Crossbow");
 Console.WriteLine("2. Sniper rifle");
 Console.WriteLine("3. U.S. military high tech anti-grav gun");
 Console.WriteLine("4.Machine pistol");

int zomb2 = Convert.ToInt32(Console.ReadLine()); 
if (zomb2 == 1)
{
 points = points + random.Next(2,5);
}
if (zomb2 == 2)
{
 points = points + random.Next(-1,4);
health = health - 15;
}
if (zomb2 == 3)
{
 points = points + random.Next(3,5);
}
 if (zomb2 == 4)
{
 points = points + random.Next(5,9);
health = health + 5;
}
 Console.Clear();
 Console.WriteLine("You see a horde of zombies and it's super cold,making a fire may alert them, what do you do?");
 Thread.Sleep(3000);
 Console.WriteLine("1.Light a huge fire");
Console.WriteLine("2.Light a normal fire");
 Console.WriteLine("3.Light a small fire");
 Console.WriteLine("4.Walk around and try to warm up");
 int zomb3 = Convert.ToInt32(Console.ReadLine());
 
 if (zomb3 == 1)
 {
 points = points + random.Next(2,4);
 health = health - 25;
 }
 
 if (zomb3 == 2)
 {
 points = points + random.Next(3,6);
 }
if (zomb3 == 3)
 {
 points = points + random.Next(4,7);
 }
 if (zomb3 == 4)
 {
 points = points + random.Next(3,6);
 health = health + 10;
 }
Console.Clear();
Console.WriteLine("Where do you set up camp?");
Thread.Sleep(3000);
Console.WriteLine("1. by the beach");
 Console.WriteLine("2. in the mountains");
 Console.WriteLine("3. by a lake");
 Console.WriteLine("4. underground");
int zomb4 = Convert.ToInt32(Console.ReadLine());

if (zomb4 == 1)
{
 points = points + random.Next(3,5);
health = health + 5;
}
if (zomb4 == 2)
{
 points = points + random.Next(5,8);
}

if (zomb4 == 3)
{
 points = points + random.Next(3,5);
}

if (zomb4 == 4)
{
 points = points + random.Next(-2,3);
health = health - 15;
 if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
return;
}

}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("A group of people confronts you and tells you to get in a box, what do you do?");
Thread.Sleep(3000);
Console.WriteLine("1. Ask to join their group");
Console.WriteLine("2. Get in the box");
Console.WriteLine("3. Run away");
Console.WriteLine("4. Pretend to be a zombie");
int zomb5 = Convert.ToInt32(Console.ReadLine());
if (zomb5 == 1)
{
 points = points + random.Next(3,5);

}

if (zomb5 == 2)
{
 points = points + random.Next(4,7);
health = health + 5;
}
 if (zomb5 == 3)
{
 points = points + random.Next(5,8);
}
if (zomb5 == 4)
{
 points = points + random.Next(2,5);
health = health - 20;
 if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
return;
}

}
 Console.Clear();
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("You find a drug store that has poisons and medicine what do you choose?");
 Thread.Sleep(3000);
 Console.WriteLine("1. pills to keep you awake");
Console.WriteLine("2. Dangerous poisons");
Console.WriteLine("3. Vitamins and boosters");
Console.WriteLine("4. Cigarettes and Alcohol");
int zomb6 = Convert.ToInt32(Console.ReadLine());
 if (zomb6 == 1)
 {
 points = points + random.Next(5,9);
 }
 if (zomb6 == 2)
 {
 points = points + random.Next(3,6);
 }
 if (zomb6 == 3)
 {
 points = points + random.Next(4,6);
 }
 if (zomb6 == 4)
 {
 points = points + random.Next(-5,2);
 health = health - 80;
  if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
return;
}
 
 }
 
 
 
 
 if (zomb < 1 ||zomb > 4 || zomb1 < 1 ||zomb1 > 4 || zomb2 < 1 ||zomb2 > 4 || zomb3 < 1 ||zomb3 > 4 || zomb4 < 1 ||zomb4 > 4 || zomb5 < 1 ||zomb5 > 4 || zomb6 < 1 ||zomb6 > 4 ) 
 {
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Invalid input");
 return;
 }
 
 Console.ForegroundColor = ConsoleColor.Cyan;
 Thread.Sleep(3000);
 Console.WriteLine("Final points:" + points);
 
 if (points >= 50)
 {
 Console.WriteLine("You survive very easily and it's like a game of hide and seek for you");
 }
 if (points > 45 && points < 50)
 {
 Console.WriteLine("You are the survival master and could survive this for until the zombies all died");
 }
 if (points > 30 && points < 45)
 {
 
 Console.WriteLine("You would survive years until the zombies find a way into your bunker");

 }
 if (points > 20 && points < 30 )
 {
 Console.ForegroundColor = ConsoleColor.DarkRed;
 Console.WriteLine("You would survive a year until you dropped a zombie on you with yout anti-grav gun");
 
 }
 if (points < 20 && points > 10)
 {
 Console.ForegroundColor = ConsoleColor.DarkRed;
 Console.WriteLine("You would survive a couple months until you try to loot a store and get overrun");
 
 }
if (points < 10)
 {
 Console.WriteLine("You would survive a week until you still deadly poison and acid on yourself");
 
 }
Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Press any key to close");
 Console.ReadKey();
 
 }
 
 
 
 
 
 
 
 
 
 if (blueberry == "2")
 {
float points = 0;
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Welcome to zombie: How long can you survive?, based off \nrhinorunner's but made in c#!");
Thread.Sleep(3000);
Console.Clear();
Console.WriteLine ("please choose the option you think is best");
 Thread.Sleep(3000);
 Console.WriteLine("You see a store what do you do?");
 Console.WriteLine("1. Steal everything");
 Console.WriteLine("2. Don't go in because of fear of zombies");
 Console.WriteLine("3.Go in and steal some stuff");
 Console.WriteLine("4. Run away");
 int zomb = Convert.ToInt32(Console.ReadLine());
 
 if (zomb == 1)
 {
 points = points + 7;
 health = health + 5;
 }
 if (zomb == 2)
 {
 points = points + 2;
 
 }
 if (zomb == 3)
 {
 points = points + 4;
 
 }

 if (zomb == 4)
{
 points = points + 0;
health = health - 20;
}
 Console.Clear();
 Console.WriteLine("You can only put one more thing in your backpack(or bring one more thing), what will it be?");
 Thread.Sleep(3000);
 Console.WriteLine("1. Police dog");
 Console.WriteLine("2. A bag of trail mix");
 Console.WriteLine("3. Your (somehow alive) 7 years old little sister");
 Console.WriteLine("4. A smoke bomb (and gogles)");
 int zomb1 = Convert.ToInt32(Console.ReadLine());
 if (zomb1 == 1)
 {
 points = points + 7;
 health = health + 5;
 }
 if (zomb1 == 2)
 {
 points = points + 1;
 }
 if (zomb1 == 3)
 {
 points = -2 + points;
 health = health - 25;
 }
 if (zomb1 == 4)
 {
 points = points + 3;
 }
 Console.Clear();
 Console.WriteLine("What weapon would you like?");
 Thread.Sleep(3000);
 Console.WriteLine("1.Crossbow");
 Console.WriteLine("2. Sniper rifle");
 Console.WriteLine("3. U.S. military high tech anti-grav gun");
 Console.WriteLine("4.Machine pistol");

int zomb2 = Convert.ToInt32(Console.ReadLine()); 
if (zomb2 == 1)
{
 points = points + 3;
}
if (zomb2 == 2)
{
 points = points + 3;
health = health - 15;
}
if (zomb2 == 3)
{
 points = points + 2;
health = health - 25;
}
 if (zomb2 == 4)
{
 points = points + 7;
health = health + 5;
}
 Console.Clear();
 Console.WriteLine("You see a horde of zombies and it's super cold,making a fire may alert them, what do you do?");
 Thread.Sleep(3000);
 Console.WriteLine("1.Light a huge fire");
Console.WriteLine("2.Light a normal fire");
 Console.WriteLine("3.Light a small fire");
 Console.WriteLine("4.Walk around and try to warm up");
 int zomb3 = Convert.ToInt32(Console.ReadLine());
 
 if (zomb3 == 1)
 {
 points = points + 5;
 health = health - 15;
 }
 
 if (zomb3 == 2)
 {
 points = points + 7;
 health = health + 3;
 }
if (zomb3 == 3)
 {
 points = points + 3;
 }
 if (zomb3 == 4)
 {
 points = points + 4;
 health = health + 2;
 }
Console.Clear();
Console.WriteLine("Where do you set up camp?");
Thread.Sleep(3000);
Console.WriteLine("1. by the beach");
 Console.WriteLine("2. in the mountains");
 Console.WriteLine("3. by a lake");
 Console.WriteLine("4. underground");
int zomb4 = Convert.ToInt32(Console.ReadLine());

if (zomb4 == 1)
{
 points = points + 3;
health = health - 15;
}
if (zomb4 == 2)
{
 points = points + 8;
health = health + 5;
}

if (zomb4 == 3)
{
 points = points + 5;
}

if (zomb4 == 4)
{
 points = points + 0;
health = health - 25;
 if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
return;
}
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("A group of people confronts you and tells you to get in a box, what do you do?");
Thread.Sleep(3000);
Console.WriteLine("1. Ask to join their group");
Console.WriteLine("2. Get in the box");
Console.WriteLine("3. Run away");
Console.WriteLine("4. Pretend to be a zombie");
int zomb5 = Convert.ToInt32(Console.ReadLine());
if (zomb5 == 1)
{
 points = points + 4;
}

if (zomb5 == 2)
{
 points = points + 6;
health = health + 5;
}
 if (zomb5 == 3)
{
 points = points + 4;
}
if (zomb5 == 4)
{
 points = points + 5;
health = health - 15;

 if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
return;
}
}
 Console.Clear();
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("You find a drug store that has poisons and medicine what do you choose?");
 Thread.Sleep(3000);
 Console.WriteLine("1. pills to keep you awake");
Console.WriteLine("2. Dangerous poisons");
Console.WriteLine("3. Vitamins and boosters");
Console.WriteLine("4. Cigarettes and Alcohol");
int zomb6 = Convert.ToInt32(Console.ReadLine());
 if (zomb6 == 1)
 {
 points = points + 9;
 }
 if (zomb6 == 2)
 {
 points = points + 2;
 }
 if (zomb6 == 3)
 {
 points = points + 5;
 }
 if (zomb6 == 4)
 {
 points = -10 + points;
 health = health - 80;
  if (health <= 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("You died");
return;
}
 
 }
 
 
 
 
 if (zomb < 1 ||zomb > 4 || zomb1 < 1 ||zomb1 > 4 || zomb2 < 1 ||zomb2 > 4 || zomb3 < 1 ||zomb3 > 4 || zomb4 < 1 ||zomb4 > 4 || zomb5 < 1 ||zomb5 > 4 || zomb6 < 1 ||zomb6 > 4 ) 
 {
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Invalid input");
 return;
 }
 
 
 Thread.Sleep(3000);
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Final points:" + points);
 
 if (points >= 50)
 {
 Console.WriteLine("You survive very easily and it's like a game of hide and seek for you");
 }
 if (points > 45 && points < 50)
 {
 Console.WriteLine("You are the survival master and could survive this for until the zombies all died");
 }
 if (points > 30 && points < 45)
 {
 
 Console.WriteLine("You would survive years until the zombies find a way into your bunker");

 }
 if (points > 20 && points < 30 )
 {
 Console.ForegroundColor = ConsoleColor.DarkRed;
 Console.WriteLine("You would survive a year until you dropped a zombie on you with yout anti-grav gun");
 
 }
 if (points < 20 && points > 10)
 {
 Console.ForegroundColor = ConsoleColor.DarkRed;
 Console.WriteLine("You would survive a couple months until you try to loot a store and get overrun");
 
 }
if (points < 10)
 {
 Console.WriteLine("You would survive a week until you still deadly poison and acid on yourself");
 
 }
Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Press any key to close");
 Console.ReadKey();
 
 
 
 }
 
 else 
 {
 Console.ForegroundColor = ConsoleColor.DarkYellow;
 Console.WriteLine("Invalid input");
 }
 }
 }

}
