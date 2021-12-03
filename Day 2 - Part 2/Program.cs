// forward x down x up x

string[] input = System.IO.File.ReadAllLines("Input.txt");

int depth = 0;
int forward = 0;
int aim = 0;

foreach (var instruction in input)
{
    string[] splitInput = instruction.Split(' ');
    if (splitInput[0] == "forward")
    {
        forward = forward + int.Parse(splitInput[1]);
        depth = depth + (int.Parse(splitInput[1]) * aim);
    }
    else if (splitInput[0] == "down")
    {
        aim = aim + int.Parse(splitInput[1]);
    }
    else if (splitInput[0] == "up")
    {
        aim = aim - int.Parse(splitInput[1]);
    }
}
int result = depth * forward;
Console.WriteLine(result);