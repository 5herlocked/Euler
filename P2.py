def fib(n):
	result = []
	a, b = 0, 1
	while a < n:
		result.append(a)
		a, b = b, a + b
	return result

fReq = fib(4000000)
sum = 0
for i in fReq:
	if i % 2 == 0:
		sum += i

print(sum)