#include "stdio.h"
int RecursivePower(int n, int p) {
  // Your code here
  if (p == 1)
    return n;

  else if (p == 0)
    return 1;

  return n * RecursivePower(n, p - 1);
}

int main() {
  int T;
  scanf("%d", &T); // testcases
  while (T--) {
    int n, p;

    // taking n and p as inputs
    scanf("%d%d", &n, &p);

    // calling RecursivePower() function
    printf("%d\n", RecursivePower(n, p));
  }
  return 0;
} // } Driver Code Ends