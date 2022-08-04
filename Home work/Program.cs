int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int times = 0;

int count = 0;

while (distance > 10) {
    if (friend == 1) {
        times = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else {
        times = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }

    distance -= (firstFriendSpeed + secondFriendSpeed) * times;
    count++;
}

Console.WriteLine(count);