int firstFriendSpeed = 1;
int secondFriendSpeed = 3;
int dogSpeed = 5;
int initialDistance = 1000;
int finalDistance = 10;
int friend = 0;
int count = 0;
int time = 0;

while (initialDistance > finalDistance) {
    if (friend % 2 == 0) {
        time = initialDistance / (secondFriendSpeed + dogSpeed);
    } else {
        time = initialDistance / (firstFriendSpeed + dogSpeed);
    }
    initialDistance = initialDistance - time * (firstFriendSpeed + secondFriendSpeed);
    friend++;
    count++;
    Console.WriteLine(initialDistance);
}
Console.Write ("Количество пробежек собаки равно: ");
Console.WriteLine (count);