#include <bits/stdc++.h>
using namespace std;

int count_moves(int arr[], int n)
{
    int moves = 0;
    for (int i = 0; i <= n-1; i++)
    {
        if(arr[i] >= arr[i+1])
        {
            moves += (arr[i] - arr[i+1]) + 1;
            arr[i+1] = arr[i];
        }
    }
    return moves;
}

int main()
{
    int n;
    cin >> n;

    int arr[n + 1];

    for (int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }

    cout << count_moves(arr, n);
    
}