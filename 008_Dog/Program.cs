Console.Write("Hello, please input distance between friends: ");
int distance = Console.Read();
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 20;
int friend = 2;
int count = 0;
int DogTime = 0;
while(distance > 10)
{
    if(friend == 1)
    {
        DogTime = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        DogTime = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * DogTime;
    count++;
}

Console.Write("Dog will run between friends ");
Console.Write(count);
Console.WriteLine(" times!");