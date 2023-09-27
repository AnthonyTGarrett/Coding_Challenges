# Complete the function/method so that it returns the url with anything after the anchor (#) removed.

# Examples
# "www.codewars.com#about" --> "www.codewars.com"
# "www.codewars.com?page=1" -->"www.codewars.com?page=1"
def remove_url_anchor(url):
    result = ""
    
    for letter in url:
        if letter == '#':
            return result
        else:
            result += letter
    return result