inc x = x + 1

double x = x * 2

square x = x * x

qthree x = if even x
           then x - 2
           else 3 * x + 1

doubleDouble x = (\x -> x*2) x * 2

overwrite x = (\x -> (\x -> (\x -> x) 4) 3) 2