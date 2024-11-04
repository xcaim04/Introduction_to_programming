#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);

    string ADN;
    cin >> ADN;

    int counter = 0, max_counter = 0;

    for (int i = 0; i < ADN.size(); i++)
    {
        if (ADN[i] == ADN[i+1]) ++counter;
        else
        {
            max_counter = max(counter+1, max_counter);
            counter = 0;
        }
    }

    cout << max_counter;
}