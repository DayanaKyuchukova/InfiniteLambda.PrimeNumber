# InfiniteLambda.PrimeNumber

# Starting the application in docker container
1. Navigate to the project root folder
2. docker-compose up

Example:
# Getting whether a given number is prime
http://localhost:5000/api/prime-number/is-prime/1 => false
http://localhost:5000/api/prime-number/is-prime/7 => true
http://localhost:5000/api/prime-number/is-prime/4 => false

# Getting next prime number
http://localhost:5000/api/prime-number/next-prime-number/1 => 2
http://localhost:5000/api/prime-number/next-prime-number/2 => 2
http://localhost:5000/api/prime-number/next-prime-number/4 => 5