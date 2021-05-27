#include <iostream>
using namespace std;

int countOfDigits(int n)
{
    if (n < 10)
        return 1;
    else
    {
        return countOfDigits(n / 10) + 1;
    }
}

int main()
{
    cout << "Result is =>" << countOfDigits(99999) << endl;
}