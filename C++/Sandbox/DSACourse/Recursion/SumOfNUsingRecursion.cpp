#include <iostream>
using namespace std;

int sumOfDigits(int n)
{
    if (n == 0)
        return 0;
    else
    {
        int result = sumOfDigits(n / 10);
        int val = result + (n % 10);
        return val;
    }
}

int main()
{
    cout << "Result is =>" << sumOfDigits(99999) << endl;
}