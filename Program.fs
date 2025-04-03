let rec gcd a b = 
     if b = 0 then a
     else gcd b (a % b)

let coprimeDigits (num: int) (func: int -> int -> int) (initial: int) =
     let rec helper current acc =
         if current = 0 then acc
         else
             let digit = current % 10
             let newAcc = 
                 if digit <> 0 && gcd num digit = 1 then func acc digit
                 else acc
             helper (current / 10) newAcc
     helper num initial
    
    
let sumCoprimeDigits num = coprimeDigits num (+) 0
let multiplyCoprimeDigits num = coprimeDigits num (*) 1
let minCoprimeDigits num = coprimeDigits num (min) 10
let maxCoprimeDigits num = coprimeDigits num (max) -1
let countCoprimeDigits num = coprimeDigits num (fun acc _ -> acc + 1) 0

let main argv =
     let num = 125
     System.Console.WriteLine($"Сумма взаимно простых с {num} = {sumCoprimeDigits num}")
     System.Console.WriteLine($"Произведение взаимно простых с {num} = {multiplyCoprimeDigits num}")
     System.Console.WriteLine($"Минимум из взаимно простых с {num} = {minCoprimeDigits num}")
     System.Console.WriteLine($"Максимум из взаимно простых с {num} = {maxCoprimeDigits num}")
     System.Console.WriteLine($"Количество взаимно простых с {num} = {countCoprimeDigits num}")
main()