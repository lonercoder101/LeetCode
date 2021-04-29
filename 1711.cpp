
//1711. Count Good Meals
// Cpp / Unordered maps


class Solution {
public:
    int countPairs(vector<int>& deliciousness) {
{
int MOD=1e9+7;
    int x,y,z,ans=0;
unordered_map<int,int>umap;
sort(deliciousness.begin(),deliciousness.end());
for(auto x:deliciousness)     // x+y = 2^z, consider elements as x, find y 
        {
            for(int i=0;i<=21;i++)
                {
                        z=1<<i; //increasing power of z
                        y=z-x; //expected y for every x
                        if(y>x) break; //sorted array so to prevent duplicacy
                
                        ans=ans+umap[y]; 
                
                        ans=ans%MOD;
                }
            umap[x]++;
        }
        return ans;
        }
    }
};