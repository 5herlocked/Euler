def primes_method5(n):
	out = list()
	sieve = [True] * (n+1)
	for p in range(2, n+1):
		if (sieve[p]):
			out.append(p)
			for i in range(p, n+1, p):
				sieve[i] = False
	return out

prime_list = primes_method5(100000000)
highest_thing = 0;
for i in prime_list:
	if 600851475143 % i == 0:
		if i > highest_thing:
			highest_thing = i

print (primes_method5(10001))