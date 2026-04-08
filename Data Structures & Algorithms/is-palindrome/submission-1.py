class Solution:
    def isPalindrome(self, s: str) -> bool:
        res=''.join(c for c in s if c.isalnum());
        rev=res[::-1]
        
        print(res,rev)
        return res.lower() == rev.lower()