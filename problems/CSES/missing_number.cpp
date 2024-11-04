#include <bits/stdc++.h>
using namespace std;

#define int long long

main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);

    int n;
    cin >> n;
    
    int sum = n * (n + 1) / 2;
    int sum_arr = 0;
    
    for (int i = 0; i < n - 1; i++)
    {
        int value;
        cin >> value;
        sum_arr += value;
    }
    cout << sum - sum_arr;
}