def checkPalindrome (n):
	return str (n) == str(n)[::-1]

possible_number = 0

for i in range (0, 999):
	for f in range (0, 999):
		temp_number = i * f
		if checkPalindrome(temp_number) and temp_number > possible_number:
			possible_number = temp_number

print(possible_number)