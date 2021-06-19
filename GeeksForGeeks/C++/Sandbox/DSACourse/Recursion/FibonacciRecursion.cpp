#include <iostream>
using namespace std;

long long fibonacci(int n)
{
    if (n == 0)
        return 0;
    else if (n == 1)
        return 1;
    else if (n == 2)
        return 1;
    else
    {
        int result = fibonacci(n-1)+fibonacci(n-2);
        return result;
    }
}

int main()
{
    cout << "Result is =>" << fibonacci(20) << endl;
}