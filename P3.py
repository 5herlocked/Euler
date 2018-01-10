def primes_method(n):
	out = list()
	sieve = [True] * (n+1)
	for p in range(2, n+1):
		if (sieve[p]):
			out.append(p)
			for i in range(p, n+1, p):
				sieve[i] = False
	return out

prime_list = primes_method(100000000)
number = 600851475143
highest_thing = 0;
for i in prime_list:
	if number % i == 0:
		if i > highest_thing:
			highest_thing = i

print (highest_thing)