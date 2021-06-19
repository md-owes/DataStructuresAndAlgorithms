#include <iostream>
#include <bits/stdc++.h>
using namespace std;

void numberRecursion(int i, int N)
{
    if(i==N+1)
        return;

    cout << i << " ";
    numberRecursion(i+1, N);   
}

void printNos(int N)
{
     numberRecursion(1, N);
}

int main()
{
    printNos(10);
}