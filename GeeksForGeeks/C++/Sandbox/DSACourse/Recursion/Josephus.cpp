#include <iostream>
using namespace std;

int josephus(int n, int k) {
  if (n == 1)
    return n;
  return (josephus(n - 1, k) + k - 1) % n + 1;
}

int main() {
  int t;
  scanf("%d", &t); // testcases
  while (t--) {
    int n, k;
    scanf("%d%d", &n, &k); // taking input n and k

    // calling josephus() function
    printf("%d\n", josephus(n, k));
  }
  return 0;
}