#!/usr/bin/hugs
main = do
	task3
	task5 
	task6

task3 = do
	showMyExpr 2.89 7.55
	showMyExpr (-3.12) 5.16
	showMyExpr 12 24.2
	showMyExpr 0 1
	showMyExpr 0 0
	showMyExpr 3 (-3)

task5 = do
	showSumEvens [1..6]
	showSumEvens [1,3..15]
	showSumEvens [2,4..10]
	showSumEvens [1,2,6,2,7,9,3,5,8]
	showSumEvens [2 ^ x | x <- [1..10]]

task5rec = do 
	showSumEvensRec [1..6]
	showSumEvensRec [1,3..15]
	showSumEvensRec [2,4..10]
	showSumEvensRec [1,2,6,2,7,9,3,5,8]
	showSumEvensRec [2 ^ x | x <- [1..10]]

task6 = do
	showF 5 10
	showF 10 5
	showF 15 5
	showF 4 7
	showF 7 4
	showF 11 4
	showF 71 243


-- Задание 3
myexpr :: (Floating a, Ord a) => a -> a -> a
myexpr x y 
	| y < 0.0 = error "y should be positive"
	| True = (exp x - 2 * sqrt y) / (sin y + x ^ 3)

showMyExpr x y = putStrLn ("myexpr " ++ show x ++ " " ++ show y ++ " = " ++ show (myexpr x y))

-- Задание 5
sumEvens :: (Integral a) => [a] -> a
sumEvens l = sum [x | x <- l, even x]

sumEvensRec :: (Integral a) => [a] -> a
sumEvensRec [] = 0
sumEvensRec (x:l) = (if even x then x else 0) + sumEvensRec l 

showSumEvens l = putStrLn ("sumEvens " ++ show l ++ " = " ++ show (sumEvens l))
showSumEvensRec l = putStrLn ("sumEvensRec " ++ show l ++ " = " ++ show (sumEvensRec l))
-- Задание 6
fib :: Integer -> Integer
fib' :: Integer -> Integer
fib n 
	| n <= 0 = 0
	| True = fib' n
fib' 1 = 1
fib' 2 = 1
fib' n = fib' (n - 1) + fib' (n - 2)

factorial :: Integer -> Integer
factorial' :: Integer -> Integer
factorial n
	| n <= 0 = 0
	| True = factorial' n
factorial' 0 = 1
factorial' n = n * factorial' (n - 1)

f :: Integer -> Integer -> Integer
f n m = factorial (mod n m) + fib (mod m n)

showF n m = putStrLn ("F(" ++ show n ++ "," ++ show m ++ ")=" ++ show (f n m))
