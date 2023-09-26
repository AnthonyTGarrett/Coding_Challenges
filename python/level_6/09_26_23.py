# A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).

# Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.


import string

def is_pangram(s):
    pangram = True
    
    alphabet = dict.fromkeys(string.ascii_lowercase, 0)
    
    for letter in s:
        if letter.isalpha():
            alphabet[letter.lower()] += 1
    
    for key in alphabet.keys():
        if alphabet[key] < 1:
            return False
        
    return True