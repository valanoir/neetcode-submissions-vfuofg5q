class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        dic={}
        res=[]
        for i in nums:
            if(i in dic):
                dic[i]+=1
            else:
                dic[i]=1
        
        sort=[key for key, value in sorted(dic.items(), key=lambda item: item[1])]
        print(sort)
        res = sort[-k:]
        print(res)
        return res
        